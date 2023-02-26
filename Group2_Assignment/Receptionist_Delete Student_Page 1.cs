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
    public partial class frm_delete_student_page_1 : Form
    {
        public frm_delete_student_page_1()
        {
            InitializeComponent();
        }
        public string Stud_ID { get; set; }
        private void btn_view_record_Click(object sender, EventArgs e)
        {
            Delete_Student obj1 = new Delete_Student(txt_student_id.Text);
            lbl_status_1.Text = obj1.find_student_id_delete(txt_student_id.Text);
            if (lbl_status_1.Text == "Student ID exist")
            {
                frm_Delete_Student_Page_2 firstForm = new frm_Delete_Student_Page_2();
                firstForm.Stud_ID = txt_student_id.Text;
                firstForm.ShowDialog();
            } 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            Delete_Student obj1 = new Delete_Student(txt_student_id.Text);
            lbl_status_1.Text = obj1.find_student_id_delete(txt_student_id.Text);
            Stud_ID = txt_student_id.Text;
            if (lbl_status_1.Text == "Student ID exist")
            {
                string message = ("Are you sure you want to delete " + Stud_ID + " ? ");
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Delete_Student obj2 = new Delete_Student(txt_student_id.Text);
                    obj2.delete_data_master(txt_student_id.Text);
                    MessageBox.Show(Stud_ID + " has been deleted ");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.ShowDialog();
        }
    }
}
