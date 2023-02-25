namespace Group2_Assignment
{
    partial class Forgot_Password_Page1_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password_Page1_));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFQues = new System.Windows.Forms.TextBox();
            this.lblFQues = new System.Windows.Forms.Label();
            this.txtSecAns = new System.Windows.Forms.TextBox();
            this.txtSecQues = new System.Windows.Forms.TextBox();
            this.txtFAns = new System.Windows.Forms.TextBox();
            this.lblSecAns = new System.Windows.Forms.Label();
            this.lblSecQues = new System.Windows.Forms.Label();
            this.lblFAns = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
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
            this.panelTutor.TabIndex = 4;
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
            this.lblTitle.Size = new System.Drawing.Size(444, 59);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "FORGOT PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fill in the correct details to verify your information before reset password";
            // 
            // txtFQues
            // 
            this.txtFQues.Location = new System.Drawing.Point(350, 291);
            this.txtFQues.Name = "txtFQues";
            this.txtFQues.ReadOnly = true;
            this.txtFQues.Size = new System.Drawing.Size(331, 34);
            this.txtFQues.TabIndex = 36;
            this.txtFQues.Text = "What was your childhood nickname?";
            // 
            // lblFQues
            // 
            this.lblFQues.AutoSize = true;
            this.lblFQues.Location = new System.Drawing.Point(191, 291);
            this.lblFQues.Name = "lblFQues";
            this.lblFQues.Size = new System.Drawing.Size(147, 28);
            this.lblFQues.TabIndex = 35;
            this.lblFQues.Text = "First Question : ";
            // 
            // txtSecAns
            // 
            this.txtSecAns.Location = new System.Drawing.Point(350, 499);
            this.txtSecAns.Name = "txtSecAns";
            this.txtSecAns.Size = new System.Drawing.Size(331, 34);
            this.txtSecAns.TabIndex = 34;
            // 
            // txtSecQues
            // 
            this.txtSecQues.Location = new System.Drawing.Point(350, 426);
            this.txtSecQues.Name = "txtSecQues";
            this.txtSecQues.ReadOnly = true;
            this.txtSecQues.Size = new System.Drawing.Size(331, 34);
            this.txtSecQues.TabIndex = 33;
            this.txtSecQues.Text = "What is the name of your best friend?\r\n";
            // 
            // txtFAns
            // 
            this.txtFAns.Location = new System.Drawing.Point(350, 354);
            this.txtFAns.Name = "txtFAns";
            this.txtFAns.Size = new System.Drawing.Size(331, 34);
            this.txtFAns.TabIndex = 32;
            // 
            // lblSecAns
            // 
            this.lblSecAns.AutoSize = true;
            this.lblSecAns.Location = new System.Drawing.Point(177, 499);
            this.lblSecAns.Name = "lblSecAns";
            this.lblSecAns.Size = new System.Drawing.Size(154, 28);
            this.lblSecAns.TabIndex = 31;
            this.lblSecAns.Text = "Second Answer :";
            // 
            // lblSecQues
            // 
            this.lblSecQues.AutoSize = true;
            this.lblSecQues.Location = new System.Drawing.Point(161, 426);
            this.lblSecQues.Name = "lblSecQues";
            this.lblSecQues.Size = new System.Drawing.Size(170, 28);
            this.lblSecQues.TabIndex = 30;
            this.lblSecQues.Text = "Second Question :";
            // 
            // lblFAns
            // 
            this.lblFAns.AutoSize = true;
            this.lblFAns.Location = new System.Drawing.Point(206, 357);
            this.lblFAns.Name = "lblFAns";
            this.lblFAns.Size = new System.Drawing.Size(131, 28);
            this.lblFAns.TabIndex = 29;
            this.lblFAns.Text = "First Answer : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(247, 235);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(84, 28);
            this.lblUserID.TabIndex = 37;
            this.lblUserID.Text = "User ID :";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(350, 235);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(331, 34);
            this.txtUserID.TabIndex = 38;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(732, 558);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(215, 68);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Forgot_Password_Page1_
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtFQues);
            this.Controls.Add(this.lblFQues);
            this.Controls.Add(this.txtSecAns);
            this.Controls.Add(this.txtSecQues);
            this.Controls.Add(this.txtFAns);
            this.Controls.Add(this.lblSecAns);
            this.Controls.Add(this.lblSecQues);
            this.Controls.Add(this.lblFAns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forgot_Password_Page1_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_Password_Page1_";
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private PictureBox pbPassword;
        private Button btnBack;
        private Label lblTitle;
        private Label label1;
        private TextBox txtFQues;
        private Label lblFQues;
        private TextBox txtSecAns;
        private TextBox txtSecQues;
        private TextBox txtFAns;
        private Label lblSecAns;
        private Label lblSecQues;
        private Label lblFAns;
        private Label lblUserID;
        private TextBox txtUserID;
        private Button btnNext;
    }
}