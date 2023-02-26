using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// This namespace contains the update_subject_enrolment class.
namespace Group2_Assignment
{
    // This class is marked as internal, which means it can only be accessed within the same assembly.
    internal class update_subject_enrolment
    {
        // These private fields will store the values of each property.
        private string request_id;
        private string student_id;
        private string current_sub_id;
        private string new_sub_id;
        private string tutor_name;
        private string date;
        private string status;
        // This static SqlConnection object will be used to connect to a database using a connection string from the configuration file.
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // This property allows access to the request_id private field.
        public string Request_id { get => request_id; set => request_id = value; }
        // This property allows access to the student_id private field.
        public string Student_id { get => student_id; set => student_id = value; }
        // This property allows access to the current_sub_id private field.
        public string Current_sub_id { get => current_sub_id; set => current_sub_id = value; }
        // This property allows access to the new_sub_id private field.
        public string New_sub_id { get => new_sub_id; set => new_sub_id = value; }
        // This property allows access to the tutor_name private field.
        public string Tutor_name { get => tutor_name; set => tutor_name = value; }
        // This property allows access to the date private field.
        public string Date { get => date; set => date = value; }
        // This property allows access to the status private field.
        public string Status { get => status; set => status = value; }

        // This is a constructor for the update_subject_enrolment class, which takes a string argument 'b'.

        public update_subject_enrolment(string b)
        {
            // The Student_id property is set to the value of 'b'.
            Student_id = b;
        }

