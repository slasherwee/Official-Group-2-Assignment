namespace Group2_Assignment
{
    partial class Student_Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Fees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTutor = new Panel();
            btnBack = new Button();
            pbFee = new PictureBox();
            lblTitle = new Label();
            lblSortDate = new Label();
            cmbSortDate = new ComboBox();
            dgvFee = new DataGridView();
            receipt_no = new DataGridViewTextBoxColumn();
            payment_date = new DataGridViewTextBoxColumn();
            payment_total = new DataGridViewTextBoxColumn();
            payment_method = new DataGridViewTextBoxColumn();
            payment_remarks = new DataGridViewTextBoxColumn();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFee).BeginInit();
            SuspendLayout();
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(pbFee);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 17;
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
            // pbFee
            // 
            pbFee.BackColor = Color.FromArgb(225, 238, 221);
            pbFee.Image = Properties.Resources.Fee;
            pbFee.Location = new Point(342, 34);
            pbFee.Name = "pbFee";
            pbFee.Size = new Size(60, 38);
            pbFee.SizeMode = PictureBoxSizeMode.Zoom;
            pbFee.TabIndex = 11;
            pbFee.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(408, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 38);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "VIEW PAID FEES";
            // 
            // lblSortDate
            // 
            lblSortDate.AutoSize = true;
            lblSortDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSortDate.Location = new Point(60, 178);
            lblSortDate.Name = "lblSortDate";
            lblSortDate.Size = new Size(104, 28);
            lblSortDate.TabIndex = 18;
            lblSortDate.Text = "Sort Date :";
            // 
            // cmbSortDate
            // 
            cmbSortDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortDate.FormattingEnabled = true;
            cmbSortDate.Items.AddRange(new object[] { "Latest first", "Oldest first" });
            cmbSortDate.Location = new Point(170, 182);
            cmbSortDate.Name = "cmbSortDate";
            cmbSortDate.Size = new Size(151, 28);
            cmbSortDate.TabIndex = 20;
            cmbSortDate.SelectedIndexChanged += cmbSortDate_SelectedIndexChanged;
            // 
            // dgvFee
            // 
            dgvFee.AllowUserToAddRows = false;
            dgvFee.AllowUserToDeleteRows = false;
            dgvFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFee.Columns.AddRange(new DataGridViewColumn[] { receipt_no, payment_date, payment_total, payment_method, payment_remarks });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFee.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFee.Location = new Point(60, 237);
            dgvFee.Name = "dgvFee";
            dgvFee.ReadOnly = true;
            dgvFee.RowHeadersWidth = 51;
            dgvFee.RowTemplate.Height = 29;
            dgvFee.Size = new Size(854, 334);
            dgvFee.TabIndex = 22;
            // 
            // receipt_no
            // 
            receipt_no.DataPropertyName = "receipt_no";
            receipt_no.HeaderText = "Receipt No";
            receipt_no.MinimumWidth = 6;
            receipt_no.Name = "receipt_no";
            receipt_no.ReadOnly = true;
            receipt_no.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_date
            // 
            payment_date.DataPropertyName = "payment_date";
            payment_date.HeaderText = "Date";
            payment_date.MinimumWidth = 6;
            payment_date.Name = "payment_date";
            payment_date.ReadOnly = true;
            payment_date.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_total
            // 
            payment_total.DataPropertyName = "payment_total";
            payment_total.HeaderText = "Total";
            payment_total.MinimumWidth = 6;
            payment_total.Name = "payment_total";
            payment_total.ReadOnly = true;
            payment_total.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_method
            // 
            payment_method.DataPropertyName = "payment_method";
            payment_method.HeaderText = "Payment Method";
            payment_method.MinimumWidth = 6;
            payment_method.Name = "payment_method";
            payment_method.ReadOnly = true;
            payment_method.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_remarks
            // 
            payment_remarks.DataPropertyName = "payment_remarks";
            payment_remarks.HeaderText = "Remarks";
            payment_remarks.MinimumWidth = 6;
            payment_remarks.Name = "payment_remarks";
            payment_remarks.ReadOnly = true;
            payment_remarks.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Student_Fees
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvFee);
            Controls.Add(cmbSortDate);
            Controls.Add(lblSortDate);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            Load += Student_Fees_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTutor;
        private Button btnBack;
        private PictureBox pbFee;
        private Label lblTitle;
        private Label lblSortDate;
        private ComboBox cmbSortDate;
        private DataGridView dgvFee;
        private DataGridViewTextBoxColumn receipt_no;
        private DataGridViewTextBoxColumn payment_date;
        private DataGridViewTextBoxColumn payment_total;
        private DataGridViewTextBoxColumn payment_method;
        private DataGridViewTextBoxColumn payment_remarks;
    }
}