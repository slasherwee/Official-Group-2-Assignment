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

        // Method definition for a click event handler for a button
        private void btn_next_Click(object sender, EventArgs e)
        {
            // Creates a new StringBuilder object for storing selected items
            StringBuilder selectedItems = new StringBuilder();
            // Initializes a counter variable to keep track of the number of selected items
            int selectedCount = 0;
            // Loops through all items in a CheckedListBox control
            for (int i = 0; i < clb_select_subject.Items.Count; i++)
            {
                // Checks if the current item is checked
                if (clb_select_subject.GetItemChecked(i))
                {
                    // Increments the selected item counter
                    selectedCount++;
                    // Appends the name of the selected item to the StringBuilder object
                    selectedItems.AppendLine(clb_select_subject.Items[i].ToString());
                    // Checks if the maximum number of selectable items has been reached
                    if (selectedCount == 3)
                    {
                        break; // Exits the loop if the maximum number of selectable items has been reached
                    }
                }
            }
            // Checks if at least one item has been selected
            if (selectedCount >= 1)
            {
                // Displays a message box showing the selected items
                MessageBox.Show("Selected items: \n" + selectedItems.ToString() , "Items Selected");
                // Creates a new instance of the SubjectPriceCalculator class with a connection string parameter
                var calculator = new SubjectPriceCalculator("your connection string");
                // Casts the checked items in the CheckedListBox to a collection of strings
                var checkedItems = clb_select_subject.CheckedItems.Cast<string>();
                // Calculates the total price of the selected items using the SubjectPriceCalculator class
                var totalPrice = calculator.CalculateTotalPrice(checkedItems);
                // Displays a message box showing the total price in currency format
                MessageBox.Show($" {totalPrice:C}" , "Total Amount");
                // Hides the current form
                this.Hide();
                // Creates a new instance of the frm_payment_section_b form
                frm_payment_section_b secondForm = new frm_payment_section_b();
                // Sets the TotalPrice property of the frm_payment_section_b form to the calculated total price
                secondForm.TotalPrice = totalPrice;
                // Displays the frm_payment_section_b form
                secondForm.Show();

            }
            // If no items are selected
            else
            {
                // Displays a message box prompting the user to select at least one item
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
