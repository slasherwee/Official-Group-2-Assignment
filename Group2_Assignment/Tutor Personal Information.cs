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
using System.Xml.Linq;

namespace Group2_Assignment
{
    public partial class Tutor_Personal_Information : Form
    {
        //member field
        private Color _formColor;// Declare a private field to store the form color
        public static string id;// Declare a static global variable to store the tutor ID
        
        //Constructors
        public Tutor_Personal_Information()// Default constructor for the form
        {
            InitializeComponent();
        }

        // Overloaded constructor with parameters to set the tutor ID and form color
        public Tutor_Personal_Information(string i, Color formColor)
        {
            InitializeComponent();
            // Set the global variable for the tutor ID
            id = i;

            // Set the private field for the form color
            _formColor = formColor;
        }


        private void Tutor_Personal_Information_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;

            lblUserID.Text = id;
            
            Tutor obj1 = new Tutor(id);

            //calling static method require className.Method(..)
            //pass object obj1 to method ViewProfile
            Tutor.viewProfile(obj1);

            txtFname.Text = obj1.FName;
            txtLname.Text = obj1.LName;
            txtTeaching.Text = obj1.TeachingEx.ToString();
            txtLocation.Text = obj1.Location;
            txtEmail.Text = obj1.Email;
            txtContactNo.Text = obj1.Contactno;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal(this.BackColor);
            tp.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtTeaching.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please fill in all the fields.");

            }

            // Check if first name text box has more than 20 characters
            else if (txtFname.TextLength > 20)
            {
                MessageBox.Show("First name cannot exceed 20 characters.");
                txtFname.Text = txtFname.Text.Substring(0, 20);
                txtFname.SelectionStart = 20;
                txtFname.Focus();
            }

            // Check if last name text box has more than 20 characters
            else if (txtLname.TextLength > 20)
            {
                MessageBox.Show("Last name cannot exceed 20 characters.");
                txtLname.Text = txtLname.Text.Substring(0, 20);
                txtLname.SelectionStart = 20;
                txtLname.Focus();
            }

            // Check if teaching experience text box contains a valid integer between 1 and 100
            else if (!int.TryParse(txtTeaching.Text, out int teaching_ex) || teaching_ex < 1 || teaching_ex > 100)
            {
                MessageBox.Show("Please enter a valid teaching experience (1-100).");
                txtTeaching.Focus();
            }

            // Check if email text box contains a valid email address format
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // check email format
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
            }

            // Check if email text box has more than 20 characters
            else if (txtEmail.TextLength > 20)
            {
                MessageBox.Show("Email cannot exceed 20 characters.");
                txtEmail.Text = txtEmail.Text.Substring(0, 20);
                txtEmail.SelectionStart = 20;
                txtEmail.Focus();
            }

            // Check if contact number text box contains a valid integer without hyphens
            else if (!int.TryParse(txtContactNo.Text.Replace("-", ""), out int contact_no))
            {
                MessageBox.Show("Please enter a valid contact number.");
                txtContactNo.Focus();
            }

            // Check if contact number text box contains a valid Malaysian phone number format
            else if (!Regex.IsMatch(txtContactNo.Text, @"^01[0-9]-\d{7,8}$")) // Malaysian phone number format
            {
                MessageBox.Show("Please enter a valid Malaysian phone number (01X-XXXXXXX or 01X-XXXXXXXX).");
                txtContactNo.Focus();
            }

            /* If all input is valid, create a new Tutor object with the current user ID,
               call the updateProfile method of the Tutor object with the updated profile details,
               and display a message box with the result*/
            else
            {
                Tutor obj1 = new Tutor(id);
                MessageBox.Show(obj1.updateProfile(txtFname.Text, txtLname.Text, txtTeaching.Text, txtLocation.Text, txtEmail.Text, txtContactNo.Text));
            }
        }


    }
}
