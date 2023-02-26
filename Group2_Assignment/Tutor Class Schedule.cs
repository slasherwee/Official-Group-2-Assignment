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
        //member field
        private Color _formColor;// Declare a private field to store the form color
        public static string id;// Declare a static global variable to store the tutor ID

        //Constructors
        public Tutor_Class_Schedule()// Default constructor for the form
        {
            InitializeComponent();
        }

        // Overloaded constructor with parameters to set the tutor ID and form color
        public Tutor_Class_Schedule(string a, Color formColor)
        {
            InitializeComponent();

            // Set the global variable for the tutor ID
            id = a;

            // Set the private field for the form color
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal(this.BackColor);
            tp.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtVenue.Text) ||
                string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }

            // Check if venue text box has more than 20 characters
            else if (txtVenue.TextLength > 20)
            {
                MessageBox.Show("First name cannot exceed 20 characters.");
                txtVenue.Text = txtVenue.Text.Substring(0, 20);
                txtVenue.SelectionStart = 20;
            }

            // Check if time text box contains a valid time in the format HH:MM
            else if (!Regex.IsMatch(txtTime.Text, @"^([01]\d|2[0-3]):([0-5]\d)$"))
            {
                MessageBox.Show("Please enter a valid time in the format HH:MM (e.g. 09:30).");
            }

            else
            {
                Tutor obj1 = new Tutor(id);

                // Check if a row is selected in the data grid view
                if (dgvSchedule.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvSchedule.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSchedule.Rows[selectedRowIndex];

                    // Set the subject ID and day properties of the tutor object
                    obj1.SubID = selectedRow.Cells[0].Value.ToString();
                    obj1.Day = cmbDay.SelectedValue.ToString();

                    // Call the updateSchedule method of the tutor object and display a message box with the result
                    MessageBox.Show(obj1.updateSchedule(obj1.SubID, id, txtVenue.Text, txtTime.Text, obj1.Day));

                    // Update the data grid view with the new schedule
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
            this.BackColor = _formColor;
            
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
                    txtVenue.Text = (dgvSchedule.Rows[e.RowIndex].Cells[2].Value.ToString());
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
