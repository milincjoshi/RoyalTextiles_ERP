using System;
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
    public partial class StichingReportDaily : Form
    {
        public StichingReportDaily()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
        void populate()
        {

            try
            {
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
                MyMessageBox.ShowBox(ex.Message,"Exception");
            }
            finally
            {
                con.Close();
            }

        }
        void dataBind()
        {
            try
            {
                con.Open();
                string table = @"SELECT c.SId 'Sr No', p.ProductName, p.Size, isnull(c.Quantity,0) as Quantity, isnull(c.ReturnQuantity,0) as ReturnQuantity FROM tblStiching AS c INNER JOIN tblProduct AS p ON c.PId = p.PId INNER JOIN tblWorker AS w ON c.WId = w.WId where c.Date='" + dtpDate.Value + "' and w.FirstName='" + cbWorkerName.Text + "'";
                SqlCommand cmd = new SqlCommand(table, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //DataSet ds = new DataSet();
                da.Fill(dt);
                dgvStichingDailyReport.DataSource = dt;


                this.dgvStichingDailyReport.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dgvStichingDailyReport.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dgvStichingDailyReport.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dgvStichingDailyReport.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

                con.Close();
                //DataSet ds1 = new DataSet();
                //da.Fill(ds);
                //daq.Fill(ds1);
                //DataSet dsAll = ds.Copy();
                //dsAll.Merge(ds1);
                //  DataTable dt2 = new DataTable();
                //  dt.Merge(dt2, true);

                // daq.Fill(dt2);
                //  DataTable dtAll = dt.Copy();
                //dtAll.Merge(dt2);


                //dgvStichingDailyReport.DataSource = dsAll;

            }
            catch (Exception e)
            {
                MyMessageBox.ShowBox(e.Message, "Exception");
            }
            finally
            {
                con.Close();
            }
        }
        void totalQuantity()
        {
            try
            {
                long totalQuantity = 0;
                long quantityGiven = 0;
                long QuantityReturn = 0;

                for (int i = 0; i < dgvStichingDailyReport.Rows.Count - 1; i++)
                {
                    string a = dgvStichingDailyReport.Rows[i].Cells["Quantity"].Value.ToString();
                    string b = dgvStichingDailyReport.Rows[i].Cells["ReturnQuantity"].Value.ToString();

                    long quantity = long.Parse(dgvStichingDailyReport.Rows[i].Cells["Quantity"].Value.ToString());
                    long Returnquantity = long.Parse(dgvStichingDailyReport.Rows[i].Cells["ReturnQuantity"].Value.ToString());
                    quantityGiven = quantityGiven + quantity;
                    QuantityReturn = QuantityReturn + Returnquantity;
                }
                long x = quantityGiven;
                lblQuantitygivenshow.Text = quantityGiven.ToString();

                long y = QuantityReturn;
                lblReturnShow.Text = QuantityReturn.ToString();
                totalQuantity = x - y;
                lblQuantityShow.Text = totalQuantity.ToString();
            }
            catch (Exception e)
            {
                MyMessageBox.ShowBox(e.Message, "Exception");
            }
        }


        private void StichingDailyReport_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dataBind();
           // zero();
            totalQuantity();
        }

        private void cbWorkerName_TextChanged(object sender, EventArgs e)
        {
            dataBind();
           // zero();
            totalQuantity();
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
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "No error occured";
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
            ExportToExcel(dgvStichingDailyReport);
        }


    }
}
