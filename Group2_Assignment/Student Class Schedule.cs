using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class Student_Class_Schedule : Form
    {
        public static string id;
        private Color _formColor;
        public Student_Class_Schedule()
        {
            InitializeComponent();
        }

        public Student_Class_Schedule(string i, Color formColor)
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

        private void Student_Class_Schedule_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;

            dgvSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSchedule.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSchedule.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSchedule.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSchedule.Columns[3].HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSchedule.Columns[4].HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Student obj1 = new Student(id);
            DataTable dt = obj1.viewDay(obj1);
            cmbDay.DataSource = dt;
            cmbDay.DisplayMember = "day";
            cmbDay.ValueMember = "day";
            cmbDay.SelectedIndex = -1;
            cmbDay.SelectedIndexChanged += cmbDay_SelectedIndexChanged;
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student obj1 = new Student(id);
            DataTable vs = obj1.viewSchedule(cmbDay.SelectedValue.ToString(), obj1);
            dgvSchedule.DataSource = vs;
        }
    }
}
