namespace Group2_Assignment
{
    partial class frmAdminRegisterNewUser1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminRegisterNewUser1));
            this.lblRegistration = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmedPassword = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmedPassword = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion1 = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.Location = new System.Drawing.Point(372, 47);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(331, 59);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "REGISTRATION";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(259, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(85, 85);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlRegistration.Controls.Add(this.btnBack);
            this.pnlRegistration.Controls.Add(this.picLogo);
            this.pnlRegistration.Controls.Add(this.lblRegistration);
            this.pnlRegistration.Location = new System.Drawing.Point(-1, -7);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(993, 147);
            this.pnlRegistration.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(183, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(257, 28);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name                               :";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactNo.Location = new System.Drawing.Point(183, 235);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(257, 28);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Contact Number               :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(183, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(257, 28);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email                                :";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecurityQuestion.Location = new System.Drawing.Point(183, 517);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(258, 28);
            this.lblSecurityQuestion.TabIndex = 7;
            this.lblSecurityQuestion.Text = "Security Question 1           :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(182, 379);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(258, 28);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password                          :";
            // 
            // lblConfirmedPassword
            // 
            this.lblConfirmedPassword.AutoSize = true;
            this.lblConfirmedPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmedPassword.Location = new System.Drawing.Point(182, 447);
            this.lblConfirmedPassword.Name = "lblConfirmedPassword";
            this.lblConfirmedPassword.Size = new System.Drawing.Size(258, 28);
            this.lblConfirmedPassword.TabIndex = 9;
            this.lblConfirmedPassword.Text = "Confirmed Password         :";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(446, 235);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PlaceholderText = "Contact Number";
            this.txtContactNo.Size = new System.Drawing.Size(320, 31);
            this.txtContactNo.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(446, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.Size = new System.Drawing.Size(320, 31);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(446, 379);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(320, 31);
            this.txtPassword.TabIndex = 14;
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmedPassword.Location = new System.Drawing.Point(446, 447);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.PlaceholderText = "Confirmed Password";
            this.txtConfirmedPassword.Size = new System.Drawing.Size(320, 31);
            this.txtConfirmedPassword.TabIndex = 15;
            // 
            // txtSecurityQuestion1
            // 
            this.txtSecurityQuestion1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecurityQuestion1.Location = new System.Drawing.Point(446, 517);
            this.txtSecurityQuestion1.Name = "txtSecurityQuestion1";
            this.txtSecurityQuestion1.PlaceholderText = "What was your childhood nickname?";
            this.txtSecurityQuestion1.Size = new System.Drawing.Size(320, 31);
            this.txtSecurityQuestion1.TabIndex = 16;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(850, 565);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 49);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(850, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 49);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(609, 167);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(157, 31);
            this.txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(446, 167);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(157, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtSecurityQuestion2
            // 
            this.txtSecurityQuestion2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecurityQuestion2.Location = new System.Drawing.Point(446, 584);
            this.txtSecurityQuestion2.Name = "txtSecurityQuestion2";
            this.txtSecurityQuestion2.PlaceholderText = "What is the name of your best friend?";
            this.txtSecurityQuestion2.Size = new System.Drawing.Size(320, 31);
            this.txtSecurityQuestion2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Security Question 2          :";
            // 
            // frmAdminRegisterNewUser1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtSecurityQuestion2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtSecurityQuestion1);
            this.Controls.Add(this.txtConfirmedPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblConfirmedPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminRegisterNewUser1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.frmRegisterNewUser1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmedPassword;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmedPassword;
        private System.Windows.Forms.TextBox txtSecurityQuestion1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSecurityQuestion2;
        private System.Windows.Forms.Label label1;
    }
}