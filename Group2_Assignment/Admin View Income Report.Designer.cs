using Group2_Assignment.Properties;

namespace Group2_Assignment
{
    partial class frmAdminViewIncomeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminViewIncomeReport));
            this.pnlIncomeReport = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.picIncomeReport = new System.Windows.Forms.PictureBox();
            this.lblIncomeReport = new System.Windows.Forms.Label();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.pnlTotalIncome = new System.Windows.Forms.Panel();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlIncomeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncomeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            this.pnlTotalIncome.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIncomeReport
            // 
            this.pnlIncomeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIncomeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pnlIncomeReport.Controls.Add(this.btnBack);
            this.pnlIncomeReport.Controls.Add(this.picIncomeReport);
            this.pnlIncomeReport.Controls.Add(this.lblIncomeReport);
            this.pnlIncomeReport.Location = new System.Drawing.Point(-1, -7);
            this.pnlIncomeReport.Name = "pnlIncomeReport";
            this.pnlIncomeReport.Size = new System.Drawing.Size(993, 147);
            this.pnlIncomeReport.TabIndex = 3;
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
            // picIncomeReport
            // 
            this.picIncomeReport.BackColor = System.Drawing.Color.Transparent;
            this.picIncomeReport.Image = ((System.Drawing.Image)(resources.GetObject("picIncomeReport.Image")));
            this.picIncomeReport.Location = new System.Drawing.Point(234, 34);
            this.picIncomeReport.Name = "picIncomeReport";
            this.picIncomeReport.Size = new System.Drawing.Size(85, 85);
            this.picIncomeReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIncomeReport.TabIndex = 1;
            this.picIncomeReport.TabStop = false;
            // 
            // lblIncomeReport
            // 
            this.lblIncomeReport.AutoSize = true;
            this.lblIncomeReport.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncomeReport.Location = new System.Drawing.Point(343, 46);
            this.lblIncomeReport.Name = "lblIncomeReport";
            this.lblIncomeReport.Size = new System.Drawing.Size(370, 59);
            this.lblIncomeReport.TabIndex = 0;
            this.lblIncomeReport.Text = "INCOME REPORT";
            // 
            // dataGridViewIncome
            // 
            this.dataGridViewIncome.AllowUserToAddRows = false;
            this.dataGridViewIncome.AllowUserToDeleteRows = false;
            this.dataGridViewIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncome.Location = new System.Drawing.Point(37, 174);
            this.dataGridViewIncome.Name = "dataGridViewIncome";
            this.dataGridViewIncome.ReadOnly = true;
            this.dataGridViewIncome.RowHeadersWidth = 51;
            this.dataGridViewIncome.RowTemplate.Height = 29;
            this.dataGridViewIncome.Size = new System.Drawing.Size(680, 354);
            this.dataGridViewIncome.TabIndex = 4;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(10, 115);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 23);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(10, 191);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(62, 23);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month";
            // 
            // cmbYear
            // 
            this.cmbYear.AllowDrop = true;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(91, 112);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(127, 28);
            this.cmbYear.TabIndex = 9;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AllowDrop = true;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(91, 188);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(127, 28);
            this.cmbMonth.TabIndex = 10;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncome.Location = new System.Drawing.Point(14, 9);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(152, 28);
            this.lblTotalIncome.TabIndex = 13;
            this.lblTotalIncome.Text = "Total Income   ";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblIncome.Location = new System.Drawing.Point(77, 49);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(2, 27);
            this.lblIncome.TabIndex = 14;
            // 
            // pnlTotalIncome
            // 
            this.pnlTotalIncome.BackColor = System.Drawing.Color.Beige;
            this.pnlTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalIncome.Controls.Add(this.lblTotalIncome);
            this.pnlTotalIncome.Controls.Add(this.lblIncome);
            this.pnlTotalIncome.Location = new System.Drawing.Point(37, 548);
            this.pnlTotalIncome.Name = "pnlTotalIncome";
            this.pnlTotalIncome.Size = new System.Drawing.Size(680, 93);
            this.pnlTotalIncome.TabIndex = 15;
            // 
            // pnlFilterBy
            // 
            this.pnlFilterBy.AllowDrop = true;
            this.pnlFilterBy.BackColor = System.Drawing.Color.Beige;
            this.pnlFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterBy.Controls.Add(this.btnSelect);
            this.pnlFilterBy.Controls.Add(this.cmbYear);
            this.pnlFilterBy.Controls.Add(this.cmbMonth);
            this.pnlFilterBy.Controls.Add(this.lblYear);
            this.pnlFilterBy.Controls.Add(this.lblMonth);
            this.pnlFilterBy.Location = new System.Drawing.Point(740, 174);
            this.pnlFilterBy.Name = "pnlFilterBy";
            this.pnlFilterBy.Size = new System.Drawing.Size(230, 354);
            this.pnlFilterBy.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(754, 573);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 52);
            this.btnClear.TabIndex = 152;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(13, 262);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(194, 52);
            this.btnSelect.TabIndex = 151;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filter by";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Year";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 313;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Month";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 314;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Level";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(740, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 79);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminViewIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewIncome);
            this.Controls.Add(this.pnlIncomeReport);
            this.Controls.Add(this.pnlTotalIncome);
            this.Controls.Add(this.pnlFilterBy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminViewIncomeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Report";
            this.Load += new System.EventHandler(this.frmAdminViewIncomeReport_Load);
            this.pnlIncomeReport.ResumeLayout(false);
            this.pnlIncomeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncomeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            this.pnlTotalIncome.ResumeLayout(false);
            this.pnlTotalIncome.PerformLayout();
            this.pnlFilterBy.ResumeLayout(false);
            this.pnlFilterBy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIncomeReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picIncomeReport;
        private System.Windows.Forms.Label lblIncomeReport;
        private System.Windows.Forms.DataGridView dataGridViewIncome;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Panel pnlTotalIncome;
        private System.Windows.Forms.Panel pnlFilterBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
    }
}