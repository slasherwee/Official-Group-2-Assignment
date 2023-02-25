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


    }
}
