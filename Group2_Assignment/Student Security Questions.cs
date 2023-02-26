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
    public partial class Student_Security_Questions : Form
    {
        public static string id;

        public Student_Security_Questions()
        {
            InitializeComponent();
        }

        public Student_Security_Questions(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal sp = new Student_Portal();
            sp.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFAns.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtFAns.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtSecAns.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                txtSecAns.Focus();
            }

            else
            {
                Student obj1 = new Student(id);
                MessageBox.Show(obj1.updateAns(txtFAns.Text, txtSecAns.Text, id));
            }
        }

        private void Student_Security_Questions_Load(object sender, EventArgs e)
        {
            txtFAns.Focus();
            Student obj1 = new Student(id);
            Student.viewSecurityQuestion(obj1);
            txtFAns.Text = obj1.Ans_q1;
            txtSecAns.Text = obj1.Ans_q2;
        }
    }
}
