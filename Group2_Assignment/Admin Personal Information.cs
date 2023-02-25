using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class frmAdminPersonalInfo : Form
    {
        public static string UserID;//global variable
        public frmAdminPersonalInfo()
        {
            InitializeComponent();
            //Disable textbox for editing
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtWorkingExp.ReadOnly = true;
            txtOfficeLocation.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContactNo.ReadOnly = true;
            //Hide button name as btnDone
            btnDone.Hide();

        }

        public frmAdminPersonalInfo(string id)
        {
            InitializeComponent();
            UserID = id;
        }

        private void AdminPersonalInfo_Load(object sender, EventArgs e)
        {
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
                frmAdminMenu am = new frmAdminMenu();
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
            btnDone.Hide();
            //Disable textbox for editing
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtWorkingExp.ReadOnly = true;
            txtOfficeLocation.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContactNo.ReadOnly = true;

            Admin obj1 = new Admin(UserID);
            MessageBox.Show(obj1.UpdateProfile(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtContactNo.Text, txtWorkingExp.Text,
            txtOfficeLocation.Text));
            //Appear of button name as btnEdit
            btnEdit.Show();
        }

    }
}
