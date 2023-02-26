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
    public partial class frm_update_subject_enrolment_page3 : Form
    {
        public frm_update_subject_enrolment_page3()
        {
            InitializeComponent();
        }
        public string Student_ID { get; set; }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_update_subject_enrolment_page2 firstForm = new frm_update_subject_enrolment_page2();
            firstForm.ShowDialog();
        }

        private void frm_update_subject_enrolment_view_Load(object sender, EventArgs e)
        {
            update_subject_enrolment obj1 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj2 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj3 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj4 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj5 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj6 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj7 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj8 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj9 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj10 = new update_subject_enrolment(Student_ID);
            update_subject_enrolment obj11 = new update_subject_enrolment(Student_ID);
            lbl_num_of_sub_1.Text = obj1.view_subject_enrolment_3(Student_ID);
            lbl_year_of_enrol_1.Text = obj2.view_subject_enrolment_4(Student_ID);
            lbl_level_of_sub_1.Text = obj3.view_subject_enrolment_7(Student_ID);
            lbl_month_of_enrol_1.Text = obj4.view_subject_enrolment_5(Student_ID);
            lbl_sub_1_name_1.Text = obj5.view_subject_enrolment_6(Student_ID);
            lbl_sub_1_code_1.Text = obj6.view_subject_enrolment_1(Student_ID);
            lbl_sub_2_code_1.Text = obj7.view_subject_enrolment_9(Student_ID);
            lbl_sub_2_name_1.Text = obj8.view_subject_enrolment_8(Student_ID);
            lbl_sub_3_code_1.Text = obj9.view_subject_enrolment_10(Student_ID);
            lbl_sub_3_name_1.Text = obj10.view_subject_enrolment_11(Student_ID);
        }

        private void lbl_update_subject_enrolment_Click(object sender, EventArgs e)
        {

        }
    }
}
