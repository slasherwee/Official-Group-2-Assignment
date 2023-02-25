using System.Windows.Forms;

namespace Group2_Assignment
{
    partial class frmAdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminChangePassword));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picCurShow = new System.Windows.Forms.PictureBox();
            this.picNewShow = new System.Windows.Forms.PictureBox();
            this.picConShow = new System.Windows.Forms.PictureBox();
            this.picCurHide = new System.Windows.Forms.PictureBox();
            this.picNewHide = new System.Windows.Forms.PictureBox();
            this.picConHide = new System.Windows.Forms.PictureBox();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConHide)).BeginInit();
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
            this.panelTutor.Size = new System.Drawing.Size(982, 147);
            this.panelTutor.TabIndex = 3;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(191, 48);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(75, 63);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(287, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 59);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CHANGE PASSWORD";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(466, 431);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.Size = new System.Drawing.Size(265, 34);
            this.txtConfirmPass.TabIndex = 18;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(466, 327);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(265, 34);
            this.txtNewPass.TabIndex = 17;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(466, 218);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '●';
            this.txtCurrentPass.Size = new System.Drawing.Size(265, 34);
            this.txtCurrentPass.TabIndex = 16;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPass.Location = new System.Drawing.Point(209, 431);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(235, 28);
            this.lblConfirmPass.TabIndex = 15;
            this.lblConfirmPass.Text = "Confirm Password         :";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPass.Location = new System.Drawing.Point(209, 330);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(233, 28);
            this.lblNewPass.TabIndex = 14;
            this.lblNewPass.Text = "New Password              :";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPass.Location = new System.Drawing.Point(209, 221);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(242, 28);
            this.lblCurrentPass.TabIndex = 13;
            this.lblCurrentPass.Text = "Current Password          : ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnSave.Location = new System.Drawing.Point(336, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 62);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picCurShow
            // 
            this.picCurShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picCurShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picCurShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.picCurShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picCurShow.Location = new System.Drawing.Point(749, 222);
            this.picCurShow.Name = "picCurShow";
            this.picCurShow.Size = new System.Drawing.Size(25, 25);
            this.picCurShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurShow.TabIndex = 30;
            this.picCurShow.TabStop = false;
            this.picCurShow.Click += new System.EventHandler(this.pbCurPassShow_Click);
            // 
            // picNewShow
            // 
            this.picNewShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picNewShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picNewShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.picNewShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picNewShow.Location = new System.Drawing.Point(749, 332);
            this.picNewShow.Name = "picNewShow";
            this.picNewShow.Size = new System.Drawing.Size(25, 25);
            this.picNewShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewShow.TabIndex = 31;
            this.picNewShow.TabStop = false;
            this.picNewShow.Click += new System.EventHandler(this.picNewShow_Click);
            // 
            // picConShow
            // 
            this.picConShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picConShow.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picConShow.Image = global::Group2_Assignment.Properties.Resources.show;
            this.picConShow.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picConShow.Location = new System.Drawing.Point(749, 435);
            this.picConShow.Name = "picConShow";
            this.picConShow.Size = new System.Drawing.Size(25, 25);
            this.picConShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConShow.TabIndex = 32;
            this.picConShow.TabStop = false;
            this.picConShow.Click += new System.EventHandler(this.picConShow_Click);
            // 
            // picCurHide
            // 
            this.picCurHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picCurHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picCurHide.Image = ((System.Drawing.Image)(resources.GetObject("picCurHide.Image")));
            this.picCurHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picCurHide.Location = new System.Drawing.Point(749, 222);
            this.picCurHide.Name = "picCurHide";
            this.picCurHide.Size = new System.Drawing.Size(25, 25);
            this.picCurHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurHide.TabIndex = 33;
            this.picCurHide.TabStop = false;
            this.picCurHide.Click += new System.EventHandler(this.picCurHide_Click);
            // 
            // picNewHide
            // 
            this.picNewHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picNewHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picNewHide.Image = ((System.Drawing.Image)(resources.GetObject("picNewHide.Image")));
            this.picNewHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picNewHide.Location = new System.Drawing.Point(749, 332);
            this.picNewHide.Name = "picNewHide";
            this.picNewHide.Size = new System.Drawing.Size(25, 25);
            this.picNewHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewHide.TabIndex = 34;
            this.picNewHide.TabStop = false;
            this.picNewHide.Click += new System.EventHandler(this.picNewHide_Click);
            // 
            // picConHide
            // 
            this.picConHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.picConHide.BackgroundImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picConHide.Image = ((System.Drawing.Image)(resources.GetObject("picConHide.Image")));
            this.picConHide.InitialImage = global::Group2_Assignment.Properties.Resources.hide;
            this.picConHide.Location = new System.Drawing.Point(749, 435);
            this.picConHide.Name = "picConHide";
            this.picConHide.Size = new System.Drawing.Size(25, 25);
            this.picConHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConHide.TabIndex = 35;
            this.picConHide.TabStop = false;
            this.picConHide.Click += new System.EventHandler(this.picConHide_Click);
            // 
            // frmAdminChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.picConHide);
            this.Controls.Add(this.picNewHide);
            this.Controls.Add(this.picCurHide);
            this.Controls.Add(this.picConShow);
            this.Controls.Add(this.picNewShow);
            this.Controls.Add(this.picCurShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmAdminChangePassword_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private PictureBox pbPassword;
        private Button btnBack;
        private Label lblTitle;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private TextBox txtCurrentPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblCurrentPass;
        private Button btnSave;
        private PictureBox picCurShow;
        private PictureBox picNewShow;
        private PictureBox picConShow;
        private PictureBox picCurHide;
        private PictureBox picNewHide;
        private PictureBox picConHide;
    }
}