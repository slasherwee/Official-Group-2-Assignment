namespace Group2_Assignment
{
    partial class Student_Security_Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Security_Questions));
            txtFQues = new TextBox();
            lblFQues = new Label();
            btnSave = new Button();
            txtSecAns = new TextBox();
            txtSecQues = new TextBox();
            txtFAns = new TextBox();
            lblSecAns = new Label();
            lblSecQues = new Label();
            lblFAns = new Label();
            panelTutor = new Panel();
            pbPassword = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // txtFQues
            // 
            txtFQues.Location = new Point(407, 195);
            txtFQues.Name = "txtFQues";
            txtFQues.ReadOnly = true;
            txtFQues.Size = new Size(331, 34);
            txtFQues.TabIndex = 38;
            txtFQues.Text = "What was your childhood nickname?";
            // 
            // lblFQues
            // 
            lblFQues.AutoSize = true;
            lblFQues.Location = new Point(248, 195);
            lblFQues.Name = "lblFQues";
            lblFQues.Size = new Size(147, 28);
            lblFQues.TabIndex = 37;
            lblFQues.Text = "First Question : ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 58, 29);
            btnSave.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(254, 251, 233);
            btnSave.Location = new Point(393, 501);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 67);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSecAns
            // 
            txtSecAns.Location = new Point(407, 403);
            txtSecAns.Name = "txtSecAns";
            txtSecAns.Size = new Size(331, 34);
            txtSecAns.TabIndex = 35;
            // 
            // txtSecQues
            // 
            txtSecQues.Location = new Point(407, 330);
            txtSecQues.Name = "txtSecQues";
            txtSecQues.ReadOnly = true;
            txtSecQues.Size = new Size(331, 34);
            txtSecQues.TabIndex = 34;
            txtSecQues.Text = "What is the name of your best friend?\r\n";
            // 
            // txtFAns
            // 
            txtFAns.Location = new Point(407, 258);
            txtFAns.Name = "txtFAns";
            txtFAns.Size = new Size(331, 34);
            txtFAns.TabIndex = 33;
            // 
            // lblSecAns
            // 
            lblSecAns.AutoSize = true;
            lblSecAns.Location = new Point(234, 403);
            lblSecAns.Name = "lblSecAns";
            lblSecAns.Size = new Size(154, 28);
            lblSecAns.TabIndex = 32;
            lblSecAns.Text = "Second Answer :";
            // 
            // lblSecQues
            // 
            lblSecQues.AutoSize = true;
            lblSecQues.Location = new Point(218, 330);
            lblSecQues.Name = "lblSecQues";
            lblSecQues.Size = new Size(170, 28);
            lblSecQues.TabIndex = 31;
            lblSecQues.Text = "Second Question :";
            // 
            // lblFAns
            // 
            lblFAns.AutoSize = true;
            lblFAns.Location = new Point(263, 261);
            lblFAns.Name = "lblFAns";
            lblFAns.Size = new Size(131, 28);
            lblFAns.TabIndex = 30;
            lblFAns.Text = "First Answer : ";
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
            panelTutor.TabIndex = 29;
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
            lblTitle.Size = new Size(503, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "UPDATE SECURITY QUESTIONS";
            // 
            // Student_Security_Questions
            // 
            AcceptButton = btnSave;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(txtFQues);
            Controls.Add(lblFQues);
            Controls.Add(btnSave);
            Controls.Add(txtSecAns);
            Controls.Add(txtSecQues);
            Controls.Add(txtFAns);
            Controls.Add(lblSecAns);
            Controls.Add(lblSecQues);
            Controls.Add(lblFAns);
            Controls.Add(panelTutor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Security_Questions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Security_Questions";
            Load += Student_Security_Questions_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFQues;
        private Label lblFQues;
        private Button btnSave;
        private TextBox txtSecAns;
        private TextBox txtSecQues;
        private TextBox txtFAns;
        private Label lblSecAns;
        private Label lblSecQues;
        private Label lblFAns;
        private Panel panelTutor;
        private PictureBox pbPassword;
        private Button btnBack;
        private Label lblTitle;
    }
}