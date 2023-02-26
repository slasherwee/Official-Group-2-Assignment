using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frm_Student_Registration__Section_B_ : Form
    {
        public string stud_ID { get; set; }
        public frm_Student_Registration__Section_B_()
        {
            InitializeComponent();
        }

        private void btn_cancel_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Student_Registration_Section_A firstForm = new frm_Student_Registration_Section_A();
            firstForm.stud_ID= stud_ID;
            firstForm.ShowDialog();
        }

        private void btn_proceed_2_Click(object sender, EventArgs e)
        {
            string b;
            int c = 0;
            int number;
            string pattern = @"^[a-zA-Z]+$";
            bool messageBoxShown = false;
            if (string.IsNullOrWhiteSpace(txt_fname_2.Text))
            {
                MessageBox.Show("Please enter first name", "First Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_lname_2.Text))
            {
                MessageBox.Show("Please enter last name", "Last Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ic_pass_2.Text))
            {
                MessageBox.Show("Please enter IC/Passport number", "IC/Passport Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_email_2.Text))
            {
                MessageBox.Show("Please enter email", "Email");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_contact_number_2.Text))
            {
                MessageBox.Show("Please enter contact number");
            }

            if (string.IsNullOrWhiteSpace(txt_occupation.Text))
            {
                MessageBox.Show("Please enter occupation", "Occupation");
                return;
            }

            if (Regex.IsMatch(txt_fname_2.Text, pattern))
            {
                c = c + 1;
                if (Regex.IsMatch(txt_lname_2.Text, pattern))
                {
                    c = c + 1;
                    if (Regex.IsMatch(txt_occupation.Text, pattern))
                    {
                        c = c + 1;
                        if (txt_email_2.Text.Length < 41)
                        {
                            c = c + 1;
                            if (Regex.IsMatch(txt_email_2.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            {
                                c = c + 1;
                                if (txt_fname_2.Text.Length < 41)
                                {
                                    c = c + 1;
                                    if (txt_lname_2.Text.Length < 41)
                                    {
                                        c = c + 1;
                                        if (txt_contact_number_2.Text.Length < 12)
                                        {
                                            c = c + 1;
                                            if ((int.TryParse(txt_contact_number_2.Text.Replace("-", ""), out int contact_no)))
                                            {
                                                c = c + 1;
                                                if ((Regex.IsMatch(txt_contact_number_2.Text, @"^01[0-9]-\d{7,8}$")))
                                                {
                                                    c = c + 1;
                                                    if (txt_occupation.Text.Length < 51)
                                                    {
                                                        c = c + 1;
                                                        if (cb_relationship.SelectedIndex != -1)
                                                        {
                                                            c = c + 1;
                                                            if (cb_pog_ic_or_pass.SelectedIndex != -1)
                                                            {
                                                                c = c + 1;
                                                                if (cb_gender.SelectedIndex != -1)
                                                                {
                                                                    c = c + 1;
                                                                    if (txt_ic_pass_2.Text.Length < 31)
                                                                    {
                                                                        c = c + 1;
                                                                        while (!int.TryParse(txt_ic_pass_2.Text, out number))
                                                                        {
                                                                            if (!messageBoxShown)
                                                                            {
                                                                                MessageBox.Show("Please enter a valid number", "IC/Passport Number");
                                                                                messageBoxShown = true;
                                                                            }
                                                                            txt_ic_pass_2.Focus();
                                                                            txt_ic_pass_2.SelectAll();
                                                                            c = c - 1;
                                                                            break;
                                                                        }
                                                                        if (c == 15)
                                                                        {
                                                                            student_registration obj1 = new student_registration(stud_ID, txt_fname_2.Text, txt_lname_2.Text, txt_ic_pass_2.Text, cb_pog_ic_or_pass.Text, txt_contact_number_2.Text, txt_email_2.Text, txt_occupation.Text, cb_relationship.Text, cb_gender.Text);
                                                                            obj1.InsertData_Section_B(stud_ID, txt_fname_2.Text, txt_lname_2.Text, txt_ic_pass_2.Text, cb_pog_ic_or_pass.Text, txt_contact_number_2.Text, txt_email_2.Text, txt_occupation.Text, cb_relationship.Text, cb_gender.Text);
                                                                            this.Hide();
                                                                            frm_Student_Registration__Section_C_ secondForm = new frm_Student_Registration__Section_C_();
                                                                            secondForm.stud_ID = stud_ID;
                                                                            secondForm.ShowDialog();
                                                                        }
                                                                        else
                                                                        {
                                                                            c = 0;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("IC/Passport number should be less than 31 characters", "IC/Passport Number");
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
                                                                MessageBox.Show("Please select an option", "IC/Passport Selection");
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please select an option", "Relationship Selection");
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Occupation should be less than 51 characters", "Occupation");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid Malaysian phone number (01X-XXXXXXX or 01X-XXXXXXXX)", "Contact Number");
                                                    txt_contact_number_2.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid contact number", "Contact Number");
                                                txt_contact_number_2.Focus();
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
                                MessageBox.Show("Please enter a valid email address", "Email");
                                txt_email_2.Focus();
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
                        MessageBox.Show("Input contains invalid characters", "Occupation");
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


        private void frm_Student_Registration__Section_B__Load(object sender, EventArgs e)
        {
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pog_ic_or_pass.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_relationship.DropDownStyle = ComboBoxStyle.DropDownList;
            pbar_student_registration.Minimum = 0;
            pbar_student_registration.Maximum = 100;
            pbar_student_registration.Value = 25;
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
                    secondForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Registration Cancelled", "Alert");
                this.Hide();
                frm_Main_Menu thirdForm = new frm_Main_Menu();
                thirdForm.ShowDialog();
            }
        }
    }
}
