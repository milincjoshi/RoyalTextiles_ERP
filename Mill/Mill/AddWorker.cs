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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string strQuerry;
                strQuerry = "insert into tblWorker values(@FirstName,@LastName,@Mobile,@Address)";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                cmd.ExecuteNonQuery();
                con.Close();
               // frmShowMessage.Show("Data Inserted Successfully!!!", "Information", enumMessageIcon.Information, enumMessageButton.OKCancel);
                string res=MyMessageBox.ShowBox("Data Added Successfully!!!","Information");
                if (res.Equals("1"))
                {
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtMobileNo.Text = string.Empty;
                }
                
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
            
        }
    }
}
