namespace Group2_Assignment
{
    partial class frm_Receptionist_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Receptionist_Change_Password));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnSave.Location = new System.Drawing.Point(337, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 48);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(398, 427);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(265, 27);
            this.txtConfirmPass.TabIndex = 26;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(398, 354);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(265, 27);
            this.txtNewPass.TabIndex = 25;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(398, 282);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '●';
            this.txtCurrentPass.Size = new System.Drawing.Size(265, 27);
            this.txtCurrentPass.TabIndex = 24;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(203, 427);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(134, 20);
            this.lblConfirmPass.TabIndex = 23;
            this.lblConfirmPass.Text = "Confirm Password :";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(234, 354);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(111, 20);
            this.lblNewPass.TabIndex = 22;
            this.lblNewPass.Text = "New Password :";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Location = new System.Drawing.Point(209, 281);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(133, 20);
            this.lblCurrentPass.TabIndex = 21;
            this.lblCurrentPass.Text = "Current Password : ";
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
            this.panelTutor.Size = new System.Drawing.Size(982, 102);
            this.panelTutor.TabIndex = 20;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(249, 38);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(60, 38);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(337, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CHANGE PASSWORD";
            // 
            // frm_Receptionist_Change_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.panelTutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Receptionist_Change_Password";
            this.Text = "Receptionist Change Password";
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}