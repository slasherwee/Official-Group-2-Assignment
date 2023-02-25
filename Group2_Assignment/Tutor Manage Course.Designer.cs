namespace Group2_Assignment
{
    partial class Tutor_Manage_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor_Manage_Course));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pbSchedule = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSubCharges = new System.Windows.Forms.TextBox();
            this.txtSubHour = new System.Windows.Forms.TextBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.lblSubCharges = new System.Windows.Forms.Label();
            this.lblSubHour = new System.Windows.Forms.Label();
            this.lblSubName = new System.Windows.Forms.Label();
            this.lblSubID = new System.Windows.Forms.Label();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.pbSchedule);
            this.panelTutor.Controls.Add(this.btnBack);
            this.panelTutor.Controls.Add(this.lblTitle);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 102);
            this.panelTutor.TabIndex = 4;
            // 
            // pbSchedule
            // 
            this.pbSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pbSchedule.Image")));
            this.pbSchedule.Location = new System.Drawing.Point(249, 41);
            this.pbSchedule.Name = "pbSchedule";
            this.pbSchedule.Size = new System.Drawing.Size(60, 38);
            this.pbSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSchedule.TabIndex = 13;
            this.pbSchedule.TabStop = false;
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
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(337, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "MANAGE COURSE";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnDelete.Location = new System.Drawing.Point(762, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 48);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnUpdate.Location = new System.Drawing.Point(578, 574);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 48);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSubCharges
            // 
            this.txtSubCharges.Location = new System.Drawing.Point(578, 508);
            this.txtSubCharges.Name = "txtSubCharges";
            this.txtSubCharges.Size = new System.Drawing.Size(265, 34);
            this.txtSubCharges.TabIndex = 33;
            // 
            // txtSubHour
            // 
            this.txtSubHour.Location = new System.Drawing.Point(578, 401);
            this.txtSubHour.Name = "txtSubHour";
            this.txtSubHour.Size = new System.Drawing.Size(265, 34);
            this.txtSubHour.TabIndex = 32;
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(105, 508);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(265, 34);
            this.txtSubName.TabIndex = 31;
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(105, 401);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.Size = new System.Drawing.Size(265, 34);
            this.txtSubID.TabIndex = 30;
            // 
            // lblSubCharges
            // 
            this.lblSubCharges.AutoSize = true;
            this.lblSubCharges.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubCharges.Location = new System.Drawing.Point(578, 470);
            this.lblSubCharges.Name = "lblSubCharges";
            this.lblSubCharges.Size = new System.Drawing.Size(158, 28);
            this.lblSubCharges.TabIndex = 29;
            this.lblSubCharges.Text = "Subject Charges";
            // 
            // lblSubHour
            // 
            this.lblSubHour.AutoSize = true;
            this.lblSubHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubHour.Location = new System.Drawing.Point(578, 361);
            this.lblSubHour.Name = "lblSubHour";
            this.lblSubHour.Size = new System.Drawing.Size(131, 28);
            this.lblSubHour.TabIndex = 28;
            this.lblSubHour.Text = "Subject Hour";
            // 
            // lblSubName
            // 
            this.lblSubName.AutoSize = true;
            this.lblSubName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubName.Location = new System.Drawing.Point(105, 470);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(139, 28);
            this.lblSubName.TabIndex = 27;
            this.lblSubName.Text = "Subject Name";
            // 
            // lblSubID
            // 
            this.lblSubID.AutoSize = true;
            this.lblSubID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubID.Location = new System.Drawing.Point(105, 362);
            this.lblSubID.Name = "lblSubID";
            this.lblSubID.Size = new System.Drawing.Size(111, 28);
            this.lblSubID.TabIndex = 26;
            this.lblSubID.Text = "Subject ID ";
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCourse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCourse.Location = new System.Drawing.Point(0, 102);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersWidth = 51;
            this.dgvCourse.RowTemplate.Height = 29;
            this.dgvCourse.Size = new System.Drawing.Size(982, 188);
            this.dgvCourse.TabIndex = 36;
            this.dgvCourse.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourse_RowHeaderMouseClick_1);
            // 
            // Tutor_Manage_Course
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSubCharges);
            this.Controls.Add(this.txtSubHour);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtSubID);
            this.Controls.Add(this.lblSubCharges);
            this.Controls.Add(this.lblSubHour);
            this.Controls.Add(this.lblSubName);
            this.Controls.Add(this.lblSubID);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutor_Manage_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor_Manage_Course";
            this.Load += new System.EventHandler(this.Tutor_Manage_Course_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private Button btnBack;
        private Label lblTitle;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSubCharges;
        private TextBox txtSubHour;
        private TextBox txtSubName;
        private TextBox txtSubID;
        private Label lblSubCharges;
        private Label lblSubHour;
        private Label lblSubName;
        private Label lblSubID;
        private PictureBox pbSchedule;
        private DataGridView dgvCourse;
    }
}