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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWorker addworker = new AddWorker();
            addworker.ShowDialog();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\Training\\Mill\\Mill\\database.mdf;Integrated Security=True;User Instance=True");
        void Bind()
        {
            try
            {
                con.Open();
                string strQuerry;
                strQuerry = "SELECT WId , FirstName, LastName , Mobile, Address FROM tblWorker";
                SqlCommand cmd = new SqlCommand(strQuerry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvWorkers.DataSource = dt;

                con.Close();
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Delete";
                button.Name = "Delete";
                button.Text = "Delete";
                button.DefaultCellStyle.BackColor = Color.SteelBlue;
                button.FlatStyle = FlatStyle.Popup;
                DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
                button1.HeaderText = "Edit";
               // button1.Name = "Edit";
                button1.Text = "Edit";
                button1.ToolTipText = "Edit";
                button1.DefaultCellStyle.BackColor = Color.SteelBlue;
                button1.DefaultCellStyle.ForeColor = Color.White;
                button1.FlatStyle = FlatStyle.Popup;
                dgvWorkers.Columns.Add(button);
                dgvWorkers.Columns.Add(button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
