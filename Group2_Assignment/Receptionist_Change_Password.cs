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
    public partial class frm_Receptionist_Change_Password : Form
    {
        public frm_Receptionist_Change_Password()
        {
            InitializeComponent();
        }
        public string r_id { get; set; }
        private bool isCurrentPassVisible = false;
        private bool isNewPassVisible = false;
        private bool isConfirmPassVisible = false;

        private void frm_Receptionist_Change_Password_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(r_id);
            Receptionist.viewPassword(obj1);
            txtCurrentPass.Text = obj1.Receptionist_pass;
            txtCurrentPass.ReadOnly = true;

            if (isCurrentPassVisible)
            {
                txtCurrentPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPass.UseSystemPasswordChar = true;
            }

            if (isNewPassVisible)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }

            if (isConfirmPassVisible)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtConfirmPass.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtNewPass.Focus();
            }

            else if (txtNewPass.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                txtNewPass.Focus();
            }

            else if (!Regex.IsMatch(txtNewPass.Text, "[a-z]"))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.");
                txtNewPass.Focus();
            }
            else if (!Regex.IsMatch(txtNewPass.Text, "[A-Z]"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.");
                txtNewPass.Focus();
            }
            else if (!Regex.IsMatch(txtNewPass.Text, "[0-9]"))
            {
                MessageBox.Show("Password must contain at least one digit.");
                txtNewPass.Focus();
            }
            else if (!Regex.IsMatch(txtNewPass.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Password must contain at least one special character.");
                txtNewPass.Focus();
            }

            else if (txtNewPass.Text != txtConfirmPass.Text)
            {
                // Passwords do not match, display error message and clear confirm password text box
                MessageBox.Show("Confirm password does not match current password. Please try again.");
                txtConfirmPass.Clear();
                txtConfirmPass.Focus();
            }

            else
            {
                Receptionist obj1 = new Receptionist(r_id);
                MessageBox.Show(obj1.updatePassword(txtConfirmPass.Text, r_id));
            }
        }

        private void pbCurPassShow_Click(object sender, EventArgs e)
        {
            pbCurPassHide.Show();
            pbCurPassShow.Hide();
            isCurrentPassVisible = true;
            txtCurrentPass.UseSystemPasswordChar = false;
        }
        private void pbNewPassHide_Click_1(object sender, EventArgs e)
        {
            pbNewPassShow.Show();
            pbNewPassHide.Hide();
            isNewPassVisible = false;
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void pbNewPassShow_Click_1(object sender, EventArgs e)
        {
            pbNewPassHide.Show();
            pbNewPassShow.Hide();
            isNewPassVisible = true;
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void pbConPassShow_Click_1(object sender, EventArgs e)
        {
            pbConPassHide.Show();
            pbConPassShow.Hide();
            isConfirmPassVisible = true;
            txtConfirmPass.UseSystemPasswordChar = false;
        }

        private void pbConPassHide_Click_1(object sender, EventArgs e)
        {
            pbConPassShow.Show();
            pbConPassHide.Hide();
            isConfirmPassVisible = false;
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void pbCurPassHide_Click_1(object sender, EventArgs e)
        {
            pbCurPassShow.Show();
            pbCurPassHide.Hide();
            isCurrentPassVisible = false;
            txtCurrentPass.UseSystemPasswordChar = true;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the change password page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frm_Main_Menu am = new frm_Main_Menu();
                am.ShowDialog();
            }
        }
    }
}
