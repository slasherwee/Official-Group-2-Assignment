namespace Group2_Assignment
{
    partial class Tutor_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor_Change_Password));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbConPassShow = new System.Windows.Forms.PictureBox();
            this.pbConPassHide = new System.Windows.Forms.PictureBox();
            this.pbNewPassShow = new System.Windows.Forms.PictureBox();
            this.pbNewPassHide = new System.Windows.Forms.PictureBox();
            this.pbCurPassShow = new System.Windows.Forms.PictureBox();
            this.pbCurPassHide = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.pbPassword);
            this.panelTutor.Controls.Add(this.btnBack);
            this.panelTutor.Controls.Add(this.lblTitle);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 117);
            this.panelTutor.TabIndex = 3;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(249, 38);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(75, 52);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 8;
            this.pbPassword.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(337, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 50);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CHANGE PASSWORD";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(398, 367);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(265, 34);
            this.txtConfirmPass.TabIndex = 18;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(398, 222);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(265, 34);
            this.txtCurrentPass.TabIndex = 16;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPass.Location = new System.Drawing.Point(203, 367);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(187, 28);
            this.lblConfirmPass.TabIndex = 15;
            this.lblConfirmPass.Text = "Confirm Password :";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPass.Location = new System.Drawing.Point(234, 294);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(155, 28);
            this.lblNewPass.TabIndex = 14;
            this.lblNewPass.Text = "New Password :";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPass.Location = new System.Drawing.Point(209, 221);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(188, 28);
            this.lblCurrentPass.TabIndex = 13;
            this.lblCurrentPass.Text = "Current Password : ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnSave.Location = new System.Drawing.Point(398, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 61);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbConPassShow
            // 
            this.pbConPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbConPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbConPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassShow.Location = new System.Drawing.Point(695, 370);
            this.pbConPassShow.Name = "pbConPassShow";
            this.pbConPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbConPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConPassShow.TabIndex = 39;
            this.pbConPassShow.TabStop = false;
            this.pbConPassShow.Click += new System.EventHandler(this.pbConPassShow_Click);
            // 
            // pbConPassHide
            // 
            this.pbConPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbConPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbConPassHide.Location = new System.Drawing.Point(695, 370);
            this.pbConPassHide.Name = "pbConPassHide";
            this.pbConPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbConPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConPassHide.TabIndex = 38;
            this.pbConPassHide.TabStop = false;
            this.pbConPassHide.Click += new System.EventHandler(this.pbConPassHide_Click);
            // 
            // pbNewPassShow
            // 
            this.pbNewPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbNewPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbNewPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassShow.Location = new System.Drawing.Point(695, 297);
            this.pbNewPassShow.Name = "pbNewPassShow";
            this.pbNewPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbNewPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewPassShow.TabIndex = 37;
            this.pbNewPassShow.TabStop = false;
            this.pbNewPassShow.Click += new System.EventHandler(this.pbNewPassShow_Click);
            // 
            // pbNewPassHide
            // 
            this.pbNewPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbNewPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbNewPassHide.Location = new System.Drawing.Point(695, 297);
            this.pbNewPassHide.Name = "pbNewPassHide";
            this.pbNewPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbNewPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewPassHide.TabIndex = 36;
            this.pbNewPassHide.TabStop = false;
            this.pbNewPassHide.Click += new System.EventHandler(this.pbNewPassHide_Click);
            // 
            // pbCurPassShow
            // 
            this.pbCurPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbCurPassShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.pbCurPassShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassShow.Location = new System.Drawing.Point(695, 224);
            this.pbCurPassShow.Name = "pbCurPassShow";
            this.pbCurPassShow.Size = new System.Drawing.Size(25, 25);
            this.pbCurPassShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurPassShow.TabIndex = 35;
            this.pbCurPassShow.TabStop = false;
            this.pbCurPassShow.Click += new System.EventHandler(this.pbCurPassShow_Click_1);
            // 
            // pbCurPassHide
            // 
            this.pbCurPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.pbCurPassHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.Image = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.pbCurPassHide.Location = new System.Drawing.Point(695, 224);
            this.pbCurPassHide.Name = "pbCurPassHide";
            this.pbCurPassHide.Size = new System.Drawing.Size(25, 25);
            this.pbCurPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurPassHide.TabIndex = 34;
            this.pbCurPassHide.TabStop = false;
            this.pbCurPassHide.Click += new System.EventHandler(this.pbCurPassHide_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(398, 297);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(265, 34);
            this.txtNewPass.TabIndex = 40;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // Tutor_Change_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.panelTutor);
            this.Controls.Add(this.pbCurPassShow);
            this.Controls.Add(this.pbNewPassShow);
            this.Controls.Add(this.pbConPassShow);
            this.Controls.Add(this.pbCurPassHide);
            this.Controls.Add(this.pbNewPassHide);
            this.Controls.Add(this.pbConPassHide);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutor_Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor Change Password";
            this.Load += new System.EventHandler(this.Tutor_Change_Password_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPassHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private PictureBox pbPassword;
        private Button btnBack;
        private Label lblTitle;
        private TextBox txtConfirmPass;
        private TextBox txtCurrentPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblCurrentPass;
        private Button btnSave;
        private PictureBox pbConPassShow;
        private PictureBox pbConPassHide;
        private PictureBox pbNewPassShow;
        private PictureBox pbNewPassHide;
        private PictureBox pbCurPassShow;
        private PictureBox pbCurPassHide;
        private TextBox txtNewPass;
    }
}