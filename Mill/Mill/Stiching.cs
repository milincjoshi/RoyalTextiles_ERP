using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace Mill
{
    public partial class Stiching : Form
    {
        public Stiching()
        {
            InitializeComponent();
            populate();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            StichingReport stichingReport = new StichingReport();
            stichingReport.Show();
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
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }

        }

        private void Stiching_Load(object sender, EventArgs e)
        {
            lblDateshow.Text = System.DateTime.Now.ToString();
            lblDayshow.Text = System.DateTime.Now.DayOfWeek.ToString();
            populate();
            dataBind();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        void dataBind()
        {
            try
            {
                con.Open();
                string strQuerry;
                strQuerry = "SELECT ProductName, Size FROM tblProduct";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStiching.DataSource = dt;
                con.Close();
                this.dgvStiching.Columns["ProductName"].Width = 400;
                this.dgvStiching.Columns["Size"].Width = 100;

                this.dgvStiching.Columns["ProductName"].ReadOnly = true;
                this.dgvStiching.Columns["Size"].ReadOnly = true;
                this.dgvStiching.AllowUserToOrderColumns = false;
                this.dgvStiching.AllowUserToResizeColumns = false;

                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "Quantity";
                int w = int.Parse(col.Index.ToString());
                col.HeaderText = "Quantity";
                col.Width = 150;
                dgvStiching.Columns.Add(col);
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.Name = "ReturnQuantity";
                int w1 = int.Parse(col.Index.ToString());
                col1.HeaderText = "Return Quantity";
                col1.Width = 150;
                dgvStiching.Columns.Add(col1);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
            
        }
        void dataInsert()
        {
            try
            {
                con.Open();
                for (int i = 0; i < dgvStiching.RowCount - 1; i++)
                {
                    
                     if (dgvStiching.Rows[i].Cells[2].Value != null && dgvStiching.Rows[i].Cells[3].Value != null)
                    {
                        
                        string WorkerId = "select Wid from tblWorker where FirstName='" + cbWorkerName.Text + "' ";
                        SqlCommand cmdWid = new SqlCommand(WorkerId, con);
                        SqlDataReader rWid;
                        rWid = cmdWid.ExecuteReader();
                        rWid.Read();
                        string stringWorkerId = rWid["WId"].ToString();
                        int intWorkerId = int.Parse(stringWorkerId);
                        rWid.Close();
                        string ProductId = "select Pid from tblProduct where ProductName='" + dgvStiching.Rows[i].Cells[0].Value.ToString() + "'";
                        SqlCommand cmdPid = new SqlCommand(ProductId, con);
                        SqlDataReader rPid;
                        rPid = cmdPid.ExecuteReader();
                        rPid.Read();
                        string StringProductId = rPid["PId"].ToString();
                        int intPId = int.Parse(StringProductId);
                        rPid.Close();
                        string PriceId = "select Price from tblProduct where ProductName='" + dgvStiching.Rows[i].Cells[0].Value.ToString() + "'and Size='" + dgvStiching.Rows[i].Cells[1].Value.ToString() + "'";
                        SqlCommand cmdPrice = new SqlCommand(PriceId, con);
                        SqlDataReader rPrice;
                        rPrice = cmdPrice.ExecuteReader();
                        rPrice.Read();
                        string Price = rPrice["Price"].ToString();
                        float floatPrice = float.Parse(Price);
                        rPrice.Close();
                        int Quantity = int.Parse(dgvStiching.Rows[i].Cells["Quantity"].Value.ToString());
                        float totalprice = floatPrice * Quantity;
                        int returnQuantity = int.Parse(dgvStiching.Rows[i].Cells["ReturnQuantity"].Value.ToString());
                        string insert;
                        insert = "insert into tblStiching values(@Wid,@Pid,@Quantity,@Date,@TotalPrice,@ReturnQuantity)";
                        SqlCommand cmdinsert = new SqlCommand(insert, con);
                        cmdinsert.Parameters.AddWithValue("@Wid", intWorkerId);
                        cmdinsert.Parameters.AddWithValue("@Pid", intPId);
                        cmdinsert.Parameters.AddWithValue("@Quantity", dgvStiching.Rows[i].Cells["Quantity"].Value.ToString());
                        cmdinsert.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                        cmdinsert.Parameters.AddWithValue("@TotalPrice", totalprice);
                        cmdinsert.Parameters.AddWithValue("@ReturnQuantity", dgvStiching.Rows[i].Cells["ReturnQuantity"].Value.ToString());
                        cmdinsert.ExecuteNonQuery();

                    }
                }
                con.Close();
                MyMessageBox.ShowBox("Data Addes Successfully!!!", "Information");

            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
            finally
            {
                con.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dataInsert();
        }

        private void dgvStiching_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == dgvStiching.Columns["Quantity"].Index || e.ColumnIndex == dgvStiching.Columns["ReturnQuantity"].Index)
            //{
            //    if (dgvStiching.Rows[e.RowIndex].Cells["Quantity"].Value != null && dgvStiching.Rows[e.RowIndex].Cells["ReturnQuantity"].Value == null)
            //    {
            //        MessageBox.Show("You must Provide both the Values");
            //    }
            //    else if (dgvStiching.Rows[e.RowIndex].Cells["ReturnQuantity"].Value != null && dgvStiching.Rows[e.RowIndex].Cells["Quantity"].Value == null)
            //    {
            //        MessageBox.Show("You must Provide both the Values");
            //    }
            //}
            //if (dgvStiching.Columns[e.ColumnIndex].Name == "Quantity" && dgvStiching.Columns[e.ColumnIndex+1].Name=="ReturnQuantity")
            //{
            //    if (String.IsNullOrEmpty(e.FormattedValue.ToString()) && dgvStiching.Rows[e.RowIndex+1].Cells[e.ColumnIndex+1].Value!=string.Empty)
            //    {
            //        dgvStiching.Rows[e.RowIndex].ErrorText =
            //            "Insert Quantity";
            //        e.Cancel = true;
            //    }
            //    if (!String.IsNullOrEmpty(e.FormattedValue.ToString()) && dgvStiching.Rows[e.RowIndex + 1].Cells[e.ColumnIndex + 1].Value == string.Empty)
            //    {
            //        dgvStiching.Rows[e.RowIndex+1].ErrorText =
            //            "Insert Return Quantity";
            //        e.Cancel = true;
            //    }
            //}
        }

    }
}
