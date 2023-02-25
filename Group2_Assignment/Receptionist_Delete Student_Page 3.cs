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
    public partial class frm_Delete_page_page_3 : Form
    {
        public frm_Delete_page_page_3()
        {
            InitializeComponent();
        }
        public string Stud_ID { get; set; }

        private void frm_Delete_page_page_3_Load(object sender, EventArgs e)
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
            Delete_Student obj11 = new Delete_Student(Stud_ID);
            obj11.pog_detail_11(Stud_ID);
            lbl_first_name.Text = obj1.pog_detail_1(Stud_ID);
            lbl_pog_lname.Text = obj2.pog_detail_2(Stud_ID);
            lbl_pog_ic_or_pass_num.Text = obj3.pog_detail_7(Stud_ID);
            lbl_pog_ic_or_pass.Text = obj4.pog_detail_8(Stud_ID);
            lbl_pog_gender.Text = obj5.pog_detail_10(Stud_ID);
            lbl_pog_email.Text = obj6.pog_detail_3(Stud_ID);
            lbl_pog_contact_no.Text = obj7.pog_detail_4(Stud_ID);
            lbl_occupation_1.Text = obj8.pog_detail_5(Stud_ID);
            lbl_relationship_1.Text = obj9.pog_detail_6(Stud_ID);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_delete_student_page_4 secondForm = new frm_delete_student_page_4();
            secondForm.Stud_ID = Stud_ID;
            secondForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Delete_Student_Page_2 firstForm = new frm_Delete_Student_Page_2();
            firstForm.Stud_ID = Stud_ID;
            firstForm.Show();
        }
    }
}
