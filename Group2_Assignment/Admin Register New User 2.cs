using Group2_Assignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;



namespace Group2_Assignment
{
    public partial class frmAdminRegisterNewUser2 : Form
    {
        private Color _formColor;
        public frmAdminRegisterNewUser2(Color formColor)
        {
            InitializeComponent();
            grp.Hide();
            cmbHour.Hide();
            lblWorkingHours.Hide();
            lblExperience.Hide();
            txtExperience.Hide();
            _formColor = formColor;
        }

        string FN = frmAdminRegisterNewUser1.FirstName;
        string LN = frmAdminRegisterNewUser1.LastName;
        string CN = frmAdminRegisterNewUser1.ContactNo;
        string E = frmAdminRegisterNewUser1.Email;
        string Pass = frmAdminRegisterNewUser1.Password;
        string CP = frmAdminRegisterNewUser1.ConfirmPassword;
        string SQ1 = frmAdminRegisterNewUser1.SecurityQuestion1;
        string SQ2 = frmAdminRegisterNewUser1.SecurityQuestion2;
        public string id;       
        public char Gender;
        public string role;
        public string SubID;
        public string Salary;
        public string SalaryID;

        private void frmRegisterNewUser2_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            for (int i = 1; i <= 100; i++)
            {
                lstHourSubject1.Items.Add(i.ToString());
                lstHourSubject2.Items.Add(i.ToString());
                lstHourSubject3.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 100; i++)
            {
                lstHourSubject1.Items.Add(i.ToString());
                lstHourSubject2.Items.Add(i.ToString());
                lstHourSubject3.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 720; i++)
            {
                cmbHour.Items.Add(i.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (cmbUserRole.SelectedIndex >= 0)
            {
                cmbUserRole.SelectedIndex = -1;
            }
            if (cmbHour.SelectedIndex >= 0)
            {
                cmbHour.SelectedIndex = -1;
                cmbHour.Text = "Hour";
            }
            if (lstHourSubject1.SelectedIndex >= 0)
            {
                lstHourSubject1.SelectedIndex = -1;
            }
            if (lstHourSubject2.SelectedIndex >= 0)
            {
                lstHourSubject2.SelectedIndex = -1;
            }
            if (lstHourSubject3.SelectedIndex >= 0)
            {
                lstHourSubject3.SelectedIndex = -1;
            }
            if (cmbSubject1.SelectedIndex >= 0)
            {
                cmbSubject1.SelectedIndex = -1;
            }
            if (cmbSubject2.SelectedIndex >= 0)
            {
                cmbSubject2.SelectedIndex = -1;
            }
            if (cmbSubject3.SelectedIndex >= 0)
            {
                cmbSubject3.SelectedIndex = -1;
            }
            lblUserID.Text = String.Empty;
            txtOfficeLocation.Clear();
            txtExperience.Clear();
        }


        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                lblUserID.Text = String.Empty;
                Admin obj1 = new Admin();
                Admin.CreateNewTutorID(obj1);
                lblUserID.Text = obj1.ID;
                id = lblUserID.Text;

                cmbHour.Hide();
                lblWorkingHours.Hide();
                grp.Show();
                lblExperience.Show();
                txtExperience.Show();
                lblExperience.Text = "Teaching Experience    :";
                role = "tutor";
            }
            else if (cmbUserRole.SelectedIndex == 1)
            {
                lblUserID.Text = String.Empty;
                Admin obj1 = new Admin();
                Admin.CreateNewReceptionistID(obj1);
                lblUserID.Text = obj1.ID;
                id = lblUserID.Text;

                cmbHour.Show();
                lblWorkingHours.Show();
                grp.Hide();
                lblExperience.Show();
                txtExperience.Show();
                lblExperience.Text = "Working Experience     :";
                role ="receptionist";
            }
            else
            {
                lblUserID.Text = String.Empty;
                cmbHour.Hide();
                lblWorkingHours.Hide();
                grp.Hide();
                lblExperience.Hide();
                txtExperience.Hide();
            }
            
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z]+$";
            bool msg = false;
            int number;

            if (radMale.Checked)
            {
                Gender = 'M';
            }
            if (radFemale.Checked)
            {
                Gender = 'F';
            }

