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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            dailyReport dailyreport = new dailyReport();
            dailyreport.Show();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyreport = new WeeklyReport();
            weeklyreport.Show();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            MonthlyReport monthlyreport = new MonthlyReport();
            monthlyreport.Show();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            YearlyReport yearlyreport = new YearlyReport();
            yearlyreport.Show();
        }
    }
}
