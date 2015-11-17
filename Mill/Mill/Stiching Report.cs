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
    public partial class StichingReport : Form
    {
        public StichingReport()
        {
            InitializeComponent();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            StichingReportDaily dailyStiching = new StichingReportDaily();
            dailyStiching.Show();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            StichingWeeklyReport weeklyStiching = new StichingWeeklyReport();
            weeklyStiching.Show();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            StichingMonthlyReport monthlyStiching = new StichingMonthlyReport();
            monthlyStiching.Show();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            StichingYearlyReport yearlyStiching = new StichingYearlyReport();
            yearlyStiching.Show();
        }

        private void btnDailyAllWorkers_Click(object sender, EventArgs e)
        {
            DailyStichingReportOfAllWorkers stichingAllWorkers = new DailyStichingReportOfAllWorkers();
            stichingAllWorkers.Show();
        }
    }
}