            int c = 11;
            if (FN == null)
            {
                c -= 1;
            }
            if (LN == null)
            {
                c -= 1;
            }
            if (Pass == null)
            {
                c -= 1;
            }
            if (E == null)
            {
                c -= 1;
            }
            if (CN == null)
            {
                c -= 1;
            }
            if (SQ1 == null)
            {
                c -= 1;
            }
            if (SQ2 == null)
            {
                c -= 1;
            }
            if (Gender < 0 )
            {
                c -= 1;
            }
            if (role == null)
            {
                c -= 1;
            }
            if (string.IsNullOrWhiteSpace(txtExperience.Text))
            {
                c -= 1;
            }
            if (string.IsNullOrWhiteSpace(txtOfficeLocation.Text))
            {
                c -= 1;
            }
            if (c < 10)
            {
                MessageBox.Show("Please check again.\nThere are some information not filled");
                return;
            }
            else if (c == 11)
            {
                //Test string using Regex.IsMatch static method.
                //returns a bool value
                if (Int32.TryParse(txtExperience.Text, out number))
                {
                    if (Regex.IsMatch(FN, pattern))
                    {
                        if (Regex.IsMatch(LN, pattern))
                        {
                            // receives two parameters
                            //out parameter to display default value
                            while (!int.TryParse(CN, out number))
                            {
                                if (!msg)
                                {
                                    MessageBox.Show("Please enter a valid number for the Contact Number");
                                    msg = true;
                                }
                                break;
                            }
                            if (Pass == CP)
                            {
                                if (cmbUserRole.SelectedIndex == 0)
                                {
                                    if (cmbSubject1.SelectedItem == null && lstHourSubject1.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Please select at least one subject and teaching hour.");
                                        return;
                                    }
                                    else if(lstHourSubject1.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Please select teaching hour .");
                                        return;
                                    }
                                    else if (cmbSubject1.SelectedItem == null)
                                    {
                                        MessageBox.Show("Please select at least one subject.");
                                        return;
                                    }
                                    else if (cmbSubject1.SelectedIndex >= 0 && lstHourSubject1.Text != null)
                                    {
                                        Admin obj1 = new Admin(id, FN, LN, E, CN, SQ1,SQ2, Gender, dob.Value, SubID,
                                        txtExperience.Text, txtOfficeLocation.Text);
                                        MessageBox.Show(obj1.AddTutor());

                                        Payroll obj2 = new Payroll();
                                        Payroll.CreateNewSalaryID(obj2);
                                        SalaryID = obj2.Sid;

                                        Payroll obj3 = new Payroll(SalaryID, id, role, SubID, decimal.Parse(Salary), int.Parse(lstHourSubject1.Text));
                                        obj3.AddSalary();
                                        if (cmbSubject3.SelectedIndex >= 0 && lstHourSubject3.Text != null)
                                        {
                                            Admin obj4 = new Admin(id, FN, LN, E, CN, SQ1,SQ2, Gender, dob.Value, SubID,
                                            txtExperience.Text, txtOfficeLocation.Text);
                                            MessageBox.Show(obj4.AddTutor());

                                            Payroll obj5 = new Payroll();
                                            Payroll.CreateNewSalaryID(obj5);
                                            SalaryID = obj5.Sid;

                                            Payroll obj6 = new Payroll(SalaryID, id, role, SubID, decimal.Parse(Salary), int.Parse(lstHourSubject3.Text));
                                            obj3.AddSalary();
                                        }

                                        if (cmbSubject2.SelectedIndex >= 0 && lstHourSubject2.Text != null)
                                        {
                                            Admin obj7 = new Admin(id, FN, LN, E, CN, SQ1, SQ2, Gender, dob.Value, SubID,
                                            txtExperience.Text, txtOfficeLocation.Text);
                                            MessageBox.Show(obj7.AddTutor());

                                            Payroll obj8 = new Payroll();
                                            Payroll.CreateNewSalaryID(obj8);
                                            SalaryID = obj8.Sid;

                                            Payroll obj9 = new Payroll(SalaryID, id, role, SubID, decimal.Parse(Salary), int.Parse(lstHourSubject2.Text));
                                            obj9.AddSalary();
                                        }

                                        Admin obj10 = new Admin(id, role, Pass, SQ1, SQ2);
                                        //calling static method require className.Method(obj1)
                                        MessageBox.Show(obj10.AddTutortoUser());

                                        frmAdminRegisterNewUser1 ar1 = new frmAdminRegisterNewUser1(_formColor);
                                        ar1.Hide();
                                        this.Hide();
                                        frmAdminMenu am = new frmAdminMenu(_formColor);
                                        am.ShowDialog();
                                    }
                                }
                                else if (cmbUserRole.SelectedIndex == 1)
                                {
                                    if (cmbHour.SelectedIndex < 0)
                                    {
                                        MessageBox.Show("Please select working hour.");
                                        return;
                                    }

                                    Salary = "15.75";
                                    Admin obj1 = new Admin(id, FN, LN, Pass, E, CN, SQ1, SQ2, Gender, dob.Value, role, txtExperience.Text, txtOfficeLocation.Text);
                                    MessageBox.Show(obj1.AddReceptionist());

                                    Payroll obj2 = new Payroll();
                                    Payroll.CreateNewSalaryID(obj2);
                                    SalaryID = obj2.Sid;
                                    Payroll obj3 = new Payroll(SalaryID, id, role, "-", decimal.Parse(Salary), int.Parse(cmbHour.Text));
                                    obj3.AddSalary();

                                    frmAdminRegisterNewUser1 ar1 = new frmAdminRegisterNewUser1(_formColor);
                                    ar1.Close();
                                    this.Hide();
                                    frmAdminMenu am = new frmAdminMenu(_formColor);
                                    am.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Please select a user role");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password not match! \n Please make sure password and confirm password are same.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please input valid characters.", "Last Name");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input valid characters.","First Name");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please input with numbers.\ne.g. 2", "Experience");
                    return;
                } 
            }

        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmbSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject1.SelectedIndex == 0) 
            {
                SubID = "ETC_ENGF01";
                Salary = "8.75";
            }
            if (cmbSubject1.SelectedIndex == 1)
            {
                SubID = "ETC_ENGF02";
                Salary = "10.20";
            }
            if (cmbSubject1.SelectedIndex == 2)
            {
                SubID = "ETC_ENGF03";
                Salary = "14.20";
            }
            if (cmbSubject1.SelectedIndex == 3)
            {
                SubID = "ETC_ENGF04";
                Salary = "18.00";
            }
            if (cmbSubject1.SelectedIndex == 4)
            {
                SubID = "ETC_ENGF05";
                Salary = "29.70";
            }
            if (cmbSubject1.SelectedIndex == 5)
            {
                SubID = "ETC_MTSF01";
                Salary = "8.75";
            }
            if (cmbSubject1.SelectedIndex == 6)
            {
                SubID = "ETC_MTSF02";
                Salary = "10.20";
            }
            if (cmbSubject1.SelectedIndex == 7)
            {
                SubID = "ETC_MTSF03";
                Salary = "14.20";
            }
            if (cmbSubject1.SelectedIndex == 8)
            {
                SubID = "ETC_MTSF04";
                Salary = "18.00";
            }
            if (cmbSubject1.SelectedIndex == 9)
            {
                SubID = "ETC_MTSF05";
                Salary = "29.70";
            }
            if (cmbSubject1.SelectedIndex == 10)
            {
                SubID = "ETC_SCIF01";
                Salary = "8.75";
            }
            if (cmbSubject1.SelectedIndex == 11)
            {
                SubID = "ETC_SCIF02";
                Salary = "10.20";
            }
            if (cmbSubject1.SelectedIndex == 12)
            {
                SubID = "ETC_SCIF03";
                Salary = "14.20";
            }
            if (cmbSubject1.SelectedIndex == 13)
            {
                SubID = "ETC_SCIF04";
                Salary = "18.00";
            }
            if (cmbSubject1.SelectedIndex == 14)
            {
                SubID = "ETC_SCIF05";
                Salary = "29.70";
            }
        }

