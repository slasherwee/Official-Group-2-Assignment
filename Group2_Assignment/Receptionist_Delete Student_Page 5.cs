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
    public partial class frm_delete_student_page_5 : Form
    {
        public frm_delete_student_page_5()
        {
            InitializeComponent();
        }
        public string Stud_ID { get; set; }

        private void frm_delete_student_page_5_Load(object sender, EventArgs e)
        {
            string f = null;
            string g = null;

            Delete_Student obj1 = new Delete_Student(Stud_ID);
            Delete_Student obj2 = new Delete_Student(Stud_ID);
            Delete_Student obj3 = new Delete_Student(Stud_ID);
            Delete_Student obj4 = new Delete_Student(Stud_ID);
            Delete_Student obj5 = new Delete_Student(Stud_ID);
            lbl_student_id_1.Text = (obj1.account_detail_1(Stud_ID));
            f = obj2.account_detail_2(Stud_ID);
            g= obj5.account_detail_5(Stud_ID);
            lbl_student_name_1.Text = ((f) +" "+ (g));
            lbl_password_1.Text = (obj3.account_detail_3(Stud_ID));
            lbl_activate_acc_1.Text = (obj4.account_detail_4(Stud_ID));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_delete_student_page_4 firstForm = new frm_delete_student_page_4();
            firstForm.Stud_ID = Stud_ID;
            firstForm.Show();
        }
    }
}
