﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class Student_Portal : Form
    {
        //global variable
        //to show the id the Student Portal
        //static -> to hold the variable until the application is closed
        public static string id;
        bool isCollapsed = true;

        public Student_Portal()
        {
            InitializeComponent();
        }

        public Student_Portal(string n)
        {
            InitializeComponent();
            id = n;
        }

        private void Student_Portal_Load(object sender, EventArgs e)
        {
            //method load is the method that will automatically executed when the form is projected
            //to display the id on the label in Student Portal
            lblUsername.Text = "Welcome, " + id;
            lblUsername.Left = (this.Width - lblUsername.Width) / 2; //center the label
            panelSetting.Size = panelSetting.MinimumSize;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Student_Class_Schedule studSched = new Student_Class_Schedule(id);
            studSched.ShowDialog();
            this.Close();
        }

        private void btnChangeSub_Click(object sender, EventArgs e)
        {
            Student_Change_Subject studChangeSub = new Student_Change_Subject(id);
            studChangeSub.ShowDialog();
            this.Close();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            Student_Fees studFees = new Student_Fees(id);
            studFees.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Student_Personal_Information studInfo = new Student_Personal_Information(id);
            studInfo.ShowDialog();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelSetting.Size = panelSetting.MaximumSize;
                if (panelSetting.Height >= panelSetting.MaximumSize.Height)
                    isCollapsed = false;
            }

            else
            {
                panelSetting.Size = panelSetting.MinimumSize;
                if (panelSetting.Height <= panelSetting.MinimumSize.Height)
                    isCollapsed = true;
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theme theme = new Theme();
            theme.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Change_Password scp = new Student_Change_Password(id);
            scp.ShowDialog();
        }

        private void btnUpdateSecurityQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Security_Questions tsq = new Student_Security_Questions(id);
            tsq.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
        }
    }
}
