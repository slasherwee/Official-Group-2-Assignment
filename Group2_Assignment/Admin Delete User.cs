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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Group2_Assignment
{
    public partial class frmAdminDeleteUser : Form
    {

        public frmAdminDeleteUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return value after the button is cliked
            DialogResult r1 = MessageBox.Show("Do you want to exit from the delete user page", "Confirmation", MessageBoxButtons.YesNo);
            if (r1 == DialogResult.Yes)
            {
                this.Hide();
                frmAdminMenu am = new frmAdminMenu();
                am.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                Admin obj1 = new Admin(cmbUserID.Text);
                MessageBox.Show(obj1.deleteTutor(obj1));
                cmbUserID.Text = obj1.ID;
                DataTable dt = obj1.ViewTutorForDelete();
                dataGridViewDelete.DataSource = dt;
            }
            if (cmbUserRole.SelectedIndex == 1)
            {
                Admin obj1 = new Admin(cmbUserID.Text);
                MessageBox.Show(obj1.deleteReceptionist(obj1));
                cmbUserID.Text = obj1.ID;
                DataTable dt = obj1.ViewReceptionistForDelete();
                dataGridViewDelete.DataSource = dt;
            }
            cmbUserID.Text = String.Empty;
            cmbUserID.Items.Clear();
            MessageBox.Show("Please select User role again.");
            cmbUserRole.SelectedIndex = 0;
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin obj1 = new Admin();
            if (cmbUserRole.Text == "Tutor")
            {
                cmbUserID.Text = String.Empty;
                cmbUserID.Items.Clear();
                DataTable dt = obj1.ViewTutorForDelete();
                dataGridViewDelete.DataSource = dt;
                ArrayList TutorID = new ArrayList();
                TutorID = Admin.TutorID();
                foreach (var item in TutorID)
                {
                    cmbUserID.Items.Add(item);
                }
            }
            else if (cmbUserRole.Text == "Receptionist")
            {
                cmbUserID.Text = String.Empty;
                cmbUserID.Items.Clear();
                DataTable dt = obj1.ViewReceptionistForDelete();
                dataGridViewDelete.DataSource = dt;
                ArrayList ReceptionistID = new ArrayList();
                ReceptionistID = Admin.ReceptionistID();
                foreach (var item in ReceptionistID)
                {
                    cmbUserID.Items.Add(item);
                }
            }
        }

    }
}
