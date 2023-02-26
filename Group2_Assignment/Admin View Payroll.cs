using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frmAdminViewPayroll : Form
    {
        public static string userid;
        private Color _formColor;

        public frmAdminViewPayroll(Color formColor, string id)
        {
            InitializeComponent();
            userid = id;
            _formColor = formColor;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the payroll page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu(_formColor);
                am.ShowDialog();
            }
        }

        private void frmAdminViewPayroll_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            ArrayList SalaryID = new ArrayList();
            SalaryID = Payroll.ViewSalaryID();
            foreach (var item in SalaryID)
            {
                lstSalaryID.Items.Add(item);
            }
            ArrayList UserID = new ArrayList();
            UserID = Payroll.ViewSalaryUserID();
            foreach (var item in UserID)
            {
                lstUserID.Items.Add(item);
            }
            ArrayList UserRole = new ArrayList();
            UserRole = Payroll.ViewSalaryUserRole();
            foreach (var item in UserRole)
            {
                lstUserRole.Items.Add(item);
            }
            ArrayList Hour = new ArrayList();
            Hour = Payroll.ViewSalaryHour();
            foreach (var item in Hour)
            {
                lstHour.Items.Add(item);
            }
            ArrayList SubjectID = new ArrayList();
            SubjectID = Payroll.ViewSalarySubjectID();
            foreach (var item in SubjectID)
            {
                lstSubjectID.Items.Add(item);
            }
            ArrayList BasicSalary = new ArrayList();
            BasicSalary = Payroll.ViewBasicSalary();
            foreach (var item in BasicSalary)
            {
                lstSalary.Items.Add(item);
            }
            ArrayList TotalSalary = new ArrayList();
            TotalSalary = Payroll.ViewTotalSalary();
            foreach (var item in TotalSalary)
            {
                lstTotalSalary.Items.Add(item);
            }

        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                cmbUserID.Items.Clear();
                cmbUserID.Text= String.Empty;
                lblIncome.Text= String.Empty;
                ArrayList TutorID = new ArrayList();
                TutorID = Payroll.FindSalaryTutorID();
                foreach (var item in TutorID)
                {
                    cmbUserID.Items.Add(item);
                }
            }
            else if (cmbUserRole.SelectedIndex == 1)
            {
                cmbUserID.Items.Clear();
                cmbUserID.Text = String.Empty;
                lblIncome.Text = String.Empty;
                ArrayList ReceptionistID = new ArrayList();
                ReceptionistID = Payroll.FindSalaryReceptionistID();
                foreach (var item in ReceptionistID)
                {
                    cmbUserID.Items.Add(item);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex >= 0)
            {
                cmbUserRole.SelectedIndex = -1;
            }
            if (cmbUserID.SelectedIndex >= 0)
            {
                cmbUserID.SelectedIndex = -1;
                cmbUserID.Items.Clear();
            }
            if (lblIncome != null)
            {
                lblIncome.Text = String.Empty;
            }
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbUserID.Text;
            Payroll obj1 = new Payroll(id);
            Payroll.FindTotalSalary(obj1);
            lblIncome.Text = cmbUserID.Text + " total salary :\n                        RM " + obj1.TotalSalary;
        }


    }
}
