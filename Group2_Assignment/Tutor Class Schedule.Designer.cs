namespace Group2_Assignment
{
    partial class Tutor_Class_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor_Class_Schedule));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.pictureBox1);
            this.panelTutor.Controls.Add(this.btnBack);
            this.panelTutor.Controls.Add(this.lblTitle);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 102);
            this.panelTutor.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pictureBox1.Image = global::Group2_Assignment.Properties.Resources.administration;
            this.pictureBox1.Location = new System.Drawing.Point(225, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            this.lblTitle.Size = new System.Drawing.Size(295, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CLASS SCHEDULE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnUpdate.Location = new System.Drawing.Point(814, 576);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 48);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(38, 143);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(110, 28);
            this.lblFilter.TabIndex = 36;
            this.lblFilter.Text = "Select day :";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(190, 140);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(151, 36);
            this.cmbDay.TabIndex = 37;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(0, 209);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 29;
            this.dgvSchedule.Size = new System.Drawing.Size(982, 235);
            this.dgvSchedule.TabIndex = 38;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(515, 511);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(265, 34);
            this.txtTime.TabIndex = 42;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(42, 511);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(265, 34);
            this.txtLocation.TabIndex = 41;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(515, 471);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 28);
            this.lblTime.TabIndex = 40;
            this.lblTime.Text = "Time";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(42, 472);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 28);
            this.lblLocation.TabIndex = 39;
            this.lblLocation.Text = "Location";
            // 
            // Tutor_Class_Schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutor_Class_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor_Class_Schedule";
            this.Load += new System.EventHandler(this.Tutor_Class_Schedule_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private Button btnBack;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Label lblFilter;
        private ComboBox cmbDay;
        private DataGridView dgvSchedule;
        private TextBox txtTime;
        private TextBox txtLocation;
        private Label lblTime;
        private Label lblLocation;
    }
}