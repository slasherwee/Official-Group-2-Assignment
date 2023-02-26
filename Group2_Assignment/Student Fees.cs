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
    public partial class Student_Fees : Form
    {
        public static string id;
        private Color _formColor;

        public Student_Fees()
        {
            InitializeComponent();
        }

        public Student_Fees(string i, Color formColor)
        {
            InitializeComponent();
            id = i;
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Portal studPortal = new Student_Portal(this.BackColor);
            studPortal.ShowDialog();
            this.Close();
        }

        private void Student_Fees_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            Student obj1 = new Student(id);
            DataTable vf = obj1.viewFee(obj1);
            dgvFee.DataSource = vf;
            cmbSortDate.SelectedIndex = 0;
        }

        private void cmbSortDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbSortDate.SelectedIndex;
            if (i == 1)
            {
                Student obj1 = new Student(id);
                DataTable vf = obj1.viewFeeOldestDate(obj1);
                dgvFee.DataSource = vf;
            }
            else if (i == 0)
            {
                Student obj1 = new Student(id);
                DataTable vf = obj1.viewFee(obj1);
                dgvFee.DataSource = vf;
            }
        }
    }
}
