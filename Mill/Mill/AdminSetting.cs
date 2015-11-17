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
    public partial class AdminSetting : Form
    {
        public AdminSetting()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");

        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSAVEPassword_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string password = "select password from tblAdmin where password='" + txtPCurrentPassword.Text + "'";
                SqlCommand cmdPassword = new SqlCommand(password, con);
                SqlDataReader rp;
                rp = cmdPassword.ExecuteReader();
                rp.Read();
                string pass = rp["password"].ToString();
                rp.Close();
                if (txtPNewPassword.Text == txtPRetypePassword.Text && txtPCurrentPassword.Text == pass)
                {
                    string update = "update tblAdmin set password='" + txtPNewPassword.Text + "' where adId='1'";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Password Updated Successfully!!!");
                    string ms = MyMessageBox.ShowBox("Password Updated Successfully!!!","Information");
                    if (ms.Equals("1"))
                    {
                        txtPUserName.Text = string.Empty;
                        txtPCurrentPassword.Text = string.Empty;
                        txtPNewPassword.Text = string.Empty;
                        txtPRetypePassword.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (txtNewPassword.Text == txtRetypePassword.Text)
                {
                    string insert = "update tblAdmin set username='" + txtUserName.Text + "',password='" + txtNewPassword.Text + "' where adId='1'";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Admin user Updated Successfully!!!");
                    string ms = MyMessageBox.ShowBox("Admin user Updated Successfully!!!", "Information");
                    if (ms.Equals("1"))
                    {
                        txtUserName.Text = string.Empty;
                        txtCurrentPassword.Text = string.Empty;
                        txtNewPassword.Text = string.Empty;
                        txtRetypePassword.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
        }
    }
}
