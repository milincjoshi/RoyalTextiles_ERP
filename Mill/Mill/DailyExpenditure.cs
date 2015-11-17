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
    public partial class DailyExpenditure : Form
    {
        public DailyExpenditure()
        {
            InitializeComponent();
            lblDateShow.Text = System.DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string strQuerry;
                strQuerry = "insert into tblExpenditure values(@Name,@Product,@Price,@Date)";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Product", txtProduct.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MyMessageBox.ShowBox("Data Inserted Successfully!!");
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DailyExpenditureReport dailyexpenditureReport = new DailyExpenditureReport();
            dailyexpenditureReport.Show();
        }
    }
}
