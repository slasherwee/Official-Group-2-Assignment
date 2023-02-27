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
    public partial class Student_Change_Subject : Form
    {
        public static string id;
        private Color _formColor;

        public Student_Change_Subject()
        {
            InitializeComponent();
        }

        public Student_Change_Subject(Color formColor)
        {
            InitializeComponent();
            _formColor = formColor;
        }

        public Student_Change_Subject(string i, Color formColor)
        {
            InitializeComponent();
            id = i;
            _formColor = formColor;
        }

        private void btnRequestChangeSub_Click(object sender, EventArgs e)
        {
            Student_Request_Change_Subject studReq = new Student_Request_Change_Subject(id,this.BackColor);
            studReq.ShowDialog();
            this.Close();
        }

        private void btnViewChangeSubStat_Click(object sender, EventArgs e)
        {
            Student_View_Change_Subject_Status studViewStat = new Student_View_Change_Subject_Status(id, this.BackColor);
            studViewStat.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Portal studPortal = new Student_Portal(this.BackColor);
            studPortal.ShowDialog();
            this.Close();
        }

        private void Student_Change_Subject_Load(object sender, EventArgs e)
        {
            this.BackColor = _formColor;
        }


    }
}
