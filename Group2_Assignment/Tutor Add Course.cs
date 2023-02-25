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
        public static string id;//global
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Tutor_Add_Course()
        {
            InitializeComponent();
        }

        public Tutor_Add_Course(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Course_Management tcm = new Tutor_Course_Management();
            tcm.ShowDialog();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;

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

            if (!isDuplicate)
            {
                if (txtSubName.TextLength > 20)
                {
                    MessageBox.Show("Subject name cannot exceed 20 characters.");
                    txtSubName.Text = txtSubName.Text.Substring(0, 20);
                    txtSubName.SelectionStart = 20;
                    txtSubName.Focus();
                }

                else if (!int.TryParse(txtSubHour.Text, out int sub_hour) || sub_hour < 1 || sub_hour > 100)
                {
                    MessageBox.Show("Please enter a valid subject hour (1-100).");
                    txtSubHour.Focus();
                }

                else if (!Regex.IsMatch(txtSubCharges.Text, @"^\d{1,2}(\.\d{1,2})?$"))
                {
                    MessageBox.Show("Please enter a valid Malaysia currency format for subscription charges (e.g. 10 or 10.00).");
                    txtSubCharges.Focus();
                }

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
