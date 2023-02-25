using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frm_Receptionist_Security_Questions : Form
    {
        public frm_Receptionist_Security_Questions()
        {
            InitializeComponent();
        }
        public string r_id { get; set; }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult m1 = MessageBox.Show("Do you want to exit from the update security questions page", "Confirmation", MessageBoxButtons.YesNo);
            if (m1 == DialogResult.Yes)
            {
                this.Hide();
                frm_Main_Menu am = new frm_Main_Menu();
                am.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFAns.Text))
            {
                MessageBox.Show("Please fill in all the fields", "Message");
                txtFAns.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtSecAns.Text))
            {
                MessageBox.Show("Please fill in all the fields", "Message");
                txtSecAns.Focus();
            }

            else
            {
                Receptionist obj1 = new Receptionist(r_id);
                MessageBox.Show(obj1.UpdateSecurityQuestionAns(txtFAns.Text, txtSecAns.Text, r_id));
            }
        }

        private void frm_Receptionist_Security_Questions_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(r_id);
            Receptionist.ViewSecurityQuestion(obj1);
            txtFAns.Text = obj1.Answer_1;
            txtSecAns.Text = obj1.Answer_2;
        }
    }
}
