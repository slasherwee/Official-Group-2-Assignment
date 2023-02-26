namespace Group2_Assignment
{
    partial class Student_Personal_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Personal_Information));
            txtContactNo = new TextBox();
            txtAdd = new TextBox();
            txtLName = new TextBox();
            txtEmail = new TextBox();
            txtFName = new TextBox();
            label9 = new Label();
            lblAdd = new Label();
            lblLName = new Label();
            label6 = new Label();
            lblLevelTitle = new Label();
            lblFName = new Label();
            panelTutor = new Panel();
            btnEdit = new Button();
            btnBack = new Button();
            pbPersonalInfo = new PictureBox();
            lblTitle = new Label();
            lblLevel = new Label();
            lblIc = new Label();
            lblIcOutput = new Label();
            lblGenderOutput = new Label();
            lblGender = new Label();
            lblNationality = new Label();
            lblNationalityOutput = new Label();
            gbPersonalInfo = new GroupBox();
            gbSubEnrolment = new GroupBox();
            lblSub3CodeOutput = new Label();
            lblSub3Output = new Label();
            lblSub3Code = new Label();
            lblSub3 = new Label();
            lblSub2CodeOutput = new Label();
            lblSub2Output = new Label();
            lblSub2Code = new Label();
            lblSub2 = new Label();
            lblSub1CodeOutput = new Label();
            lblSub1Output = new Label();
            lblSub1Code = new Label();
            lblSub1 = new Label();
            lblNoOfSubOutput = new Label();
            lblNoOfSub = new Label();
            lblEnrolYearOutput = new Label();
            lblEnrolYear = new Label();
            lblStudId = new Label();
            label2 = new Label();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonalInfo).BeginInit();
            gbPersonalInfo.SuspendLayout();
            gbSubEnrolment.SuspendLayout();
            SuspendLayout();
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(662, 144);
            txtContactNo.MaxLength = 12;
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(220, 27);
            txtContactNo.TabIndex = 29;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            txtContactNo.KeyPress += txtContactNo_KeyPress;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(662, 201);
            txtAdd.MaxLength = 100;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(220, 27);
            txtAdd.TabIndex = 28;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(662, 33);
            txtLName.MaxLength = 30;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(220, 27);
            txtLName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 144);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 26;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(189, 33);
            txtFName.MaxLength = 30;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(220, 27);
            txtFName.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(486, 140);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 23;
            label9.Text = "Contact Number :";
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdd.Location = new Point(486, 197);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(151, 28);
            lblAdd.TabIndex = 22;
            lblAdd.Text = "House Address :";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLName.Location = new Point(486, 29);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(117, 28);
            lblLName.TabIndex = 21;
            lblLName.Text = "Last Name : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 140);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 20;
            label6.Text = "Email :";
            // 
            // lblLevelTitle
            // 
            lblLevelTitle.AutoSize = true;
            lblLevelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLevelTitle.Location = new Point(13, 39);
            lblLevelTitle.Name = "lblLevelTitle";
            lblLevelTitle.Size = new Size(65, 28);
            lblLevelTitle.TabIndex = 19;
            lblLevelTitle.Text = "Level :";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFName.Location = new Point(13, 29);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(120, 28);
            lblFName.TabIndex = 18;
            lblFName.Text = "First Name : ";
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(btnEdit);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(pbPersonalInfo);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(24, 58, 29);
            btnEdit.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(254, 251, 233);
            btnEdit.Location = new Point(819, 30);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 48);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            // pbPersonalInfo
            // 
            pbPersonalInfo.BackColor = Color.FromArgb(225, 238, 221);
            pbPersonalInfo.Image = Properties.Resources.resume;
            pbPersonalInfo.Location = new Point(271, 34);
            pbPersonalInfo.Name = "pbPersonalInfo";
            pbPersonalInfo.Size = new Size(60, 38);
            pbPersonalInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonalInfo.TabIndex = 11;
            pbPersonalInfo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(337, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 38);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "PERSONAL INFORMATION";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Location = new Point(215, 45);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 22);
            lblLevel.TabIndex = 31;
            // 
            // lblIc
            // 
            lblIc.AutoSize = true;
            lblIc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIc.Location = new Point(13, 85);
            lblIc.Name = "lblIc";
            lblIc.Size = new Size(120, 28);
            lblIc.TabIndex = 32;
            lblIc.Text = "IC/Passport :";
            // 
            // lblIcOutput
            // 
            lblIcOutput.AutoSize = true;
            lblIcOutput.BorderStyle = BorderStyle.Fixed3D;
            lblIcOutput.Location = new Point(189, 92);
            lblIcOutput.Name = "lblIcOutput";
            lblIcOutput.Size = new Size(2, 22);
            lblIcOutput.TabIndex = 33;
            // 
            // lblGenderOutput
            // 
            lblGenderOutput.AutoSize = true;
            lblGenderOutput.BorderStyle = BorderStyle.Fixed3D;
            lblGenderOutput.Location = new Point(662, 92);
            lblGenderOutput.Name = "lblGenderOutput";
            lblGenderOutput.Size = new Size(2, 22);
            lblGenderOutput.TabIndex = 35;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(486, 85);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(85, 28);
            lblGender.TabIndex = 34;
            lblGender.Text = "Gender :";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNationality.Location = new Point(13, 197);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(118, 28);
            lblNationality.TabIndex = 36;
            lblNationality.Text = "Nationality :";
            // 
            // lblNationalityOutput
            // 
            lblNationalityOutput.AutoSize = true;
            lblNationalityOutput.BorderStyle = BorderStyle.Fixed3D;
            lblNationalityOutput.Location = new Point(189, 204);
            lblNationalityOutput.Name = "lblNationalityOutput";
            lblNationalityOutput.Size = new Size(2, 22);
            lblNationalityOutput.TabIndex = 37;
            // 
            // gbPersonalInfo
            // 
            gbPersonalInfo.Controls.Add(lblAdd);
            gbPersonalInfo.Controls.Add(lblNationalityOutput);
            gbPersonalInfo.Controls.Add(lblFName);
            gbPersonalInfo.Controls.Add(lblNationality);
            gbPersonalInfo.Controls.Add(label6);
            gbPersonalInfo.Controls.Add(lblGenderOutput);
            gbPersonalInfo.Controls.Add(lblLName);
            gbPersonalInfo.Controls.Add(lblGender);
            gbPersonalInfo.Controls.Add(label9);
            gbPersonalInfo.Controls.Add(lblIcOutput);
            gbPersonalInfo.Controls.Add(txtFName);
            gbPersonalInfo.Controls.Add(lblIc);
            gbPersonalInfo.Controls.Add(txtEmail);
            gbPersonalInfo.Controls.Add(txtLName);
            gbPersonalInfo.Controls.Add(txtAdd);
            gbPersonalInfo.Controls.Add(txtContactNo);
            gbPersonalInfo.Location = new Point(38, 148);
            gbPersonalInfo.Name = "gbPersonalInfo";
            gbPersonalInfo.Size = new Size(902, 246);
            gbPersonalInfo.TabIndex = 38;
            gbPersonalInfo.TabStop = false;
            gbPersonalInfo.Text = "Personal Information";
            // 
            // gbSubEnrolment
            // 
            gbSubEnrolment.Controls.Add(lblSub3CodeOutput);
            gbSubEnrolment.Controls.Add(lblSub3Output);
            gbSubEnrolment.Controls.Add(lblSub3Code);
            gbSubEnrolment.Controls.Add(lblSub3);
            gbSubEnrolment.Controls.Add(lblSub2CodeOutput);
            gbSubEnrolment.Controls.Add(lblSub2Output);
            gbSubEnrolment.Controls.Add(lblSub2Code);
            gbSubEnrolment.Controls.Add(lblSub2);
            gbSubEnrolment.Controls.Add(lblSub1CodeOutput);
            gbSubEnrolment.Controls.Add(lblSub1Output);
            gbSubEnrolment.Controls.Add(lblSub1Code);
            gbSubEnrolment.Controls.Add(lblSub1);
            gbSubEnrolment.Controls.Add(lblNoOfSubOutput);
            gbSubEnrolment.Controls.Add(lblNoOfSub);
            gbSubEnrolment.Controls.Add(lblEnrolYearOutput);
            gbSubEnrolment.Controls.Add(lblLevelTitle);
            gbSubEnrolment.Controls.Add(lblEnrolYear);
            gbSubEnrolment.Controls.Add(lblLevel);
            gbSubEnrolment.Location = new Point(38, 400);
            gbSubEnrolment.Name = "gbSubEnrolment";
            gbSubEnrolment.Size = new Size(902, 241);
            gbSubEnrolment.TabIndex = 39;
            gbSubEnrolment.TabStop = false;
            gbSubEnrolment.Text = "Subject Enrolment";
            // 
            // lblSub3CodeOutput
            // 
            lblSub3CodeOutput.AutoSize = true;
            lblSub3CodeOutput.BorderStyle = BorderStyle.Fixed3D;
            lblSub3CodeOutput.Location = new Point(629, 202);
            lblSub3CodeOutput.Name = "lblSub3CodeOutput";
            lblSub3CodeOutput.Size = new Size(2, 22);
            lblSub3CodeOutput.TabIndex = 53;
            // 
            // lblSub3Output
            // 
            lblSub3Output.AutoSize = true;
            lblSub3Output.BorderStyle = BorderStyle.Fixed3D;
            lblSub3Output.Location = new Point(427, 202);
            lblSub3Output.Name = "lblSub3Output";
            lblSub3Output.Size = new Size(2, 22);
            lblSub3Output.TabIndex = 52;
            // 
            // lblSub3Code
            // 
            lblSub3Code.AutoSize = true;
            lblSub3Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub3Code.Location = new Point(620, 166);
            lblSub3Code.Name = "lblSub3Code";
            lblSub3Code.Size = new Size(153, 28);
            lblSub3Code.TabIndex = 51;
            lblSub3Code.Text = "Subject 3 Code :";
            // 
            // lblSub3
            // 
            lblSub3.AutoSize = true;
            lblSub3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub3.Location = new Point(420, 166);
            lblSub3.Name = "lblSub3";
            lblSub3.Size = new Size(102, 28);
            lblSub3.TabIndex = 50;
            lblSub3.Text = "Subject 3 :";
            // 
            // lblSub2CodeOutput
            // 
            lblSub2CodeOutput.AutoSize = true;
            lblSub2CodeOutput.BorderStyle = BorderStyle.Fixed3D;
            lblSub2CodeOutput.Location = new Point(629, 133);
            lblSub2CodeOutput.Name = "lblSub2CodeOutput";
            lblSub2CodeOutput.Size = new Size(2, 22);
            lblSub2CodeOutput.TabIndex = 49;
            // 
            // lblSub2Output
            // 
            lblSub2Output.AutoSize = true;
            lblSub2Output.BorderStyle = BorderStyle.Fixed3D;
            lblSub2Output.Location = new Point(427, 133);
            lblSub2Output.Name = "lblSub2Output";
            lblSub2Output.Size = new Size(2, 22);
            lblSub2Output.TabIndex = 48;
            // 
            // lblSub2Code
            // 
            lblSub2Code.AutoSize = true;
            lblSub2Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub2Code.Location = new Point(620, 97);
            lblSub2Code.Name = "lblSub2Code";
            lblSub2Code.Size = new Size(153, 28);
            lblSub2Code.TabIndex = 47;
            lblSub2Code.Text = "Subject 2 Code :";
            // 
            // lblSub2
            // 
            lblSub2.AutoSize = true;
            lblSub2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub2.Location = new Point(420, 97);
            lblSub2.Name = "lblSub2";
            lblSub2.Size = new Size(102, 28);
            lblSub2.TabIndex = 46;
            lblSub2.Text = "Subject 2 :";
            // 
            // lblSub1CodeOutput
            // 
            lblSub1CodeOutput.AutoSize = true;
            lblSub1CodeOutput.BorderStyle = BorderStyle.Fixed3D;
            lblSub1CodeOutput.Location = new Point(629, 58);
            lblSub1CodeOutput.Name = "lblSub1CodeOutput";
            lblSub1CodeOutput.Size = new Size(2, 22);
            lblSub1CodeOutput.TabIndex = 45;
            // 
            // lblSub1Output
            // 
            lblSub1Output.AutoSize = true;
            lblSub1Output.BorderStyle = BorderStyle.Fixed3D;
            lblSub1Output.Location = new Point(427, 58);
            lblSub1Output.Name = "lblSub1Output";
            lblSub1Output.Size = new Size(2, 22);
            lblSub1Output.TabIndex = 44;
            // 
            // lblSub1Code
            // 
            lblSub1Code.AutoSize = true;
            lblSub1Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub1Code.Location = new Point(620, 22);
            lblSub1Code.Name = "lblSub1Code";
            lblSub1Code.Size = new Size(153, 28);
            lblSub1Code.TabIndex = 43;
            lblSub1Code.Text = "Subject 1 Code :";
            // 
            // lblSub1
            // 
            lblSub1.AutoSize = true;
            lblSub1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub1.Location = new Point(420, 22);
            lblSub1.Name = "lblSub1";
            lblSub1.Size = new Size(102, 28);
            lblSub1.TabIndex = 42;
            lblSub1.Text = "Subject 1 :";
            // 
            // lblNoOfSubOutput
            // 
            lblNoOfSubOutput.AutoSize = true;
            lblNoOfSubOutput.BorderStyle = BorderStyle.Fixed3D;
            lblNoOfSubOutput.Location = new Point(215, 148);
            lblNoOfSubOutput.Name = "lblNoOfSubOutput";
            lblNoOfSubOutput.Size = new Size(2, 22);
            lblNoOfSubOutput.TabIndex = 41;
            // 
            // lblNoOfSub
            // 
            lblNoOfSub.AutoSize = true;
            lblNoOfSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoOfSub.Location = new Point(13, 141);
            lblNoOfSub.Name = "lblNoOfSub";
            lblNoOfSub.Size = new Size(194, 28);
            lblNoOfSub.TabIndex = 40;
            lblNoOfSub.Text = "Number of Subjects :";
            // 
            // lblEnrolYearOutput
            // 
            lblEnrolYearOutput.AutoSize = true;
            lblEnrolYearOutput.BorderStyle = BorderStyle.Fixed3D;
            lblEnrolYearOutput.Location = new Point(215, 96);
            lblEnrolYearOutput.Name = "lblEnrolYearOutput";
            lblEnrolYearOutput.Size = new Size(2, 22);
            lblEnrolYearOutput.TabIndex = 39;
            // 
            // lblEnrolYear
            // 
            lblEnrolYear.AutoSize = true;
            lblEnrolYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnrolYear.Location = new Point(13, 90);
            lblEnrolYear.Name = "lblEnrolYear";
            lblEnrolYear.Size = new Size(175, 28);
            lblEnrolYear.TabIndex = 38;
            lblEnrolYear.Text = "Year of Enrolment :";
            // 
            // lblStudId
            // 
            lblStudId.AutoSize = true;
            lblStudId.BorderStyle = BorderStyle.Fixed3D;
            lblStudId.Location = new Point(167, 111);
            lblStudId.Name = "lblStudId";
            lblStudId.Size = new Size(2, 22);
            lblStudId.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 30;
            label2.Text = "Student ID : ";
            // 
            // Student_Personal_Information
            // 
            AcceptButton = btnEdit;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(gbSubEnrolment);
            Controls.Add(gbPersonalInfo);
            Controls.Add(label2);
            Controls.Add(lblStudId);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Personal_Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Information";
            Load += Student_Personal_Information_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonalInfo).EndInit();
            gbPersonalInfo.ResumeLayout(false);
            gbPersonalInfo.PerformLayout();
            gbSubEnrolment.ResumeLayout(false);
            gbSubEnrolment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContactNo;
        private TextBox txtAdd;
        private TextBox txtLName;
        private TextBox txtEmail;
        private TextBox txtFName;
        private Label label9;
        private Label lblAdd;
        private Label lblLName;
        private Label label6;
        private Label lblLevelTitle;
        private Label lblFName;
        private Panel panelTutor;
        private Button btnEdit;
        private Button btnBack;
        private PictureBox pbPersonalInfo;
        private Label lblTitle;
        private Label lblLevel;
        private Label lblIc;
        private Label lblIcOutput;
        private Label lblGenderOutput;
        private Label lblGender;
        private Label lblNationality;
        private Label lblNationalityOutput;
        private GroupBox gbPersonalInfo;
        private GroupBox gbSubEnrolment;
        private Label lblSub3CodeOutput;
        private Label lblSub3Output;
        private Label lblSub3Code;
        private Label lblSub3;
        private Label lblSub2CodeOutput;
        private Label lblSub2Output;
        private Label lblSub2Code;
        private Label lblSub2;
        private Label lblSub1CodeOutput;
        private Label lblSub1Output;
        private Label lblSub1Code;
        private Label lblSub1;
        private Label lblNoOfSubOutput;
        private Label lblNoOfSub;
        private Label lblEnrolYearOutput;
        private Label lblEnrolYear;
        private Label lblStudId;
        private Label label2;
    }
}