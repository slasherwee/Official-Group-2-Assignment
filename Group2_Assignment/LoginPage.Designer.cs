using System.Windows.Forms;

namespace Group2_Assignment
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pbUsername = new PictureBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            txtPassword = new TextBox();
            picUsername = new PictureBox();
            pictureBox1 = new PictureBox();
            picShow = new PictureBox();
            picHide = new PictureBox();
            lblForgetPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            SuspendLayout();
            // 
            // pbUsername
            // 
            pbUsername.BackColor = Color.Transparent;
            pbUsername.BackgroundImageLayout = ImageLayout.Stretch;
            pbUsername.Image = (Image)resources.GetObject("pbUsername.Image");
            pbUsername.Location = new Point(397, 122);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(185, 176);
            pbUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsername.TabIndex = 11;
            pbUsername.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(330, 363);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "type username...";
            txtUsername.Size = new Size(342, 34);
            txtUsername.TabIndex = 10;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(24, 58, 29);
            btnLogin.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(367, 552);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(215, 68);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 31.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(246, 196, 83);
            lblTitle.Location = new Point(107, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(766, 71);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Excellent Tuition Centre (ETC)";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(330, 444);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "type password...";
            txtPassword.Size = new Size(342, 34);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(275, 356);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(39, 41);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 13;
            picUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 440);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // picShow
            // 
            picShow.BackColor = Color.White;
            picShow.Image = (Image)resources.GetObject("picShow.Image");
            picShow.Location = new Point(640, 447);
            picShow.Name = "picShow";
            picShow.Size = new Size(27, 27);
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            picShow.TabIndex = 15;
            picShow.TabStop = false;
            picShow.Click += picShow_Click;
            // 
            // picHide
            // 
            picHide.BackColor = Color.White;
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(640, 447);
            picHide.Name = "picHide";
            picHide.Size = new Size(27, 27);
            picHide.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide.TabIndex = 16;
            picHide.TabStop = false;
            picHide.Click += picHide_Click;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblForgetPassword.Location = new Point(556, 483);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(116, 20);
            lblForgetPassword.TabIndex = 17;
            lblForgetPassword.Text = "forget password?";
            lblForgetPassword.Click += lblForgetPassword_Click;
            // 
            // LoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            ClientSize = new Size(982, 653);
            Controls.Add(lblForgetPassword);
            Controls.Add(picHide);
            Controls.Add(picShow);
            Controls.Add(pictureBox1);
            Controls.Add(picUsername);
            Controls.Add(txtPassword);
            Controls.Add(pbUsername);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblTitle;
        private TextBox txtPassword;
        private PictureBox picUsername;
        private PictureBox pictureBox1;
        private PictureBox picShow;
        private PictureBox picHide;
        private Label lblForgetPassword;
    }
}