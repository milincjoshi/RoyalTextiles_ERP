namespace Mill
{
    partial class DailyStichingReportOfAllWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyStichingReportOfAllWorkers));
            this.lbldate = new System.Windows.Forms.Label();
            this.dtpDatey = new System.Windows.Forms.DateTimePicker();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.lblReturnShow = new System.Windows.Forms.Label();
            this.lblQuantitygiven = new System.Windows.Forms.Label();
            this.lblQuantitygivenshow = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityShow = new System.Windows.Forms.Label();
            this.dgvStichingDailyReportOfAllWorkers = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingDailyReportOfAllWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(82, 26);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 20);
            this.lbldate.TabIndex = 22;
            this.lbldate.Text = "Date";
            // 
            // dtpDatey
            // 
            this.dtpDatey.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDatey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatey.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatey.Location = new System.Drawing.Point(181, 23);
            this.dtpDatey.Name = "dtpDatey";
            this.dtpDatey.Size = new System.Drawing.Size(232, 26);
            this.dtpDatey.TabIndex = 21;
            this.dtpDatey.ValueChanged += new System.EventHandler(this.dtpDatey_ValueChanged);
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnQuantity.Location = new System.Drawing.Point(324, 618);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(136, 20);
            this.lblReturnQuantity.TabIndex = 44;
            this.lblReturnQuantity.Text = "Return Quantity";
            // 
            // lblReturnShow
            // 
            this.lblReturnShow.AutoSize = true;
            this.lblReturnShow.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnShow.Location = new System.Drawing.Point(477, 618);
            this.lblReturnShow.Name = "lblReturnShow";
            this.lblReturnShow.Size = new System.Drawing.Size(0, 20);
            this.lblReturnShow.TabIndex = 43;
            // 
            // lblQuantitygiven
            // 
            this.lblQuantitygiven.AutoSize = true;
            this.lblQuantitygiven.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygiven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygiven.Location = new System.Drawing.Point(61, 618);
            this.lblQuantitygiven.Name = "lblQuantitygiven";
            this.lblQuantitygiven.Size = new System.Drawing.Size(132, 20);
            this.lblQuantitygiven.TabIndex = 42;
            this.lblQuantitygiven.Text = " Quantity Given";
            // 
            // lblQuantitygivenshow
            // 
            this.lblQuantitygivenshow.AutoSize = true;
            this.lblQuantitygivenshow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygivenshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygivenshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygivenshow.Location = new System.Drawing.Point(209, 618);
            this.lblQuantitygivenshow.Name = "lblQuantitygivenshow";
            this.lblQuantitygivenshow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantitygivenshow.TabIndex = 41;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(695, 618);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 20);
            this.lblQuantity.TabIndex = 40;
            this.lblQuantity.Text = "Total Quantity";
            // 
            // lblQuantityShow
            // 
            this.lblQuantityShow.AutoSize = true;
            this.lblQuantityShow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantityShow.Location = new System.Drawing.Point(822, 618);
            this.lblQuantityShow.Name = "lblQuantityShow";
            this.lblQuantityShow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityShow.TabIndex = 39;
            // 
            // dgvStichingDailyReportOfAllWorkers
            // 
            this.dgvStichingDailyReportOfAllWorkers.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStichingDailyReportOfAllWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStichingDailyReportOfAllWorkers.Location = new System.Drawing.Point(16, 71);
            this.dgvStichingDailyReportOfAllWorkers.Name = "dgvStichingDailyReportOfAllWorkers";
            this.dgvStichingDailyReportOfAllWorkers.Size = new System.Drawing.Size(814, 519);
            this.dgvStichingDailyReportOfAllWorkers.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(702, 664);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportToExcel.Location = new System.Drawing.Point(488, 664);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(202, 40);
            this.btnExportToExcel.TabIndex = 35;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // DailyStichingReportOfAllWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 716);
            this.Controls.Add(this.lblReturnQuantity);
            this.Controls.Add(this.lblReturnShow);
            this.Controls.Add(this.lblQuantitygiven);
            this.Controls.Add(this.lblQuantitygivenshow);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuantityShow);
            this.Controls.Add(this.dgvStichingDailyReportOfAllWorkers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dtpDatey);
            this.Name = "DailyStichingReportOfAllWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Stiching Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailyStichingReportOfAllWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingDailyReportOfAllWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtpDatey;
        private System.Windows.Forms.Label lblReturnQuantity;
        private System.Windows.Forms.Label lblReturnShow;
        private System.Windows.Forms.Label lblQuantitygiven;
        private System.Windows.Forms.Label lblQuantitygivenshow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityShow;
        private System.Windows.Forms.DataGridView dgvStichingDailyReportOfAllWorkers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToExcel;

    }
}