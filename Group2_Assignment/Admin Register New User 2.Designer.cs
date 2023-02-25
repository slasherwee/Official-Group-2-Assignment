namespace Group2_Assignment
{
    partial class frmAdminRegisterNewUser2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminRegisterNewUser2));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.grpDOB = new System.Windows.Forms.GroupBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.grpUserRole = new System.Windows.Forms.GroupBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.cmbSubject3 = new System.Windows.Forms.ComboBox();
            this.cmbSubject2 = new System.Windows.Forms.ComboBox();
            this.cmbSubject1 = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lstHourSubject3 = new System.Windows.Forms.ListBox();
            this.lstHourSubject2 = new System.Windows.Forms.ListBox();
            this.lstHourSubject1 = new System.Windows.Forms.ListBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtOfficeLocation = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblOfficeLocation = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRegistration.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpDOB.SuspendLayout();
            this.grpUserRole.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(259, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(85, 85);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.Location = new System.Drawing.Point(372, 47);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(331, 59);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "REGISTRATION";
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlRegistration.Controls.Add(this.btnBack);
            this.pnlRegistration.Controls.Add(this.picLogo);
            this.pnlRegistration.Controls.Add(this.lblRegistration);
            this.pnlRegistration.Location = new System.Drawing.Point(-1, -7);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(993, 147);
            this.pnlRegistration.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 46;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(850, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 49);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpGender
            // 
            this.grpGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpGender.Location = new System.Drawing.Point(63, 174);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(204, 86);
            this.grpGender.TabIndex = 20;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radFemale.Location = new System.Drawing.Point(99, 41);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(89, 29);
            this.radFemale.TabIndex = 22;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMale.Location = new System.Drawing.Point(22, 41);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(71, 29);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // grpDOB
            // 
            this.grpDOB.Controls.Add(this.dob);
            this.grpDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDOB.Location = new System.Drawing.Point(318, 174);
            this.grpDOB.Name = "grpDOB";
            this.grpDOB.Size = new System.Drawing.Size(295, 86);
            this.grpDOB.TabIndex = 23;
            this.grpDOB.TabStop = false;
            this.grpDOB.Text = "Date of Birth";
            // 
            // dob
            // 
            this.dob.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dob.Location = new System.Drawing.Point(17, 43);
            this.dob.MaxDate = new System.DateTime(2023, 2, 25, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(272, 27);
            this.dob.TabIndex = 27;
            this.dob.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dof_ValueChanged);
            this.dob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dof_KeyDown);
            // 
            // grpUserRole
            // 
            this.grpUserRole.Controls.Add(this.cmbUserRole);
            this.grpUserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpUserRole.Location = new System.Drawing.Point(669, 174);
            this.grpUserRole.Name = "grpUserRole";
            this.grpUserRole.Size = new System.Drawing.Size(248, 86);
            this.grpUserRole.TabIndex = 27;
            this.grpUserRole.TabStop = false;
            this.grpUserRole.Text = "User Role";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Tutor",
            "Receptionist"});
            this.cmbUserRole.Location = new System.Drawing.Point(23, 40);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(206, 33);
            this.cmbUserRole.TabIndex = 24;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.cmbSubject3);
            this.grp.Controls.Add(this.cmbSubject2);
            this.grp.Controls.Add(this.cmbSubject1);
            this.grp.Controls.Add(this.lblHour);
            this.grp.Controls.Add(this.lblSubject);
            this.grp.Controls.Add(this.lstHourSubject3);
            this.grp.Controls.Add(this.lstHourSubject2);
            this.grp.Controls.Add(this.lstHourSubject1);
            this.grp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp.Location = new System.Drawing.Point(258, 435);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(398, 193);
            this.grp.TabIndex = 23;
            this.grp.TabStop = false;
            // 
            // cmbSubject3
            // 
            this.cmbSubject3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubject3.FormattingEnabled = true;
            this.cmbSubject3.Items.AddRange(new object[] {
            "ETC_ENGF01",
            "ETC_ENGF02",
            "ETC_ENGF03",
            "ETC_ENGF04",
            "ETC_ENGF05",
            "ETC_MTSF01",
            "ETC_MTSF02",
            "ETC_MTSF03",
            "ETC_MTCF04",
            "ETC_MTCF05",
            "ETC_SCIF01",
            "ETC_SCIF02",
            "ETC_SCIF03",
            "ETC_SCIF04",
            "ETC_SCIF05"});
            this.cmbSubject3.Location = new System.Drawing.Point(66, 150);
            this.cmbSubject3.Name = "cmbSubject3";
            this.cmbSubject3.Size = new System.Drawing.Size(138, 33);
            this.cmbSubject3.TabIndex = 45;
            this.cmbSubject3.SelectedIndexChanged += new System.EventHandler(this.cmbSubject3_SelectedIndexChanged);
            // 
            // cmbSubject2
            // 
            this.cmbSubject2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubject2.FormattingEnabled = true;
            this.cmbSubject2.Items.AddRange(new object[] {
            "ETC_ENGF01",
            "ETC_ENGF02",
            "ETC_ENGF03",
            "ETC_ENGF04",
            "ETC_ENGF05",
            "ETC_MTSF01",
            "ETC_MTSF02",
            "ETC_MTSF03",
            "ETC_MTCF04",
            "ETC_MTCF05",
            "ETC_SCIF01",
            "ETC_SCIF02",
            "ETC_SCIF03",
            "ETC_SCIF04",
            "ETC_SCIF05"});
            this.cmbSubject2.Location = new System.Drawing.Point(66, 104);
            this.cmbSubject2.Name = "cmbSubject2";
            this.cmbSubject2.Size = new System.Drawing.Size(138, 33);
            this.cmbSubject2.TabIndex = 44;
            this.cmbSubject2.SelectedIndexChanged += new System.EventHandler(this.cmbSubject2_SelectedIndexChanged);
            // 
            // cmbSubject1
            // 
            this.cmbSubject1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubject1.FormattingEnabled = true;
            this.cmbSubject1.Items.AddRange(new object[] {
            "ETC_ENGF01",
            "ETC_ENGF02",
            "ETC_ENGF03",
            "ETC_ENGF04",
            "ETC_ENGF05",
            "ETC_MTSF01",
            "ETC_MTSF02",
            "ETC_MTSF03",
            "ETC_MTCF04",
            "ETC_MTCF05",
            "ETC_SCIF01",
            "ETC_SCIF02",
            "ETC_SCIF03",
            "ETC_SCIF04",
            "ETC_SCIF05"});
            this.cmbSubject1.Location = new System.Drawing.Point(66, 57);
            this.cmbSubject1.Name = "cmbSubject1";
            this.cmbSubject1.Size = new System.Drawing.Size(138, 33);
            this.cmbSubject1.TabIndex = 25;
            this.cmbSubject1.SelectedIndexChanged += new System.EventHandler(this.cmbSubject1_SelectedIndexChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(262, 21);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(67, 28);
            this.lblHour.TabIndex = 39;
            this.lblHour.Text = "Hours";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(84, 21);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(79, 28);
            this.lblSubject.TabIndex = 37;
            this.lblSubject.Text = "Subject";
            // 
            // lstHourSubject3
            // 
            this.lstHourSubject3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHourSubject3.FormattingEnabled = true;
            this.lstHourSubject3.ItemHeight = 25;
            this.lstHourSubject3.Location = new System.Drawing.Point(264, 150);
            this.lstHourSubject3.Name = "lstHourSubject3";
            this.lstHourSubject3.Size = new System.Drawing.Size(66, 29);
            this.lstHourSubject3.TabIndex = 36;
            // 
            // lstHourSubject2
            // 
            this.lstHourSubject2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHourSubject2.FormattingEnabled = true;
            this.lstHourSubject2.ItemHeight = 25;
            this.lstHourSubject2.Location = new System.Drawing.Point(264, 104);
            this.lstHourSubject2.Name = "lstHourSubject2";
            this.lstHourSubject2.Size = new System.Drawing.Size(66, 29);
            this.lstHourSubject2.TabIndex = 35;
            // 
            // lstHourSubject1
            // 
            this.lstHourSubject1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHourSubject1.FormattingEnabled = true;
            this.lstHourSubject1.ItemHeight = 25;
            this.lstHourSubject1.Location = new System.Drawing.Point(264, 57);
            this.lstHourSubject1.Name = "lstHourSubject1";
            this.lstHourSubject1.Size = new System.Drawing.Size(66, 29);
            this.lstHourSubject1.TabIndex = 34;
            // 
            // txtExperience
            // 
            this.txtExperience.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txtExperience.Location = new System.Drawing.Point(692, 276);
            this.txtExperience.Multiline = true;
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(225, 34);
            this.txtExperience.TabIndex = 28;
            // 
            // txtOfficeLocation
            // 
            this.txtOfficeLocation.Location = new System.Drawing.Point(243, 372);
            this.txtOfficeLocation.Multiline = true;
            this.txtOfficeLocation.Name = "txtOfficeLocation";
            this.txtOfficeLocation.Size = new System.Drawing.Size(178, 36);
            this.txtOfficeLocation.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(59, 279);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(180, 28);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "User ID                :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.Location = new System.Drawing.Point(245, 287);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(2, 22);
            this.lblUserID.TabIndex = 31;
            // 
            // lblOfficeLocation
            // 
            this.lblOfficeLocation.AutoSize = true;
            this.lblOfficeLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOfficeLocation.Location = new System.Drawing.Point(59, 368);
            this.lblOfficeLocation.Name = "lblOfficeLocation";
            this.lblOfficeLocation.Size = new System.Drawing.Size(178, 28);
            this.lblOfficeLocation.TabIndex = 32;
            this.lblOfficeLocation.Text = "Office Location    :";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExperience.Location = new System.Drawing.Point(455, 275);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(228, 28);
            this.lblExperience.TabIndex = 33;
            this.lblExperience.Text = "Working Experience     :";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(850, 565);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 49);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkingHours.Location = new System.Drawing.Point(455, 368);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(230, 28);
            this.lblWorkingHours.TabIndex = 35;
            this.lblWorkingHours.Text = "Working hours             :";
            this.lblWorkingHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(692, 368);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(106, 33);
            this.cmbHour.TabIndex = 27;
            this.cmbHour.Text = "Hour";
            // 
            // frmAdminRegisterNewUser2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.lblWorkingHours);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblOfficeLocation);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtOfficeLocation);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.grpUserRole);
            this.Controls.Add(this.grpDOB);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminRegisterNewUser2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.frmRegisterNewUser2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpDOB.ResumeLayout(false);
            this.grpUserRole.ResumeLayout(false);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grpDOB;
        private System.Windows.Forms.GroupBox grpUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ListBox lstHourSubject3;
        private System.Windows.Forms.ListBox lstHourSubject2;
        private System.Windows.Forms.ListBox lstHourSubject1;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtOfficeLocation;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbSubject3;
        private System.Windows.Forms.ComboBox cmbSubject2;
        private System.Windows.Forms.ComboBox cmbSubject1;
        private System.Windows.Forms.DateTimePicker dob;
    }
}