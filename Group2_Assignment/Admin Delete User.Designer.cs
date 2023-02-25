namespace Group2_Assignment
{
    partial class frmAdminDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDeleteUser));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.pnlRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // pnlRegistration
            // 
            this.pnlRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlRegistration.Controls.Add(this.btnBack);
            this.pnlRegistration.Controls.Add(this.picLogo);
            this.pnlRegistration.Controls.Add(this.lblDeleteUser);
            this.pnlRegistration.Location = new System.Drawing.Point(-1, -7);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(993, 147);
            this.pnlRegistration.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(259, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteUser.Location = new System.Drawing.Point(380, 48);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(291, 59);
            this.lblDeleteUser.TabIndex = 0;
            this.lblDeleteUser.Text = "DELETE USER";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Tutor",
            "Receptionist"});
            this.cmbUserRole.Location = new System.Drawing.Point(199, 174);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(138, 31);
            this.cmbUserRole.TabIndex = 127;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserRole.Location = new System.Drawing.Point(37, 175);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(143, 28);
            this.lblUserRole.TabIndex = 129;
            this.lblUserRole.Text = "User Role      :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnDelete.Location = new System.Drawing.Point(784, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 60);
            this.btnDelete.TabIndex = 131;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AllowUserToAddRows = false;
            this.dataGridViewDelete.AllowUserToDeleteRows = false;
            this.dataGridViewDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(37, 227);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.ReadOnly = true;
            this.dataGridViewDelete.RowHeadersWidth = 51;
            this.dataGridViewDelete.RowTemplate.Height = 29;
            this.dataGridViewDelete.Size = new System.Drawing.Size(913, 327);
            this.dataGridViewDelete.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "UserID  :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbUserID);
            this.panel1.Location = new System.Drawing.Point(391, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 60);
            this.panel1.TabIndex = 135;
            // 
            // cmbUserID
            // 
            this.cmbUserID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(113, 17);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(207, 31);
            this.cmbUserID.TabIndex = 136;
            // 
            // frmAdminDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.dataGridViewDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminDeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbUserID;
    }
}