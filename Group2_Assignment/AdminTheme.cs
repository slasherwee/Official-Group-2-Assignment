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
    public partial class AdminTheme : Form
    {
        private Color _formColor;
        public AdminTheme(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminMenu am = new frmAdminMenu(this.BackColor);
            am.ShowDialog();
        }

        private void radAuto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radAuto.Checked)
            {
                this.BackColor = Color.FromArgb(254, 251, 233);
            }
        }

        private void radLight_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radLight.Checked)
            {
                this.BackColor = SystemColors.ControlLightLight;
            }
        }

        private void radBlack_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void AdminTheme_Load(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(254, 251, 233))
            {
                radAuto.Checked = true;
            }
            else if (this.BackColor == SystemColors.ControlDarkDark)
            {
                radBlack.Checked = true;
            }
            else if (this.BackColor == SystemColors.ControlLightLight)
            {
                radLight.Checked = true;
            }
        }
    }
}
