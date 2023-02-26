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

        public Student_Change_Subject()
        {
            InitializeComponent();
        }

        public Student_Change_Subject(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void btnRequestChangeSub_Click(object sender, EventArgs e)
        {
            Student_Request_Change_Subject studReq = new Student_Request_Change_Subject(id);
            studReq.ShowDialog();
            this.Close();
        }

        private void btnViewChangeSubStat_Click(object sender, EventArgs e)
        {
            Student_View_Change_Subject_Status studViewStat = new Student_View_Change_Subject_Status(id);
            studViewStat.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Portal studPortal = new Student_Portal(this.BackColor);
            studPortal.ShowDialog();
            this.Close();
        }
    }
}
