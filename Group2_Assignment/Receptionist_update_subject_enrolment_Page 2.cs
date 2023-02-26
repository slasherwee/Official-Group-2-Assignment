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
    public partial class frm_update_subject_enrolment_page2 : Form
    {
        public frm_update_subject_enrolment_page2()
        {
            InitializeComponent();
        }
        public string Student_ID { get; set; }
        private void btn_proceed_Click(object sender, EventArgs e)
        {
            update_subject_enrolment obj1 = new update_subject_enrolment(Student_ID);
            lbl_status_1.Text = obj1.find_student_id_subject_enrolment(txt_student_id.Text);
            if (lbl_status_1.Text == "Student ID exist")
            {
                frm_update_subject_enrolment_page3 firstForm = new frm_update_subject_enrolment_page3();
                firstForm.Student_ID = txt_student_id.Text;
                firstForm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_update_subject_enrolment_page1 secondForm = new frm_update_subject_enrolment_page1();
            secondForm.ShowDialog();
        }
    }
}
