using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            int c = 0;
            string k = null;
            string pattern = @"^[a-zA-Z]+$";
            if (string.IsNullOrWhiteSpace(txt_stud_id.Text))
            {
                c = c - 1;
                MessageBox.Show("Please enter Student ID", "Student ID");
                return;
            }
            // Create a new Payment_section object "obj2" and pass the student ID entered in the "txt_stud_id" textbox as a parameter
            Payment_section obj2 = new Payment_section(txt_stud_id.Text);
            // Call the "find_id_payment" method of the "obj2" object and pass the student ID entered in the "txt_stud_id" textbox as a parameter
            obj2.find_id_payment(txt_stud_id.Text);
            // Check if the "k" variable is equal to "Student ID exist"
            if (k == "Student ID does not exist")
            {
                // If the "k" variable is equal to "Student ID exist", display a message box with the title "Student ID" and the message "Student ID exist"
                MessageBox.Show("Student ID does not exist", "Student ID");
                // Display another message box with the title "Student ID" and the message "Please enter existing Student ID"
                MessageBox.Show("Please enter an existing Student ID", "Student ID");
            }
            else
            {
                //Validation to ensure all textbox and combo box has an input and student name has no numbers entered//
                c = c + 1;
                if (string.IsNullOrWhiteSpace(txt_stud_name.Text))
                {
                    c = c - 1;
                    MessageBox.Show("Please enter student name", "Student Name");
                    return;
                }
                if (Regex.IsMatch(txt_stud_name.Text, pattern))
                {
                    c = c + 1;
                }
                else
                {
                    c = c - 1;
                    MessageBox.Show("Input contains invalid characters", "Student Name");
                }
                if (cb_payment_method.SelectedIndex != -1)
                {
                    c = c + 1;
                }
                else
                {
                    MessageBox.Show("Please select an option", "Payment Method Selection");
                    return;
                }
                if (c == 3)
                {
                    // If the "k" variable is not equal to "Student ID exist", create a new Payment_section object "obj1" and pass the values of the textboxes and comboboxes as parameters
                    Payment_section obj1 = new Payment_section(txt_remarks.Text, txt_stud_id.Text, txt_stud_name.Text, cb_payment_method.Text, dtp_date.Text, lbl_total_amount_1.Text);
                    // Call the "payment_receipt" method of the "obj1" object and pass the values of the textboxes and comboboxes as parameters
                    // Display the returned value in a message box
                    MessageBox.Show(obj1.payment_receipt(txt_remarks.Text, txt_stud_id.Text, txt_stud_name.Text, cb_payment_method.Text, dtp_date.Text, lbl_total_amount_1.Text));
                    // Hide the current form
                    this.Hide();
                    // Create a new instance of the frm_Main_Menu form and display it as a dialog box
                    frm_Main_Menu secondForm = new frm_Main_Menu();
                    secondForm.ShowDialog();
                }
                else
                {
                    c = 0;
                }
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
