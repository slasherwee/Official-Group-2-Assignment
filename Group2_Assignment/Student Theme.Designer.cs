namespace Group2_Assignment
{
    partial class Student_Theme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Theme));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radLight = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.radAuto = new System.Windows.Forms.RadioButton();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.panelTutor.Controls.Add(this.btnBack);
            this.panelTutor.Controls.Add(this.pbProfile);
            this.panelTutor.Controls.Add(this.label1);
            this.panelTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTutor.Location = new System.Drawing.Point(0, 0);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(982, 117);
            this.panelTutor.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(38, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(316, 34);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(75, 52);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 11;
            this.pbProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(446, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "THEME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radBlack.Location = new System.Drawing.Point(780, 388);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(80, 32);
            this.radBlack.TabIndex = 10;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radLight
            // 
            this.radLight.AutoSize = true;
            this.radLight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radLight.Location = new System.Drawing.Point(485, 388);
            this.radLight.Name = "radLight";
            this.radLight.Size = new System.Drawing.Size(79, 32);
            this.radLight.TabIndex = 9;
            this.radLight.TabStop = true;
            this.radLight.Text = "Light";
            this.radLight.UseVisualStyleBackColor = true;
            this.radLight.CheckedChanged += new System.EventHandler(this.radLight_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(29)))));
            this.lblHeader.Location = new System.Drawing.Point(122, 232);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(399, 31);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Choose your preffered Theme Mode";
            // 
            // radAuto
            // 
            this.radAuto.AutoSize = true;
            this.radAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radAuto.Location = new System.Drawing.Point(122, 388);
            this.radAuto.Name = "radAuto";
            this.radAuto.Size = new System.Drawing.Size(163, 32);
            this.radAuto.TabIndex = 7;
            this.radAuto.TabStop = true;
            this.radAuto.Text = "Auto (Default)";
            this.radAuto.UseVisualStyleBackColor = true;
            this.radAuto.CheckedChanged += new System.EventHandler(this.radAuto_CheckedChanged);
            // 
            // Student_Theme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.radBlack);
            this.Controls.Add(this.radLight);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.radAuto);
            this.Controls.Add(this.panelTutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Theme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Theme";
            this.Load += new System.EventHandler(this.Student_Theme_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTutor;
        private Button btnBack;
        private PictureBox pbProfile;
        private Label label1;
        private RadioButton radBlack;
        private RadioButton radLight;
        private Label lblHeader;
        private RadioButton radAuto;
    }
}