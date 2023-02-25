using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Group2_Assignment
{
    public partial class frm_Student_Registration__Section_D_ : Form
    {
        public frm_Student_Registration__Section_D_()
        {
            InitializeComponent();
        }
        public string stud_ID { get; set; }
        public string e;

        private void btn_proceed_4_Click(object sender, EventArgs e)
        {
            int c = 1;

            if (cb_activate_account.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Activate Account Selection");
                return;
            }
            if (c == 1)
            {
                if (cb_activate_account.Text == "Activate")
                {
                    student_registration obj1 = new student_registration(lbl_student_id.Text, cb_activate_account.Text);
                    MessageBox.Show(obj1.InsertData_Section_D(lbl_student_id.Text, cb_activate_account.Text));
                    pbar_student_registration.Value = 100;
                    MessageBox.Show("Temporary passowrd is : etc12345");
                    this.Hide();
                    frm_Main_Menu secondForm = new frm_Main_Menu();
                    secondForm.Show();
                }
                else
                    MessageBox.Show("Account must be activated in order to proceed with student registration", "Student Account Activation");
            }
            else
            {
                c = 0;
            }
        }

        private void btn_cancel_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Student_Registration__Section_C_ firstForm = new frm_Student_Registration__Section_C_();
            firstForm.stud_ID = stud_ID;
            firstForm.Show();
        }

        private void frm_Student_Registration__Section_D__Load(object sender, EventArgs e)
        {
            string g = null;
            string i = null;
            cb_activate_account.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_stud_id.Text = stud_ID.ToString();
            pbar_student_registration.Minimum = 0;
            pbar_student_registration.Maximum = 100;
            pbar_student_registration.Value = 75;
            student_registration obj3 = new student_registration(stud_ID);
            student_registration obj4 = new student_registration(stud_ID);
            g= obj3.DisplayData_SectionD_name_1(stud_ID);
            i= obj4.DisplayData_SectionD_name_2(stud_ID);
            lbl_student_name_1.Text = ((g) +" "+ (i));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string b = stud_ID;
            Delete_Student obj1 = new Delete_Student(stud_ID);
            b = obj1.find_student_id_delete(stud_ID);
            if (b == "Student ID exist")
            {
                string message = ("Are you sure you want to cancel " + stud_ID + " registration " + " ? ");
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Delete_Student obj2 = new Delete_Student(stud_ID);
                    obj2.delete_data_master(stud_ID);
                    MessageBox.Show(stud_ID + " registration has been deleted ");
                    this.Hide();
                    frm_Main_Menu secondForm = new frm_Main_Menu();
                    secondForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Registration Cancelled", "Alert");
                this.Hide();
                frm_Main_Menu thirdForm = new frm_Main_Menu();
                thirdForm.Show();
            }
        }

        private void grb_section_c_Enter(object sender, EventArgs e)
        {

        }
    }
}
