namespace Group2_Assignment
{
    partial class frm_payment_Section_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_payment_Section_A));
            this.btn_next = new System.Windows.Forms.Button();
            this.clb_select_subject = new System.Windows.Forms.CheckedListBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pb_payment_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_payment_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_next.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(805, 575);
            this.btn_next.Margin = new System.Windows.Forms.Padding(1);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(149, 68);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // clb_select_subject
            // 
            this.clb_select_subject.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_select_subject.FormattingEnabled = true;
            this.clb_select_subject.Items.AddRange(new object[] {
            "ETC_ENGF01",
            "ETC_ENGF02",
            "ETC_ENGF03",
            "ETC_ENGF04",
            "ETC_ENGF05",
            "ETC_MTSF01",
            "ETC_MTSF02",
            "ETC_MTSF03",
            "ETC_MTSF04",
            "ETC_MTSF05",
            "ETC_SCIF01",
            "ETC_SCIF02",
            "ETC_SCIF03",
            "ETC_SCIF04",
            "ETC_SCIF05"});
            this.clb_select_subject.Location = new System.Drawing.Point(88, 94);
            this.clb_select_subject.Margin = new System.Windows.Forms.Padding(1);
            this.clb_select_subject.Name = "clb_select_subject";
            this.clb_select_subject.Size = new System.Drawing.Size(722, 276);
            this.clb_select_subject.TabIndex = 16;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_subject.Location = new System.Drawing.Point(115, 51);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(91, 31);
            this.lbl_subject.TabIndex = 17;
            this.lbl_subject.Text = "Subject";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_subject);
            this.groupBox1.Controls.Add(this.clb_select_subject);
            this.groupBox1.Location = new System.Drawing.Point(17, 147);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(948, 420);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.lbl_payment.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_payment.Location = new System.Drawing.Point(-69, 0);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(1088, 135);
            this.lbl_payment.TabIndex = 37;
            this.lbl_payment.Text = "                                   \r\n                                            " +
    "      PAYMENT                                                    \r\n             " +
    "           ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(17, 40);
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
            this.pb_payment_logo.Location = new System.Drawing.Point(272, 23);
            this.pb_payment_logo.Name = "pb_payment_logo";
            this.pb_payment_logo.Size = new System.Drawing.Size(104, 95);
            this.pb_payment_logo.TabIndex = 57;
            this.pb_payment_logo.TabStop = false;
            // 
            // frm_payment_Section_A
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pb_payment_logo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_next);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frm_payment_Section_A";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frm_payment_Section_A_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_payment_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_next;
        private CheckedListBox clb_select_subject;
        private Label lbl_subject;
        private GroupBox groupBox1;
        private Label lbl_payment;
        private Button btnBack;
        private PictureBox pb_payment_logo;
    }
}