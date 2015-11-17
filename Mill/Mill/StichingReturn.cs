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
    public partial class StichingReturn : Form
    {
        public StichingReturn()
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
                MessageBox.Show(ex.Message);
            }

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
                dgvStichingReturn.DataSource = dt;
                con.Close();
                this.dgvStichingReturn.Columns["ProductName"].Width = 400;
                this.dgvStichingReturn.Columns["Size"].Width = 100;

                this.dgvStichingReturn.Columns["ProductName"].ReadOnly = true;
                this.dgvStichingReturn.Columns["Size"].ReadOnly = true;
                this.dgvStichingReturn.AllowUserToOrderColumns = false;
                this.dgvStichingReturn.AllowUserToResizeColumns = false;

                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "Quantity";
                int w = int.Parse(col.Index.ToString());
                col.HeaderText = "Quantity";
                col.Width = 150;

                dgvStichingReturn.Columns.Add(col);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void dataInsert()
        {

            try
            {
                con.Open();
                for (int i = 0; i < dgvStichingReturn.RowCount - 1; i++)
                {
                    if (dgvStichingReturn.Rows[i].Cells[2].Value != null)
                    {
                        string WorkerId = "select Wid from tblWorker where FirstName='" + cbWorkerName.Text + "' ";
                        SqlCommand cmdWid = new SqlCommand(WorkerId, con);
                        SqlDataReader rWid;
                        rWid = cmdWid.ExecuteReader();
                        rWid.Read();
                        string stringWorkerId = rWid["WId"].ToString();
                        int intWorkerId = int.Parse(stringWorkerId);
                        rWid.Close();
                        string ProductId = "select Pid from tblProduct where ProductName='" + dgvStichingReturn.Rows[i].Cells[0].Value.ToString() + "'";
                        SqlCommand cmdPid = new SqlCommand(ProductId, con);
                        SqlDataReader rPid;
                        rPid = cmdPid.ExecuteReader();
                        rPid.Read();
                        string StringProductId = rPid["PId"].ToString();
                        int intPId = int.Parse(StringProductId);
                        rPid.Close();
                        //string StichingID = "select SId from tblStiching where WId='"+intWorkerId+"'";
                        //SqlCommand cmdStichingId = new SqlCommand(StichingID, con);
                        //SqlDataReader rSId;
                        //rSId = cmdStichingId.ExecuteReader();
                        //rSId.Read();
                        //string stringSid= rSId["SId"].ToString();
                        //int intSId = int.Parse(stringSid);
                        //rSId.Close();
                        //string quantity = "select sum(Quantity) sum from tblStiching where Wid='"+intWorkerId+"' and PId='"+intPId+"'";
                        //SqlCommand cmdquantity = new SqlCommand(quantity,con);
                        //SqlDataReader rquantity;
                        //rquantity = cmdquantity.ExecuteReader();
                        //rquantity.Read();
                        //string stringquantity = rquantity["sum"].ToString();
                        //int intquantity = int.Parse(stringquantity);
                        //rquantity.Close();
                        int currentquantity = int.Parse(dgvStichingReturn.Rows[i].Cells["Quantity"].Value.ToString());
                        //int remainingQuantity = intquantity - currentquantity;
                        string insert = "insert into tblStichingReturn values(@WId,@PId,@Quantity,@Date)";
                        SqlCommand cmdInsert = new SqlCommand(insert, con);
                        //  cmdInsert.Parameters.AddWithValue("@SId",intSId);
                        cmdInsert.Parameters.AddWithValue("@WId", intWorkerId);
                        cmdInsert.Parameters.AddWithValue("@PId", intPId);
                        cmdInsert.Parameters.AddWithValue("@Quantity", currentquantity);
                        cmdInsert.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                        // cmdInsert.Parameters.AddWithValue("@RemainingQuantity",remainingQuantity);
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Data Addes Successfully!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StichingReturn_Load(object sender, EventArgs e)
        {
            lblDateshow.Text = System.DateTime.Now.ToString();
            lblDayshow.Text = System.DateTime.Now.DayOfWeek.ToString();
            populate();
            dataBind();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataInsert();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
