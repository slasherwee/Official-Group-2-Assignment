using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group2_Assignment
{
    public partial class Tutor_Add_Course : Form
    {
        //member field
        public static string id;//global

        private Color _formColor;// This line declares a private Color variable named "_formColor"
        
        //constructors
        public Tutor_Add_Course()
        {
            InitializeComponent();
        }

        // Define an overloaded public constructor for the Tutor_Add_Course class with parameters
        public Tutor_Add_Course(string i, Color formColor)
        {
            InitializeComponent();

            // Set the value of the id variable to the value of the i parameter
            id = i;

            // Set the value of the _formColor variable to the value of the formColor parameter
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Course_Management tcm = new Tutor_Course_Management(this.BackColor);
            tcm.ShowDialog();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;

            // Check if any of the required fields are empty or have whitespace
            if (string.IsNullOrWhiteSpace(txtSubID.Text) ||
                string.IsNullOrWhiteSpace(txtSubName.Text) ||
                string.IsNullOrWhiteSpace(txtSubHour.Text) ||
                string.IsNullOrWhiteSpace(txtSubCharges.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }

            // Use a regular expression to validate the format of subId
            else if (!Regex.IsMatch(txtSubID.Text, "^ETC_[A-Z0-9]{6}$"))
            {
                MessageBox.Show("Please enter a valid subject ID in the format ETC_XXXXXX (e.g. ETC_ENGF01).");
                txtSubID.Focus();
            }

            // Check for duplicate subIDs
            else
            {
                foreach (DataGridViewRow row in dgvCourse.Rows)
                {
                    // If the current cell is not null and its value equals txtSubID, then set isDuplicate to true and display a message
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSubID.Text)
                    {
                        isDuplicate = true;
                        MessageBox.Show("SubID already exists. Please enter a different SubID.");
                        txtSubID.Focus();
                        break;
                    }
                }

                // Check for duplicate subNames
                if (!isDuplicate)
                {
                    foreach (DataGridViewRow row in dgvCourse.Rows)
                    {
                        // If the current cell is not null and its value equals txtSubName, then set isDuplicate to true and display a message
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == txtSubName.Text)
                        {
                            isDuplicate = true;
                            MessageBox.Show("SubName already exists. Please enter a different SubName.");
                            txtSubName.Focus();
                            break;
                        }
                    }
                }
            }

            // If there are no duplicates, validate the other fields
            if (!isDuplicate)
            {
                // Check if subject name is longer than 20 characters
                if (txtSubName.TextLength > 20)
                {
                    MessageBox.Show("Subject name cannot exceed 20 characters.");
                    txtSubName.Text = txtSubName.Text.Substring(0, 20);
                    txtSubName.SelectionStart = 20;
                    txtSubName.Focus();
                }

                // Check if subject hour is a valid integer between 1 and 100
                else if (!int.TryParse(txtSubHour.Text, out int sub_hour) || sub_hour < 1 || sub_hour > 100)
                {
                    MessageBox.Show("Please enter a valid subject hour (1-100).");
                    txtSubHour.Focus();
                }

                // Use a regular expression to validate the format of subscription charges
                else if (!Regex.IsMatch(txtSubCharges.Text, @"^\d{1,2}(\.\d{1,2})?$"))
                {
                    MessageBox.Show("Please enter a valid Malaysia currency format for subscription charges (e.g. 10 or 10.00).");
                    txtSubCharges.Focus();
                }

                // If all fields are valid, create a new Tutor object with the field values and display the updated table
                else
                {
                    Tutor obj1 = new Tutor(txtSubID.Text, txtSubName.Text, txtSubHour.Text, txtSubCharges.Text, id);
                    MessageBox.Show(obj1.addCourse());

                    txtSubID.Text = obj1.SubID;
                    txtSubName.Text = obj1.SubName;
                    txtSubHour.Text = obj1.SubHour;
                    txtSubCharges.Text = obj1.SubCharges;

                    DataTable dt = obj1.viewCourse(obj1);
                    dgvCourse.DataSource = dt;
                }
            }
        }



        private void Tutor_Add_Course_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            Tutor obj1 = new Tutor(id);
            DataTable dt = obj1.viewCourse(obj1);
            dgvCourse.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubID.Text = string.Empty;
            txtSubName.Text = string.Empty;
            txtSubHour.Text = string.Empty;
            txtSubCharges.Text = string.Empty;
        }
    }
}
