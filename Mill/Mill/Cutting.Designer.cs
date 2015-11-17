namespace Mill
{
    partial class Cutting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cutting));
            this.lblDayshow = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDateshow = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvCutting = new System.Windows.Forms.DataGridView();
            this.cbPurchasedCloth = new System.Windows.Forms.ComboBox();
            this.lblPurchasedCloth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDayshow
            // 
            this.lblDayshow.AutoSize = true;
            this.lblDayshow.BackColor = System.Drawing.Color.Transparent;
            this.lblDayshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayshow.Location = new System.Drawing.Point(764, 36);
            this.lblDayshow.Name = "lblDayshow";
            this.lblDayshow.Size = new System.Drawing.Size(0, 18);
            this.lblDayshow.TabIndex = 12;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDay.Location = new System.Drawing.Point(677, 36);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 18);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "Day";
            // 
            // lblDateshow
            // 
            this.lblDateshow.AutoSize = true;
            this.lblDateshow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateshow.Location = new System.Drawing.Point(120, 26);
            this.lblDateshow.Name = "lblDateshow";
            this.lblDateshow.Size = new System.Drawing.Size(0, 18);
            this.lblDateshow.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(38, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(86, 114);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(113, 18);
            this.lblWorkerName.TabIndex = 13;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbWorkerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(245, 111);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(329, 26);
            this.cbWorkerName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(520, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(728, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(36, 642);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 40);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvCutting
            // 
            this.dgvCutting.AllowUserToOrderColumns = true;
            this.dgvCutting.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvCutting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCutting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCutting.Location = new System.Drawing.Point(44, 156);
            this.dgvCutting.Name = "dgvCutting";
            this.dgvCutting.Size = new System.Drawing.Size(848, 453);
            this.dgvCutting.TabIndex = 14;
            this.dgvCutting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCutting_CellContentClick);
            this.dgvCutting.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCutting_CellValidating);
            // 
            // cbPurchasedCloth
            // 
            this.cbPurchasedCloth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPurchasedCloth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPurchasedCloth.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbPurchasedCloth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPurchasedCloth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPurchasedCloth.FormattingEnabled = true;
            this.cbPurchasedCloth.Location = new System.Drawing.Point(245, 68);
            this.cbPurchasedCloth.Name = "cbPurchasedCloth";
            this.cbPurchasedCloth.Size = new System.Drawing.Size(329, 26);
            this.cbPurchasedCloth.TabIndex = 15;
            // 
            // lblPurchasedCloth
            // 
            this.lblPurchasedCloth.AutoSize = true;
            this.lblPurchasedCloth.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchasedCloth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedCloth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchasedCloth.Location = new System.Drawing.Point(86, 71);
            this.lblPurchasedCloth.Name = "lblPurchasedCloth";
            this.lblPurchasedCloth.Size = new System.Drawing.Size(133, 18);
            this.lblPurchasedCloth.TabIndex = 16;
            this.lblPurchasedCloth.Text = "Purchased Cloth";
            // 
            // Cutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 714);
            this.Controls.Add(this.cbPurchasedCloth);
            this.Controls.Add(this.lblPurchasedCloth);
            this.Controls.Add(this.dgvCutting);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.lblDayshow);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDateshow);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Cutting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cutting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cutting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDayshow;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDateshow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvCutting;
        private System.Windows.Forms.ComboBox cbPurchasedCloth;
        private System.Windows.Forms.Label lblPurchasedCloth;
    }
}