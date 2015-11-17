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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string strQuerry;
                strQuerry = "select * from tbladmin where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Home home = new Home();
                    home.Show();

                }
                else
                {
                    MyMessageBox.ShowBox("Invalid Username or Password", "Login Failed");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message,"Exception");
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            AdminSetting adminSetting = new AdminSetting();
            adminSetting.ShowDialog();
        }
    }
}
