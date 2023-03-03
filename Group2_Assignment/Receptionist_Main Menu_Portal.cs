using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frm_Main_Menu : Form
    {
        public string r_id { get; set; }
        public static string id;
        private Color _formColor;
        public frm_Main_Menu()
        {
            InitializeComponent();
        }
        bool isCollapsed = true;
        private void button1_Click(object sender, EventArgs e)
        {
        }

        public frm_Main_Menu (string un,Color formColor)
        {
            InitializeComponent();
            id = un;
            _formColor = formColor;
        }
        public frm_Main_Menu(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Student_Registration_Section_A thirdForm = new frm_Student_Registration_Section_A();
            thirdForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_payment_Section_A forthForm = new frm_payment_Section_A();
            forthForm.ShowDialog(); 
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_generate_Receipt fifthForm = new frm_generate_Receipt();
            fifthForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_delete_student_page_1 sixForm = new frm_delete_student_page_1();
            sixForm.ShowDialog();
        }

        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            r_id = id;
            this.Hide();
            frm_update_profile sevenForm = new frm_update_profile();
            sevenForm.r_ID = r_id;
            sevenForm.ShowDialog();
        }

        private void btn_update_subject_enrolment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_update_subject_enrolment_page1 eightForm = new frm_update_subject_enrolment_page1();
            eightForm.ShowDialog();
        }
        private void frm_Main_Menu_Load(object sender, EventArgs e)
        {
            LoginPage main = new LoginPage();
            main.Hide();
            ps_setting.Size = ps_setting.MinimumSize;
            lbl_user_name.Text = "Hello, " + id;
            lbl_user_name.Left = (this.Width - lbl_user_name.Width) / 2;
            ps_setting.Size = ps_setting.MinimumSize;
            //this.BackColor = _formColor;
            this.BackColor = Color.FromArgb(254, 251, 233);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                ps_setting.Size = ps_setting.MaximumSize;
                if (ps_setting.Height >= ps_setting.MaximumSize.Height)
                {
                    isCollapsed = false;
                }

            }

            else
            {
                ps_setting.Size = ps_setting.MinimumSize;
                if (ps_setting.Height <= ps_setting.MinimumSize.Height)
                {
                    isCollapsed = true;

                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage nineForm = new LoginPage();
            nineForm.ShowDialog();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            frm_Receptionist_Theme twelveForm = new frm_Receptionist_Theme(this.BackColor);
            twelveForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            r_id = id;
            this.Hide();
            frm_Receptionist_Change_Password elevenForm = new frm_Receptionist_Change_Password();
            elevenForm.r_id = r_id;
            elevenForm.ShowDialog();
        }

        private void btnUpdateSecurityQuestions_Click(object sender, EventArgs e)
        {
            r_id = id;
            this.Hide();
            frm_Receptionist_Security_Questions tenForm = new frm_Receptionist_Security_Questions();
            tenForm.r_id = r_id;
            tenForm.ShowDialog();
        }
    }
}
