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
    public partial class Student_Theme : Form
    {
        public Student_Theme()
        {
            InitializeComponent();
        }

        private void radAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radAuto.Checked)
            {
                this.BackColor = Color.FromArgb(254, 251, 233);
            }
        }

        private void radLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radLight.Checked)
            {
                this.BackColor = SystemColors.ControlLightLight;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void Student_Theme_Load(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Portal studPortal = new Student_Portal(this.BackColor);
            studPortal.ShowDialog();
            this.Hide();
        }
    }
}
