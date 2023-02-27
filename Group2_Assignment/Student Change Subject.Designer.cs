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
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbChangeSub = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbRequestChangeSub = new System.Windows.Forms.PictureBox();
            this.btnRequestChangeSub = new System.Windows.Forms.Button();
            this.pbViewChangeSubStat = new System.Windows.Forms.PictureBox();
            this.btnViewChangeSubStat = new System.Windows.Forms.Button();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestChangeSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewChangeSubStat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.pbChangeSub);
            this.panelTutor.Controls.Add(this.btnBack);
            this.panelTutor.Controls.Add(this.lblTitle);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 102);
            this.panelTutor.TabIndex = 44;
            // 
            // pbChangeSub
            // 
            this.pbChangeSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbChangeSub.Image = global::Group2_Assignment.Properties.Resources.Subject;
            this.pbChangeSub.Location = new System.Drawing.Point(284, 35);
            this.pbChangeSub.Name = "pbChangeSub";
            this.pbChangeSub.Size = new System.Drawing.Size(60, 38);
            this.pbChangeSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeSub.TabIndex = 8;
            this.pbChangeSub.TabStop = false;
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
            this.lblTitle.Location = new System.Drawing.Point(350, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CHANGE SUBJECT";
            // 
            // pbRequestChangeSub
            // 
            this.pbRequestChangeSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.pbRequestChangeSub.Image = global::Group2_Assignment.Properties.Resources.Change;
            this.pbRequestChangeSub.Location = new System.Drawing.Point(213, 287);
            this.pbRequestChangeSub.Name = "pbRequestChangeSub";
            this.pbRequestChangeSub.Size = new System.Drawing.Size(60, 38);
            this.pbRequestChangeSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRequestChangeSub.TabIndex = 48;
            this.pbRequestChangeSub.TabStop = false;
            // 
            // btnRequestChangeSub
            // 
            this.btnRequestChangeSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnRequestChangeSub.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRequestChangeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnRequestChangeSub.Location = new System.Drawing.Point(198, 278);
            this.btnRequestChangeSub.Name = "btnRequestChangeSub";
            this.btnRequestChangeSub.Size = new System.Drawing.Size(592, 59);
            this.btnRequestChangeSub.TabIndex = 47;
            this.btnRequestChangeSub.Text = "Request Change Subject";
            this.btnRequestChangeSub.UseVisualStyleBackColor = false;
            this.btnRequestChangeSub.Click += new System.EventHandler(this.btnRequestChangeSub_Click);
            // 
            // pbViewChangeSubStat
            // 
            this.pbViewChangeSubStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.pbViewChangeSubStat.Image = global::Group2_Assignment.Properties.Resources.Request;
            this.pbViewChangeSubStat.Location = new System.Drawing.Point(213, 412);
            this.pbViewChangeSubStat.Name = "pbViewChangeSubStat";
            this.pbViewChangeSubStat.Size = new System.Drawing.Size(60, 38);
            this.pbViewChangeSubStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewChangeSubStat.TabIndex = 46;
            this.pbViewChangeSubStat.TabStop = false;
            // 
            // btnViewChangeSubStat
            // 
            this.btnViewChangeSubStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnViewChangeSubStat.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewChangeSubStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnViewChangeSubStat.Location = new System.Drawing.Point(198, 401);
            this.btnViewChangeSubStat.Name = "btnViewChangeSubStat";
            this.btnViewChangeSubStat.Size = new System.Drawing.Size(592, 59);
            this.btnViewChangeSubStat.TabIndex = 45;
            this.btnViewChangeSubStat.Text = "View Change Subject Status";
            this.btnViewChangeSubStat.UseVisualStyleBackColor = false;
            this.btnViewChangeSubStat.Click += new System.EventHandler(this.btnViewChangeSubStat_Click);
            // 
            // Student_Change_Subject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pbRequestChangeSub);
            this.Controls.Add(this.btnRequestChangeSub);
            this.Controls.Add(this.pbViewChangeSubStat);
            this.Controls.Add(this.btnViewChangeSubStat);
            this.Controls.Add(this.panelTutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Change_Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Subject";
            this.Load += new System.EventHandler(this.Student_Change_Subject_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestChangeSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewChangeSubStat)).EndInit();
            this.ResumeLayout(false);

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