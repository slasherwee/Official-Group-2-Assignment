namespace Group2_Assignment
{
    partial class Student_Request_Change_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Request_Change_Subject));
            lblNewSubTutor = new Label();
            btnSendReq = new Button();
            lblNewSubName = new Label();
            lblCurrentTutor = new Label();
            lblCurrentSub = new Label();
            panelTutor = new Panel();
            pbRequestChange = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            lblCurrentSubName = new Label();
            lblNewSubID = new Label();
            lblDate = new Label();
            lblDateOutput = new Label();
            cmbCurrentSubID = new ComboBox();
            cmbNewSubID = new ComboBox();
            lblCurrentSubNameOutput = new Label();
            lblNewSubNameOutput = new Label();
            cmbNewTutor = new ComboBox();
            cmbCurrentTutor = new ComboBox();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRequestChange).BeginInit();
            SuspendLayout();
            // 
            // lblNewSubTutor
            // 
            lblNewSubTutor.AutoSize = true;
            lblNewSubTutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSubTutor.Location = new Point(360, 478);
            lblNewSubTutor.Name = "lblNewSubTutor";
            lblNewSubTutor.Size = new Size(112, 28);
            lblNewSubTutor.TabIndex = 38;
            lblNewSubTutor.Text = "New Tutor :";
            // 
            // btnSendReq
            // 
            btnSendReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSendReq.BackColor = Color.FromArgb(24, 58, 29);
            btnSendReq.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendReq.ForeColor = Color.FromArgb(254, 251, 233);
            btnSendReq.Location = new Point(373, 561);
            btnSendReq.Name = "btnSendReq";
            btnSendReq.Size = new Size(234, 48);
            btnSendReq.TabIndex = 37;
            btnSendReq.Text = "SEND REQUEST";
            btnSendReq.UseVisualStyleBackColor = false;
            btnSendReq.Click += btnSendReq_Click;
            // 
            // lblNewSubName
            // 
            lblNewSubName.AutoSize = true;
            lblNewSubName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSubName.Location = new Point(285, 420);
            lblNewSubName.Name = "lblNewSubName";
            lblNewSubName.Size = new Size(187, 28);
            lblNewSubName.TabIndex = 36;
            lblNewSubName.Text = "New Subject Name :";
            // 
            // lblCurrentTutor
            // 
            lblCurrentTutor.AutoSize = true;
            lblCurrentTutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentTutor.Location = new Point(334, 304);
            lblCurrentTutor.Name = "lblCurrentTutor";
            lblCurrentTutor.Size = new Size(138, 28);
            lblCurrentTutor.TabIndex = 35;
            lblCurrentTutor.Text = "Current Tutor :";
            // 
            // lblCurrentSub
            // 
            lblCurrentSub.AutoSize = true;
            lblCurrentSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentSub.Location = new Point(292, 190);
            lblCurrentSub.Name = "lblCurrentSub";
            lblCurrentSub.Size = new Size(180, 28);
            lblCurrentSub.TabIndex = 34;
            lblCurrentSub.Text = "Current Subejct ID :";
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(pbRequestChange);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 33;
            // 
            // pbRequestChange
            // 
            pbRequestChange.BackColor = Color.FromArgb(225, 238, 221);
            pbRequestChange.Image = Properties.Resources.Change;
            pbRequestChange.Location = new Point(228, 35);
            pbRequestChange.Name = "pbRequestChange";
            pbRequestChange.Size = new Size(60, 38);
            pbRequestChange.SizeMode = PictureBoxSizeMode.Zoom;
            pbRequestChange.TabIndex = 8;
            pbRequestChange.TabStop = false;
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
            lblTitle.Location = new Point(294, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(456, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "REQUEST CHANGE SUBJECT";
            // 
            // lblCurrentSubName
            // 
            lblCurrentSubName.AutoSize = true;
            lblCurrentSubName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentSubName.Location = new Point(259, 247);
            lblCurrentSubName.Name = "lblCurrentSubName";
            lblCurrentSubName.Size = new Size(213, 28);
            lblCurrentSubName.TabIndex = 44;
            lblCurrentSubName.Text = "Current Subejct Name :";
            // 
            // lblNewSubID
            // 
            lblNewSubID.AutoSize = true;
            lblNewSubID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSubID.Location = new Point(318, 362);
            lblNewSubID.Name = "lblNewSubID";
            lblNewSubID.Size = new Size(154, 28);
            lblNewSubID.TabIndex = 46;
            lblNewSubID.Text = "New Subject ID :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(410, 137);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(62, 28);
            lblDate.TabIndex = 54;
            lblDate.Text = "Date :";
            // 
            // lblDateOutput
            // 
            lblDateOutput.AutoSize = true;
            lblDateOutput.BorderStyle = BorderStyle.Fixed3D;
            lblDateOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOutput.Location = new Point(487, 137);
            lblDateOutput.Name = "lblDateOutput";
            lblDateOutput.Size = new Size(2, 30);
            lblDateOutput.TabIndex = 55;
            // 
            // cmbCurrentSubID
            // 
            cmbCurrentSubID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrentSubID.FormattingEnabled = true;
            cmbCurrentSubID.Location = new Point(487, 194);
            cmbCurrentSubID.Name = "cmbCurrentSubID";
            cmbCurrentSubID.Size = new Size(197, 28);
            cmbCurrentSubID.TabIndex = 56;
            cmbCurrentSubID.SelectedIndexChanged += cmbCurrentSubID_SelectedIndexChanged;
            // 
            // cmbNewSubID
            // 
            cmbNewSubID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewSubID.FormattingEnabled = true;
            cmbNewSubID.Location = new Point(487, 362);
            cmbNewSubID.Name = "cmbNewSubID";
            cmbNewSubID.Size = new Size(197, 28);
            cmbNewSubID.TabIndex = 57;
            cmbNewSubID.SelectedIndexChanged += cmbNewSubID_SelectedIndexChanged;
            // 
            // lblCurrentSubNameOutput
            // 
            lblCurrentSubNameOutput.AutoSize = true;
            lblCurrentSubNameOutput.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentSubNameOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentSubNameOutput.Location = new Point(487, 249);
            lblCurrentSubNameOutput.Name = "lblCurrentSubNameOutput";
            lblCurrentSubNameOutput.Size = new Size(2, 30);
            lblCurrentSubNameOutput.TabIndex = 58;
            // 
            // lblNewSubNameOutput
            // 
            lblNewSubNameOutput.AutoSize = true;
            lblNewSubNameOutput.BorderStyle = BorderStyle.Fixed3D;
            lblNewSubNameOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSubNameOutput.Location = new Point(487, 420);
            lblNewSubNameOutput.Name = "lblNewSubNameOutput";
            lblNewSubNameOutput.Size = new Size(2, 30);
            lblNewSubNameOutput.TabIndex = 60;
            // 
            // cmbNewTutor
            // 
            cmbNewTutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewTutor.FormattingEnabled = true;
            cmbNewTutor.Location = new Point(487, 482);
            cmbNewTutor.Name = "cmbNewTutor";
            cmbNewTutor.Size = new Size(197, 28);
            cmbNewTutor.TabIndex = 61;
            // 
            // cmbCurrentTutor
            // 
            cmbCurrentTutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrentTutor.FormattingEnabled = true;
            cmbCurrentTutor.Location = new Point(487, 308);
            cmbCurrentTutor.Name = "cmbCurrentTutor";
            cmbCurrentTutor.Size = new Size(197, 28);
            cmbCurrentTutor.TabIndex = 62;
            // 
            // Student_Request_Change_Subject
            // 
            AcceptButton = btnSendReq;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(cmbCurrentTutor);
            Controls.Add(cmbNewTutor);
            Controls.Add(lblNewSubNameOutput);
            Controls.Add(lblCurrentSubNameOutput);
            Controls.Add(cmbNewSubID);
            Controls.Add(cmbCurrentSubID);
            Controls.Add(lblDateOutput);
            Controls.Add(lblDate);
            Controls.Add(lblNewSubID);
            Controls.Add(lblCurrentSubName);
            Controls.Add(lblNewSubTutor);
            Controls.Add(btnSendReq);
            Controls.Add(lblNewSubName);
            Controls.Add(lblCurrentTutor);
            Controls.Add(lblCurrentSub);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Request_Change_Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request Change Subject";
            Load += Student_Request_Change_Subject_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRequestChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbNewSub;
        private Label lblNewSubTutor;
        private Button btnSendReq;
        private Label lblNewSubName;
        private Label lblCurrentTutor;
        private Label lblCurrentSub;
        private Panel panelTutor;
        private PictureBox pbRequestChange;
        private Button btnBack;
        private Label lblTitle;
        private Label lblCurrentSubName;
        private Label lblNewSubID;
        private Label lblDate;
        private Label lblDateOutput;
        private ComboBox cmbCurrentSubID;
        private ComboBox cmbNewSubID;
        private Label lblCurrentSubNameOutput;
        private Label lblNewSubNameOutput;
        private ComboBox cmbNewTutor;
        private ComboBox cmbCurrentTutor;
    }
}