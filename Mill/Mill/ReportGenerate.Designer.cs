namespace Mill
{
    partial class ReportGenerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGenerate));
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnYearly = new System.Windows.Forms.Button();
            this.btnDailyAllWorkers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(126, 89);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(200, 60);
            this.btnDaily.TabIndex = 2;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(569, 89);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(200, 60);
            this.btnWeekly.TabIndex = 3;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.UseVisualStyleBackColor = false;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(126, 182);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(200, 60);
            this.btnMonthly.TabIndex = 4;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnYearly
            // 
            this.btnYearly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearly.Location = new System.Drawing.Point(569, 182);
            this.btnYearly.Name = "btnYearly";
            this.btnYearly.Size = new System.Drawing.Size(200, 60);
            this.btnYearly.TabIndex = 5;
            this.btnYearly.Text = "Yearly";
            this.btnYearly.UseVisualStyleBackColor = false;
            this.btnYearly.Click += new System.EventHandler(this.btnYearly_Click);
            // 
            // btnDailyAllWorkers
            // 
            this.btnDailyAllWorkers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDailyAllWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyAllWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyAllWorkers.Location = new System.Drawing.Point(185, 298);
            this.btnDailyAllWorkers.Name = "btnDailyAllWorkers";
            this.btnDailyAllWorkers.Size = new System.Drawing.Size(525, 60);
            this.btnDailyAllWorkers.TabIndex = 6;
            this.btnDailyAllWorkers.Text = "Daily Report of All Workers";
            this.btnDailyAllWorkers.UseVisualStyleBackColor = false;
            this.btnDailyAllWorkers.Click += new System.EventHandler(this.btnDailyAllWorkers_Click);
            // 
            // ReportGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 668);
            this.Controls.Add(this.btnDailyAllWorkers);
            this.Controls.Add(this.btnYearly);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.btnDaily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportGenerate";
            this.Text = "Report Generate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnYearly;
        private System.Windows.Forms.Button btnDailyAllWorkers;
    }
}