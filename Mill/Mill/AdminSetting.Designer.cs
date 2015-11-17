namespace Mill
{
    partial class AdminSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSetting));
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.gbChangeAdmin = new System.Windows.Forms.GroupBox();
            this.btnSAVEPassword = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPasword = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtPUserName = new System.Windows.Forms.TextBox();
            this.txtPNewPassword = new System.Windows.Forms.TextBox();
            this.txtPCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtPRetypePassword = new System.Windows.Forms.TextBox();
            this.btnCancelPassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.gbChangePassword.SuspendLayout();
            this.gbChangeAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.gbChangePassword.Controls.Add(this.btnCancelPassword);
            this.gbChangePassword.Controls.Add(this.txtPRetypePassword);
            this.gbChangePassword.Controls.Add(this.txtPCurrentPassword);
            this.gbChangePassword.Controls.Add(this.txtPNewPassword);
            this.gbChangePassword.Controls.Add(this.txtPUserName);
            this.gbChangePassword.Controls.Add(this.lblRetypePassword);
            this.gbChangePassword.Controls.Add(this.lblNewPasword);
            this.gbChangePassword.Controls.Add(this.lblCurrentPassword);
            this.gbChangePassword.Controls.Add(this.lblUserName);
            this.gbChangePassword.Controls.Add(this.btnSAVEPassword);
            this.gbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbChangePassword.Location = new System.Drawing.Point(44, 39);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(360, 413);
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change Password";
            // 
            // gbChangeAdmin
            // 
            this.gbChangeAdmin.BackColor = System.Drawing.Color.Transparent;
            this.gbChangeAdmin.Controls.Add(this.btnCancel);
            this.gbChangeAdmin.Controls.Add(this.txtRetypePassword);
            this.gbChangeAdmin.Controls.Add(this.txtCurrentPassword);
            this.gbChangeAdmin.Controls.Add(this.txtNewPassword);
            this.gbChangeAdmin.Controls.Add(this.txtUserName);
            this.gbChangeAdmin.Controls.Add(this.label1);
            this.gbChangeAdmin.Controls.Add(this.label2);
            this.gbChangeAdmin.Controls.Add(this.label3);
            this.gbChangeAdmin.Controls.Add(this.label4);
            this.gbChangeAdmin.Controls.Add(this.btnSAVE);
            this.gbChangeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangeAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbChangeAdmin.Location = new System.Drawing.Point(456, 39);
            this.gbChangeAdmin.Name = "gbChangeAdmin";
            this.gbChangeAdmin.Size = new System.Drawing.Size(351, 413);
            this.gbChangeAdmin.TabIndex = 1;
            this.gbChangeAdmin.TabStop = false;
            this.gbChangeAdmin.Text = "Change ADMIN";
            // 
            // btnSAVEPassword
            // 
            this.btnSAVEPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSAVEPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAVEPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVEPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSAVEPassword.Location = new System.Drawing.Point(33, 323);
            this.btnSAVEPassword.Name = "btnSAVEPassword";
            this.btnSAVEPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSAVEPassword.TabIndex = 0;
            this.btnSAVEPassword.Text = "SAVE";
            this.btnSAVEPassword.UseVisualStyleBackColor = false;
            this.btnSAVEPassword.Click += new System.EventHandler(this.btnSAVEPassword_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(33, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(33, 103);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(120, 17);
            this.lblCurrentPassword.TabIndex = 2;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // lblNewPasword
            // 
            this.lblNewPasword.AutoSize = true;
            this.lblNewPasword.Location = new System.Drawing.Point(33, 177);
            this.lblNewPasword.Name = "lblNewPasword";
            this.lblNewPasword.Size = new System.Drawing.Size(93, 17);
            this.lblNewPasword.TabIndex = 3;
            this.lblNewPasword.Text = "New Pasword";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(33, 235);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(118, 17);
            this.lblRetypePassword.TabIndex = 4;
            this.lblRetypePassword.Text = "Retype Password";
            // 
            // txtPUserName
            // 
            this.txtPUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPUserName.Location = new System.Drawing.Point(33, 70);
            this.txtPUserName.Name = "txtPUserName";
            this.txtPUserName.Size = new System.Drawing.Size(232, 23);
            this.txtPUserName.TabIndex = 5;
            // 
            // txtPNewPassword
            // 
            this.txtPNewPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPNewPassword.Location = new System.Drawing.Point(33, 197);
            this.txtPNewPassword.Name = "txtPNewPassword";
            this.txtPNewPassword.Size = new System.Drawing.Size(232, 23);
            this.txtPNewPassword.TabIndex = 6;
            // 
            // txtPCurrentPassword
            // 
            this.txtPCurrentPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPCurrentPassword.Location = new System.Drawing.Point(33, 135);
            this.txtPCurrentPassword.Name = "txtPCurrentPassword";
            this.txtPCurrentPassword.Size = new System.Drawing.Size(232, 23);
            this.txtPCurrentPassword.TabIndex = 6;
            // 
            // txtPRetypePassword
            // 
            this.txtPRetypePassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPRetypePassword.Location = new System.Drawing.Point(33, 269);
            this.txtPRetypePassword.Name = "txtPRetypePassword";
            this.txtPRetypePassword.Size = new System.Drawing.Size(232, 23);
            this.txtPRetypePassword.TabIndex = 7;
            // 
            // btnCancelPassword
            // 
            this.btnCancelPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelPassword.Location = new System.Drawing.Point(190, 323);
            this.btnCancelPassword.Name = "btnCancelPassword";
            this.btnCancelPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPassword.TabIndex = 8;
            this.btnCancelPassword.Text = "Cancel";
            this.btnCancelPassword.UseVisualStyleBackColor = false;
            this.btnCancelPassword.Click += new System.EventHandler(this.btnCancelPassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(203, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRetypePassword.Location = new System.Drawing.Point(46, 276);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(232, 23);
            this.txtRetypePassword.TabIndex = 17;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCurrentPassword.Location = new System.Drawing.Point(46, 142);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(232, 23);
            this.txtCurrentPassword.TabIndex = 15;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNewPassword.Location = new System.Drawing.Point(46, 204);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(232, 23);
            this.txtNewPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserName.Location = new System.Drawing.Point(46, 77);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 23);
            this.txtUserName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Retype Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Pasword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Name";
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSAVE.Location = new System.Drawing.Point(46, 330);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 9;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // AdminSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 528);
            this.Controls.Add(this.gbChangeAdmin);
            this.Controls.Add(this.gbChangePassword);
            this.Name = "AdminSetting";
            this.Text = "AdminSetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.gbChangeAdmin.ResumeLayout(false);
            this.gbChangeAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.TextBox txtPRetypePassword;
        private System.Windows.Forms.TextBox txtPCurrentPassword;
        private System.Windows.Forms.TextBox txtPNewPassword;
        private System.Windows.Forms.TextBox txtPUserName;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Label lblNewPasword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSAVEPassword;
        private System.Windows.Forms.GroupBox gbChangeAdmin;
        private System.Windows.Forms.Button btnCancelPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSAVE;
    }
}