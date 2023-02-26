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
    public partial class frm_delete_student_page_4 : Form
    {
        public frm_delete_student_page_4()
        {
            InitializeComponent();
        }
        public string Stud_ID { get; set; }

        private void frm_delete_student_page_4_Load(object sender, EventArgs e)
        {
            Delete_Student obj1 = new Delete_Student(Stud_ID);
            Delete_Student obj2 = new Delete_Student(Stud_ID);
            Delete_Student obj3 = new Delete_Student(Stud_ID);
            Delete_Student obj4 = new Delete_Student(Stud_ID);
            Delete_Student obj5 = new Delete_Student(Stud_ID);
            Delete_Student obj6 = new Delete_Student(Stud_ID);
            Delete_Student obj7 = new Delete_Student(Stud_ID);
            Delete_Student obj8 = new Delete_Student(Stud_ID);
            Delete_Student obj9 = new Delete_Student(Stud_ID);
            Delete_Student obj10 = new Delete_Student(Stud_ID);
            lbl_num_of_sub.Text = (obj1.subject_detail_3(Stud_ID));
            lbl_year_of_enrol.Text = (obj2.subject_detail_4(Stud_ID));
            lbl_month_of_enrol.Text = (obj3.subject_detail_5(Stud_ID));
            lbl_level_of_sub.Text = (obj4.subject_detail_7(Stud_ID));
            lbl_sc_1.Text = (obj5.subject_detail_1(Stud_ID));
            lbl_sub_1.Text= (obj6.subject_detail_6(Stud_ID));
            lbl_sub_2.Text = (obj7.subject_detail_8(Stud_ID));
            lbl_sub_3.Text = (obj8.subject_detail_9(Stud_ID));
            lbl_sc_2.Text = (obj9.subject_detail_10(Stud_ID));
            lbl_sc_3.Text = (obj10.subject_detail_11(Stud_ID));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_delete_student_page_5 secondForm = new frm_delete_student_page_5();
            secondForm.Stud_ID= Stud_ID;
            secondForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Delete_page_page_3 firstForm = new frm_Delete_page_page_3();
            firstForm.Stud_ID = Stud_ID;
            firstForm.ShowDialog();
        }
    }
}
