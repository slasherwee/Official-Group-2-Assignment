﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Assignment
{
    public partial class frmAdminMenu : Form
    {
        private bool isCollapsed = true;
        public static string UserID; //global

        private Color _formColor;

        public frmAdminMenu()
        {
            InitializeComponent();
        }

        public frmAdminMenu(string id)
        {
            InitializeComponent();
            UserID = id;

        }

        public frmAdminMenu(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        public frmAdminMenu(string id,Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
            UserID = id;
        }


        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Hello, " + UserID;
            panelSetting.Size = panelSetting.MinimumSize;
            this.BackColor = _formColor;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmRegisterNewUser
            //classname objectname = new constructor 
            //classname = constructor
            frmAdminRegisterNewUser1 reg = new frmAdminRegisterNewUser1(_formColor);
            reg.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmDeleteUser
            frmAdminDeleteUser adu = new frmAdminDeleteUser(_formColor);
            adu.ShowDialog();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmViewPayroll
            frmAdminViewPayroll avp = new frmAdminViewPayroll(_formColor);
            avp.ShowDialog();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmPersonalInfo
            frmAdminPersonalInfo api = new frmAdminPersonalInfo(UserID,_formColor);
            api.ShowDialog();
            this.Show();
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
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

        private void btnUpdateSecurityQuestions_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmfrmAdminSecurityQuestions
            frmAdminSecurityQuestions asq = new frmAdminSecurityQuestions(UserID, _formColor);
            asq.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmfrmAdminSecurityQuestions
            frmAdminChangePassword acp = new frmAdminChangePassword(UserID, _formColor);
            acp.ShowDialog();
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmfrmAdminSecurityQuestions
            frmAdminViewIncomeReport avir = new frmAdminViewIncomeReport(_formColor);
            avir.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();
            //create object for frmLoginPage
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
        }


        private void btnTheme_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminTheme theme = new AdminTheme();
            theme.ShowDialog();
        }
    }
}
