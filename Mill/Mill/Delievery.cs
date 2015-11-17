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
    public partial class Delievery : Form
    {
        public Delievery()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");

        private void Delievery_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        void dataBind()
        {
            con.Open();
            string strQuerry;
            strQuerry = "SELECT ProductName, Size FROM tblProduct";
            SqlCommand cmd = new SqlCommand(strQuerry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDelivery.DataSource = dt;
            con.Close();
            this.dgvDelivery.Columns["ProductName"].Width = 400;
            this.dgvDelivery.Columns["Size"].Width = 100;

            this.dgvDelivery.Columns["ProductName"].ReadOnly = true;
            this.dgvDelivery.Columns["Size"].ReadOnly = true;
            this.dgvDelivery.AllowUserToOrderColumns = false;
            this.dgvDelivery.AllowUserToResizeColumns = false;

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Quantity";
            int w = int.Parse(col.Index.ToString());
            col.HeaderText = "Quantity";
            col.Width = 150;

            dgvDelivery.Columns.Add(col);
        }
        void dataInsert()
        {
            try
            {
                con.Open();
                transport();
                Purchaser();
                for (int i = 0; i < dgvDelivery.RowCount - 1; i++)
                {
                    if (dgvDelivery.Rows[i].Cells[2].Value != null)
                    {
                        string ProductId = "select Pid from tblProduct where ProductName='" + dgvDelivery.Rows[i].Cells[0].Value.ToString() + "'";
                        SqlCommand cmdPid = new SqlCommand(ProductId, con);
                        SqlDataReader rPid;
                        rPid = cmdPid.ExecuteReader();
                        rPid.Read();
                        string StringProductId = rPid["PId"].ToString();
                        int intPId = int.Parse(StringProductId);
                        rPid.Close();
                        string TransportId = "select TId from tblTransport where TransportName='" + txtTransportName.Text + "'";
                        SqlCommand cmdTId = new SqlCommand(TransportId, con);
                        SqlDataReader rTId;
                        rTId = cmdTId.ExecuteReader();
                        rTId.Read();
                        string stringTransportId = rTId["TId"].ToString();
                        int intTId = int.Parse(stringTransportId);
                        rTId.Close();
                        string PurchaserId = "select PUId from tblPurchaser where PurchaserName = '" + txtPurchaserName.Text + "'";
                        SqlCommand cmdPUId = new SqlCommand(PurchaserId, con);
                        SqlDataReader rPUId;
                        rPUId = cmdPUId.ExecuteReader();
                        rPUId.Read();
                        string stringPurchaserId = rPUId["PUId"].ToString();
                        int intPUId = int.Parse(stringPurchaserId);
                        rPUId.Close();
                        int quantity = int.Parse(dgvDelivery.Rows[i].Cells["Quantity"].Value.ToString());
                        string insert = "insert into tblDelivery values(@PId,@TId,@Quantity,@PUId,@Date)";
                        SqlCommand cmdinsert = new SqlCommand(insert, con);
                        cmdinsert.Parameters.AddWithValue("@PID", intPId);
                        cmdinsert.Parameters.AddWithValue("@TId", intTId);
                        cmdinsert.Parameters.AddWithValue("@Quantity", quantity);
                        cmdinsert.Parameters.AddWithValue("@PUId", intPUId);
                        cmdinsert.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                        cmdinsert.ExecuteNonQuery();

                    }
                }
                con.Close();
                MyMessageBox.ShowBox("Data Addes Successfully!!!", "Information");
            }
            catch (Exception e)
            {
                MyMessageBox.ShowBox(e.Message, "Exception");
            }
        }
        void transport()
        {
            try
            {
                //con.Open();
                string insertToTransport = "insert into tblTransport values(@TransportName,@LRNo,@Parcel)";
                SqlCommand cmdinserToTransport = new SqlCommand(insertToTransport, con);
                cmdinserToTransport.Parameters.AddWithValue("@TransportName", txtTransportName.Text);
                cmdinserToTransport.Parameters.AddWithValue("@LRNo", txtLRNo.Text);
                cmdinserToTransport.Parameters.AddWithValue("@Parcel", txtParcels.Text);
                cmdinserToTransport.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message,"Exception");
            }

        }
        void Purchaser()
        {
            try
            {
                string insertToPurchaser = "insert into tblPurchaser values(@PurchaserName)";
                SqlCommand cmdinsertToPurchaser = new SqlCommand(insertToPurchaser, con);
                cmdinsertToPurchaser.Parameters.AddWithValue("@PurchaserName", txtPurchaserName.Text);
                cmdinsertToPurchaser.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message,"Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataInsert();
        }
    }
       
}

