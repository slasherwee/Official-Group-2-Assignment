namespace Group2_Assignment
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.pbCurPassShow = new System.Windows.Forms.PictureBox();
            this.pbNewPassShow = new System.Windows.Forms.PictureBox();
            this.pbConPassShow = new System.Windows.Forms.PictureBox();
            this.pbCurPassHide = new System.Windows.Forms.PictureBox();
            this.pbNewPassHide = new System.Windows.Forms.PictureBox();
            this.pbConPassHide = new System.Windows.Forms.PictureBox();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.pbPassword);
            this.panelTutor.Controls.Add(this.lblTitle);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 147);
            this.panelTutor.TabIndex = 5;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(236, 44);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(75, 63);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 8;
            this.pbPassword.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(332, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 59);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "RESET PASSWORD";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(380, 300);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(265, 34);
            this.txtNewPass.TabIndex = 53;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnProceed.Location = new System.Drawing.Point(380, 468);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(223, 61);
            this.btnProceed.TabIndex = 46;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(380, 370);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(265, 34);
            this.txtConfirmPass.TabIndex = 45;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(380, 225);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(265, 34);
            this.txtCurrentPass.TabIndex = 44;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(185, 370);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(187, 28);
            this.lblConfirmPass.TabIndex = 43;
            this.lblConfirmPass.Text = "Confirm Password :";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(216, 297);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(155, 28);
            this.lblNewPass.TabIndex = 42;
            this.lblNewPass.Text = "New Password :";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Location = new System.Drawing.Point(191, 224);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(188, 28);
            this.lblCurrentPass.TabIndex = 41;
            this.lblCurrentPass.Text = "Current Password : ";
            // 
            // pbCurPassShow
            // 
            this.pbCurPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbCurPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbCurPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassShow.Location = new System.Drawing.Point(677, 227);
            this.pbCurPassShow.Name = "pbCurPassShow";
            this.pbCurPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbCurPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurPassShow.TabIndex = 48;
            this.pbCurPassShow.TabStop = false;
            this.pbCurPassShow.Click += new System.EventHandler(this.pbCurPassShow_Click);
            // 
            // pbNewPassShow
            // 
            this.pbNewPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbNewPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbNewPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassShow.Location = new System.Drawing.Point(677, 300);
            this.pbNewPassShow.Name = "pbNewPassShow";
            this.pbNewPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbNewPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewPassShow.TabIndex = 50;
            this.pbNewPassShow.TabStop = false;
            this.pbNewPassShow.Click += new System.EventHandler(this.pbNewPassShow_Click);
            // 
            // pbConPassShow
            // 
            this.pbConPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbConPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbConPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassShow.Location = new System.Drawing.Point(677, 373);
            this.pbConPassShow.Name = "pbConPassShow";
            this.pbConPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbConPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConPassShow.TabIndex = 52;
            this.pbConPassShow.TabStop = false;
            this.pbConPassShow.Click += new System.EventHandler(this.pbConPassShow_Click);
            // 
            // pbCurPassHide
            // 
            this.pbCurPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbCurPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.Location = new System.Drawing.Point(677, 227);
            this.pbCurPassHide.Name = "pbCurPassHide";
            this.pbCurPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbCurPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurPassHide.TabIndex = 47;
            this.pbCurPassHide.TabStop = false;
            this.pbCurPassHide.Click += new System.EventHandler(this.pbCurPassHide_Click);
            // 
            // pbNewPassHide
            // 
            this.pbNewPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbNewPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.Location = new System.Drawing.Point(677, 300);
            this.pbNewPassHide.Name = "pbNewPassHide";
            this.pbNewPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbNewPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewPassHide.TabIndex = 49;
            this.pbNewPassHide.TabStop = false;
            this.pbNewPassHide.Click += new System.EventHandler(this.pbNewPassHide_Click);
            // 
            // pbConPassHide
            // 
            this.pbConPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbConPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.Location = new System.Drawing.Point(677, 373);
            this.pbConPassHide.Name = "pbConPassHide";
            this.pbConPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbConPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConPassHide.TabIndex = 51;
            this.pbConPassHide.TabStop = false;
            this.pbConPassHide.Click += new System.EventHandler(this.pbConPassHide_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.panelTutor);
            this.Controls.Add(this.pbCurPassShow);
            this.Controls.Add(this.pbCurPassHide);
            this.Controls.Add(this.pbNewPassShow);
            this.Controls.Add(this.pbNewPassHide);
            this.Controls.Add(this.pbConPassShow);
            this.Controls.Add(this.pbConPassHide);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private PictureBox pbPassword;
        private Label lblTitle;
        private TextBox txtNewPass;
        private Button btnProceed;
        private TextBox txtConfirmPass;
        private TextBox txtCurrentPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblCurrentPass;
        private PictureBox pbCurPassShow;
        private PictureBox pbNewPassShow;
        private PictureBox pbConPassShow;
        private PictureBox pbCurPassHide;
        private PictureBox pbNewPassHide;
        private PictureBox pbConPassHide;
    }
}