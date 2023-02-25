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
    public partial class frm_payment_section_b : Form
    {
        public frm_payment_section_b()
        {
            InitializeComponent();
        }
        public decimal TotalPrice { get; set; }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.ShowDialog();

        }


        private void btn_generate_receipt_Click(object sender, EventArgs e)
        {
            string k = null;
            Payment_section obj2 = new Payment_section(txt_stud_id.Text);
            obj2.find_id_payment(txt_stud_id.Text);
            if (k == "Student ID exist")
            {
                MessageBox.Show("Student ID exist", "Student ID");
                MessageBox.Show("Please enter existing Student ID", "Student ID");
            }
            else
            {
                Payment_section obj1 = new Payment_section(txt_remarks.Text, txt_stud_id.Text, txt_stud_name.Text, cb_payment_method.Text, dtp_date.Text, lbl_total_amount_1.Text);
                MessageBox.Show(obj1.payment_receipt(txt_remarks.Text, txt_stud_id.Text, txt_stud_name.Text, cb_payment_method.Text, dtp_date.Text, lbl_total_amount_1.Text));
                this.Hide();
                frm_Main_Menu secondForm = new frm_Main_Menu();
                secondForm.ShowDialog();
            }
        }

        private void frm_payment_section_b_Load(object sender, EventArgs e)
        {
            lbl_total_amount_1.Text = TotalPrice.ToString();
            cb_payment_method.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.ShowDialog();
        }
    }
}
