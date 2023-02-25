namespace Group2_Assignment
{
    partial class frm_Receptionist_Security_Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Receptionist_Security_Questions));
            this.txtSecQues = new System.Windows.Forms.TextBox();
            this.txtFQues = new System.Windows.Forms.TextBox();
            this.lblFQues = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSecAns = new System.Windows.Forms.TextBox();
            this.txtFAns = new System.Windows.Forms.TextBox();
            this.lblSecAns = new System.Windows.Forms.Label();
            this.lblSecQues = new System.Windows.Forms.Label();
            this.lblFAns = new System.Windows.Forms.Label();
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSecQues
            // 
            this.txtSecQues.Location = new System.Drawing.Point(418, 388);
            this.txtSecQues.Name = "txtSecQues";
            this.txtSecQues.ReadOnly = true;
            this.txtSecQues.Size = new System.Drawing.Size(275, 27);
            this.txtSecQues.TabIndex = 40;
            this.txtSecQues.Text = "What is the name of your best friend?\r\n";
            // 
            // txtFQues
            // 
            this.txtFQues.Location = new System.Drawing.Point(418, 216);
            this.txtFQues.Name = "txtFQues";
            this.txtFQues.ReadOnly = true;
            this.txtFQues.Size = new System.Drawing.Size(275, 27);
            this.txtFQues.TabIndex = 39;
            this.txtFQues.Text = "What was your childhood nickname?";
            // 
            // lblFQues
            // 
            this.lblFQues.AutoSize = true;
            this.lblFQues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFQues.Location = new System.Drawing.Point(212, 216);
            this.lblFQues.Name = "lblFQues";
            this.lblFQues.Size = new System.Drawing.Size(204, 28);
            this.lblFQues.TabIndex = 38;
            this.lblFQues.Text = "First Question         : ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnSave.Location = new System.Drawing.Point(387, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 62);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSecAns
            // 
            this.txtSecAns.Location = new System.Drawing.Point(418, 477);
            this.txtSecAns.Name = "txtSecAns";
            this.txtSecAns.Size = new System.Drawing.Size(275, 27);
            this.txtSecAns.TabIndex = 36;
            // 
            // txtFAns
            // 
            this.txtFAns.Location = new System.Drawing.Point(418, 299);
            this.txtFAns.Name = "txtFAns";
            this.txtFAns.Size = new System.Drawing.Size(275, 27);
            this.txtFAns.TabIndex = 35;
            // 
            // lblSecAns
            // 
            this.lblSecAns.AutoSize = true;
            this.lblSecAns.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecAns.Location = new System.Drawing.Point(211, 480);
            this.lblSecAns.Name = "lblSecAns";
            this.lblSecAns.Size = new System.Drawing.Size(199, 28);
            this.lblSecAns.TabIndex = 34;
            this.lblSecAns.Text = "Second Answer       :";
            // 
            // lblSecQues
            // 
            this.lblSecQues.AutoSize = true;
            this.lblSecQues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecQues.Location = new System.Drawing.Point(212, 388);
            this.lblSecQues.Name = "lblSecQues";
            this.lblSecQues.Size = new System.Drawing.Size(197, 28);
            this.lblSecQues.TabIndex = 33;
            this.lblSecQues.Text = "Second Question    :";
            // 
            // lblFAns
            // 
            this.lblFAns.AutoSize = true;
            this.lblFAns.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFAns.Location = new System.Drawing.Point(210, 302);
            this.lblFAns.Name = "lblFAns";
            this.lblFAns.Size = new System.Drawing.Size(206, 28);
            this.lblFAns.TabIndex = 32;
            this.lblFAns.Text = "First Answer            : ";
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
            this.panelTutor.TabIndex = 31;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(179, 44);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(64, 57);
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(249, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(637, 57);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "UPDATE SECURITY QUESTIONS";
            // 
            // frm_Receptionist_Security_Questions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtSecQues);
            this.Controls.Add(this.txtFQues);
            this.Controls.Add(this.lblFQues);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSecAns);
            this.Controls.Add(this.txtFAns);
            this.Controls.Add(this.lblSecAns);
            this.Controls.Add(this.lblSecQues);
            this.Controls.Add(this.lblFAns);
            this.Controls.Add(this.panelTutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Receptionist_Security_Questions";
            this.Text = "Receptionist Security Questions";
            this.Load += new System.EventHandler(this.frm_Receptionist_Security_Questions_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSecQues;
        private TextBox txtFQues;
        private Label lblFQues;
        private Button btnSave;
        private TextBox txtSecAns;
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