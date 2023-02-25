namespace Group2_Assignment
{
    partial class frmAdminViewPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminViewPayroll));
            this.picPayrollDetail = new System.Windows.Forms.PictureBox();
            this.pnlPayrollDetail = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPayrollDetail = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSalaryID = new System.Windows.Forms.Label();
            this.lstHour = new System.Windows.Forms.ListBox();
            this.lstUserID = new System.Windows.Forms.ListBox();
            this.lstSalaryID = new System.Windows.Forms.ListBox();
            this.lstSubjectID = new System.Windows.Forms.ListBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTotalIncome = new System.Windows.Forms.Panel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lstUserRole = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSalary = new System.Windows.Forms.ListBox();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lstTotalSalary = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPayrollDetail)).BeginInit();
            this.pnlPayrollDetail.SuspendLayout();
            this.pnlTotalIncome.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPayrollDetail
            // 
            this.picPayrollDetail.BackColor = System.Drawing.Color.Transparent;
            this.picPayrollDetail.Image = ((System.Drawing.Image)(resources.GetObject("picPayrollDetail.Image")));
            this.picPayrollDetail.Location = new System.Drawing.Point(259, 34);
            this.picPayrollDetail.Name = "picPayrollDetail";
            this.picPayrollDetail.Size = new System.Drawing.Size(85, 85);
            this.picPayrollDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPayrollDetail.TabIndex = 1;
            this.picPayrollDetail.TabStop = false;
            // 
            // pnlPayrollDetail
            // 
            this.pnlPayrollDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPayrollDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlPayrollDetail.Controls.Add(this.btnBack);
            this.pnlPayrollDetail.Controls.Add(this.picPayrollDetail);
            this.pnlPayrollDetail.Controls.Add(this.lblPayrollDetail);
            this.pnlPayrollDetail.Location = new System.Drawing.Point(-1, -7);
            this.pnlPayrollDetail.Name = "pnlPayrollDetail";
            this.pnlPayrollDetail.Size = new System.Drawing.Size(993, 147);
            this.pnlPayrollDetail.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPayrollDetail
            // 
            this.lblPayrollDetail.AutoSize = true;
            this.lblPayrollDetail.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayrollDetail.Location = new System.Drawing.Point(371, 49);
            this.lblPayrollDetail.Name = "lblPayrollDetail";
            this.lblPayrollDetail.Size = new System.Drawing.Size(361, 59);
            this.lblPayrollDetail.TabIndex = 0;
            this.lblPayrollDetail.Text = "PAYROLL DETAIL";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(829, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 49);
            this.btnClear.TabIndex = 150;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubjectID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubjectID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubjectID.Location = new System.Drawing.Point(564, 173);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(133, 36);
            this.lblSubjectID.TabIndex = 135;
            this.lblSubjectID.Text = "Subject ID";
            this.lblSubjectID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(370, 173);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(70, 36);
            this.lblHour.TabIndex = 131;
            this.lblHour.Text = "Hour";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(204, 173);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(168, 36);
            this.lblID.TabIndex = 132;
            this.lblID.Text = "UserID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalaryID
            // 
            this.lblSalaryID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSalaryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalaryID.Location = new System.Drawing.Point(60, 173);
            this.lblSalaryID.Name = "lblSalaryID";
            this.lblSalaryID.Size = new System.Drawing.Size(148, 36);
            this.lblSalaryID.TabIndex = 130;
            this.lblSalaryID.Text = "Salary ID";
            this.lblSalaryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstHour
            // 
            this.lstHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHour.FormattingEnabled = true;
            this.lstHour.ItemHeight = 23;
            this.lstHour.Location = new System.Drawing.Point(370, 208);
            this.lstHour.Name = "lstHour";
            this.lstHour.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstHour.Size = new System.Drawing.Size(70, 280);
            this.lstHour.TabIndex = 129;
            // 
            // lstUserID
            // 
            this.lstUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUserID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUserID.FormattingEnabled = true;
            this.lstUserID.ItemHeight = 23;
            this.lstUserID.Location = new System.Drawing.Point(204, 208);
            this.lstUserID.Name = "lstUserID";
            this.lstUserID.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstUserID.Size = new System.Drawing.Size(168, 280);
            this.lstUserID.TabIndex = 128;
            // 
            // lstSalaryID
            // 
            this.lstSalaryID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSalaryID.FormattingEnabled = true;
            this.lstSalaryID.ItemHeight = 23;
            this.lstSalaryID.Location = new System.Drawing.Point(60, 208);
            this.lstSalaryID.Name = "lstSalaryID";
            this.lstSalaryID.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSalaryID.Size = new System.Drawing.Size(148, 280);
            this.lstSalaryID.TabIndex = 127;
            // 
            // lstSubjectID
            // 
            this.lstSubjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSubjectID.FormattingEnabled = true;
            this.lstSubjectID.ItemHeight = 23;
            this.lstSubjectID.Location = new System.Drawing.Point(564, 208);
            this.lstSubjectID.Name = "lstSubjectID";
            this.lstSubjectID.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSubjectID.Size = new System.Drawing.Size(133, 280);
            this.lstSubjectID.TabIndex = 137;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.Location = new System.Drawing.Point(9, 21);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(111, 25);
            this.lblUserID.TabIndex = 141;
            this.lblUserID.Text = "UserRole    :";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Tutor",
            "Receptionist"});
            this.cmbUserRole.Location = new System.Drawing.Point(131, 21);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(151, 28);
            this.cmbUserRole.TabIndex = 143;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(131, 66);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(151, 28);
            this.cmbUserID.TabIndex = 144;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 145;
            this.label1.Text = "UserID        :";
            // 
            // pnlTotalIncome
            // 
            this.pnlTotalIncome.BackColor = System.Drawing.Color.Beige;
            this.pnlTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalIncome.Controls.Add(this.lblIncome);
            this.pnlTotalIncome.Location = new System.Drawing.Point(370, 518);
            this.pnlTotalIncome.Name = "pnlTotalIncome";
            this.pnlTotalIncome.Size = new System.Drawing.Size(435, 112);
            this.pnlTotalIncome.TabIndex = 146;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(26, 30);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(2, 30);
            this.lblIncome.TabIndex = 14;
            // 
            // pnlFilterBy
            // 
            this.pnlFilterBy.BackColor = System.Drawing.Color.Beige;
            this.pnlFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterBy.Controls.Add(this.label1);
            this.pnlFilterBy.Controls.Add(this.cmbUserRole);
            this.pnlFilterBy.Controls.Add(this.lblUserID);
            this.pnlFilterBy.Controls.Add(this.cmbUserID);
            this.pnlFilterBy.Location = new System.Drawing.Point(60, 518);
            this.pnlFilterBy.Name = "pnlFilterBy";
            this.pnlFilterBy.Size = new System.Drawing.Size(312, 112);
            this.pnlFilterBy.TabIndex = 147;
            // 
            // lblUserRole
            // 
            this.lblUserRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserRole.Location = new System.Drawing.Point(438, 173);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(127, 36);
            this.lblUserRole.TabIndex = 148;
            this.lblUserRole.Text = "User Role";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstUserRole
            // 
            this.lstUserRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUserRole.FormattingEnabled = true;
            this.lstUserRole.ItemHeight = 23;
            this.lstUserRole.Location = new System.Drawing.Point(438, 208);
            this.lstUserRole.Name = "lstUserRole";
            this.lstUserRole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstUserRole.Size = new System.Drawing.Size(127, 280);
            this.lstUserRole.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(696, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 151;
            this.label2.Text = "Salary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSalary
            // 
            this.lstSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSalary.FormattingEnabled = true;
            this.lstSalary.ItemHeight = 23;
            this.lstSalary.Location = new System.Drawing.Point(696, 208);
            this.lstSalary.Name = "lstSalary";
            this.lstSalary.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSalary.Size = new System.Drawing.Size(109, 280);
            this.lstSalary.TabIndex = 152;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSalary.Location = new System.Drawing.Point(804, 173);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(129, 36);
            this.lblTotalSalary.TabIndex = 153;
            this.lblTotalSalary.Text = "Total Salary";
            this.lblTotalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTotalSalary
            // 
            this.lstTotalSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTotalSalary.FormattingEnabled = true;
            this.lstTotalSalary.ItemHeight = 23;
            this.lstTotalSalary.Location = new System.Drawing.Point(804, 208);
            this.lstTotalSalary.Name = "lstTotalSalary";
            this.lstTotalSalary.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTotalSalary.Size = new System.Drawing.Size(129, 280);
            this.lstTotalSalary.TabIndex = 154;
            // 
            // frmAdminViewPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.lstTotalSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstSalary);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lstUserRole);
            this.Controls.Add(this.pnlFilterBy);
            this.Controls.Add(this.pnlTotalIncome);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSalaryID);
            this.Controls.Add(this.lstHour);
            this.Controls.Add(this.lstUserID);
            this.Controls.Add(this.lstSalaryID);
            this.Controls.Add(this.lstSubjectID);
            this.Controls.Add(this.pnlPayrollDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminViewPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.frmAdminViewPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPayrollDetail)).EndInit();
            this.pnlPayrollDetail.ResumeLayout(false);
            this.pnlPayrollDetail.PerformLayout();
            this.pnlTotalIncome.ResumeLayout(false);
            this.pnlTotalIncome.PerformLayout();
            this.pnlFilterBy.ResumeLayout(false);
            this.pnlFilterBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPayrollDetail;
        private System.Windows.Forms.Panel pnlPayrollDetail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPayrollDetail;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSalaryID;
        private System.Windows.Forms.ListBox lstHour;
        private System.Windows.Forms.ListBox lstUserID;
        private System.Windows.Forms.ListBox lstSalaryID;
        private System.Windows.Forms.ListBox lstSubjectID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTotalIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Panel pnlFilterBy;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ListBox lstUserRole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSalary;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.ListBox lstTotalSalary;
    }
}