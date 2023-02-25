namespace Group2_Assignment
{
    partial class Student_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Portal));
            btnLogout = new Button();
            panelSetting = new Panel();
            btnUpdateSecurityQuestions = new Button();
            btnChangePassword = new Button();
            btnTheme = new Button();
            btnSetting = new Button();
            pictureBox2 = new PictureBox();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            pbSchedule = new PictureBox();
            btnProfile = new Button();
            btnFees = new Button();
            btnSchedule = new Button();
            pictureBox3 = new PictureBox();
            panelTutor = new Panel();
            lblETC = new Label();
            pictureBox4 = new PictureBox();
            btnChangeSub = new Button();
            panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(254, 251, 233);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(254, 251, 233);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(27, 68);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(70, 81);
            btnLogout.TabIndex = 25;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelSetting
            // 
            panelSetting.BackColor = Color.FromArgb(225, 238, 221);
            panelSetting.Controls.Add(btnUpdateSecurityQuestions);
            panelSetting.Controls.Add(btnChangePassword);
            panelSetting.Controls.Add(btnTheme);
            panelSetting.Controls.Add(btnSetting);
            panelSetting.Location = new Point(771, 7);
            panelSetting.MaximumSize = new Size(213, 224);
            panelSetting.MinimumSize = new Size(213, 63);
            panelSetting.Name = "panelSetting";
            panelSetting.Size = new Size(213, 224);
            panelSetting.TabIndex = 24;
            // 
            // btnUpdateSecurityQuestions
            // 
            btnUpdateSecurityQuestions.BackColor = Color.FromArgb(216, 240, 230);
            btnUpdateSecurityQuestions.Dock = DockStyle.Top;
            btnUpdateSecurityQuestions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateSecurityQuestions.ForeColor = SystemColors.ControlText;
            btnUpdateSecurityQuestions.Image = (Image)resources.GetObject("btnUpdateSecurityQuestions.Image");
            btnUpdateSecurityQuestions.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateSecurityQuestions.Location = new Point(0, 169);
            btnUpdateSecurityQuestions.Name = "btnUpdateSecurityQuestions";
            btnUpdateSecurityQuestions.Size = new Size(213, 53);
            btnUpdateSecurityQuestions.TabIndex = 6;
            btnUpdateSecurityQuestions.Text = "Update Security Questions";
            btnUpdateSecurityQuestions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateSecurityQuestions.UseVisualStyleBackColor = false;
            btnUpdateSecurityQuestions.Click += btnUpdateSecurityQuestions_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(216, 240, 230);
            btnChangePassword.Dock = DockStyle.Top;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = SystemColors.ControlText;
            btnChangePassword.Image = (Image)resources.GetObject("btnChangePassword.Image");
            btnChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.Location = new Point(0, 116);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(213, 53);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnTheme
            // 
            btnTheme.BackColor = Color.FromArgb(216, 240, 230);
            btnTheme.Dock = DockStyle.Top;
            btnTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTheme.ForeColor = SystemColors.ControlText;
            btnTheme.Image = (Image)resources.GetObject("btnTheme.Image");
            btnTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheme.Location = new Point(0, 63);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(213, 53);
            btnTheme.TabIndex = 4;
            btnTheme.Text = "Theme";
            btnTheme.TextAlign = ContentAlignment.MiddleRight;
            btnTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheme.UseVisualStyleBackColor = false;
            btnTheme.Click += btnTheme_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(225, 238, 221);
            btnSetting.Dock = DockStyle.Top;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.Location = new Point(0, 0);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(213, 63);
            btnSetting.TabIndex = 3;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(24, 58, 29);
            pictureBox2.Image = Properties.Resources.resume;
            pictureBox2.Location = new Point(292, 559);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BorderStyle = BorderStyle.Fixed3D;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(246, 196, 83);
            lblUsername.Location = new Point(399, 280);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(14, 30);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 58, 29);
            pictureBox1.Image = Properties.Resources.Fee;
            pictureBox1.Location = new Point(292, 490);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pbSchedule
            // 
            pbSchedule.BackColor = Color.FromArgb(24, 58, 29);
            pbSchedule.Image = Properties.Resources.administration;
            pbSchedule.Location = new Point(292, 347);
            pbSchedule.Name = "pbSchedule";
            pbSchedule.Size = new Size(60, 38);
            pbSchedule.SizeMode = PictureBoxSizeMode.Zoom;
            pbSchedule.TabIndex = 21;
            pbSchedule.TabStop = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(24, 58, 29);
            btnProfile.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.FromArgb(254, 251, 233);
            btnProfile.Location = new Point(277, 550);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(449, 59);
            btnProfile.TabIndex = 19;
            btnProfile.Text = "Personal Info";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnFees
            // 
            btnFees.BackColor = Color.FromArgb(24, 58, 29);
            btnFees.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFees.ForeColor = Color.FromArgb(254, 251, 233);
            btnFees.Location = new Point(277, 479);
            btnFees.Name = "btnFees";
            btnFees.Size = new Size(449, 59);
            btnFees.TabIndex = 18;
            btnFees.Text = "Fees";
            btnFees.UseVisualStyleBackColor = false;
            btnFees.Click += btnFees_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(24, 58, 29);
            btnSchedule.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.ForeColor = Color.FromArgb(254, 251, 233);
            btnSchedule.Location = new Point(277, 337);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(449, 59);
            btnSchedule.TabIndex = 17;
            btnSchedule.Text = "Class Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.student_icon;
            pictureBox3.Location = new Point(413, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(lblETC);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 69);
            panelTutor.TabIndex = 13;
            // 
            // lblETC
            // 
            lblETC.AutoSize = true;
            lblETC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblETC.Location = new Point(27, 22);
            lblETC.Name = "lblETC";
            lblETC.Size = new Size(310, 31);
            lblETC.TabIndex = 0;
            lblETC.Text = "Excellent Tutor Centre (ETC)";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(24, 58, 29);
            pictureBox4.Image = Properties.Resources.Subject;
            pictureBox4.Location = new Point(292, 418);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // btnChangeSub
            // 
            btnChangeSub.BackColor = Color.FromArgb(24, 58, 29);
            btnChangeSub.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeSub.ForeColor = Color.FromArgb(254, 251, 233);
            btnChangeSub.Location = new Point(277, 409);
            btnChangeSub.Name = "btnChangeSub";
            btnChangeSub.Size = new Size(449, 59);
            btnChangeSub.TabIndex = 26;
            btnChangeSub.Text = "Change Subject";
            btnChangeSub.UseVisualStyleBackColor = false;
            btnChangeSub.Click += btnChangeSub_Click;
            // 
            // Student_Portal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnLogout;
            ClientSize = new Size(982, 653);
            Controls.Add(pictureBox4);
            Controls.Add(btnChangeSub);
            Controls.Add(btnLogout);
            Controls.Add(panelSetting);
            Controls.Add(pictureBox2);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Controls.Add(pbSchedule);
            Controls.Add(btnProfile);
            Controls.Add(btnFees);
            Controls.Add(btnSchedule);
            Controls.Add(pictureBox3);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Portal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Portal";
            Load += Student_Portal_Load;
            panelSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Panel panelSetting;
        private Button btnUpdateSecurityQuestions;
        private Button btnChangePassword;
        private Button btnTheme;
        private Button btnSetting;
        private PictureBox pictureBox2;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private PictureBox pbSchedule;
        private Button btnProfile;
        private Button btnFees;
        private Button btnSchedule;
        private PictureBox pictureBox3;
        private Panel panelTutor;
        private Label lblETC;
        private PictureBox pictureBox4;
        private Button btnChangeSub;
    }
}