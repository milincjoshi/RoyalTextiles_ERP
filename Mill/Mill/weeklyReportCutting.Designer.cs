namespace Mill
{
    partial class weeklyReportCutting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weeklyReportCutting));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.lblWorkernameshow = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.dgvWeeklycuttingReport = new System.Windows.Forms.DataGridView();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklycuttingReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(704, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 40);
            this.btnCancel.TabIndex = 34;
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
            this.btnExportToExcel.Location = new System.Drawing.Point(492, 663);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(187, 40);
            this.btnExportToExcel.TabIndex = 33;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(590, 88);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(222, 26);
            this.dtpDateTo.TabIndex = 32;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTo.Location = new System.Drawing.Point(537, 88);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 20);
            this.lblTo.TabIndex = 31;
            this.lblTo.Text = "To";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWeek.Location = new System.Drawing.Point(45, 50);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(110, 20);
            this.lblWeek.TabIndex = 30;
            this.lblWeek.Text = "Select Week";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(198, 82);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(222, 26);
            this.dtpDateFrom.TabIndex = 29;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFrom.Location = new System.Drawing.Point(112, 88);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 28;
            this.lblFrom.Text = "From";
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(198, 22);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(276, 28);
            this.cbWorkerName.TabIndex = 37;
            this.cbWorkerName.TextChanged += new System.EventHandler(this.cbWorkerName_TextChanged);
            // 
            // lblWorkernameshow
            // 
            this.lblWorkernameshow.AutoSize = true;
            this.lblWorkernameshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkernameshow.Location = new System.Drawing.Point(91, 22);
            this.lblWorkernameshow.Name = "lblWorkernameshow";
            this.lblWorkernameshow.Size = new System.Drawing.Size(0, 20);
            this.lblWorkernameshow.TabIndex = 36;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(45, 22);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(117, 20);
            this.lblWorkerName.TabIndex = 35;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // dgvWeeklycuttingReport
            // 
            this.dgvWeeklycuttingReport.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvWeeklycuttingReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklycuttingReport.Location = new System.Drawing.Point(58, 135);
            this.dgvWeeklycuttingReport.Name = "dgvWeeklycuttingReport";
            this.dgvWeeklycuttingReport.Size = new System.Drawing.Size(777, 460);
            this.dgvWeeklycuttingReport.TabIndex = 38;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(652, 616);
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
            this.lblQuantityShow.Location = new System.Drawing.Point(779, 616);
            this.lblQuantityShow.Name = "lblQuantityShow";
            this.lblQuantityShow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityShow.TabIndex = 39;
            // 
            // weeklyReportCutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 716);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuantityShow);
            this.Controls.Add(this.dgvWeeklycuttingReport);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lblWorkernameshow);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblFrom);
            this.Name = "weeklyReportCutting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Report Cutting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.weeklyReportCutting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklycuttingReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.Label lblWorkernameshow;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.DataGridView dgvWeeklycuttingReport;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityShow;

    }
}