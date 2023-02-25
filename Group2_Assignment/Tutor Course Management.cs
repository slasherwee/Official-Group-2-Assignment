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
    public partial class Tutor_Course_Management : Form
    {
        public static string id;//global
        public Tutor_Course_Management()
        {
            InitializeComponent();
        }

        public Tutor_Course_Management(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void Tutor_Course_Management_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Portal tp = new Tutor_Portal();
            tp.ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Add_Course tac = new Tutor_Add_Course(id);
            tac.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Manage_Course tmc = new Tutor_Manage_Course(id);
            tmc.ShowDialog();
        }
    }
}
