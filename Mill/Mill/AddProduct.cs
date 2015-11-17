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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidate())
                {
                    epAddProduct.Clear();
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string strQuerry;
                    strQuerry = "insert into tblProduct Values(@ProductName,@Size,@Average,@Price)";
                    SqlCommand cmd = new SqlCommand(strQuerry, con);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Size", cbSize.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Average", txtAverage.Text);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   // MessageBox.Show("The Product has been Inserted Successfully!!!");
                    string str = MyMessageBox.ShowBox("The Product has been Inserted Successfully!!!","Information");
                    if (str.Equals("1"))
                    {
                        txtProductName.Text = string.Empty;
                        txtAverage.Text = string.Empty;
                        txtPrice.Text = string.Empty;
                    }

                }
               
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowBox(ex.Message, "Exception");
            }
        }
        private bool IsValidate()
        {
            bool NoError = true;
            if (txtProductName.Text == string.Empty || txtProductName.Text==null)
            {
                epAddProduct.SetError(txtProductName, "Please Enter Product Name");
                NoError = false;
            }
            else
            {
                epAddProduct.Clear();
            }
            if (cbSize.SelectedIndex == -1)
            {
                epAddProduct.SetError(cbSize, "Select the Size of the Product");
                NoError = false;
            }
            else
            {
                epAddProduct.Clear();
            }
            if (txtAverage.Text == string.Empty)
            {
                epAddProduct.SetError(txtAverage, "Please Enter the Average");
                NoError = false;
            }
            else
            {
                epAddProduct.Clear();
            }
            if (txtPrice.Text == string.Empty)
            {
                epAddProduct.SetError(txtPrice, "Please enter the Price");
                NoError = false;
            }
            else
            {
                epAddProduct.Clear();
            }
            try
            {
                float i = float.Parse(txtAverage.Text);
                float j = float.Parse(txtPrice.Text);
            }
            catch
            {
                epAddProduct.Clear();
                epAddProduct.SetError(txtAverage, "Numeric Values Allowed");
                epAddProduct.SetError(txtPrice, "Numeric Values Allowed");
                return false;
            }
            return NoError;

        }
    }
}
