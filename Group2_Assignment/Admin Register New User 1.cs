using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class frmAdminRegisterNewUser1 : Form
    {
        public static string FirstName;
        public static string LastName;
        public static string ContactNo;
        public static string Email;
        public static string Password;
        public static string ConfirmPassword;
        public static string SecurityQuestion1;
        public static string SecurityQuestion2;
        private Color _formColor;

        public frmAdminRegisterNewUser1(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;

        }

        private void frmRegisterNewUser1_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmedPassword.Clear();
            txtSecurityQuestion1.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            ContactNo = txtContactNo.Text;
            Email = txtEmail.Text;
            Password = txtPassword.Text;
            ConfirmPassword = txtConfirmedPassword.Text;
            SecurityQuestion1 = txtSecurityQuestion1.Text;
            SecurityQuestion2 = txtSecurityQuestion2.Text;

            frmAdminRegisterNewUser2 rnu = new frmAdminRegisterNewUser2(_formColor);
            rnu.ShowDialog();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the new user registration page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu(_formColor);
                am.ShowDialog();
            }
        }
    }
}
