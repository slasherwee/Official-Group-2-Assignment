namespace Group2_Assignment
{
    partial class frmAdminPersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPersonalInfo));
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.picPersonalInfo = new System.Windows.Forms.PictureBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblWorkingExp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblOfficeLocation = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtWorkingExp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOfficeLocation = new System.Windows.Forms.TextBox();
            this.pnlPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlPersonalInfo.Controls.Add(this.btnBack);
            this.pnlPersonalInfo.Controls.Add(this.picPersonalInfo);
            this.pnlPersonalInfo.Controls.Add(this.lblRegistration);
            this.pnlPersonalInfo.Controls.Add(this.btnEdit);
            this.pnlPersonalInfo.Controls.Add(this.btnDone);
            this.pnlPersonalInfo.Location = new System.Drawing.Point(-1, -7);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(983, 147);
            this.pnlPersonalInfo.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 48;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picPersonalInfo
            // 
            this.picPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.picPersonalInfo.Image = ((System.Drawing.Image)(resources.GetObject("picPersonalInfo.Image")));
            this.picPersonalInfo.Location = new System.Drawing.Point(173, 34);
            this.picPersonalInfo.Name = "picPersonalInfo";
            this.picPersonalInfo.Size = new System.Drawing.Size(75, 76);
            this.picPersonalInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonalInfo.TabIndex = 10;
            this.picPersonalInfo.TabStop = false;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.Location = new System.Drawing.Point(264, 50);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(562, 59);
            this.lblRegistration.TabIndex = 9;
            this.lblRegistration.Text = "PERSONAL INFORMATION";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(860, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "*EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(860, 30);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(86, 39);
            this.btnDone.TabIndex = 49;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminID.Location = new System.Drawing.Point(24, 162);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(154, 31);
            this.lblAdminID.TabIndex = 8;
            this.lblAdminID.Text = "ADMIN ID    :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(24, 264);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(223, 28);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name                  :";
            // 
            // lblWorkingExp
            // 
            this.lblWorkingExp.AutoSize = true;
            this.lblWorkingExp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkingExp.Location = new System.Drawing.Point(24, 398);
            this.lblWorkingExp.Name = "lblWorkingExp";
            this.lblWorkingExp.Size = new System.Drawing.Size(222, 28);
            this.lblWorkingExp.TabIndex = 10;
            this.lblWorkingExp.Text = "Working Experience    :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(24, 530);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(221, 28);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email                          :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.Location = new System.Drawing.Point(200, 165);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(2, 27);
            this.lblUserID.TabIndex = 12;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactNumber.Location = new System.Drawing.Point(501, 398);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(203, 28);
            this.lblContactNumber.TabIndex = 13;
            this.lblContactNumber.Text = "Contact Number      :";
            // 
            // lblOfficeLocation
            // 
            this.lblOfficeLocation.AutoSize = true;
            this.lblOfficeLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOfficeLocation.Location = new System.Drawing.Point(501, 530);
            this.lblOfficeLocation.Name = "lblOfficeLocation";
            this.lblOfficeLocation.Size = new System.Drawing.Size(202, 28);
            this.lblOfficeLocation.TabIndex = 14;
            this.lblOfficeLocation.Text = "Office Location        :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(501, 261);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(203, 28);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name               :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(256, 261);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(201, 34);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtWorkingExp
            // 
            this.txtWorkingExp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWorkingExp.Location = new System.Drawing.Point(256, 398);
            this.txtWorkingExp.Multiline = true;
            this.txtWorkingExp.Name = "txtWorkingExp";
            this.txtWorkingExp.PlaceholderText = "Working Experience";
            this.txtWorkingExp.ReadOnly = true;
            this.txtWorkingExp.Size = new System.Drawing.Size(201, 35);
            this.txtWorkingExp.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(256, 527);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(201, 34);
            this.txtEmail.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(710, 261);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(235, 34);
            this.txtLastName.TabIndex = 22;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(710, 398);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PlaceholderText = "Contact Number";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(235, 35);
            this.txtContactNo.TabIndex = 23;
            // 
            // txtOfficeLocation
            // 
            this.txtOfficeLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOfficeLocation.Location = new System.Drawing.Point(710, 527);
            this.txtOfficeLocation.Multiline = true;
            this.txtOfficeLocation.Name = "txtOfficeLocation";
            this.txtOfficeLocation.PlaceholderText = "Office Location";
            this.txtOfficeLocation.ReadOnly = true;
            this.txtOfficeLocation.Size = new System.Drawing.Size(235, 34);
            this.txtOfficeLocation.TabIndex = 24;
            // 
            // frmAdminPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txtOfficeLocation);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWorkingExp);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOfficeLocation);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWorkingExp);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.pnlPersonalInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminPersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Info";
            this.Load += new System.EventHandler(this.AdminPersonalInfo_Load);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picPersonalInfo;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblWorkingExp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtWorkingExp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOfficeLocation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDone;
    }
}