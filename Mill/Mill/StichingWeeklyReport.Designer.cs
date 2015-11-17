namespace Mill
{
    partial class StichingWeeklyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StichingWeeklyReport));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.lblWorkernameshow = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.lblReturnShow = new System.Windows.Forms.Label();
            this.lblQuantitygiven = new System.Windows.Forms.Label();
            this.lblQuantitygivenshow = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityShow = new System.Windows.Forms.Label();
            this.dgvStichingMonthlyReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingMonthlyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(717, 666);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 40);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportToExcel.Location = new System.Drawing.Point(511, 666);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(182, 40);
            this.btnExportToExcel.TabIndex = 24;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(194, 23);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(276, 28);
            this.cbWorkerName.TabIndex = 45;
            this.cbWorkerName.TextChanged += new System.EventHandler(this.cbWorkerName_TextChanged);
            // 
            // lblWorkernameshow
            // 
            this.lblWorkernameshow.AutoSize = true;
            this.lblWorkernameshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkernameshow.Location = new System.Drawing.Point(87, 23);
            this.lblWorkernameshow.Name = "lblWorkernameshow";
            this.lblWorkernameshow.Size = new System.Drawing.Size(0, 20);
            this.lblWorkernameshow.TabIndex = 44;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(41, 23);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(117, 20);
            this.lblWorkerName.TabIndex = 43;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(586, 89);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(222, 26);
            this.dtpDateTo.TabIndex = 42;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTo.Location = new System.Drawing.Point(533, 89);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 20);
            this.lblTo.TabIndex = 41;
            this.lblTo.Text = "To";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWeek.Location = new System.Drawing.Point(41, 51);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(110, 20);
            this.lblWeek.TabIndex = 40;
            this.lblWeek.Text = "Select Week";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(194, 83);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(222, 26);
            this.dtpDateFrom.TabIndex = 39;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFrom.Location = new System.Drawing.Point(108, 89);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 38;
            this.lblFrom.Text = "From";
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnQuantity.Location = new System.Drawing.Point(339, 634);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(136, 20);
            this.lblReturnQuantity.TabIndex = 57;
            this.lblReturnQuantity.Text = "Return Quantity";
            // 
            // lblReturnShow
            // 
            this.lblReturnShow.AutoSize = true;
            this.lblReturnShow.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnShow.Location = new System.Drawing.Point(492, 634);
            this.lblReturnShow.Name = "lblReturnShow";
            this.lblReturnShow.Size = new System.Drawing.Size(0, 20);
            this.lblReturnShow.TabIndex = 56;
            // 
            // lblQuantitygiven
            // 
            this.lblQuantitygiven.AutoSize = true;
            this.lblQuantitygiven.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygiven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygiven.Location = new System.Drawing.Point(76, 634);
            this.lblQuantitygiven.Name = "lblQuantitygiven";
            this.lblQuantitygiven.Size = new System.Drawing.Size(132, 20);
            this.lblQuantitygiven.TabIndex = 55;
            this.lblQuantitygiven.Text = " Quantity Given";
            // 
            // lblQuantitygivenshow
            // 
            this.lblQuantitygivenshow.AutoSize = true;
            this.lblQuantitygivenshow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygivenshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygivenshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygivenshow.Location = new System.Drawing.Point(224, 634);
            this.lblQuantitygivenshow.Name = "lblQuantitygivenshow";
            this.lblQuantitygivenshow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantitygivenshow.TabIndex = 54;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(710, 634);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 20);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "Total Quantity";
            // 
            // lblQuantityShow
            // 
            this.lblQuantityShow.AutoSize = true;
            this.lblQuantityShow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantityShow.Location = new System.Drawing.Point(837, 634);
            this.lblQuantityShow.Name = "lblQuantityShow";
            this.lblQuantityShow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityShow.TabIndex = 52;
            // 
            // dgvStichingMonthlyReport
            // 
            this.dgvStichingMonthlyReport.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStichingMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStichingMonthlyReport.Location = new System.Drawing.Point(79, 138);
            this.dgvStichingMonthlyReport.Name = "dgvStichingMonthlyReport";
            this.dgvStichingMonthlyReport.Size = new System.Drawing.Size(729, 471);
            this.dgvStichingMonthlyReport.TabIndex = 50;
            // 
            // StichingWeeklyReport
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
            this.Controls.Add(this.dgvStichingMonthlyReport);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lblWorkernameshow);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StichingWeeklyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stiching Weekly Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StichingWeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingMonthlyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.Label lblWorkernameshow;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblReturnQuantity;
        private System.Windows.Forms.Label lblReturnShow;
        private System.Windows.Forms.Label lblQuantitygiven;
        private System.Windows.Forms.Label lblQuantitygivenshow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityShow;
        private System.Windows.Forms.DataGridView dgvStichingMonthlyReport;
    }
}