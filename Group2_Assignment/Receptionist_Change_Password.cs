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
    public partial class frm_Receptionist_Change_Password : Form
    {
        public frm_Receptionist_Change_Password()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult m1= MessageBox.Show("Do you want to exit from the change password page", "Confirmation", MessageBoxButtons.YesNo);
            if (m1== DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu();
                am.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
