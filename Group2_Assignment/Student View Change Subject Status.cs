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
    public partial class Student_View_Change_Subject_Status : Form
    {
        public static string id;
        private Color _formColor;

        public Student_View_Change_Subject_Status()
        {
            InitializeComponent();
        }

        public Student_View_Change_Subject_Status(string i, Color formColor)
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

        private void Student_View_Change_Subject_Status_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
            txtRequestID.Focus();
            Student obj1 = new Student(id);
            DataTable vrs = obj1.viewRequestStatus(obj1);
            dgvRequestStatus.DataSource = vrs;
        }

        private void btnDelReq_Click(object sender, EventArgs e)
        {
            if (txtRequestID.Text == "")
            {
                MessageBox.Show("Please enter request ID to proceed.");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete your request?", "Delete Pending Request", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Student obj1 = new Student(id, txtRequestID.Text);
                    MessageBox.Show(obj1.deleteRequest());
                    DataTable vrs = obj1.viewRequestStatus(obj1);
                    dgvRequestStatus.DataSource = vrs;
                }
            }
        }

        private void txtRequestID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Request ID should contain digit only. Please try again.");
            }
        }
    }
}
