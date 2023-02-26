using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class frm_Student_Registration_Section_A : Form
    {
        public string stud_ID { get; set; }

        public frm_Student_Registration_Section_A()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
        }

        private void Student_Registration_Section_A_Load(object sender, EventArgs e)
        {
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_stud_ic_or_pass.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nationality.DropDownStyle = ComboBoxStyle.DropDownList;
            pbar_student_registration.Minimum = 0;
            pbar_student_registration.Maximum = 100;
            pbar_student_registration.Value = 0;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            int c = 0;
            int number;
            string pattern = @"^[a-zA-Z]+$";
            bool messageBoxShown = false;
            if (string.IsNullOrWhiteSpace(txt_fname.Text))
            {
                MessageBox.Show("Please enter first name", "First Name");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_lname.Text))
            {
                MessageBox.Show("Please enter last name", "Last Name");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_ic_pass.Text))
            {
                MessageBox.Show("Please enter IC/Passport number", "IC/Passport Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please enter email", "Email");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_house_address.Text))
            {
                MessageBox.Show("Please enter house address", "House Address");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_s_id.Text))
            {
                MessageBox.Show("Please enter Student ID", "Student ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_contact_number.Text))
            {
                MessageBox.Show("Please enter contact number");
            }
            while (!int.TryParse(txt_s_id.Text, out number))
            {
                if (!messageBoxShown)
                {
                    MessageBox.Show("Please enter a valid number.", "Student ID");
                    messageBoxShown = true;
                }
                break;
            }
            if (txt_s_id.Text.Length > 3)
            {
                MessageBox.Show("Student ID number should be less than 4 characters", "Student ID");
                txt_s_id.Focus();
                txt_s_id.SelectAll();
                c = c - 1;
            }


            if (txt_s_id.Text.Length > 3)
            {
                MessageBox.Show("Student ID number should be less than 4 characters", "Student ID");
                txt_s_id.Focus();
                txt_s_id.SelectAll();
                c = c - 1;
            }
            else
            {
                a = "ETC_STUD" + txt_s_id.Text;
                stud_ID = a;
                student_registration obj1 = new student_registration(cb_nationality.Text, dtp_dob.Text, txt_fname.Text, txt_lname.Text, txt_ic_pass.Text, cb_stud_ic_or_pass.Text, a, txt_house_address.Text, txt_contact_number.Text, txt_email.Text, cb_gender.Text);
                b = obj1.check_student_id(a);
                if (b == "Student ID Exist")
                {
                    MessageBox.Show("Student ID Exists", "Alert");
                    MessageBox.Show("Please enter another Student ID", "Alert");
                    b = " ";
                }
                else if (txt_s_id.Text == pattern)
                {
                    MessageBox.Show("Please enter numbers only for Student ID", "Student ID");
                }
                else
                {
                    if (Regex.IsMatch(txt_fname.Text, pattern))
                    {
                        if (Regex.IsMatch(txt_lname.Text, pattern))
                        {
                            c = c + 1;
                            if (txt_fname.Text.Length < 41)
                            {
                                c = c + 1;
                                if (txt_lname.Text.Length < 41)
                                {
                                    c = c + 1;
                                    if (txt_email.Text.Length < 41)
                                    {
                                        c = c + 1;
                                        if (Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                                        {
                                            c = c + 1;
                                            if (txt_house_address.Text.Length < 1001)
                                            {
                                                c = c + 1;
                                                if (txt_s_id.Text.Length < 11)
                                                {
                                                    c = c + 1;
                                                    if (txt_contact_number.Text.Length < 12)
                                                    {
                                                        c = c + 1;
                                                        if ((int.TryParse(txt_contact_number.Text.Replace("-", ""), out int contact_no)))
                                                        {
                                                            c = c + 1;
                                                            if ((Regex.IsMatch(txt_contact_number.Text, @"^01[0-9]-\d{7,8}$")))
                                                            {
                                                                c = c + 1;
                                                                if (txt_ic_pass.Text.Length < 11)
                                                                {
                                                                    c = c + 1;
                                                                    while (!int.TryParse(txt_ic_pass.Text, out number))
                                                                    {
                                                                        if (!messageBoxShown)
                                                                        {
                                                                            MessageBox.Show("Please enter a valid number", "IC/Passport Number");
                                                                            messageBoxShown = true;
                                                                        }
                                                                        txt_ic_pass.Focus();
                                                                        txt_ic_pass.SelectAll();
                                                                        c = c - 1;
                                                                        break;
                                                                    }
                                                                    if (cb_gender.SelectedIndex != -1)
                                                                    {
                                                                        c = c + 1;
                                                                        if (cb_nationality.SelectedIndex != -1)
                                                                        {
                                                                            c = c + 1;
                                                                            if (cb_stud_ic_or_pass.SelectedIndex != -1)
                                                                            {
                                                                                c = c + 1;
                                                                                if (c == 14)
                                                                                {
                                                                                    obj1.InsertData_Section_A(cb_nationality.Text, dtp_dob.Text, txt_fname.Text, txt_lname.Text, txt_ic_pass.Text, cb_stud_ic_or_pass.Text, a, txt_house_address.Text, txt_contact_number.Text, txt_email.Text, cb_gender.Text);
                                                                                    this.Hide();
                                                                                    frm_Student_Registration__Section_B_ secondForm = new frm_Student_Registration__Section_B_();
                                                                                    secondForm.stud_ID = stud_ID;
                                                                                    secondForm.Show();
                                                                                }
                                                                                else
                                                                                {
                                                                                    c = 0;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Please select an option", "IC/Passport Selection");
                                                                                return;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Please select an option", "Nationality Selection");
                                                                            return;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Please select an option", "Gender Selection");
                                                                        return;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("IC/Passport number should be less than 11 characters", "IC/Passport Number");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Please enter a valid Malaysian phone number (01X-XXXXXXX or 01X-XXXXXXXX)", "Contact Number");
                                                                txt_contact_number.Focus();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter a valid contact number", "Contact Number");
                                                            txt_contact_number.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Contact number should be less than 12 characters", "Contact Number");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Student ID should be less than 11 characters", "Student ID");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("House address should be less than 101 characters", "House Address");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid email address", "Email");
                                            txt_email.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email should be less than 41 characters", "Email");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Last name should be less than 41 characters", "Last Name");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("First name should be less than 41 characters", "First Name");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input contains invalid characters", "Last Name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input contains invalid characters", "First Name");
                    }
                }
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
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
                    frm_Main_Menu fifthForm = new frm_Main_Menu();
                    fifthForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Registration Cancelled", "Alert");
                    this.Hide();
                    frm_Main_Menu thirdForm = new frm_Main_Menu();
                    thirdForm.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                frm_Main_Menu forthForm = new frm_Main_Menu();
                forthForm.ShowDialog();
            }
        }
    }
}