        public DataTable GetRequestTable()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM REQUEST_T", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public string find_student_id_subject_enrolment(string un)
        {
            string find;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from SUBJECT_LQT where student_id =@id", con);
                    {
                        cmd.Parameters.AddWithValue("@id", un);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            find = "Student ID exist";
                        }
                        else
                        {
                            find = "Student ID does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    find = "An error occurred: " + ex.Message;
                }
            }
            return find;
        }
        public string view_subject_enrolment_1(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_id_sub_1 = reader.GetString(1);
                    a = subject_id_sub_1.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_2(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_id = reader.GetString(0);
                    a = student_id.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_3(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_num_of_sub = reader.GetString(4);
                    a = subject_num_of_sub.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_4(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_year_of_enrol = reader.GetString(5);
                    a = subject_year_of_enrol.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_5(string un)

        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_month_of_enrol = reader.GetString(6);
                    a = subject_month_of_enrol.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_6(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_1 = reader.GetString(7);
                    a = subject_sub_1.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_7(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string sub_level_of_subject = reader.GetString(10);
                    a = sub_level_of_subject.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_8(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_2 = reader.GetString(8);
                    a = subject_sub_2.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_9(string un)
        {
            string a = string.Empty;
            string b = " ";
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_id_sub_2 = reader.GetString(2);
                    a = subject_id_sub_2.ToString();
                    if (a == null)
                    {
                        b = " ";
                    }

                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_10(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_id_sub_3 = reader.GetString(3);
                    a = subject_id_sub_3.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string view_subject_enrolment_11(string un)
        {
            string a = string.Empty;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT", con);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_3 = reader.GetString(9);
                    a = subject_sub_3.ToString();
                }
            }
            con.Close();
            return a;
        }
        public void update_request(DataGridView dataGridView)
        {
            string approve = "APPROVE";
            string decline = "DECLINE";
            con.Open();
            string updateQuerySub1 = "UPDATE SUBJECT_LQT " +
                                     "SET subject_id_sub_1 = @newSubId, subject_sub_1 = @newSubName " +
                                     "WHERE subject_id_sub_1 = @currentSubId";
            string updateQuerySub2 = "UPDATE SUBJECT_LQT " +
                                     "SET subject_id_sub_2 = @newSubId, subject_sub_2 = @newSubName " +
                                     "WHERE subject_id_sub_2 = @currentSubId";
            string updateQuerySub3 = "UPDATE SUBJECT_LQT " +
                                     "SET subject_id_sub_3 = @newSubId, subject_sub_3 = @newSubName " +
                                     "WHERE subject_id_sub_3 = @currentSubId";

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["ANSWER"].Value != null && row.Cells["ANSWER"].Value.ToString() == "APPROVE")
                {
                    string studentId = row.Cells["student_id"].Value.ToString();
                    string currentSubId = row.Cells["current_sub_id"].Value.ToString();
                    string newSubId = row.Cells["new_sub_id"].Value.ToString();
                    string newSubName = row.Cells["new_sub_name"].Value.ToString();

                    SqlCommand cmd2 = new SqlCommand("UPDATE REQUEST_T SET request_status = @rst", con);
                    SqlCommand commandSub1 = new SqlCommand(updateQuerySub1, con);
                    SqlCommand commandSub2 = new SqlCommand(updateQuerySub2, con);
                    SqlCommand commandSub3 = new SqlCommand(updateQuerySub3, con);

                    cmd2.Parameters.AddWithValue("@rst", approve);
                    commandSub1.Parameters.AddWithValue("@newSubId", newSubId);
                    commandSub1.Parameters.AddWithValue("@newSubName", newSubName);
                    commandSub1.Parameters.AddWithValue("@currentSubId", currentSubId);
                    commandSub2.Parameters.AddWithValue("@newSubId", newSubId);
                    commandSub2.Parameters.AddWithValue("@newSubName", newSubName);
                    commandSub2.Parameters.AddWithValue("@currentSubId", currentSubId);
                    commandSub3.Parameters.AddWithValue("@newSubId", newSubId);
                    commandSub3.Parameters.AddWithValue("@newSubName", newSubName);
                    commandSub3.Parameters.AddWithValue("@currentSubId", currentSubId);

                    cmd2.ExecuteNonQuery();
                    commandSub1.ExecuteNonQuery();
                    commandSub2.ExecuteNonQuery();
                    commandSub3.ExecuteNonQuery();
                }
                else if (row.Cells["ANSWER"].Value != null && row.Cells["ANSWER"].Value.ToString() == "DECLINE")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE REQUEST_T SET request_status = @rst", con);
                    cmd.Parameters.AddWithValue("@rst", decline);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Updated successfully");
            con.Close();
        }
        public string find_request_id(string un)
        {
            Request_id = un;
            string request;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from REQUEST_T where request_id =@id", con);
                    {
                        cmd.Parameters.AddWithValue("@id", Request_id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            request = "Request ID exist";
                        }
                        else
                        {
                            request = "Request ID does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    request = "An error occurred: " + ex.Message;
                }
            }
            return request;
        }
        public string check_status(string un)
        {
            Request_id = un;
            string request;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT request_status FROM REQUEST_T WHERE request_id = @id AND request_status = 'pending'", con);
                    {
                        cmd.Parameters.AddWithValue("@id", Request_id);
                        string status = Convert.ToString(cmd.ExecuteScalar());

                        if (!string.IsNullOrEmpty(status) && status == "pending")
                        {
                            request = "Request ID exists and is pending";
                        }
                        else
                        {
                            request = "Request ID exists and status and answer has already been given";
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    request = "An error occurred: " + ex.Message;
                }
            }
            return request;
        }

        // The method delete's the request from student when updating subject enrolment
        public string delete_request(string un)
        {
            // Declare a string variable 'c' and initialize it with an empty string
            string c = string.Empty;
            // Assign the value of the 'un' parameter to the 'Request_id' variable
            Request_id = un;
            // Open a database connection
            con.Open();
            // Create a SqlCommand object with a DELETE SQL statement that deletes a row from the 'REQUEST_T' table where the 'request_id' column matches the value of the 'Request_id' variable
            SqlCommand cmd = new SqlCommand("DELETE FROM REQUEST_T WHERE request_id = @id", con);
            // Add a parameter '@id' to the SqlCommand object and assign it the value of the 'Request_id' variable using the 'AddWithValue' method
            cmd.Parameters.AddWithValue("@id", Request_id);
            // Execute the SQL command and retrieve the result set using a SqlDataReader object in a 'using' block to ensure proper disposal of resources
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) // While there are more rows in the result set, execute the following code block for each row
                {
                    // Retrieve the value of the third column in the current row of the result set using the 'GetString' method and assign it to the 'delete' variable
                    string delete = reader.GetString(2);
                    // Assign the value of the 'delete' variable converted to a string to the 'c' variable
                    c = delete.ToString();
                }
            }
            con.Close(); // Close the database connection
            return c; // Return the value of the 'c' variable
        }
    }
}

