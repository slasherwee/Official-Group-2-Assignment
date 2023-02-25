namespace Group2_Assignment
{
    partial class frmAdminMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblETC = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnViewPayroll = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnUpdateSecurityQuestions = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnRegisterUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegisterUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Location = new System.Drawing.Point(304, 299);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(365, 62);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "Register New User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlMenu.Controls.Add(this.lblETC);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(983, 63);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(22, 17);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(329, 31);
            this.lblETC.TabIndex = 2;
            this.lblETC.Text = "Excellent Tuition Centre (ETC)";
            // 
            // picAdmin
            // 
            this.picAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(400, 78);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(166, 166);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 2;
            this.picAdmin.TabStop = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(304, 370);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(365, 62);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnViewIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewIncome.ForeColor = System.Drawing.Color.White;
            this.btnViewIncome.Location = new System.Drawing.Point(304, 510);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(365, 62);
            this.btnViewIncome.TabIndex = 4;
            this.btnViewIncome.Text = "View Income Report";
            this.btnViewIncome.UseVisualStyleBackColor = false;
            this.btnViewIncome.Click += new System.EventHandler(this.btnViewIncome_Click);
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnPersonalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.Location = new System.Drawing.Point(304, 579);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(365, 62);
            this.btnPersonalInfo.TabIndex = 5;
            this.btnPersonalInfo.Text = "Personal Info";
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // btnViewPayroll
            // 
            this.btnViewPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnViewPayroll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewPayroll.ForeColor = System.Drawing.Color.White;
            this.btnViewPayroll.Location = new System.Drawing.Point(304, 440);
            this.btnViewPayroll.Name = "btnViewPayroll";
            this.btnViewPayroll.Size = new System.Drawing.Size(365, 62);
            this.btnViewPayroll.TabIndex = 6;
            this.btnViewPayroll.Text = "View Payroll";
            this.btnViewPayroll.UseVisualStyleBackColor = false;
            this.btnViewPayroll.Click += new System.EventHandler(this.btnViewPayroll_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.Controls.Add(this.btnUpdateSecurityQuestions);
            this.panelSetting.Controls.Add(this.btnChangePassword);
            this.panelSetting.Controls.Add(this.btnTheme);
            this.panelSetting.Controls.Add(this.btnSetting);
            this.panelSetting.Location = new System.Drawing.Point(770, 0);
            this.panelSetting.MaximumSize = new System.Drawing.Size(213, 224);
            this.panelSetting.MinimumSize = new System.Drawing.Size(213, 63);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(213, 224);
            this.panelSetting.TabIndex = 12;
            // 
            // btnUpdateSecurityQuestions
            // 
            this.btnUpdateSecurityQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.btnUpdateSecurityQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateSecurityQuestions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSecurityQuestions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateSecurityQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSecurityQuestions.Image")));
            this.btnUpdateSecurityQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSecurityQuestions.Location = new System.Drawing.Point(0, 169);
            this.btnUpdateSecurityQuestions.Name = "btnUpdateSecurityQuestions";
            this.btnUpdateSecurityQuestions.Size = new System.Drawing.Size(213, 55);
            this.btnUpdateSecurityQuestions.TabIndex = 6;
            this.btnUpdateSecurityQuestions.Text = "Update Security Questions";
            this.btnUpdateSecurityQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateSecurityQuestions.UseVisualStyleBackColor = false;
            this.btnUpdateSecurityQuestions.Click += new System.EventHandler(this.btnUpdateSecurityQuestions_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 116);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(213, 53);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.btnTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTheme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnTheme.Image")));
            this.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.Location = new System.Drawing.Point(0, 63);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(213, 53);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.Text = "Theme";
            this.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheme.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(213, 63);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(22, 69);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 74);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(83)))));
            this.lblUsername.Location = new System.Drawing.Point(377, 255);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(14, 30);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "\r\n";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.btnViewPayroll);
            this.Controls.Add(this.btnPersonalInfo);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnRegisterUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.panelSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblETC;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnViewIncome;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnViewPayroll;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button btnUpdateSecurityQuestions;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
    }
}
