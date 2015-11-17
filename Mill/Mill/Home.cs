using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mill
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchasedCloth pc = new PurchasedCloth();
            pc.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void btnCutting_Click(object sender, EventArgs e)
        {
            Cutting cutting = new Cutting();
            cutting.ShowDialog();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.ShowDialog();
        }

        private void btnStiching_Click(object sender, EventArgs e)
        {
            Stiching stiching = new Stiching();
            stiching.ShowDialog();
        }

        private void btnDelievery_Click(object sender, EventArgs e)
        {
            Delievery delievery = new Delievery();
            delievery.ShowDialog();
        }

        private void btnStichngReturn_Click(object sender, EventArgs e)
        {
            StichingReturn stichingReturn = new StichingReturn();
            stichingReturn.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void btnExpenditure_Click(object sender, EventArgs e)
        {
            DailyExpenditure expenditure = new DailyExpenditure();
            expenditure.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
