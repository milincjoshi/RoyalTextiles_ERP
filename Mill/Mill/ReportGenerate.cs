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
    public partial class ReportGenerate : Form
    {
        public ReportGenerate()
        {
            InitializeComponent();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            DailyReportCutting dailyCutting = new DailyReportCutting();
            dailyCutting.Show();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            weeklyReportCutting weeklyCutting = new weeklyReportCutting();
            weeklyCutting.Show();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            monthlyReportCutting monthlyCutting = new monthlyReportCutting();
            monthlyCutting.Show();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            yearlyReportCutting yearlyCutting = new yearlyReportCutting();
            yearlyCutting.Show();
        }

        private void btnDailyAllWorkers_Click(object sender, EventArgs e)
        {
            DailyCuttingReportOfAllWorkers dailyAllWorkers = new DailyCuttingReportOfAllWorkers();
            dailyAllWorkers.Show();
        }
    }
}
