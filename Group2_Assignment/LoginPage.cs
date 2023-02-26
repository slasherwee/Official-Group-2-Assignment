using System;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            picShow.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            Users obj1 = new Users(txtUsername.Text, txtPassword.Text);
            stat = obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picHide.Show();
            picShow.Hide();
            txtPassword.PasswordChar = '\0';
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picShow.Show();
            picHide.Hide();
            txtPassword.PasswordChar = '●';
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = System.Drawing.Color.BlueViolet;
            this.Hide();
            Forgot_Password_Page1_ fp = new Forgot_Password_Page1_();
            fp.ShowDialog();
        }
    }
}
