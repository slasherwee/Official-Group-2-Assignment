namespace Group2_Assignment
{
    partial class frm_update_subject_enrolment_page1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_update_subject_enrolment_page1));
            this.lbl_update_subject_enrolment = new System.Windows.Forms.Label();
            this.dgv_update_subject_enrolment = new System.Windows.Forms.DataGridView();
            this.ANSWER = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_view_subject_enrolment = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pb_update_subject_enrolment_logo = new System.Windows.Forms.PictureBox();
            this.grb_delete_request = new System.Windows.Forms.GroupBox();
            this.btnDelReq = new System.Windows.Forms.Button();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lbl_request_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_subject_enrolment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update_subject_enrolment_logo)).BeginInit();
            this.grb_delete_request.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_update_subject_enrolment
            // 
            this.lbl_update_subject_enrolment.AutoSize = true;
            this.lbl_update_subject_enrolment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.lbl_update_subject_enrolment.Font = new System.Drawing.Font("Segoe UI", 18.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_update_subject_enrolment.Location = new System.Drawing.Point(-2, 0);
            this.lbl_update_subject_enrolment.Name = "lbl_update_subject_enrolment";
            this.lbl_update_subject_enrolment.Size = new System.Drawing.Size(1900, 228);
            this.lbl_update_subject_enrolment.TabIndex = 5;
            this.lbl_update_subject_enrolment.Text = "\r\n                                      UPDATE SUBJECT ENROLMENT                 " +
    "          \r\n                                         ";
            // 
            // dgv_update_subject_enrolment
            // 
            this.dgv_update_subject_enrolment.AllowUserToAddRows = false;
            this.dgv_update_subject_enrolment.AllowUserToDeleteRows = false;
            this.dgv_update_subject_enrolment.AllowUserToOrderColumns = true;
            this.dgv_update_subject_enrolment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.dgv_update_subject_enrolment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_update_subject_enrolment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ANSWER});
            this.dgv_update_subject_enrolment.Location = new System.Drawing.Point(10, 148);
            this.dgv_update_subject_enrolment.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_update_subject_enrolment.Name = "dgv_update_subject_enrolment";
            this.dgv_update_subject_enrolment.RowHeadersWidth = 102;
            this.dgv_update_subject_enrolment.RowTemplate.Height = 49;
            this.dgv_update_subject_enrolment.Size = new System.Drawing.Size(967, 326);
            this.dgv_update_subject_enrolment.TabIndex = 6;
            this.dgv_update_subject_enrolment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ANSWER
            // 
            this.ANSWER.HeaderText = "ANSWER";
            this.ANSWER.Items.AddRange(new object[] {
            "APPROVE",
            "DECLINE"});
            this.ANSWER.MinimumWidth = 12;
            this.ANSWER.Name = "ANSWER";
            this.ANSWER.Width = 250;
            // 
            // btn_view_subject_enrolment
            // 
            this.btn_view_subject_enrolment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_view_subject_enrolment.Font = new System.Drawing.Font("Segoe UI Semibold", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_view_subject_enrolment.ForeColor = System.Drawing.Color.White;
            this.btn_view_subject_enrolment.Location = new System.Drawing.Point(10, 548);
            this.btn_view_subject_enrolment.Margin = new System.Windows.Forms.Padding(1);
            this.btn_view_subject_enrolment.Name = "btn_view_subject_enrolment";
            this.btn_view_subject_enrolment.Size = new System.Drawing.Size(212, 83);
            this.btn_view_subject_enrolment.TabIndex = 8;
            this.btn_view_subject_enrolment.Text = "VIEW SUBJECT ENROLMENT";
            this.btn_view_subject_enrolment.UseVisualStyleBackColor = false;
            this.btn_view_subject_enrolment.Click += new System.EventHandler(this.btn_view_subject_enrolment_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(765, 548);
            this.btn_update.Margin = new System.Windows.Forms.Padding(1);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(212, 83);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(23, 36);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 59);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pb_update_subject_enrolment_logo
            // 
            this.pb_update_subject_enrolment_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pb_update_subject_enrolment_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_update_subject_enrolment_logo.Image")));
            this.pb_update_subject_enrolment_logo.Location = new System.Drawing.Point(237, 22);
            this.pb_update_subject_enrolment_logo.Name = "pb_update_subject_enrolment_logo";
            this.pb_update_subject_enrolment_logo.Size = new System.Drawing.Size(97, 100);
            this.pb_update_subject_enrolment_logo.TabIndex = 17;
            this.pb_update_subject_enrolment_logo.TabStop = false;
            // 
            // grb_delete_request
            // 
            this.grb_delete_request.Controls.Add(this.btnDelReq);
            this.grb_delete_request.Controls.Add(this.txtRequestID);
            this.grb_delete_request.Controls.Add(this.lbl_request_id);
            this.grb_delete_request.Location = new System.Drawing.Point(383, 504);
            this.grb_delete_request.Name = "grb_delete_request";
            this.grb_delete_request.Size = new System.Drawing.Size(250, 141);
            this.grb_delete_request.TabIndex = 47;
            this.grb_delete_request.TabStop = false;
            this.grb_delete_request.Text = "Delete Request";
            this.grb_delete_request.Enter += new System.EventHandler(this.grbDeleteRequest_Enter);
            // 
            // btnDelReq
            // 
            this.btnDelReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDelReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btnDelReq.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.btnDelReq.Location = new System.Drawing.Point(52, 73);
            this.btnDelReq.Name = "btnDelReq";
            this.btnDelReq.Size = new System.Drawing.Size(158, 64);
            this.btnDelReq.TabIndex = 47;
            this.btnDelReq.Text = "DELETE";
            this.btnDelReq.UseVisualStyleBackColor = false;
            this.btnDelReq.Click += new System.EventHandler(this.btnDelReq_Click);
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(126, 36);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(109, 43);
            this.txtRequestID.TabIndex = 46;
            // 
            // lbl_request_id
            // 
            this.lbl_request_id.AutoSize = true;
            this.lbl_request_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_request_id.Location = new System.Drawing.Point(6, 32);
            this.lbl_request_id.Name = "lbl_request_id";
            this.lbl_request_id.Size = new System.Drawing.Size(210, 48);
            this.lbl_request_id.TabIndex = 45;
            this.lbl_request_id.Text = "Request ID :";
            // 
            // frm_update_subject_enrolment_page1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grb_delete_request);
            this.Controls.Add(this.pb_update_subject_enrolment_logo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view_subject_enrolment);
            this.Controls.Add(this.dgv_update_subject_enrolment);
            this.Controls.Add(this.lbl_update_subject_enrolment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frm_update_subject_enrolment_page1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Subject Enrolment";
            this.Load += new System.EventHandler(this.frm_update_subject_Enrolment_Page_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_subject_enrolment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update_subject_enrolment_logo)).EndInit();
            this.grb_delete_request.ResumeLayout(false);
            this.grb_delete_request.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_update_subject_enrolment;
        private DataGridView dgv_update_subject_enrolment;
        private Button btn_view_subject_enrolment;
        private Button btn_update;
        private DataGridViewComboBoxColumn ANSWER;
        private Button btnBack;
        private PictureBox pb_update_subject_enrolment_logo;
        private GroupBox grb_delete_request;
        private Button btnDelReq;
        private TextBox txtRequestID;
        private Label lbl_request_id;
    }
}