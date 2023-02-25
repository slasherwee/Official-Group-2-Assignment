namespace Group2_Assignment
{
    partial class Tutor_Add_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor_Add_Course));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSubCharges = new System.Windows.Forms.TextBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.lblSubCharges = new System.Windows.Forms.Label();
            this.lblSubHour = new System.Windows.Forms.Label();
            this.lblSubName = new System.Windows.Forms.Label();
            this.lblSubID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.txtSubHour = new System.Windows.Forms.TextBox();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
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
            this.panelTutor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
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
            this.lblTitle.Location = new System.Drawing.Point(337, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "ADD NEW COURSE";
            // 
            // txtSubCharges
            // 
            this.txtSubCharges.Location = new System.Drawing.Point(589, 511);
            this.txtSubCharges.Name = "txtSubCharges";
            this.txtSubCharges.Size = new System.Drawing.Size(265, 34);
            this.txtSubCharges.TabIndex = 22;
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(116, 511);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(265, 34);
            this.txtSubName.TabIndex = 20;
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(116, 404);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.Size = new System.Drawing.Size(265, 34);
            this.txtSubID.TabIndex = 19;
            // 
            // lblSubCharges
            // 
            this.lblSubCharges.AutoSize = true;
            this.lblSubCharges.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubCharges.Location = new System.Drawing.Point(589, 473);
            this.lblSubCharges.Name = "lblSubCharges";
            this.lblSubCharges.Size = new System.Drawing.Size(158, 28);
            this.lblSubCharges.TabIndex = 18;
            this.lblSubCharges.Text = "Subject Charges";
            // 
            // lblSubHour
            // 
            this.lblSubHour.AutoSize = true;
            this.lblSubHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubHour.Location = new System.Drawing.Point(589, 364);
            this.lblSubHour.Name = "lblSubHour";
            this.lblSubHour.Size = new System.Drawing.Size(131, 28);
            this.lblSubHour.TabIndex = 17;
            this.lblSubHour.Text = "Subject Hour";
            // 
            // lblSubName
            // 
            this.lblSubName.AutoSize = true;
            this.lblSubName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubName.Location = new System.Drawing.Point(116, 473);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(139, 28);
            this.lblSubName.TabIndex = 16;
            this.lblSubName.Text = "Subject Name";
            // 
            // lblSubID
            // 
            this.lblSubID.AutoSize = true;
            this.lblSubID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubID.Location = new System.Drawing.Point(116, 365);
            this.lblSubID.Name = "lblSubID";
            this.lblSubID.Size = new System.Drawing.Size(111, 28);
            this.lblSubID.TabIndex = 15;
            this.lblSubID.Text = "Subject ID ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnClear.Location = new System.Drawing.Point(590, 573);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 48);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnAdd.Location = new System.Drawing.Point(774, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 48);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvCourse.Size = new System.Drawing.Size(982, 259);
            this.dgvCourse.TabIndex = 26;
            // 
            // txtSubHour
            // 
            this.txtSubHour.Location = new System.Drawing.Point(589, 404);
            this.txtSubHour.Name = "txtSubHour";
            this.txtSubHour.Size = new System.Drawing.Size(265, 34);
            this.txtSubHour.TabIndex = 27;
            // 
            // Tutor_Add_Course
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtSubHour);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSubCharges);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtSubID);
            this.Controls.Add(this.lblSubCharges);
            this.Controls.Add(this.lblSubHour);
            this.Controls.Add(this.lblSubName);
            this.Controls.Add(this.lblSubID);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutor_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor_Add_Course";
            this.Load += new System.EventHandler(this.Tutor_Add_Course_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private Button btnBack;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private TextBox txtSubCharges;
        private TextBox txtSubName;
        private TextBox txtSubID;
        private Label lblSubCharges;
        private Label lblSubHour;
        private Label lblSubName;
        private Label lblSubID;
        private Button btnClear;
        private Button btnAdd;
        private DataGridView dgvCourse;
        private TextBox txtSubHour;
    }
}