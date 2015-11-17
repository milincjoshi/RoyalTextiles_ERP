namespace Mill
{
    partial class StichingReportDaily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StichingReportDaily));
            this.lbldate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.lblWorkernameshow = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.dgvStichingDailyReport = new System.Windows.Forms.DataGridView();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityShow = new System.Windows.Forms.Label();
            this.lblQuantitygiven = new System.Windows.Forms.Label();
            this.lblQuantitygivenshow = new System.Windows.Forms.Label();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.lblReturnShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingDailyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(78, 76);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 20);
            this.lbldate.TabIndex = 25;
            this.lbldate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(221, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(282, 26);
            this.dtpDate.TabIndex = 24;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(770, 666);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 23;
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
            this.btnExportToExcel.Location = new System.Drawing.Point(533, 666);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(202, 40);
            this.btnExportToExcel.TabIndex = 22;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // lblWorkernameshow
            // 
            this.lblWorkernameshow.AutoSize = true;
            this.lblWorkernameshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkernameshow.Location = new System.Drawing.Point(97, 18);
            this.lblWorkernameshow.Name = "lblWorkernameshow";
            this.lblWorkernameshow.Size = new System.Drawing.Size(0, 20);
            this.lblWorkernameshow.TabIndex = 21;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(78, 21);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(117, 20);
            this.lblWorkerName.TabIndex = 20;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(221, 18);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(282, 28);
            this.cbWorkerName.TabIndex = 26;
            this.cbWorkerName.TextChanged += new System.EventHandler(this.cbWorkerName_TextChanged);
            // 
            // dgvStichingDailyReport
            // 
            this.dgvStichingDailyReport.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStichingDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStichingDailyReport.Location = new System.Drawing.Point(82, 119);
            this.dgvStichingDailyReport.Name = "dgvStichingDailyReport";
            this.dgvStichingDailyReport.Size = new System.Drawing.Size(734, 471);
            this.dgvStichingDailyReport.TabIndex = 27;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(712, 618);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 20);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Total Quantity";
            // 
            // lblQuantityShow
            // 
            this.lblQuantityShow.AutoSize = true;
            this.lblQuantityShow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantityShow.Location = new System.Drawing.Point(839, 618);
            this.lblQuantityShow.Name = "lblQuantityShow";
            this.lblQuantityShow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityShow.TabIndex = 29;
            // 
            // lblQuantitygiven
            // 
            this.lblQuantitygiven.AutoSize = true;
            this.lblQuantitygiven.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygiven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygiven.Location = new System.Drawing.Point(78, 618);
            this.lblQuantitygiven.Name = "lblQuantitygiven";
            this.lblQuantitygiven.Size = new System.Drawing.Size(132, 20);
            this.lblQuantitygiven.TabIndex = 32;
            this.lblQuantitygiven.Text = " Quantity Given";
            // 
            // lblQuantitygivenshow
            // 
            this.lblQuantitygivenshow.AutoSize = true;
            this.lblQuantitygivenshow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygivenshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygivenshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygivenshow.Location = new System.Drawing.Point(226, 618);
            this.lblQuantitygivenshow.Name = "lblQuantitygivenshow";
            this.lblQuantitygivenshow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantitygivenshow.TabIndex = 31;
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnQuantity.Location = new System.Drawing.Point(341, 618);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(136, 20);
            this.lblReturnQuantity.TabIndex = 34;
            this.lblReturnQuantity.Text = "Return Quantity";
            // 
            // lblReturnShow
            // 
            this.lblReturnShow.AutoSize = true;
            this.lblReturnShow.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnShow.Location = new System.Drawing.Point(494, 618);
            this.lblReturnShow.Name = "lblReturnShow";
            this.lblReturnShow.Size = new System.Drawing.Size(0, 20);
            this.lblReturnShow.TabIndex = 33;
            // 
            // StichingReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 718);
            this.Controls.Add(this.lblReturnQuantity);
            this.Controls.Add(this.lblReturnShow);
            this.Controls.Add(this.lblQuantitygiven);
            this.Controls.Add(this.lblQuantitygivenshow);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuantityShow);
            this.Controls.Add(this.dgvStichingDailyReport);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.lblWorkernameshow);
            this.Controls.Add(this.lblWorkerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StichingReportDaily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stiching Daily Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StichingDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingDailyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label lblWorkernameshow;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.DataGridView dgvStichingDailyReport;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityShow;
        private System.Windows.Forms.Label lblQuantitygiven;
        private System.Windows.Forms.Label lblQuantitygivenshow;
        private System.Windows.Forms.Label lblReturnQuantity;
        private System.Windows.Forms.Label lblReturnShow;

    }
}