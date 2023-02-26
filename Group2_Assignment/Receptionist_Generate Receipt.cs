using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frm_generate_Receipt : Form
    {
        public frm_generate_Receipt()
        {
            InitializeComponent();
        } 
        public string Receipt_no { get; set; }
        private void btn_generate_receipt_Click(object sender, EventArgs e)
        {
            Payment_section obj1 = new Payment_section(txt_stud_id.Text);
            Payment_section obj2 = new Payment_section(txt_receipt_no.Text);
            lbl_status_1.Text = obj1.find_id_receipt_generator(txt_stud_id.Text);
            if (lbl_status_1.Text == "Student ID exist")
            {
                lbl_status_2.Text = obj2.find_receipt_no_payment(txt_receipt_no.Text);
                if (lbl_status_2.Text == "Receipt No exist")
                {
                    frm_payment_receipt secondForm = new frm_payment_receipt();
                    secondForm.Receipt_no = txt_receipt_no.Text;
                    secondForm.Show();
                }
                else
                {
                    MessageBox.Show("Receipt No does not exist", "Receipt");
                    MessageBox.Show("Please enter an existing Receipt No", "Receipt");
                }
            }
            else
            {
                MessageBox.Show("Student ID does not exist", "Receipt");
                MessageBox.Show("Please enter an existing Student ID", "Receipt");
            }
        }

        private void frm_generate_Receipt_Load(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu secondForm = new frm_Main_Menu();
            secondForm.ShowDialog();
        }

        private void gb_receipt_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
