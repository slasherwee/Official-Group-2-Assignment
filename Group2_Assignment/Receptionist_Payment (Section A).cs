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
using static Group2_Assignment.Payment_section;
using static Group2_Assignment.Subject_price_calculator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Assignment
{
    public partial class frm_payment_Section_A : Form
    {
        public frm_payment_Section_A()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> checkedItems = CheckedListBoxClass.GetCheckedItems();
            foreach (string item in checkedItems)
            {
                int index = clb_select_subject.Items.IndexOf(item);
                if (index != -1)
                {
                    clb_select_subject.SetItemChecked(index, true);
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            StringBuilder selectedItems = new StringBuilder();
            int selectedCount = 0;
            for (int i = 0; i < clb_select_subject.Items.Count; i++)
            {
                if (clb_select_subject.GetItemChecked(i))
                {
                    selectedCount++;
                    selectedItems.AppendLine(clb_select_subject.Items[i].ToString());

                    if (selectedCount == 3)
                    {
                        break;
                    }
                }
            }

            if (selectedCount >= 1)
            {
                MessageBox.Show("Selected items: \n" + selectedItems.ToString() , "Items Selected");
                var calculator = new SubjectPriceCalculator("your connection string");
                var checkedItems = clb_select_subject.CheckedItems.Cast<string>();
                var totalPrice = calculator.CalculateTotalPrice(checkedItems);
                MessageBox.Show($" {totalPrice:C}" , "Total Amount");
                this.Hide();
                frm_payment_section_b secondForm = new frm_payment_section_b();
                secondForm.TotalPrice = totalPrice;
                secondForm.Show();

            }

            else
            {
                MessageBox.Show("Please select at least one subject");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        private void frm_payment_Section_A_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu secondForm = new frm_Main_Menu();
            secondForm.Show();

        }
    }
}
