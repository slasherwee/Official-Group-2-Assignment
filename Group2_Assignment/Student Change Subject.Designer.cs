namespace Group2_Assignment
{
    partial class Student_Change_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Change_Subject));
            panelTutor = new Panel();
            pbChangeSub = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            pbRequestChangeSub = new PictureBox();
            btnRequestChangeSub = new Button();
            pbViewChangeSubStat = new PictureBox();
            btnViewChangeSubStat = new Button();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbChangeSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRequestChangeSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbViewChangeSubStat).BeginInit();
            SuspendLayout();
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(pbChangeSub);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 44;
            // 
            // pbChangeSub
            // 
            pbChangeSub.BackColor = Color.FromArgb(225, 238, 221);
            pbChangeSub.Image = Properties.Resources.Subject;
            pbChangeSub.Location = new Point(284, 35);
            pbChangeSub.Name = "pbChangeSub";
            pbChangeSub.Size = new Size(60, 38);
            pbChangeSub.SizeMode = PictureBoxSizeMode.Zoom;
            pbChangeSub.TabIndex = 8;
            pbChangeSub.TabStop = false;
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
            lblTitle.Location = new Point(350, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "CHANGE SUBJECT";
            // 
            // pbRequestChangeSub
            // 
            pbRequestChangeSub.BackColor = Color.FromArgb(24, 58, 29);
            pbRequestChangeSub.Image = Properties.Resources.Change;
            pbRequestChangeSub.Location = new Point(213, 287);
            pbRequestChangeSub.Name = "pbRequestChangeSub";
            pbRequestChangeSub.Size = new Size(60, 38);
            pbRequestChangeSub.SizeMode = PictureBoxSizeMode.Zoom;
            pbRequestChangeSub.TabIndex = 48;
            pbRequestChangeSub.TabStop = false;
            // 
            // btnRequestChangeSub
            // 
            btnRequestChangeSub.BackColor = Color.FromArgb(24, 58, 29);
            btnRequestChangeSub.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRequestChangeSub.ForeColor = Color.FromArgb(254, 251, 233);
            btnRequestChangeSub.Location = new Point(198, 278);
            btnRequestChangeSub.Name = "btnRequestChangeSub";
            btnRequestChangeSub.Size = new Size(592, 59);
            btnRequestChangeSub.TabIndex = 47;
            btnRequestChangeSub.Text = "Request Change Subject";
            btnRequestChangeSub.UseVisualStyleBackColor = false;
            btnRequestChangeSub.Click += btnRequestChangeSub_Click;
            // 
            // pbViewChangeSubStat
            // 
            pbViewChangeSubStat.BackColor = Color.FromArgb(24, 58, 29);
            pbViewChangeSubStat.Image = Properties.Resources.Request;
            pbViewChangeSubStat.Location = new Point(213, 412);
            pbViewChangeSubStat.Name = "pbViewChangeSubStat";
            pbViewChangeSubStat.Size = new Size(60, 38);
            pbViewChangeSubStat.SizeMode = PictureBoxSizeMode.Zoom;
            pbViewChangeSubStat.TabIndex = 46;
            pbViewChangeSubStat.TabStop = false;
            // 
            // btnViewChangeSubStat
            // 
            btnViewChangeSubStat.BackColor = Color.FromArgb(24, 58, 29);
            btnViewChangeSubStat.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewChangeSubStat.ForeColor = Color.FromArgb(254, 251, 233);
            btnViewChangeSubStat.Location = new Point(198, 401);
            btnViewChangeSubStat.Name = "btnViewChangeSubStat";
            btnViewChangeSubStat.Size = new Size(592, 59);
            btnViewChangeSubStat.TabIndex = 45;
            btnViewChangeSubStat.Text = "View Change Subject Status";
            btnViewChangeSubStat.UseVisualStyleBackColor = false;
            btnViewChangeSubStat.Click += btnViewChangeSubStat_Click;
            // 
            // Student_Change_Subject
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(pbRequestChangeSub);
            Controls.Add(btnRequestChangeSub);
            Controls.Add(pbViewChangeSubStat);
            Controls.Add(btnViewChangeSubStat);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Change_Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Subject";
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbChangeSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRequestChangeSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbViewChangeSubStat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTutor;
        private PictureBox pbChangeSub;
        private Button btnBack;
        private Label lblTitle;
        private PictureBox pbRequestChangeSub;
        private Button btnRequestChangeSub;
        private PictureBox pbViewChangeSubStat;
        private Button btnViewChangeSubStat;
    }
}