using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Assignment
{
    public partial class frmAdminChangePassword : Form
    {
        public static string UserID;
        private Color _formColor;
        public frmAdminChangePassword()
        {
            InitializeComponent();
        }

        public frmAdminChangePassword(string id, Color formColor)
        {
            InitializeComponent();
            UserID = id;
            _formColor = formColor;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the change password page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu();
                am.ShowDialog();
            }
        }

        private void frmAdminChangePassword_Load(object sender, EventArgs e)
        {
            txtCurrentPass.PasswordChar = '●';
            txtConfirmPass.PasswordChar = '●';
            txtNewPass.PasswordChar = '●';
            picCurShow.Visible = true;
            picCurHide.Visible = false;
            picNewShow.Visible = true;
            picNewHide.Visible = false;
            picConShow.Visible = true;
            picConHide.Visible = false;
            this.BackColor = _formColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(UserID);

            //calling static method require className.Method(obj1)
            //pass object obj1 through method ViewProfile
            Admin.ViewPassword(obj1);
            if (txtCurrentPass.Text != obj1.Password)
            {
                MessageBox.Show("Current password incorrect");
                return;
            }
            else if (txtCurrentPass.Text == txtNewPass.Text)
            {
                MessageBox.Show("Old password is same as new password!");
                return;
            }
            else if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password does not match", "error");
                return;
            }
            else
            {
                MessageBox.Show(obj1.UpdatePassword(txtConfirmPass.Text));
            }
            this.Hide();
            frmAdminMenu am = new frmAdminMenu(_formColor);
            am.ShowDialog();

        }

        private void pbCurPassShow_Click(object sender, EventArgs e)
        {
            txtCurrentPass.PasswordChar = '\0';
            picCurShow.Visible = false;
            picCurHide.Visible = true;
        }

        private void picCurHide_Click(object sender, EventArgs e)
        {
            txtCurrentPass.PasswordChar = '●';
            picCurShow.Visible = true;
            picCurHide.Visible = false;
        }

        private void picNewShow_Click(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar = '\0';
            picNewShow.Visible = false;
            picNewHide.Visible = true;
        }

        private void picNewHide_Click(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar = '●';
            picNewShow.Visible = true;
            picNewHide.Visible = false;
        }

        private void picConShow_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '\0';
            picConShow.Visible = false;
            picConHide.Visible = true;
        }

        private void picConHide_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '●';
            picConShow.Visible = true;
            picConHide.Visible = false;
        }
    }
}
