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
        public static string id;//global

        private Color _formColor;

        bool isCollapsed = true;

        public Tutor_Portal()
        {
            InitializeComponent();
        }

        public Tutor_Portal(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        public Tutor_Portal(string n)
        {
            InitializeComponent();
            id = n;
        }

        private void Tutor_Portal_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Hello, " + id;
            lblUsername.Left = (this.Width - lblUsername.Width) / 2;
            panelSetting.Size = panelSetting.MinimumSize;
            this.BackColor = _formColor;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelSetting.Size = panelSetting.MaximumSize;
                if (panelSetting.Height >= panelSetting.MaximumSize.Height)
                {
                    isCollapsed = false;
                }

            }

            else
            {
                panelSetting.Size = panelSetting.MinimumSize;
                if (panelSetting.Height <= panelSetting.MinimumSize.Height)
                {
                    isCollapsed = true;

                }
            }


        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Course_Management tcm = new Tutor_Course_Management(id);
            tcm.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Class_Schedule tcs = new Tutor_Class_Schedule(id);
            tcs.ShowDialog();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_View_Student_Enrolled tvse = new Tutor_View_Student_Enrolled(id);
            tvse.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Personal_Information tpi = new Tutor_Personal_Information(id);  
            tpi.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Change_Password tcp = new Tutor_Change_Password(id);
            tcp.ShowDialog();
        }

        private void btnUpdateSecurityQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Security_Questions tsq = new Tutor_Security_Questions(id);
            tsq.ShowDialog();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theme theme= new Theme();
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

            

