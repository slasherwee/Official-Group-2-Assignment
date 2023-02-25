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
    public partial class Forgot_Password_Page1_ : Form
    {
        public Forgot_Password_Page1_()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmLoginPage
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtUserID.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtFAns.Text))
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
                string stat;
                Users obj1 = new Users(txtUserID.Text, txtFAns.Text,txtSecAns.Text);
                stat = obj1.forgot_password(txtUserID.Text);
                if (stat != null)
                {
                    MessageBox.Show(stat);
                }
                txtUserID.Text = string.Empty;
                txtFAns.Text = string.Empty;
                txtSecAns.Text= string.Empty;
            }
        }
    }
}
