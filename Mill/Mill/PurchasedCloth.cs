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
    public partial class PurchasedCloth : Form
    {
        public PurchasedCloth()
        {
            InitializeComponent();
        }
  

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduct.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the Product");
                }
                else if (txtMeters.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the Proper values");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string str = "spClothPurchase";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PurchasedProduct", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@PurchasedMeters", txtMeters.Text);
                    cmd.Parameters.AddWithValue("@Date", System.DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@RemainingMeters", txtMeters.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string s=MyMessageBox.ShowBox("Product Inserted Successfully!!!","Information");
                    if (s.Equals("1"))
                    {
                        txtProduct.Text = string.Empty;
                        txtMeters.Text = string.Empty;
                    }

                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
            
        }

        private void PurchasedCloth_Load(object sender, EventArgs e)
        {
            lblDateshow.Text = System.DateTime.Now.ToString();
            lblDayshow.Text = System.DateTime.Now.DayOfWeek.ToString();
        } 
    }
}
