namespace Group2_Assignment
{
    partial class Student_Class_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Class_Schedule));
            dgvSchedule = new DataGridView();
            tutor_id = new DataGridViewTextBoxColumn();
            sub_id = new DataGridViewTextBoxColumn();
            sub_name = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            cmbDay = new ComboBox();
            lblDay = new Label();
            panelTutor = new Panel();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { tutor_id, sub_id, sub_name, location, time });
            dgvSchedule.Location = new Point(62, 222);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(860, 333);
            dgvSchedule.TabIndex = 42;
            // 
            // tutor_id
            // 
            tutor_id.DataPropertyName = "tutor_id";
            tutor_id.HeaderText = "Tutor ID";
            tutor_id.MinimumWidth = 6;
            tutor_id.Name = "tutor_id";
            tutor_id.ReadOnly = true;
            // 
            // sub_id
            // 
            sub_id.DataPropertyName = "sub_id";
            sub_id.HeaderText = "Subject ID";
            sub_id.MinimumWidth = 6;
            sub_id.Name = "sub_id";
            sub_id.ReadOnly = true;
            // 
            // sub_name
            // 
            sub_name.DataPropertyName = "sub_name";
            sub_name.HeaderText = "Subject Name";
            sub_name.MinimumWidth = 6;
            sub_name.Name = "sub_name";
            sub_name.ReadOnly = true;
            // 
            // location
            // 
            location.DataPropertyName = "location";
            location.HeaderText = "Venue";
            location.MinimumWidth = 6;
            location.Name = "location";
            location.ReadOnly = true;
            // 
            // time
            // 
            time.DataPropertyName = "time";
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(185, 173);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(151, 28);
            cmbDay.TabIndex = 41;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.Location = new Point(61, 169);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(112, 28);
            lblDay.TabIndex = 40;
            lblDay.Text = "Select Day :";
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(pictureBox1);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(225, 238, 221);
            pictureBox1.Image = Properties.Resources.administration;
            pictureBox1.Location = new Point(304, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
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
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(390, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "CLASS SCHEDULE";
            // 
            // Student_Class_Schedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvSchedule);
            Controls.Add(cmbDay);
            Controls.Add(lblDay);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Class_Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Schedule";
            Load += Student_Class_Schedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private ComboBox cmbDay;
        private Label lblDay;
        private Panel panelTutor;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Label lblTitle;
        private DataGridViewTextBoxColumn tutor_id;
        private DataGridViewTextBoxColumn sub_id;
        private DataGridViewTextBoxColumn sub_name;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn time;
    }
}