﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mill
{
    public partial class DailyReportCutting : Form
    {
        public DailyReportCutting()
        {
            InitializeComponent();
        }
       
        void populate()
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string strQuerry;
                strQuerry = "select FirstName from tblWorker";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandText = cmd.CommandText.ToString();
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbWorkerName.DataSource = dt;
                cbWorkerName.DisplayMember = "FirstName";
                cbWorkerName.ValueMember = "FirstName";
                con.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
           

        }
        void dataBind()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string querry = "SELECT c.CId 'Sr No', p.ProductName, p.Size, c.Quantity FROM tblCutting AS c INNER JOIN tblProduct AS p ON c.PId = p.PId INNER JOIN tblWorker AS w ON c.WId = w.WId where c.Date='"+dtpDate.Value+"' and w.FirstName='"+cbWorkerName.Text+"'";

                SqlCommand cmd = new SqlCommand(querry, con);
                //cmd.Parameters.AddWithValue("@Date",dtpDate.Value);
                //cmd.Parameters.AddWithValue("@FirstName",cbWorkerName.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdailycuttingReport.DataSource = dt;
                dgvdailycuttingReport.Columns["ProductName"].Width = 400;
                con.Close();
            }
            catch(Exception e)
            {
                MyMessageBox.ShowBox(e.Message, "Exception");
            }
           
        }
        void totalQuantity()
        {
            try
            {
                long totalQuantity = 0;

                for (int i = 0; i < dgvdailycuttingReport.Rows.Count - 1; i++)
                {
                    long quantity = long.Parse(dgvdailycuttingReport.Rows[i].Cells["Quantity"].Value.ToString());
                    totalQuantity = totalQuantity + quantity;
                }
                lblQuantityShow.Text = totalQuantity.ToString();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
        }

        private void DailyReportCutting_Load(object sender, EventArgs e)
        {
           populate();
          // dataBind();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dataBind();
            totalQuantity();
        }
        string worker = "";
        private void cbWorkerName_TextChanged(object sender, EventArgs e)
        {
            dataBind();
            totalQuantity();
            worker = cbWorkerName.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static void ExportToExcel(DataGridView dgView)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                object misValue = System.Reflection.Missing.Value;
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;
                if (dgView.Rows.Count > 0)
                {
                   currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    currentWorksheet.Cells[1, 2] = "WorkerName";
                   
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.Name;
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                }
                else
                {
                    //string timeStamp = DateTime.Now.ToString("s");
                    //timeStamp = timeStamp.Replace(':', '-');
                    //timeStamp = timeStamp.Replace("T", "__");
                    ////currentWorksheet.Cells[1, 1] = timeStamp;
                    
                    //currentWorksheet.Cells[1, 2] = "No error occured";
                }
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, misValue, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
                        currentWorkbook.Saved = true;
                        MyMessageBox.ShowBox("Exported successfully", "Exported to Excel");
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvdailycuttingReport);
        }

        

        
    }
}
