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
    public partial class frm_Student_Registration__Section_C_ : Form
    {
        public frm_Student_Registration__Section_C_()
        {
            InitializeComponent();
            dtp_year_of_enrolment.Format = DateTimePickerFormat.Custom;
            dtp_year_of_enrolment.CustomFormat = "yyyy";
            dtp_year_of_enrolment.ShowUpDown = true;
        }
        public string stud_ID { get; set; }

        private void cb_level_of_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_Registration__Section_C__Load(object sender, EventArgs e)
        {
            cb_level_of_subject.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_month_of_enrolment.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_num_of_sub.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sc_1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sc_2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sc_3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sub_1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sub_2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sub_3.DropDownStyle = ComboBoxStyle.DropDownList;
            pbar_student_registration.Minimum = 0;
            pbar_student_registration.Maximum = 100;
            pbar_student_registration.Value = 50;
        }

        private void btn_cancel_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Student_Registration__Section_B_ firstForm = new frm_Student_Registration__Section_B_();
            firstForm.stud_ID= this.stud_ID;
            firstForm.ShowDialog();
        }

        private void btn_proceed_3_Click(object sender, EventArgs e)
        {
            string year;
            int c = 10;
            int number;
            if (cb_level_of_subject.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Level of Subject Selection");
                return;
            }
            if (cb_month_of_enrolment.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Month Selection");
                return;
            }
            if (cb_num_of_sub.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Number of subject Selection");
                return;
            }
            if (cb_sc_1.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Code 1 Selection");
                return;
            }
            if (cb_sub_1.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Name 1 Selection");
                return;
            }
            if (cb_sub_2.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Name 2 Selection");
                return;
            }
            if (cb_sc_2.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Code 2 Selection");
                return;
            }
            if (cb_sub_3.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Name 3 Selection");
                return;
            }
            if (cb_sc_3.SelectedIndex == -1)
            {
                c = c - 1;
                MessageBox.Show("Please select an option", "Subject Code 3 Selection");
                return;
            }
            if (string.IsNullOrWhiteSpace(dtp_year_of_enrolment.Text))
            {
                c = c - 1;
                MessageBox.Show("Please enter year of enrolment", "Year of Enrolment");
                return;
            }

            if (dtp_year_of_enrolment.Text.Length > 0 && dtp_year_of_enrolment.Text.Length <5)
            {

                if (c == 10)
                {
                    year = dtp_year_of_enrolment.Text.ToString();
                    student_registration obj1 = new student_registration(stud_ID, cb_sc_2.Text, cb_sc_3.Text, cb_sub_2.Text, cb_sub_3.Text, cb_level_of_subject.Text, cb_month_of_enrolment.Text, year, cb_num_of_sub.Text, cb_sub_1.Text, cb_sc_1.Text);
                    obj1.InsertData_Section_C(stud_ID, cb_sc_2.Text, cb_sc_3.Text, cb_sub_2.Text, cb_sub_3.Text, cb_level_of_subject.Text, cb_month_of_enrolment.Text, year, cb_num_of_sub.Text, cb_sub_1.Text, cb_sc_1.Text);
                    this.Hide();
                    frm_Student_Registration__Section_D_ secondForm = new frm_Student_Registration__Section_D_();
                    secondForm.stud_ID = stud_ID;
                    secondForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Enrolment year should have four numbers only", "Enrolment Year");
                return;
            }
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
    }
}
