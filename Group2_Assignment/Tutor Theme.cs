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
    public partial class Theme : Form
    {
        private Color _formColor;

        public Theme()
        {
            InitializeComponent();
        }

        public Theme(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal(this.BackColor);
            tp.ShowDialog();

        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void radLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radLight.Checked)
            {
                this.BackColor = SystemColors.ControlLightLight;
            }
        }

        private void radAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radAuto.Checked)
            {
                this.BackColor = Color.FromArgb(254, 251, 233);
            }
        }

        private void Theme_Load(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.ControlDarkDark)
            {
                radBlack.Checked = true;
            }
            else if (this.BackColor == SystemColors.ControlLightLight)
            {
                radLight.Checked = true;
            }
            else if (this.BackColor == Color.FromArgb(254, 251, 233))
            {
                radAuto.Checked = true;
            }

        }
    }
}
