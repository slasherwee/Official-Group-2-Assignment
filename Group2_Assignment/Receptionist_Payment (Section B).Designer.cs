namespace Group2_Assignment
{
    partial class frm_payment_section_b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_payment_section_b));
            this.lbl_total_amount_1 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_payment_method = new System.Windows.Forms.Label();
            this.cb_payment_method = new System.Windows.Forms.ComboBox();
            this.txt_stud_name = new System.Windows.Forms.TextBox();
            this.lbl_stud_id = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.txt_stud_id = new System.Windows.Forms.TextBox();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.lbl_total_amount = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lblstudname = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pb_payment_logo = new System.Windows.Forms.PictureBox();
            this.grb_payment = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_payment_logo)).BeginInit();
            this.grb_payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total_amount_1
            // 
            this.lbl_total_amount_1.AutoSize = true;
            this.lbl_total_amount_1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total_amount_1.Location = new System.Drawing.Point(207, 258);
            this.lbl_total_amount_1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_total_amount_1.Name = "lbl_total_amount_1";
            this.lbl_total_amount_1.Size = new System.Drawing.Size(0, 32);
            this.lbl_total_amount_1.TabIndex = 35;
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_date.Location = new System.Drawing.Point(710, 90);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(237, 27);
            this.dtp_date.TabIndex = 33;
            this.dtp_date.Value = new System.DateTime(2023, 2, 11, 0, 0, 0, 0);
            // 
            // lbl_payment_method
            // 
            this.lbl_payment_method.AutoSize = true;
            this.lbl_payment_method.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_payment_method.Location = new System.Drawing.Point(492, 176);
            this.lbl_payment_method.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_payment_method.Name = "lbl_payment_method";
            this.lbl_payment_method.Size = new System.Drawing.Size(197, 31);
            this.lbl_payment_method.TabIndex = 30;
            this.lbl_payment_method.Text = "Payment Method:";
            // 
            // cb_payment_method
            // 
            this.cb_payment_method.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_payment_method.FormattingEnabled = true;
            this.cb_payment_method.Items.AddRange(new object[] {
            "Cash",
            "E-Wallet",
            "Online Banking",
            "Cheque"});
            this.cb_payment_method.Location = new System.Drawing.Point(710, 172);
            this.cb_payment_method.Margin = new System.Windows.Forms.Padding(1);
            this.cb_payment_method.Name = "cb_payment_method";
            this.cb_payment_method.Size = new System.Drawing.Size(237, 39);
            this.cb_payment_method.TabIndex = 29;
            // 
            // txt_stud_name
            // 
            this.txt_stud_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stud_name.Location = new System.Drawing.Point(207, 176);
            this.txt_stud_name.Margin = new System.Windows.Forms.Padding(1);
            this.txt_stud_name.Name = "txt_stud_name";
            this.txt_stud_name.Size = new System.Drawing.Size(228, 39);
            this.txt_stud_name.TabIndex = 26;
            // 
            // lbl_stud_id
            // 
            this.lbl_stud_id.AutoSize = true;
            this.lbl_stud_id.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_stud_id.Location = new System.Drawing.Point(13, 90);
            this.lbl_stud_id.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_stud_id.Name = "lbl_stud_id";
            this.lbl_stud_id.Size = new System.Drawing.Size(130, 31);
            this.lbl_stud_id.TabIndex = 25;
            this.lbl_stud_id.Text = "Student ID:";
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_remarks.Location = new System.Drawing.Point(259, 333);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(1);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(581, 39);
            this.txt_remarks.TabIndex = 24;
            // 
            // txt_stud_id
            // 
            this.txt_stud_id.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stud_id.Location = new System.Drawing.Point(207, 86);
            this.txt_stud_id.Margin = new System.Windows.Forms.Padding(1);
            this.txt_stud_id.Name = "txt_stud_id";
            this.txt_stud_id.Size = new System.Drawing.Size(228, 39);
            this.txt_stud_id.TabIndex = 7;
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.AutoSize = true;
            this.lbl_remarks.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_remarks.Location = new System.Drawing.Point(139, 336);
            this.lbl_remarks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(108, 31);
            this.lbl_remarks.TabIndex = 4;
            this.lbl_remarks.Text = "Remarks:";
            // 
            // lbl_total_amount
            // 
            this.lbl_total_amount.AutoSize = true;
            this.lbl_total_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total_amount.Location = new System.Drawing.Point(15, 258);
            this.lbl_total_amount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_total_amount.Name = "lbl_total_amount";
            this.lbl_total_amount.Size = new System.Drawing.Size(160, 31);
            this.lbl_total_amount.TabIndex = 2;
            this.lbl_total_amount.Text = "Total Amount:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(492, 86);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(69, 31);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date:";
            // 
            // lblstudname
            // 
            this.lblstudname.AutoSize = true;
            this.lblstudname.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstudname.Location = new System.Drawing.Point(12, 176);
            this.lblstudname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblstudname.Name = "lblstudname";
            this.lblstudname.Size = new System.Drawing.Size(168, 31);
            this.lblstudname.TabIndex = 0;
            this.lblstudname.Text = "Student Name:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(20, 575);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(1);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(149, 68);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_proceed.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_proceed.ForeColor = System.Drawing.Color.White;
            this.btn_proceed.Location = new System.Drawing.Point(808, 575);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(1);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(149, 68);
            this.btn_proceed.TabIndex = 15;
            this.btn_proceed.Text = "PROCEED";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.btn_generate_receipt_Click);
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.lbl_payment.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_payment.Location = new System.Drawing.Point(-44, -3);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(1088, 135);
            this.lbl_payment.TabIndex = 36;
            this.lbl_payment.Text = "                                   \r\n                                            " +
    "      PAYMENT                                                    \r\n             " +
    "           ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(33, 36);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 59);
            this.btnBack.TabIndex = 56;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pb_payment_logo
            // 
            this.pb_payment_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pb_payment_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_payment_logo.Image")));
            this.pb_payment_logo.Location = new System.Drawing.Point(291, 21);
            this.pb_payment_logo.Name = "pb_payment_logo";
            this.pb_payment_logo.Size = new System.Drawing.Size(104, 95);
            this.pb_payment_logo.TabIndex = 58;
            this.pb_payment_logo.TabStop = false;
            // 
            // grb_payment
            // 
            this.grb_payment.Controls.Add(this.lbl_total_amount_1);
            this.grb_payment.Controls.Add(this.dtp_date);
            this.grb_payment.Controls.Add(this.lbl_payment_method);
            this.grb_payment.Controls.Add(this.cb_payment_method);
            this.grb_payment.Controls.Add(this.txt_stud_name);
            this.grb_payment.Controls.Add(this.lbl_stud_id);
            this.grb_payment.Controls.Add(this.txt_remarks);
            this.grb_payment.Controls.Add(this.txt_stud_id);
            this.grb_payment.Controls.Add(this.lbl_remarks);
            this.grb_payment.Controls.Add(this.lbl_total_amount);
            this.grb_payment.Controls.Add(this.lbl_date);
            this.grb_payment.Controls.Add(this.lblstudname);
            this.grb_payment.Location = new System.Drawing.Point(20, 145);
            this.grb_payment.Margin = new System.Windows.Forms.Padding(1);
            this.grb_payment.Name = "grb_payment";
            this.grb_payment.Padding = new System.Windows.Forms.Padding(1);
            this.grb_payment.Size = new System.Drawing.Size(948, 414);
            this.grb_payment.TabIndex = 4;
            this.grb_payment.TabStop = false;
            this.grb_payment.Text = "Payment";
            // 
            // frm_payment_section_b
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pb_payment_logo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.grb_payment);
            this.Controls.Add(this.btn_proceed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frm_payment_section_b";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frm_payment_section_b_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_payment_logo)).EndInit();
            this.grb_payment.ResumeLayout(false);
            this.grb_payment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_cancel;
        private DateTimePicker dtp_date;
        private Label lbl_payment_method;
        private ComboBox cb_payment_method;
        private TextBox txt_stud_name;
        private Label lbl_stud_id;
        private TextBox txt_remarks;
        private Button btn_proceed;
        private TextBox txt_stud_id;
        private Label lbl_remarks;
        private Label lbl_total_amount;
        private Label lbl_date;
        private Label lblstudname;
        private Label lbl_total_amount_1;
        private Label lbl_payment;
        private Button btnBack;
        private PictureBox pb_payment_logo;
        private GroupBox grb_payment;
    }
}