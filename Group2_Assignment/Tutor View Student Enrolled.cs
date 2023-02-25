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
    public partial class Tutor_View_Student_Enrolled : Form
    {
        public static string id;//global
        public Tutor_View_Student_Enrolled()
        {
            InitializeComponent();
        }

        public Tutor_View_Student_Enrolled(string a)
        {
            InitializeComponent();
            id = a;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal();
            tp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tutor obj1 = new Tutor(id);
            DataTable dt = obj1.viewStudent(cmbSubName.SelectedValue.ToString(), obj1);
            dgvStudent.DataSource = dt;
        }


        private void Tutor_View_Student_Enrolled_Load(object sender, EventArgs e)
        {
            Tutor obj1 = new Tutor(id);

            DataTable dt = obj1.viewSubject(obj1);
            cmbSubName.DataSource = dt;
            cmbSubName.DisplayMember = "sub_name";
            cmbSubName.ValueMember = "sub_name";
            cmbSubName.SelectedIndex = -1;
        }
    }
    
}
