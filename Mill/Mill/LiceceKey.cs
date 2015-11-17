using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FormToImage
{
    public partial class LiceceKey : Form
    {
        private Button button1;
        private TextBox textBox1;
    
        public LiceceKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //// String[] commandLineArgs = System.Environment.GetCommandLineArgs();
           // string decryptionKey = CreateKey(System.Convert.ToInt32(10));
           // string validationKey = CreateKey(System.Convert.ToInt32(20));
            
            //label1.Text =  validationKey;
            //label1.Text += "\n" + decryptionKey;
            if (textBox1.Text.Trim() == "ECAEE7303BA8D4C535C2DFCDEE3AEAA41EA223CB")
            {
                Application.UserAppDataRegistry.SetValue("installeddate", System.DateTime.Now.ToShortDateString().ToString());
                Application.UserAppDataRegistry.SetValue("licence", textBox1.Text);
                MessageBox.Show("Successfull registered.");
                this.Hide();
            }
            else
                MessageBox.Show("Please enter valid key");
        }	

        static String CreateKey(int numBytes)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[numBytes];

            rng.GetBytes(buff);
            return BytesToHexString(buff);
        }

        static String BytesToHexString(byte[] bytes)
        {
            StringBuilder hexString = new StringBuilder(64);

            for (int counter = 0; counter < bytes.Length; counter++)
            {
                hexString.Append(String.Format("{0:X2}", bytes[counter]));
            }
            return hexString.ToString();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LiceceKey
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "LiceceKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
