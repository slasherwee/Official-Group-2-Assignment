namespace Group2_Assignment
{
    partial class frm_generate_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_generate_Receipt));
            this.gb_receipt = new System.Windows.Forms.GroupBox();
            this.lbl_status_2 = new System.Windows.Forms.Label();
            this.lbl_receipt_no = new System.Windows.Forms.Label();
            this.txt_receipt_no = new System.Windows.Forms.TextBox();
            this.lbl_status_1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_stud_id = new System.Windows.Forms.Label();
            this.txt_stud_id = new System.Windows.Forms.TextBox();
            this.btn_generate_receipt = new System.Windows.Forms.Button();
            this.lbl_receipt = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pb_receipt_logo = new System.Windows.Forms.PictureBox();
            this.gb_receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_receipt_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_receipt
            // 
            this.gb_receipt.Controls.Add(this.lbl_status_2);
            this.gb_receipt.Controls.Add(this.lbl_receipt_no);
            this.gb_receipt.Controls.Add(this.txt_receipt_no);
            this.gb_receipt.Controls.Add(this.lbl_status_1);
            this.gb_receipt.Controls.Add(this.lbl_status);
            this.gb_receipt.Controls.Add(this.lbl_stud_id);
            this.gb_receipt.Controls.Add(this.txt_stud_id);
            this.gb_receipt.Location = new System.Drawing.Point(17, 155);
            this.gb_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.gb_receipt.Name = "gb_receipt";
            this.gb_receipt.Padding = new System.Windows.Forms.Padding(2);
            this.gb_receipt.Size = new System.Drawing.Size(948, 340);
            this.gb_receipt.TabIndex = 7;
            this.gb_receipt.TabStop = false;
            // 
            // lbl_status_2
            // 
            this.lbl_status_2.AutoSize = true;
            this.lbl_status_2.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_status_2.Location = new System.Drawing.Point(441, 245);
            this.lbl_status_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status_2.Name = "lbl_status_2";
            this.lbl_status_2.Size = new System.Drawing.Size(0, 32);
            this.lbl_status_2.TabIndex = 61;
            // 
            // lbl_receipt_no
            // 
            this.lbl_receipt_no.AutoSize = true;
            this.lbl_receipt_no.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_receipt_no.Location = new System.Drawing.Point(247, 32);
            this.lbl_receipt_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_receipt_no.Name = "lbl_receipt_no";
            this.lbl_receipt_no.Size = new System.Drawing.Size(134, 31);
            this.lbl_receipt_no.TabIndex = 60;
            this.lbl_receipt_no.Text = "Receipt No:";
            // 
            // txt_receipt_no
            // 
            this.txt_receipt_no.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_receipt_no.Location = new System.Drawing.Point(441, 28);
            this.txt_receipt_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_receipt_no.Name = "txt_receipt_no";
            this.txt_receipt_no.Size = new System.Drawing.Size(228, 39);
            this.txt_receipt_no.TabIndex = 59;
            // 
            // lbl_status_1
            // 
            this.lbl_status_1.AutoSize = true;
            this.lbl_status_1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_status_1.Location = new System.Drawing.Point(441, 187);
            this.lbl_status_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status_1.Name = "lbl_status_1";
            this.lbl_status_1.Size = new System.Drawing.Size(0, 32);
            this.lbl_status_1.TabIndex = 28;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.Location = new System.Drawing.Point(247, 187);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(83, 31);
            this.lbl_status.TabIndex = 27;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_stud_id
            // 
            this.lbl_stud_id.AutoSize = true;
            this.lbl_stud_id.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_stud_id.Location = new System.Drawing.Point(247, 108);
            this.lbl_stud_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stud_id.Name = "lbl_stud_id";
            this.lbl_stud_id.Size = new System.Drawing.Size(130, 31);
            this.lbl_stud_id.TabIndex = 25;
            this.lbl_stud_id.Text = "Student ID:";
            // 
            // txt_stud_id
            // 
            this.txt_stud_id.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stud_id.Location = new System.Drawing.Point(441, 104);
            this.txt_stud_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stud_id.Name = "txt_stud_id";
            this.txt_stud_id.Size = new System.Drawing.Size(228, 39);
            this.txt_stud_id.TabIndex = 7;
            // 
            // btn_generate_receipt
            // 
            this.btn_generate_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.btn_generate_receipt.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generate_receipt.ForeColor = System.Drawing.Color.White;
            this.btn_generate_receipt.Location = new System.Drawing.Point(749, 539);
            this.btn_generate_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generate_receipt.Name = "btn_generate_receipt";
            this.btn_generate_receipt.Size = new System.Drawing.Size(206, 85);
            this.btn_generate_receipt.TabIndex = 15;
            this.btn_generate_receipt.Text = "Generate Receipt";
            this.btn_generate_receipt.UseVisualStyleBackColor = false;
            this.btn_generate_receipt.Click += new System.EventHandler(this.btn_generate_receipt_Click);
            // 
            // lbl_receipt
            // 
            this.lbl_receipt.AutoSize = true;
            this.lbl_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.lbl_receipt.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_receipt.Location = new System.Drawing.Point(-5, -4);
            this.lbl_receipt.Name = "lbl_receipt";
            this.lbl_receipt.Size = new System.Drawing.Size(1062, 135);
            this.lbl_receipt.TabIndex = 29;
            this.lbl_receipt.Text = "                                        \r\n                                       " +
    "           RECEIPT                                                    \r\n        " +
    "                ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(28, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 59);
            this.btnBack.TabIndex = 57;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pb_receipt_logo
            // 
            this.pb_receipt_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pb_receipt_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_receipt_logo.Image")));
            this.pb_receipt_logo.Location = new System.Drawing.Point(374, 38);
            this.pb_receipt_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_receipt_logo.Name = "pb_receipt_logo";
            this.pb_receipt_logo.Size = new System.Drawing.Size(71, 78);
            this.pb_receipt_logo.TabIndex = 58;
            this.pb_receipt_logo.TabStop = false;
            // 
            // frm_generate_Receipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pb_receipt_logo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbl_receipt);
            this.Controls.Add(this.gb_receipt);
            this.Controls.Add(this.btn_generate_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_generate_Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Receipt";
            this.Load += new System.EventHandler(this.frm_generate_Receipt_Load);
            this.gb_receipt.ResumeLayout(false);
            this.gb_receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_receipt_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gb_receipt;
        private Label lbl_status_1;
        private Label lbl_status;
        private Label lbl_stud_id;
        private Button btn_generate_receipt;
        private TextBox txt_stud_id;
        private Label lbl_receipt;
        private Button btnBack;
        private PictureBox pb_receipt_logo;
        private Label lbl_receipt_no;
        private TextBox txt_receipt_no;
        private Label lbl_status_2;
    }
}