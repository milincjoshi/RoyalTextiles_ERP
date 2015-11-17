namespace Mill
{
    partial class StichingYearlyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StichingYearlyReport));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.dgvStichingMonthlyReport = new System.Windows.Forms.DataGridView();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.lblReturnShow = new System.Windows.Forms.Label();
            this.lblQuantitygiven = new System.Windows.Forms.Label();
            this.lblQuantitygivenshow = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityShow = new System.Windows.Forms.Label();
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
            this.btnCancel.Location = new System.Drawing.Point(727, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 40);
            this.btnCancel.TabIndex = 29;
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
            this.btnExportToExcel.Location = new System.Drawing.Point(527, 663);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(187, 40);
            this.btnExportToExcel.TabIndex = 28;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbWorkerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(261, 24);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(300, 28);
            this.cbWorkerName.TabIndex = 40;
            this.cbWorkerName.TextChanged += new System.EventHandler(this.cbWorkerName_TextChanged);
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(102, 27);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(117, 20);
            this.lblWorkerName.TabIndex = 41;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(261, 79);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(300, 28);
            this.cbYear.TabIndex = 39;
            this.cbYear.TextChanged += new System.EventHandler(this.cbYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(102, 82);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 20);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "Year";
            // 
            // dgvStichingMonthlyReport
            // 
            this.dgvStichingMonthlyReport.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStichingMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStichingMonthlyReport.Location = new System.Drawing.Point(89, 123);
            this.dgvStichingMonthlyReport.Name = "dgvStichingMonthlyReport";
            this.dgvStichingMonthlyReport.Size = new System.Drawing.Size(721, 471);
            this.dgvStichingMonthlyReport.TabIndex = 42;
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnQuantity.Location = new System.Drawing.Point(349, 619);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(136, 20);
            this.lblReturnQuantity.TabIndex = 49;
            this.lblReturnQuantity.Text = "Return Quantity";
            // 
            // lblReturnShow
            // 
            this.lblReturnShow.AutoSize = true;
            this.lblReturnShow.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReturnShow.Location = new System.Drawing.Point(502, 619);
            this.lblReturnShow.Name = "lblReturnShow";
            this.lblReturnShow.Size = new System.Drawing.Size(0, 20);
            this.lblReturnShow.TabIndex = 48;
            // 
            // lblQuantitygiven
            // 
            this.lblQuantitygiven.AutoSize = true;
            this.lblQuantitygiven.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygiven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygiven.Location = new System.Drawing.Point(86, 619);
            this.lblQuantitygiven.Name = "lblQuantitygiven";
            this.lblQuantitygiven.Size = new System.Drawing.Size(132, 20);
            this.lblQuantitygiven.TabIndex = 47;
            this.lblQuantitygiven.Text = " Quantity Given";
            // 
            // lblQuantitygivenshow
            // 
            this.lblQuantitygivenshow.AutoSize = true;
            this.lblQuantitygivenshow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantitygivenshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitygivenshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantitygivenshow.Location = new System.Drawing.Point(234, 619);
            this.lblQuantitygivenshow.Name = "lblQuantitygivenshow";
            this.lblQuantitygivenshow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantitygivenshow.TabIndex = 46;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(720, 619);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 20);
            this.lblQuantity.TabIndex = 45;
            this.lblQuantity.Text = "Total Quantity";
            // 
            // lblQuantityShow
            // 
            this.lblQuantityShow.AutoSize = true;
            this.lblQuantityShow.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantityShow.Location = new System.Drawing.Point(847, 619);
            this.lblQuantityShow.Name = "lblQuantityShow";
            this.lblQuantityShow.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityShow.TabIndex = 44;
            // 
            // StichingYearlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 716);
            this.Controls.Add(this.lblReturnQuantity);
            this.Controls.Add(this.lblReturnShow);
            this.Controls.Add(this.lblQuantitygiven);
            this.Controls.Add(this.lblQuantitygivenshow);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuantityShow);
            this.Controls.Add(this.dgvStichingMonthlyReport);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToExcel);
            this.Name = "StichingYearlyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stiching Yearly Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StichingYearlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingMonthlyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridView dgvStichingMonthlyReport;
        private System.Windows.Forms.Label lblReturnQuantity;
        private System.Windows.Forms.Label lblReturnShow;
        private System.Windows.Forms.Label lblQuantitygiven;
        private System.Windows.Forms.Label lblQuantitygivenshow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityShow;
    }
}