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
    public partial class Cutting : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");

        public Cutting()
        {
            InitializeComponent();
            populate();
            Bind();
            populateCloth();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportGenerate cuttingreport = new ReportGenerate();
            cuttingreport.Show();
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
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message,"Exception");
            }

        }
        void populateCloth()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string strQuerry;
                strQuerry = "select PurchasedProduct from tblProductPurchase";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandText = cmd.CommandText.ToString();
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbPurchasedCloth.DataSource = dt;
                cbPurchasedCloth.DisplayMember = "PurchasedProduct";
                cbPurchasedCloth.ValueMember = "PurchasedProduct";
            }
            catch (Exception exe)
            {
                MyMessageBox.ShowBox(exe.Message, "Exception");
            }
        }
        void Bind()
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
                dgvCutting.DataSource = dt;

                con.Close();
                this.dgvCutting.Columns["ProductName"].Width = 400;
                this.dgvCutting.Columns["Size"].Width = 100;

                this.dgvCutting.Columns["ProductName"].ReadOnly = true;
                this.dgvCutting.Columns["Size"].ReadOnly = true;
                this.dgvCutting.AllowUserToOrderColumns = false;
                this.dgvCutting.AllowUserToResizeColumns = false;
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "Quantity";
                int w = int.Parse(col.Index.ToString());
                col.HeaderText = "Quantity";
                col.Width = 150;

                dgvCutting.Columns.Add(col);
                //dgvCutting.Columns[3].Name = "Quantity";
                //DataGridViewColumn qt = dgvCutting.Columns[2];
                //DataGridViewCell c = new DataGridViewTextBoxCell();
                //c.Style.BackColor = Color.Wheat;
                //qt.CellTemplate = c;
                ///dgvCutting.Columns.Add(qt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //void DataStoringFromGridView()
        //{
        //    con.Open();
        //    string querry;
        //    string q = "select wid from tblworker where firstname='"+cbWorkerName.SelectedItem+"'";
        //    SqlCommand cmd1 = new SqlCommand(q, con);
        //    SqlDataReader r;
        //    r = cmd1.ExecuteReader();
        //    string q1=r["Wid"].ToString();
        //    int i1 = int.Parse(q1);

        //    string q11 = "select pid from tblproduct where ";
        //    SqlCommand cmd11 = new SqlCommand(q11, con);
        //    SqlDataReader r1;
        //    r1 = cmd11.ExecuteReader();
        //    string q111 = r["Wid"].ToString();
        //    int i11 = int.Parse(q111);


        //    querry = "select * from tblWorker where FirstName='@Worker'";
        //    SqlCommand cmd = new SqlCommand(querry,con);
        //    cmd.Parameters.AddWithValue("@Worker",cbWorkerName.SelectedItem.ToString());
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    int Wid = 0;
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        Wid = Convert.ToInt32(ds.Tables[0].Rows[0]["Wid"].ToString());
        //    }
        //     int Pid = 0;
        //     int Price = 0;
        //     int TotalPrice = 0;
        //    for (int i = 1; i <= dgvCutting.Rows.Count; i++)
        //    {
        //        string querryProduct;
        //        querryProduct = "select * from tblProduct where ProductName=@ProductName";
        //        SqlCommand cmdProduct = new SqlCommand(querryProduct,con);
        //        cmd.Parameters.AddWithValue("@ProductName", dgvCutting.Rows[i].Cells["ProductName"].Value);
        //        SqlDataAdapter daProduct = new SqlDataAdapter(cmdProduct);
        //        DataSet dsProduct = new DataSet();
        //        daProduct.Fill(dsProduct);

        //        if (dsProduct.Tables[0].Rows.Count > 0)
        //        {
        //            Pid = Convert.ToInt32(dsProduct.Tables[0].Rows[0]["Pid"].ToString());
        //            Price = Convert.ToInt32(ds.Tables[0].Rows[0]["Price"].ToString());
        //        }
        //        int Quantity=Convert.ToInt32(dgvCutting.Rows[i].Cells["Quantity"].Value);
        //        TotalPrice = Price * Quantity;
        //    }

        //    if (Wid > 0 && Pid > 0)
        //    {
        //        for (int i = 0; i < dgvCutting.Rows.Count; i++)
        //        {
        //            string insert;
        //            insert = "insert into tblCutting values(@Wid,@Pid,@Quantity,@Date,@TotalPrice)";
        //            SqlCommand cmdinsert = new SqlCommand(insert, con);
        //            cmdinsert.Parameters.AddWithValue("@Wid",Wid);
        //            cmdinsert.Parameters.AddWithValue("@Pid",Pid);
        //            cmdinsert.Parameters.AddWithValue("@Quantity",dgvCutting.Rows[i].Cells["Quantity"].Value);
        //            cmdinsert.Parameters.AddWithValue("@Date",System.DateTime.Now.ToString());
        //            cmdinsert.Parameters.AddWithValue("@TotalPrice",TotalPrice);
        //            cmdinsert.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show("Data Addes Successfully!!!");

        //        }
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                for (int i = 0; i < dgvCutting.RowCount - 1; i++)
                {
                    if (dgvCutting.Rows[i].Cells[0].Value != null)
                    {
                        string WorkerId = "select Wid from tblWorker where FirstName='" + cbWorkerName.Text + "' ";
                        SqlCommand cmdWid = new SqlCommand(WorkerId, con);
                        SqlDataReader rWid;
                        rWid = cmdWid.ExecuteReader();
                        rWid.Read();
                        string stringWorkerId = rWid["WId"].ToString();
                        int intWorkerId = int.Parse(stringWorkerId);
                        rWid.Close();
                        string ProductId = "select Pid from tblProduct where ProductName='" + dgvCutting.Rows[i].Cells[1].Value.ToString() + "'";
                        SqlCommand cmdPid = new SqlCommand(ProductId, con);
                        SqlDataReader rPid;
                        rPid = cmdPid.ExecuteReader();
                        rPid.Read();
                        string StringProductId = rPid["PId"].ToString();
                        int intPId = int.Parse(StringProductId);
                        rPid.Close();
                        string PriceId = "select Price from tblProduct where ProductName='" + dgvCutting.Rows[i].Cells[1].Value.ToString() + "'and Size='" + dgvCutting.Rows[i].Cells[2].Value.ToString() + "'";
                        SqlCommand cmdPrice = new SqlCommand(PriceId, con);
                        SqlDataReader rPrice;
                        rPrice = cmdPrice.ExecuteReader();
                        rPrice.Read();
                        string Price = rPrice["Price"].ToString();
                        float floatPrice = float.Parse(Price);
                        rPrice.Close();
                        string PurchaseId = "select PurchaseId from tblProductPurchase where PurchasedProduct='" + cbPurchasedCloth.Text + "'";
                        SqlCommand cmdPurchase = new SqlCommand(PurchaseId, con);
                        SqlDataReader rPurchaseId;
                        rPurchaseId = cmdPurchase.ExecuteReader();
                        rPurchaseId.Read();
                        string stringPurchaseId = rPurchaseId["PurchaseId"].ToString();
                        int intPurchaseId = int.Parse(stringPurchaseId);
                        rPurchaseId.Close();
                        string remainingMeters = "select RemainingMeters from tblProductPurchase where PurchasedProduct ='" + cbPurchasedCloth.Text + "'";
                        SqlCommand cmdRemainingProduct = new SqlCommand(remainingMeters, con);
                        SqlDataReader rRemainingMeters;
                        rRemainingMeters = cmdRemainingProduct.ExecuteReader();
                        rRemainingMeters.Read();
                        string stringRemainingMeters = rRemainingMeters["RemainingMeters"].ToString();
                        float intRemainingMeters = float.Parse(stringRemainingMeters);
                        rRemainingMeters.Close();
                        string average = "select Average from tblProduct where ProductName='" + dgvCutting.Rows[i].Cells["ProductName"].Value.ToString() + "'";
                        SqlCommand cmdAveage = new SqlCommand(average, con);
                        SqlDataReader rAverage;
                        rAverage = cmdAveage.ExecuteReader();
                        rAverage.Read();
                        float intAverage = float.Parse(rAverage["Average"].ToString());
                        rAverage.Close();
                        int Quantity = int.Parse(dgvCutting.Rows[i].Cells["Quantity"].Value.ToString());
                        float totalprice = floatPrice * Quantity;
                        float x = intAverage * Quantity;
                        float totalRemainingMeters = intRemainingMeters - x;


                        if (totalRemainingMeters > 0 || x < totalRemainingMeters)
                        {
                            string updateRemainingMeters = "update tblProductPurchase set RemainingMeters=@RemainingMeters where PurchaseId='" + intPurchaseId + "'";
                            SqlCommand cmdUpdateRemainingMeters = new SqlCommand(updateRemainingMeters, con);
                            cmdUpdateRemainingMeters.Parameters.AddWithValue("@RemainingMeters", totalRemainingMeters);
                            cmdUpdateRemainingMeters.ExecuteNonQuery();
                            string insert;
                            insert = "insert into tblCutting values(@Wid,@Pid,@Quantity,@Date,@TotalPrice,@PurchaseId)";
                            SqlCommand cmdinsert = new SqlCommand(insert, con);
                            cmdinsert.Parameters.AddWithValue("@Wid", intWorkerId);
                            cmdinsert.Parameters.AddWithValue("@Pid", intPId);
                            cmdinsert.Parameters.AddWithValue("@Quantity", dgvCutting.Rows[i].Cells["Quantity"].Value.ToString());
                            cmdinsert.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                            cmdinsert.Parameters.AddWithValue("@TotalPrice", totalprice);
                            cmdinsert.Parameters.AddWithValue("@PurchaseId", intPurchaseId);
                            cmdinsert.ExecuteNonQuery();
                            MessageBox.Show("Data Addes Successfully!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }

                        else
                        {
                            MyMessageBox.ShowBox(+intRemainingMeters + " " + "Meters remaining" + "You cannot cut the Products from the given Quantity, Reduce the Quantity or Change the Product Cloth for cutting!!!","Information");

                        }

                    }
                }
                con.Close();
                //MessageBox.Show("Data Addes Successfully!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


                //DataStoringFromGridView();
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

        private void dgvCutting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cutting_Load(object sender, EventArgs e)
        {

            lblDateshow.Text = System.DateTime.Now.ToString();
            lblDayshow.Text = System.DateTime.Now.DayOfWeek.ToString();


        }

        private void dgvCutting_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == dgvCutting.Columns["Quantity"].Index)
            //{
            //    dgvCutting.Rows[e.RowIndex].ErrorText = "";
            //    int newInteger;
            //    if (dgvCutting.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!int.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger < 0)
            //    {
            //        e.Cancel = true;
            //        dgvCutting.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            //    }
            //}
            DataGridViewTextBoxCell cell = dgvCutting["Quantity", e.RowIndex] as DataGridViewTextBoxCell;

            if (cell != null)
            {
                if (e.ColumnIndex == 2)
                {
                    char[] chars = e.FormattedValue.ToString().ToCharArray();
                    foreach (char c in chars)
                    {
                        if (char.IsDigit(c) == false)
                        {
                            MyMessageBox.ShowBox("You have to enter digits only");

                            e.Cancel = true;
                            break;
                        }
                    }
                }
            }
        }



    }
}
