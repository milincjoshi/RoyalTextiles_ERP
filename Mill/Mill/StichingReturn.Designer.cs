namespace Mill
{
    partial class StichingReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StichingReturn));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvStichingReturn = new System.Windows.Forms.DataGridView();
            this.cbWorkerName = new System.Windows.Forms.ComboBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.lblDayshow = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDateshow = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingReturn)).BeginInit();
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
            this.btnCancel.Location = new System.Drawing.Point(745, 648);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "    Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(537, 648);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "   SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvStichingReturn
            // 
            this.dgvStichingReturn.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvStichingReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStichingReturn.Location = new System.Drawing.Point(83, 143);
            this.dgvStichingReturn.Name = "dgvStichingReturn";
            this.dgvStichingReturn.Size = new System.Drawing.Size(812, 456);
            this.dgvStichingReturn.TabIndex = 55;
            // 
            // cbWorkerName
            // 
            this.cbWorkerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerName.FormattingEnabled = true;
            this.cbWorkerName.Location = new System.Drawing.Point(228, 96);
            this.cbWorkerName.Name = "cbWorkerName";
            this.cbWorkerName.Size = new System.Drawing.Size(271, 28);
            this.cbWorkerName.TabIndex = 61;
            this.cbWorkerName.Text = "---Select Worker---";
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerName.Location = new System.Drawing.Point(79, 99);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(117, 20);
            this.lblWorkerName.TabIndex = 60;
            this.lblWorkerName.Text = "Worker Name";
            // 
            // lblDayshow
            // 
            this.lblDayshow.AutoSize = true;
            this.lblDayshow.BackColor = System.Drawing.Color.Transparent;
            this.lblDayshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayshow.Location = new System.Drawing.Point(643, 34);
            this.lblDayshow.Name = "lblDayshow";
            this.lblDayshow.Size = new System.Drawing.Size(0, 20);
            this.lblDayshow.TabIndex = 59;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDay.Location = new System.Drawing.Point(582, 34);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 20);
            this.lblDay.TabIndex = 58;
            this.lblDay.Text = "Day";
            // 
            // lblDateshow
            // 
            this.lblDateshow.AutoSize = true;
            this.lblDateshow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateshow.Location = new System.Drawing.Point(145, 34);
            this.lblDateshow.Name = "lblDateshow";
            this.lblDateshow.Size = new System.Drawing.Size(0, 20);
            this.lblDateshow.TabIndex = 57;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(79, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // StichingReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 718);
            this.Controls.Add(this.cbWorkerName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.lblDayshow);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDateshow);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvStichingReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StichingReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stiching Return";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StichingReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStichingReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvStichingReturn;
        private System.Windows.Forms.ComboBox cbWorkerName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Label lblDayshow;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDateshow;
        private System.Windows.Forms.Label lblDate;
    }
}