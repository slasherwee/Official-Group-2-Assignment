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
    public partial class Student_Change_Password : Form
    {
        public static string id;
        private Color _formColor;

        public Student_Change_Password()
        {
            InitializeComponent();
        }

        public Student_Change_Password(string i, Color formColor)
        {
            InitializeComponent();
            id = i;
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal sp = new Student_Portal(this.BackColor);
            sp.ShowDialog();
        }

        private void Student_Change_Password_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            pbCurPassShow.Hide();
            pbNewPassShow.Hide();
            pbConPassShow.Hide();
            Student obj1 = new Student(id);
            Student.viewPassword(obj1);
            txtCurrentPass.Text = obj1.Password;
            txtCurrentPass.ReadOnly = true;
            txtCurrentPass.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            else if (txtCurrentPass.Text == txtCurrentPass.Text)
            {
                MessageBox.Show("Old password is same as new password.");
            }
            else
            {
                Student obj1 = new Student(id);
                MessageBox.Show(obj1.changePassword(txtConfirmPass.Text, id));
            }
        }

        private void pbCurPassHide_Click(object sender, EventArgs e)
        {
            txtCurrentPass.UseSystemPasswordChar = false;
            pbCurPassHide.Hide();
            pbCurPassShow.Show();
        }

        private void pbCurPassShow_Click(object sender, EventArgs e)
        {
            txtCurrentPass.UseSystemPasswordChar = true;
            pbCurPassHide.Show();
            pbCurPassShow.Hide();
        }

        private void pbNewPassHide_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
            pbNewPassHide.Hide();
            pbNewPassShow.Show();
        }

        private void pbNewPassShow_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
            pbNewPassHide.Show();
            pbNewPassShow.Hide();
        }

        private void pbConPassHide_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = false;
            pbConPassHide.Hide();
            pbConPassShow.Show();
        }

        private void pbConPassShow_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
            pbConPassHide.Show();
            pbConPassShow.Hide();
        }
    }
}

