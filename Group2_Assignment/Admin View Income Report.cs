using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frmAdminViewIncomeReport : Form
    {
        private Color _formColor;
        public frmAdminViewIncomeReport(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the income report page", "Confirmation", MessageBoxButtons.YesNo); // message, title, buttons
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu(_formColor);
                am.ShowDialog();
            }
        }

        private void frmAdminViewIncomeReport_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            Income obj1 = new Income();
            DataTable dt = obj1.ViewIncomeReport();
            dataGridViewIncome.DataSource = dt;

            //Add month to combo box item from the arraylist
            ArrayList mth = new ArrayList();
            mth = Income.ViewMonth();
            foreach (var item in mth)
            {
                cmbMonth.Items.Add(item);
            }

            //Add year to combo box item from the arraylist
            ArrayList year = new ArrayList();
            year = Income.ViewYear();
            foreach (var item in year)
            {
                cmbYear.Items.Add(item);
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            string month = cmbMonth.Text;
           
            
            if (string.IsNullOrWhiteSpace(month) && string.IsNullOrWhiteSpace(cmbYear.Text))
            {
                MessageBox.Show("Please select Month and Year", "Month and Year");
            }
            else
            {
                int Month = 0;
                switch (month)
                {
                    case "January":
                        Month = 01;
                        break;
                    case "February":
                        Month = 02;
                        break;
                    case "March":
                        Month = 03;
                        break;
                    case "April":
                        Month = 04;
                        break;
                    case "May":
                        Month = 05;
                        break;
                    case "June":
                        Month = 06;
                        break;
                    case "July":
                        Month = 07;
                        break;
                    case "August":
                        Month = 08;
                        break;
                    case "September":
                        Month = 09;
                        break;
                    case "October":
                        Month = 10;
                        break;
                    case "November":
                        Month = 11;
                        break;
                    case "December":
                        Month = 12;
                        break;
                }

                if (!string.IsNullOrWhiteSpace(month) && !string.IsNullOrWhiteSpace(cmbYear.Text))
                {
                    Income mth = new Income(Month, Convert.ToInt32(cmbYear.Text));
                    Income.SortMonthYear(mth);
                    lblIncome.Text = "The total income for is " + month + "," + cmbYear.Text + " was " + mth.TotalIncome1;
                    DataTable dt = mth.ViewIncomeReportSortMonthYear(Month, Convert.ToInt32(cmbYear.Text));
                    dataGridViewIncome.DataSource = dt;
                }
                else if (!string.IsNullOrWhiteSpace(month) && string.IsNullOrWhiteSpace(cmbYear.Text))
                {
                    MessageBox.Show("Please select Year", "Year");
                }
                else if (string.IsNullOrWhiteSpace(month) && !string.IsNullOrWhiteSpace(cmbYear.Text))
                {
                    Income mth = new Income(Convert.ToInt32(cmbYear.Text));
                    Income.SortYear(mth);
                    lblIncome.Text = "The total income for is " + cmbYear.Text + " was " + mth.TotalIncome1;
                    DataTable dt = mth.ViewIncomeReportSortYear(Convert.ToInt32(cmbYear.Text));
                    dataGridViewIncome.DataSource = dt;
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex >= 0)
            {
                cmbMonth.SelectedIndex = -1;
            }
            if (cmbYear.SelectedIndex >= 0)
            {
                cmbYear.SelectedIndex = -1;
            }
            lblIncome.Text = string.Empty;
            Income obj1 = new Income();
            DataTable dt = obj1.ViewIncomeReport();
            dataGridViewIncome.DataSource = dt;
        }
    }
}
