using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class Student_Request_Change_Subject : Form
    {
        public static string id;
        private Color _formColor;

        public Student_Request_Change_Subject()
        {
            InitializeComponent();
        }

        public Student_Request_Change_Subject(string i, Color formColor)
        {
            InitializeComponent();
            id = i;
            _formColor = formColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Change_Subject studChangeSub = new Student_Change_Subject(this.BackColor);
            studChangeSub.ShowDialog();
            this.Close();
        }

        private void Student_Request_Change_Subject_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            btnSendReq.Focus();
            Student obj1 = new Student(id);
            lblDateOutput.Text = DateTime.Now.ToString("MM-dd-yyyy");
            obj1.viewAllSubID();
            obj1.viewCurrentSubID();
            foreach (string allSub in obj1.viewAllSubID())
            {
                cmbNewSubID.Items.Add(allSub);
            }
            foreach (string currentSub in obj1.viewCurrentSubID())
            {
                cmbCurrentSubID.Items.Add(currentSub);
            }
        }

        private void btnSendReq_Click(object sender, EventArgs e)
        {
            if (cmbCurrentSubID.SelectedItem == null || cmbNewSubID.SelectedItem == null || cmbCurrentTutor.SelectedItem == null || cmbNewTutor.SelectedItem == null)
            {
                MessageBox.Show("Do not leave any blanks!");
            }
            else if ((cmbCurrentSubID.SelectedItem.ToString() == cmbNewSubID.SelectedItem.ToString()) && (cmbCurrentTutor.SelectedItem.ToString() == cmbNewTutor.SelectedItem.ToString()))
            {
                MessageBox.Show("Current subject and tutor is same as requested subject and requested tutor!");
            }
            else
            {
                Student obj1 = new Student(lblDateOutput.Text, cmbCurrentSubID.SelectedItem.ToString(), lblCurrentSubName.Text, cmbCurrentTutor.SelectedItem.ToString(), cmbNewSubID.SelectedItem.ToString(), lblNewSubNameOutput.Text, cmbNewTutor.SelectedItem.ToString(), id);
                MessageBox.Show(obj1.changeSubject());
            }
        }

        private void cmbNewSubID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNewTutor.Items.Clear();
            Student obj1 = new Student(id);
            Student.viewNewSubName(cmbNewSubID.SelectedItem.ToString(), obj1);
            lblNewSubNameOutput.Text = obj1.NewSubNameSelected;
            foreach (string tutor in obj1.viewNewTutor(cmbNewSubID.SelectedItem.ToString()))
            {
                cmbNewTutor.Items.Add(tutor);
            }
        }

        private void cmbCurrentSubID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCurrentTutor.Items.Clear();
            Student obj1 = new Student(id);
            Student.viewCurrentSubName(cmbCurrentSubID.SelectedItem.ToString(), obj1);
            lblCurrentSubNameOutput.Text = obj1.CurrentSubNameSelected;
            foreach (string tutor in obj1.viewCurrentTutor(cmbCurrentSubID.SelectedItem.ToString()))
            {
                cmbCurrentTutor.Items.Add(tutor);
            }

        }
    }
}
