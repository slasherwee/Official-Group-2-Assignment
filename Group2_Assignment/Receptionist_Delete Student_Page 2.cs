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
    public partial class frm_Delete_Student_Page_2 : Form
    {
        public frm_Delete_Student_Page_2()
        {
            InitializeComponent();
        }
        public string Stud_ID { get; set; }

        private void frm_Delete_Student_Page_2_Load(object sender, EventArgs e)
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
            Delete_Student obj11 = new Delete_Student(Stud_ID); 
            lbl_student_id_1.Text = (obj1.student_detail_1(Stud_ID));
            lbl_first_name.Text = (obj2.student_detail_2(Stud_ID));
            lbl_student_lname.Text = (obj3.student_detail_3(Stud_ID));
            lbl_ic_pass_num_1.Text = (obj4.student_detail_4(Stud_ID));
            lbl_ic_pass_1.Text = (obj5.student_detail_5(Stud_ID));
            lbl_student_email.Text = (obj6.student_detail_6(Stud_ID));
            lbl_student_contact_no.Text = (obj7.student_detail_7(Stud_ID));
            lbl_student_house_adr.Text = (obj8.student_detail_8(Stud_ID));
            lbl_student_gender.Text = (obj9.student_detail_9(Stud_ID));
            lbl_dob_1.Text = (obj10.student_detail_10(Stud_ID)); 
            lbl_nationality_1.Text = (obj11.student_detail_11(Stud_ID));
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Delete_page_page_3 secondForm = new frm_Delete_page_page_3();
            secondForm.Stud_ID = Stud_ID;
            secondForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu thirdForm = new frm_Main_Menu();
            thirdForm.Show();
        }

        private void gb_section_A_Enter(object sender, EventArgs e)
        {

        }
    }
}
