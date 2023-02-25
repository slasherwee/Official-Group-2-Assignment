using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Assignment
{
    internal class update_subject_enrolment
    {
        private string request_id;
        private string student_id;
        private string current_sub_id;
        private string new_sub_id;
        private string tutor_name;
        private string date;
        private string status;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Request_id { get => request_id; set => request_id = value; }
        public string Student_id { get => student_id; set => student_id = value; }
        public string Current_sub_id { get => current_sub_id; set => current_sub_id = value; }
        public string New_sub_id { get => new_sub_id; set => new_sub_id = value; }
        public string Tutor_name { get => tutor_name; set => tutor_name = value; }
        public string Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }

        public update_subject_enrolment(string b)
        {
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
        public string delete_request(string un)
        {
            string c = string.Empty;
            Request_id = un;
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM REQUEST_T WHERE request_id = @id", con);
            cmd.Parameters.AddWithValue("@id", Request_id);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string delete = reader.GetString(2);
                    c = delete.ToString();
                }
            }
            con.Close();
            return c;
        }
    }
}

