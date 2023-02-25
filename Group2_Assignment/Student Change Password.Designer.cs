namespace Group2_Assignment
{
    partial class Student_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Change_Password));
            btnSave = new Button();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            txtCurrentPass = new TextBox();
            lblConfirmPass = new Label();
            lblNewPass = new Label();
            lblCurrentPass = new Label();
            panelTutor = new Panel();
            pbPassword = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            pbCurPassHide = new PictureBox();
            pbCurPassShow = new PictureBox();
            pbNewPassHide = new PictureBox();
            pbNewPassShow = new PictureBox();
            pbConPassHide = new PictureBox();
            pbConPassShow = new PictureBox();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCurPassHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCurPassShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPassHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPassShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConPassHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConPassShow).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 58, 29);
            btnSave.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(254, 251, 233);
            btnSave.Location = new Point(385, 507);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(221, 48);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(446, 390);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(265, 27);
            txtConfirmPass.TabIndex = 26;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(446, 317);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(265, 27);
            txtNewPass.TabIndex = 25;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Location = new Point(446, 245);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.Size = new Size(265, 27);
            txtCurrentPass.TabIndex = 24;
            txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPass.Location = new Point(251, 390);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(177, 28);
            lblConfirmPass.TabIndex = 23;
            lblConfirmPass.Text = "Confirm Password :";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewPass.Location = new Point(282, 317);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(146, 28);
            lblNewPass.TabIndex = 22;
            lblNewPass.Text = "New Password :";
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentPass.Location = new Point(257, 244);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(177, 28);
            lblCurrentPass.TabIndex = 21;
            lblCurrentPass.Text = "Current Password : ";
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(pbPassword);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 20;
            // 
            // pbPassword
            // 
            pbPassword.BackColor = Color.FromArgb(225, 238, 221);
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(249, 38);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(60, 38);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 8;
            pbPassword.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(225, 238, 221);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(38, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 50);
            btnBack.TabIndex = 14;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(337, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "CHANGE PASSWORD";
            // 
            // pbCurPassHide
            // 
            pbCurPassHide.BackColor = Color.FromArgb(254, 251, 233);
            pbCurPassHide.BackgroundImage = Properties.Resources.hide;
            pbCurPassHide.Image = Properties.Resources.hide;
            pbCurPassHide.InitialImage = Properties.Resources.hide;
            pbCurPassHide.Location = new Point(717, 247);
            pbCurPassHide.Name = "pbCurPassHide";
            pbCurPassHide.Size = new Size(25, 25);
            pbCurPassHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbCurPassHide.TabIndex = 28;
            pbCurPassHide.TabStop = false;
            pbCurPassHide.Click += pbCurPassHide_Click;
            // 
            // pbCurPassShow
            // 
            pbCurPassShow.BackColor = Color.FromArgb(254, 251, 233);
            pbCurPassShow.BackgroundImage = Properties.Resources.hide;
            pbCurPassShow.Image = Properties.Resources.show;
            pbCurPassShow.InitialImage = Properties.Resources.hide;
            pbCurPassShow.Location = new Point(717, 247);
            pbCurPassShow.Name = "pbCurPassShow";
            pbCurPassShow.Size = new Size(25, 25);
            pbCurPassShow.SizeMode = PictureBoxSizeMode.Zoom;
            pbCurPassShow.TabIndex = 29;
            pbCurPassShow.TabStop = false;
            pbCurPassShow.Click += pbCurPassShow_Click;
            // 
            // pbNewPassHide
            // 
            pbNewPassHide.BackColor = Color.FromArgb(254, 251, 233);
            pbNewPassHide.BackgroundImage = Properties.Resources.hide;
            pbNewPassHide.Image = Properties.Resources.hide;
            pbNewPassHide.InitialImage = Properties.Resources.hide;
            pbNewPassHide.Location = new Point(717, 320);
            pbNewPassHide.Name = "pbNewPassHide";
            pbNewPassHide.Size = new Size(25, 25);
            pbNewPassHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewPassHide.TabIndex = 30;
            pbNewPassHide.TabStop = false;
            pbNewPassHide.Click += pbNewPassHide_Click;
            // 
            // pbNewPassShow
            // 
            pbNewPassShow.BackColor = Color.FromArgb(254, 251, 233);
            pbNewPassShow.BackgroundImage = Properties.Resources.hide;
            pbNewPassShow.Image = Properties.Resources.show;
            pbNewPassShow.InitialImage = Properties.Resources.hide;
            pbNewPassShow.Location = new Point(717, 320);
            pbNewPassShow.Name = "pbNewPassShow";
            pbNewPassShow.Size = new Size(25, 25);
            pbNewPassShow.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewPassShow.TabIndex = 31;
            pbNewPassShow.TabStop = false;
            pbNewPassShow.Click += pbNewPassShow_Click;
            // 
            // pbConPassHide
            // 
            pbConPassHide.BackColor = Color.FromArgb(254, 251, 233);
            pbConPassHide.BackgroundImage = Properties.Resources.hide;
            pbConPassHide.Image = Properties.Resources.hide;
            pbConPassHide.InitialImage = Properties.Resources.hide;
            pbConPassHide.Location = new Point(717, 393);
            pbConPassHide.Name = "pbConPassHide";
            pbConPassHide.Size = new Size(25, 25);
            pbConPassHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbConPassHide.TabIndex = 32;
            pbConPassHide.TabStop = false;
            pbConPassHide.Click += pbConPassHide_Click;
            // 
            // pbConPassShow
            // 
            pbConPassShow.BackColor = Color.FromArgb(254, 251, 233);
            pbConPassShow.BackgroundImage = Properties.Resources.hide;
            pbConPassShow.Image = Properties.Resources.show;
            pbConPassShow.InitialImage = Properties.Resources.hide;
            pbConPassShow.Location = new Point(717, 393);
            pbConPassShow.Name = "pbConPassShow";
            pbConPassShow.Size = new Size(25, 25);
            pbConPassShow.SizeMode = PictureBoxSizeMode.Zoom;
            pbConPassShow.TabIndex = 33;
            pbConPassShow.TabStop = false;
            pbConPassShow.Click += pbConPassShow_Click;
            // 
            // Student_Change_Password
            // 
            AcceptButton = btnSave;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(pbConPassShow);
            Controls.Add(pbConPassHide);
            Controls.Add(pbNewPassShow);
            Controls.Add(pbNewPassHide);
            Controls.Add(pbCurPassShow);
            Controls.Add(pbCurPassHide);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtCurrentPass);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblNewPass);
            Controls.Add(lblCurrentPass);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Change_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += Student_Change_Password_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCurPassHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCurPassShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPassHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPassShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConPassHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConPassShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private TextBox txtCurrentPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblCurrentPass;
        private Panel panelTutor;
        private PictureBox pbPassword;
        private Button btnBack;
        private Label lblTitle;
        private PictureBox pbCurPassHide;
        private PictureBox pbCurPassShow;
        private PictureBox pbNewPassHide;
        private PictureBox pbNewPassShow;
        private PictureBox pbConPassHide;
        private PictureBox pbConPassShow;
    }
}