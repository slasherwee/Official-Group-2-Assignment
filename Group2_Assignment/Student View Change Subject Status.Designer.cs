namespace Group2_Assignment
{
    partial class Student_View_Change_Subject_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_View_Change_Subject_Status));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTutor = new Panel();
            pbViewRequest = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            dgvRequestStatus = new DataGridView();
            label1 = new Label();
            grbDeleteRequest = new GroupBox();
            btnDelReq = new Button();
            txtRequestID = new TextBox();
            panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbViewRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestStatus).BeginInit();
            grbDeleteRequest.SuspendLayout();
            SuspendLayout();
            // 
            // panelTutor
            // 
            panelTutor.BackColor = Color.FromArgb(225, 238, 221);
            panelTutor.Controls.Add(pbViewRequest);
            panelTutor.Controls.Add(btnBack);
            panelTutor.Controls.Add(lblTitle);
            panelTutor.Dock = DockStyle.Top;
            panelTutor.Location = new Point(0, 0);
            panelTutor.Name = "panelTutor";
            panelTutor.Size = new Size(982, 102);
            panelTutor.TabIndex = 43;
            // 
            // pbViewRequest
            // 
            pbViewRequest.BackColor = Color.FromArgb(225, 238, 221);
            pbViewRequest.Image = Properties.Resources.Request;
            pbViewRequest.Location = new Point(284, 35);
            pbViewRequest.Name = "pbViewRequest";
            pbViewRequest.Size = new Size(60, 38);
            pbViewRequest.SizeMode = PictureBoxSizeMode.Zoom;
            pbViewRequest.TabIndex = 8;
            pbViewRequest.TabStop = false;
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
            lblTitle.Location = new Point(350, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "VIEW REQUEST STATUS";
            // 
            // dgvRequestStatus
            // 
            dgvRequestStatus.AllowUserToAddRows = false;
            dgvRequestStatus.AllowUserToDeleteRows = false;
            dgvRequestStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequestStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 58, 29);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequestStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequestStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequestStatus.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequestStatus.Location = new Point(32, 178);
            dgvRequestStatus.Name = "dgvRequestStatus";
            dgvRequestStatus.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRequestStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRequestStatus.RowHeadersWidth = 51;
            dgvRequestStatus.RowTemplate.Height = 29;
            dgvRequestStatus.Size = new Size(918, 282);
            dgvRequestStatus.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 45;
            label1.Text = "Request ID :";
            // 
            // grbDeleteRequest
            // 
            grbDeleteRequest.Controls.Add(btnDelReq);
            grbDeleteRequest.Controls.Add(txtRequestID);
            grbDeleteRequest.Controls.Add(label1);
            grbDeleteRequest.Location = new Point(652, 488);
            grbDeleteRequest.Name = "grbDeleteRequest";
            grbDeleteRequest.Size = new Size(250, 141);
            grbDeleteRequest.TabIndex = 46;
            grbDeleteRequest.TabStop = false;
            grbDeleteRequest.Text = "Delete Change Subject Request";
            // 
            // btnDelReq
            // 
            btnDelReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnDelReq.BackColor = Color.FromArgb(24, 58, 29);
            btnDelReq.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelReq.ForeColor = Color.FromArgb(254, 251, 233);
            btnDelReq.Location = new Point(48, 79);
            btnDelReq.Name = "btnDelReq";
            btnDelReq.Size = new Size(158, 48);
            btnDelReq.TabIndex = 47;
            btnDelReq.Text = "DELETE";
            btnDelReq.UseVisualStyleBackColor = false;
            btnDelReq.Click += btnDelReq_Click;
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(126, 36);
            txtRequestID.MaxLength = 2;
            txtRequestID.Name = "txtRequestID";
            txtRequestID.PlaceholderText = "Request ID";
            txtRequestID.Size = new Size(109, 27);
            txtRequestID.TabIndex = 46;
            txtRequestID.KeyPress += txtRequestID_KeyPress;
            // 
            // Student_View_Change_Subject_Status
            // 
            AcceptButton = btnDelReq;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(254, 251, 233);
            CancelButton = btnBack;
            ClientSize = new Size(982, 653);
            Controls.Add(grbDeleteRequest);
            Controls.Add(dgvRequestStatus);
            Controls.Add(panelTutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_View_Change_Subject_Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Request Status";
            Load += Student_View_Change_Subject_Status_Load;
            panelTutor.ResumeLayout(false);
            panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbViewRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestStatus).EndInit();
            grbDeleteRequest.ResumeLayout(false);
            grbDeleteRequest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTutor;
        private PictureBox pbViewRequest;
        private Button btnBack;
        private Label lblTitle;
        private DataGridView dgvRequestStatus;
        private Label label1;
        private GroupBox grbDeleteRequest;
        private TextBox txtRequestID;
        private Button btnDelReq;
    }
}