        private void cmbSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject2.SelectedIndex == 0)
            {
                SubID = "ETC_ENGF01";
                Salary = "8.75";
            }
            if (cmbSubject2.SelectedIndex == 1)
            {
                SubID = "ETC_ENGF02";
                Salary = "10.20";
            }
            if (cmbSubject2.SelectedIndex == 2)
            {
                SubID = "ETC_ENGF03";
                Salary = "14.20";
            }
            if (cmbSubject2.SelectedIndex == 3)
            {
                SubID = "ETC_ENGF04";
                Salary = "18.00";
            }
            if (cmbSubject2.SelectedIndex == 4)
            {
                SubID = "ETC_ENGF05";
                Salary = "29.70";
            }
            if (cmbSubject2.SelectedIndex == 5)
            {
                SubID = "ETC_MTSF01";
                Salary = "8.75";
            }
            if (cmbSubject2.SelectedIndex == 6)
            {
                SubID = "ETC_MTSF02";
                Salary = "10.20";
            }
            if (cmbSubject2.SelectedIndex == 7)
            {
                SubID = "ETC_MTSF03";
                Salary = "14.20";
            }
            if (cmbSubject2.SelectedIndex == 8)
            {
                SubID = "ETC_MTSF04";
                Salary = "18.00";
            }
            if (cmbSubject2.SelectedIndex == 9)
            {
                SubID = "ETC_MTSF05";
                Salary = "29.70";
            }
            if (cmbSubject2.SelectedIndex == 10)
            {
                SubID = "ETC_SCIF01";
                Salary = "8.75";
            }
            if (cmbSubject2.SelectedIndex == 11)
            {
                SubID = "ETC_SCIF02";
                Salary = "10.20";
            }
            if (cmbSubject2.SelectedIndex == 12)
            {
                SubID = "ETC_SCIF03";
                Salary = "14.20";
            }
            if (cmbSubject2.SelectedIndex == 13)
            {
                SubID = "ETC_SCIF04";
                Salary = "18.00";
            }
            if (cmbSubject2.SelectedIndex == 14)
            {
                SubID = "ETC_SCIF05";
                Salary = "29.70";
            }
        }

        private void cmbSubject3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject3.SelectedIndex == 0)
            {
                SubID = "ETC_ENGF01";
                Salary = "8.75";
            }
            if (cmbSubject3.SelectedIndex == 1)
            {
                SubID = "ETC_ENGF02";
                Salary = "10.20";
            }
            if (cmbSubject3.SelectedIndex == 2)
            {
                SubID = "ETC_ENGF03";
                Salary = "14.20";
            }
            if (cmbSubject3.SelectedIndex == 3)
            {
                SubID = "ETC_ENGF04";
                Salary = "18.00";
            }
            if (cmbSubject3.SelectedIndex == 4)
            {
                SubID = "ETC_ENGF05";
                Salary = "29.70";
            }
            if (cmbSubject3.SelectedIndex == 5)
            {
                SubID = "ETC_MTSF01";
                Salary = "8.75";
            }
            if (cmbSubject3.SelectedIndex == 6)
            {
                SubID = "ETC_MTSF02";
                Salary = "10.20";
            }
            if (cmbSubject3.SelectedIndex == 7)
            {
                SubID = "ETC_MTSF03";
                Salary = "14.20";
            }
            if (cmbSubject3.SelectedIndex == 8)
            {
                SubID = "ETC_MTSF04";
                Salary = "18.00";
            }
            if (cmbSubject3.SelectedIndex == 9)
            {
                SubID = "ETC_MTSF05";
                Salary = "29.70";
            }
            if (cmbSubject3.SelectedIndex == 10)
            {
                SubID = "ETC_SCIF01";
                Salary = "8.75";
            }
            if (cmbSubject3.SelectedIndex == 11)
            {
                SubID = "ETC_SCIF02";
                Salary = "10.20";
            }
            if (cmbSubject3.SelectedIndex == 12)
            {
                SubID = "ETC_SCIF03";
                Salary = "14.20";
            }
            if (cmbSubject3.SelectedIndex == 13)
            {
                SubID = "ETC_SCIF04";
                Salary = "18.00";
            }
            if (cmbSubject3.SelectedIndex == 14)
            {
                SubID = "ETC_SCIF05";
                Salary = "29.70";
            }
        }

        private void dof_ValueChanged(object sender, EventArgs e)
        {
            dob.CustomFormat = "dd/MM/yyy";
        }

        private void dof_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Back) 
            {
                dob.CustomFormat = " ";
            }
        }

    }
}
