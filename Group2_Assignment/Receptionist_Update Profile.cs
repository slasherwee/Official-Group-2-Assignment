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
    public partial class frm_update_profile : Form
    {
        public static string id;
        public string r_ID { get; set; }
        public frm_update_profile()
        {
            InitializeComponent();
        }
        public frm_update_profile(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblUserID.Text = r_ID;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_working_experience.ReadOnly = false;
            txt_office_location.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_contact_num.ReadOnly = false;

            if (string.IsNullOrWhiteSpace(txt_fname.Text) ||
                string.IsNullOrWhiteSpace(txt_lname.Text) ||
                string.IsNullOrWhiteSpace(txt_working_experience.Text) ||
                string.IsNullOrWhiteSpace(txt_office_location.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_contact_num.Text))
            {
                MessageBox.Show("Please fill in all the fields.");

            }

            else if (txt_fname.TextLength > 20)
            {
                MessageBox.Show("First name cannot exceed 20 characters.");
                txt_fname.Text = txt_fname.Text.Substring(0, 20);
                txt_fname.SelectionStart = 20;
                txt_fname.Focus();
            }

            else if (txt_lname.TextLength > 20)
            {
                MessageBox.Show("Last name cannot exceed 20 characters.");
                txt_lname.Text = txt_lname.Text.Substring(0, 20);
                txt_lname.SelectionStart = 20;
                txt_lname.Focus();
            }


            else if (!int.TryParse(txt_working_experience.Text, out int working_ex) || working_ex < 1 || working_ex > 100)
            {
                MessageBox.Show("Please enter a valid teaching experience (1-100).");
                txt_working_experience.Focus();
            }

            else if (!Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // check email format
            {
                MessageBox.Show("Please enter a valid email address.");
                txt_email.Focus();
            }

            else if (txt_email.TextLength > 20)
            {
                MessageBox.Show("Email cannot exceed 20 characters.");
                txt_email.Text = txt_email.Text.Substring(0, 20);
                txt_email.SelectionStart = 20;
                txt_email.Focus();
            }

            else if (!int.TryParse(txt_contact_num.Text.Replace("-", ""), out int contact_no))
            {
                MessageBox.Show("Please enter a valid contact number.");
                txt_contact_num.Focus();
            }

            else if (!Regex.IsMatch(txt_contact_num.Text, @"^01[0-9]-\d{7,8}$")) // Malaysian phone number format
            {
                MessageBox.Show("Please enter a valid Malaysian phone number (01X-XXXXXXX or 01X-XXXXXXXX).");
                txt_contact_num.Focus();
            }

            else
            {
                Receptionist obj1 = new Receptionist(r_ID);
                MessageBox.Show(obj1.updateProfile(txt_fname.Text, txt_lname.Text, txt_working_experience.Text, txt_office_location.Text, txt_email.Text, txt_contact_num.Text));
                lblUserID.Text = r_ID;
                txt_fname.ReadOnly = true;
                txt_lname.ReadOnly = true;
                txt_working_experience.ReadOnly = true;
                txt_office_location.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_contact_num.ReadOnly = true;
            }
        }
        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_update_profile_Load(object sender, EventArgs e)
        {
            lblUserID.Text = r_ID;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_working_experience.ReadOnly = true;
            txt_office_location.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_contact_num.ReadOnly = true;

        Receptionist obj1 = new Receptionist(r_ID);

            //calling static method require className.Method(..)
            //pass object obj1 to method ViewProfile
            Receptionist.viewProfile(obj1);

            txt_fname.Text = obj1.FName;
            txt_lname.Text = obj1.LName;
            txt_working_experience.Text = obj1.WorkingEx.ToString();
            txt_office_location.Text = obj1.Location;
            txt_email.Text = obj1.Email;
            txt_contact_num.Text = obj1.Contactno;
        }
    }
}
