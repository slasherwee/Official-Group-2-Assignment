using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class Tutor_Class_Schedule : Form
    {

        public static string id;//global

        public Tutor_Class_Schedule()
        {
            InitializeComponent();
        }

        public Tutor_Class_Schedule(string a)
        {
            InitializeComponent();
            id = a;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal();
            tp.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }

            else if (txtLocation.TextLength > 20)
            {
                MessageBox.Show("First name cannot exceed 20 characters.");
                txtLocation.Text = txtLocation.Text.Substring(0, 20);
                txtLocation.SelectionStart = 20;
            }

            else if (!Regex.IsMatch(txtTime.Text, @"^([01]\d|2[0-3]):([0-5]\d)$"))
            {
                MessageBox.Show("Please enter a valid time in the format HH:MM (e.g. 09:30).");
            }

            else
            {
                Tutor obj1 = new Tutor(id);

                if (dgvSchedule.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvSchedule.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSchedule.Rows[selectedRowIndex];

                    obj1.SubID = selectedRow.Cells[0].Value.ToString();
                    obj1.Day = cmbDay.SelectedValue.ToString();

                    MessageBox.Show(obj1.updateSchedule(obj1.SubID, id, txtLocation.Text, txtTime.Text, obj1.Day));

                    DataTable vs = obj1.viewSchedule(cmbDay.SelectedValue.ToString(), obj1);
                    dgvSchedule.DataSource = vs;
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }


        }

        private void Tutor_Class_Schedule_Load(object sender, EventArgs e)
        {
            Tutor obj1 = new Tutor(id);

            DataTable dt = obj1.viewDay(obj1);
            cmbDay.DataSource = dt;
            cmbDay.DisplayMember = "day";
            cmbDay.ValueMember = "day";
            cmbDay.SelectedIndex = -1;

            cmbDay.SelectedIndexChanged += cmbDay_SelectedIndexChanged;

        }


        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tutor obj1 = new Tutor(id);

            DataTable vs = obj1.viewSchedule(cmbDay.SelectedValue.ToString(), obj1);
            dgvSchedule.DataSource = vs;
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get Data
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dgvSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtLocation.Text = (dgvSchedule.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtTime.Text = (dgvSchedule.Rows[e.RowIndex].Cells[3].Value.ToString());
                }

            }
            catch
            {
                MessageBox.Show("Dont click the Header!");
            }
        }
    }
}
