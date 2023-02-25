using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group2_Assignment
{
    public partial class Student_Personal_Information : Form
    {
        public static string id;

        public Student_Personal_Information()
        {
            InitializeComponent();
        }

        public Student_Personal_Information(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Portal studPortal = new Student_Portal();
            studPortal.ShowDialog();
            this.Close();
        }

        private void Student_Personal_Information_Load(object sender, EventArgs e)
        {
            lblStudId.Text = id;
            Student obj1 = new Student(id);
            //call static method viewProfile by supplying the object
            Student.viewProfile(obj1);

            txtFName.Text = obj1.FirstName;
            txtLName.Text = obj1.LastName;
            lblIcOutput.Text = obj1.Ic;
            lblGenderOutput.Text = obj1.Gender;
            txtEmail.Text = obj1.Email;
            txtContactNo.Text = obj1.ContactNo;
            lblNationalityOutput.Text = obj1.Nationality;
            txtAdd.Text = obj1.HouseAdd;

            lblLevel.Text = obj1.Level;
            lblEnrolYearOutput.Text = obj1.YearOfEnrolment;
            lblNoOfSubOutput.Text = obj1.NoOfSub;
            lblSub1Output.Text = obj1.Sub1;
            lblSub2Output.Text = obj1.Sub2;
            lblSub3Output.Text = obj1.Sub3;
            lblSub1CodeOutput.Text = obj1.Sub1Code;
            lblSub2CodeOutput.Text = obj1.Sub2Code;
            lblSub3CodeOutput.Text = obj1.Sub3Code;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string name = "^[a-zA-Z ]+$";

            if (txtFName.Text.Trim() == string.Empty || txtLName.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty || txtContactNo.Text.Trim() == string.Empty || txtAdd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Do not leave any of the textboxes blank!");
            }
            else if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                MessageBox.Show("Please provide a valid email");
                txtEmail.Focus();
            }
            else if (txtContactNo.TextLength < 10)
            {
                MessageBox.Show("Contact numebr should contain at least 10 characters!");
                txtContactNo.Focus();
            }
            else if (!Regex.IsMatch(txtFName.Text, name))
            {
                MessageBox.Show("Invalid first name.");
                txtFName.Focus();
            }
            else if (!Regex.IsMatch(txtLName.Text, name))
            {
                MessageBox.Show("Invalid last name.");
                txtLName.Focus();
            }
            else
            {
                Student obj1 = new Student(id);
                MessageBox.Show(obj1.updateProfile(txtFName.Text, txtLName.Text, txtEmail.Text, txtContactNo.Text, txtAdd.Text, id));
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            txtEmail.ForeColor = Color.Black;

            if (Regex.IsMatch(txtEmail.Text, pattern))
                txtEmail.ForeColor = Color.Black;
            else
                txtEmail.ForeColor = Color.Red;
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            txtContactNo.ForeColor = Color.Black;

            if (txtContactNo.TextLength < 10)
                txtContactNo.ForeColor = Color.Red;
            else
                txtContactNo.ForeColor = Color.Black;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Contact number should only contain numbers!");
            }
        }
    }
}
