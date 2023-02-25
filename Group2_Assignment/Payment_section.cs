using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Assignment
{
    internal class Payment_section
    {
        private string subject_selected;
        private string calculate_total_amount;
        private string student_id;
        private string student_name;
        private string date;
        private string payment_method;
        private string remarks;
        private string payment_total;
        private string receipt_no;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Subject_selected { get => subject_selected; set => subject_selected = value; }
        public string Calculate_total_amount { get => calculate_total_amount; set => calculate_total_amount = value; }
        public string Student_id { get => student_id; set => student_id = value; }
        public string Date { get => date; set => date = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Payment_total { get => payment_total; set => payment_total = value; }
        public string Receipt_no { get => receipt_no; set => receipt_no = value; }

        public Payment_section(string ss, string cta)
        {
            Subject_selected = ss;
            Calculate_total_amount = cta;
        }
        public Payment_section(string sid, string sname, string date, string pm, string remarks, string paytotal)
        {
            Student_id = sid;
            student_name = sname;
            Date = date;
            Payment_method = pm;
            Remarks = remarks;
            Payment_total = paytotal;
        }
        public Payment_section(string sname)
        {
            student_name = sname;
        }

        public string payment_receipt(string ua, string ub, string uc, string ud, string ue, string uf)
        {
            Remarks = ua;
            Student_id = ub;
            student_name = uc;
            Payment_method= ud;
            Date = ue;
            Payment_total = uf;

            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO RECEIPT_T (student_id, student_name, payment_total, payment_date, payment_method, payment_remarks) VALUES (@sid, @sname, @paytotal, @paydate, @paymethod, @payremarks)", con);
            cmd.Parameters.AddWithValue("@sid", Student_id);
            cmd.Parameters.AddWithValue("@sname", Date);
            cmd.Parameters.AddWithValue("@paytotal", Payment_total);
            cmd.Parameters.AddWithValue("@paymethod", Payment_method);
            cmd.Parameters.AddWithValue("@payremarks", Remarks);
            if (DateTime.TryParse(Date, out DateTime d))
            {
                cmd.Parameters.AddWithValue("@paydate", d);
            }
            else
            {
                MessageBox.Show("The string could not be parsed to a DateTime value");
            }

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Payment Successful.";
            else
                status = "Payment Unsuccessful.";

            con.Close();
            return status;
        }
        public string generate_receipt_1(string un)
        {
            Receipt_no = un;
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string studentId = reader.GetString(1);
                    a = studentId.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string generate_receipt_2(string un)
        {
            Receipt_no = un;
            string b = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string studentName = reader.GetString(2);
                    b = studentName.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string generate_receipt_3(string un)
        {
            Receipt_no = un;
            string c = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    decimal paymentTotal = reader.GetDecimal(3);
                    c = paymentTotal.ToString();
                }
            }
            con.Close();
            return c;
        }
        private DateTime currentDate;
        public string generate_receipt_4(string un)
        {
            Receipt_no = un;
            string d = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentDate = reader.GetDateTime(4);
                    d = currentDate.ToString("d");
                }
            }
            con.Close();
            return d;
        }
        public string generate_receipt_5(string un)
        {
            Receipt_no = un;
            string e = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string paymentMethod = reader.GetString(5);
                    e = paymentMethod.ToString();
                }
            }
            con.Close();
            return e;
        }
        public string generate_receipt_6(string un)
        {
            Receipt_no = un;
            string f = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string paymentRemarks = reader.GetString(6);
                    f = paymentRemarks.ToString();
                }
            }
            con.Close();
            return f;
        }
        public string generate_receipt_7(string un)
        {
            Receipt_no = un;
            string g = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM RECEIPT_T WHERE receipt_no = @no", con);
            cmd2.Parameters.AddWithValue("@no", Receipt_no);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    int studentId = reader.GetInt32(0);
                    g = studentId.ToString();
                }
            }
            con.Close();
            return g;
        }

        public string find_id_payment(string un)
        {
            string receipt;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from STUDENT_T where student_id =@id", con);
                    {
                        cmd.Parameters.AddWithValue("@id", student_name);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            receipt = "Student ID exist";
                        }
                        else
                        {
                            receipt = "Student ID does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    receipt = "An error occurred: " + ex.Message;
                }
            }
            return receipt;
        }
        public string find_receipt_no_payment(string un)
        {
            Receipt_no = un;
            string receipt;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from RECEIPT_T where receipt_no =@no", con);
                    {
                        cmd.Parameters.AddWithValue("@no", Receipt_no);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            receipt = "Receipt No exist";
                        }
                        else
                        {
                            receipt = "Receipt No does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    receipt = "An error occurred: " + ex.Message;
                }
            }
            return receipt;
        }
        public string find_id_receipt_generator(string un)
        {
            string receipt;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from RECEIPT_T where student_id =@id", con);
                    {
                        cmd.Parameters.AddWithValue("@id", student_name);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            receipt = "Student ID exist";
                        }
                        else
                        {
                            receipt = "Student ID does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    receipt = "An error occurred: " + ex.Message;
                }
            }
            return receipt;
        }

        private List<double> selectedValues;

        public void CheckListBoxCalculator()
        {
            selectedValues = new List<double>();
        }

        public string ShowSelected(CheckedListBox checkedListBox)
        {
            decimal totalValue = 0.00m;
            StringBuilder selectedItems = new StringBuilder();
            int selectedCount = 0;

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    selectedCount++;
                    selectedItems.AppendLine(checkedListBox.Items[i].ToString());

                    // Retrieve the value from the database table based on the selected item
                    string selectedItem = checkedListBox.Items[i].ToString();
                    decimal value = GetValueFromDatabase(selectedItem);

                    if (value != 0.00m)
                    {
                        totalValue += value;
                    }
                    else
                    {
                        selectedCount--;
                    }
                }
            }

            if (selectedCount >= 2)
            {
                MessageBox.Show("Selected items: \n" + selectedItems.ToString() + "\nTotal value: " + totalValue.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Please select at least 2 items");
            }

            return totalValue.ToString();
        }



        private decimal GetValueFromDatabase(string selectedItem)
        {
            decimal value = 0.00m;
            con.Open();
            using (SqlCommand command = new SqlCommand("SELECT subject_price FROM PRICE_T WHERE subject_price = @Subject", con))
            {
                command.Parameters.Add("@Subject", SqlDbType.NVarChar, 50).Value = selectedItem;
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    if (decimal.TryParse(result.ToString(), out value))
                    {
                        MessageBox.Show("Value successfully parsed to decimal");
                    }
                    else
                    {
                        MessageBox.Show("Value could not be parsed to decimal");
                        // Handle the error here
                    }
                }
            }
            con.Close();
            return value;
        }

    public class CheckedListBoxClass
        {
            private string mgb;

            private CheckedListBox checkedListBox1;

            public CheckedListBoxClass(string bb)
            {
                mgb = bb;
                checkedListBox1 = new CheckedListBox();
            }

            public static List<string> CheckedItems = new List<string>();

            public static void AddCheckedItem(string item)
            {
                CheckedItems.Add(item);
            }

            public static void RemoveCheckedItem(string item)
            {
                CheckedItems.Remove(item);
            }

            public static List<string> GetCheckedItems()
            {
                return CheckedItems;
            }

            public string GetCheckedItems(string un)
            {
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    // If so, loop through all checked items and print results.  
                    string s = "";
                    for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                    {
                        s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                    }
                    MessageBox.Show(s);
                }

                if (checkedListBox1.Text == "")
                {
                    checkedListBox1.Text = "No items are checked.";
                }

                return checkedListBox1.Text;
            }

        }
    }
}
