using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class frmAdminPersonalInfo : Form
    {
        public static string UserID;//global variable
        private Color _formColor;

        public frmAdminPersonalInfo(string id, Color formColor)
        {
            InitializeComponent();
            UserID = id;
            _formColor = formColor;
        }

        private void AdminPersonalInfo_Load(object sender, EventArgs e)
        {
            //Disable textbox for editing
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtWorkingExp.ReadOnly = true;
            txtOfficeLocation.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContactNo.ReadOnly = true;
            //Hide button name as btnDone
            btnDone.Hide();

            this.BackColor = _formColor;

            lblUserID.Text = UserID;
            Admin obj1 = new Admin(UserID);

            //calling static method require className.Method(obj1)
            //pass object obj1 through method ViewProfile
            Admin.ViewProfile(obj1);
            txtFirstName.Text = obj1.Fname;
            txtLastName.Text = obj1.Lname;
            txtWorkingExp.Text = (obj1.WorkingExp).ToString();
            txtOfficeLocation.Text = obj1.OfficeLocation;
            txtEmail.Text = obj1.Email;
            txtContactNo.Text = obj1.ContactNo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the personal information page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu(_formColor);
                am.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Enable textbox for editing
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtWorkingExp.ReadOnly = false;
            txtOfficeLocation.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContactNo.ReadOnly = false;
            //Hide button name as btnEdit
            btnEdit.Hide();
            //Appear of button name as btnDone
            btnDone.Show();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Hide button name as btnDone

            //Disable textbox for editing

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string name = "^[a-zA-Z ]+$";

            if (txtFirstName.Text != null && txtLastName.Text != null && txtWorkingExp.Text != null && txtOfficeLocation.Text != null && txtEmail != null && txtContactNo.Text != null)
            {

                if (!Regex.IsMatch(txtEmail.Text, pattern))
                {
                    MessageBox.Show("Please provide a valid email");
                    txtEmail.Focus();
                }
                else if (txtContactNo.TextLength < 10)
                {
                    MessageBox.Show("Contact numebr should contain at least 10 characters!");
                    txtContactNo.Focus();
                }
                else if (!Regex.IsMatch(txtFirstName.Text, name))
                {
                    MessageBox.Show("Invalid first name.");
                    txtFirstName.Focus();
                }
                else if (!Regex.IsMatch(txtLastName.Text, name))
                {
                    MessageBox.Show("Invalid last name.");
                    txtLastName.Focus();
                }
                else
                {
                    Admin obj1 = new Admin(UserID);
                    MessageBox.Show(obj1.UpdateProfile(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtContactNo.Text, txtWorkingExp.Text,
                    txtOfficeLocation.Text));
                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    txtWorkingExp.ReadOnly = true;
                    txtOfficeLocation.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtContactNo.ReadOnly = true;
                    //Appear of button name as btnEdit
                    btnEdit.Show();
                    btnDone.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all information!!");
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                txtWorkingExp.ReadOnly = false;
                txtOfficeLocation.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtContactNo.ReadOnly = false;
            }


        }

    }
}
