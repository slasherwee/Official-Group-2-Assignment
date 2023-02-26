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
    public partial class Tutor_Portal : Form
    {
        //member field
        public static string id;//global
        private Color _formColor;// private variable to store the color of the form
        bool isCollapsed = true;// a boolean variable to keep track of the collapse state of a panel

        //constructor
        public Tutor_Portal()// Default constructor for the Tutor_Portal form
        {
            InitializeComponent();
        }

        // Overloaded constructor that takes a form color parameter
        public Tutor_Portal(Color formColor)
        {
            // initialize the components of the form
            InitializeComponent();

            // store the passed form color in the private variable
            _formColor = formColor;
        }

        // Overloaded constructor that takes an ID and a form color parameter
        public Tutor_Portal(string n, Color formColor)
        {
            InitializeComponent();

            // store the passed ID in the public static variable
            id = n;

            // store the passed form color in the private variable
            _formColor = formColor;
        }

        // Event handler for the Tutor_Portal form's Load event
        private void Tutor_Portal_Load(object sender, EventArgs e)
        {
            // display the user's ID in a label
            lblUserID.Text = "Hello, " + id;

            // center the label horizontally
            lblUserID.Left = (this.Width - lblUserID.Width) / 2;

            // set the size of a panel to its minimum size
            panelSetting.Size = panelSetting.MinimumSize;

            // set the background color of the form to the stored color
            this.BackColor = _formColor;
        }

        // Event handler for a button that toggles the collapse state of a panel
        private void btnSetting_Click(object sender, EventArgs e)
        {
            // if the panel is collapsed
            if (isCollapsed)
            {
                // set the size of the panel to its maximum size
                panelSetting.Size = panelSetting.MaximumSize;

                // if the panel has reached its maximum size
                if (panelSetting.Height >= panelSetting.MaximumSize.Height)
                {
                    isCollapsed = false;// set the collapse state to false
                }

            }

            // if the panel is not collapsed
            else
            {
                // set the size of the panel to its minimum size
                panelSetting.Size = panelSetting.MinimumSize;

                // if the panel has reached its minimum size
                if (panelSetting.Height <= panelSetting.MinimumSize.Height)
                {
                    isCollapsed = true;// set the collapse state to true

                }
            }


        }

        // Event handler for a button that opens the Tutor_Course_Management form
        private void btnCourse_Click(object sender, EventArgs e)
        {
            // hide the current form
            this.Hide();

            // create a new instance of the Tutor_Course_Management form
            Tutor_Course_Management tcm = new Tutor_Course_Management(id, this.BackColor);
            
            // display the Tutor_Course_Management form as a dialog
            tcm.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Class_Schedule tcs = new Tutor_Class_Schedule(id, this.BackColor);
            tcs.ShowDialog();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_View_Student_Enrolled tvse = new Tutor_View_Student_Enrolled(id, this.BackColor);
            tvse.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Personal_Information tpi = new Tutor_Personal_Information(id, this.BackColor);  
            tpi.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Change_Password tcp = new Tutor_Change_Password(id, this.BackColor);
            tcp.ShowDialog();
        }

        private void btnUpdateSecurityQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Security_Questions tsq = new Tutor_Security_Questions(id, this.BackColor);
            tsq.ShowDialog();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theme theme= new Theme(this.BackColor);
            theme.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmLoginPage
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
        }
    }
}

            

