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
    public partial class frmAdminSecurityQuestions: Form
    {
        public static string UserID;
        public frmAdminSecurityQuestions()
        {
            InitializeComponent();
        }
        public frmAdminSecurityQuestions(string id)
        {
            InitializeComponent();
            UserID = id;
        }

    private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the update security questions page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu();
                am.ShowDialog();
            }
        }

        private void frmAdminSecurityQuestions_Load(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(UserID);
            Admin.viewSecurityQuestion(obj1);
            txtFAns.Text = obj1.Ans_q1;
            txtSecAns.Text = obj1.Ans_q2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFAns.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtFAns.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtSecAns.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtSecAns.Focus();
            }

            else
            {
                Admin obj1 = new Admin(UserID);
                MessageBox.Show(obj1.updateAns(txtFAns.Text, txtSecAns.Text, UserID));
            }
        }
    }
}
