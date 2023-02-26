using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Assignment
{
    internal class Delete_Student
    {
        // These private fields represent the Delete_Student attributes.
        private string stud_fname;
        private string stud_lname;
        private string stud_Ic_or_pass_num;
        private string stud_Ic_or_pass;
        private string s_ID;
        private string stud_contact_no;
        private string stud_house_adr;
        private string stud_email;
        private string stud_gender;
        private string student_dob;
        private string student_nationality;

        private string pg_fname;
        private string pg_lname;
        private string pg_email;
        private string pg_contact_no;
        private string pg_occupation;
        private string pg_relationship;
        private string pg_ic_or_pass_num;
        private string pg_ic_or_pass;
        private string pg_house_adr;
        private string pg_gender;
        private string student_id;
        private string student_name;
        private string activate_acc;
        private string account_type;
        private string sub_id;
        private string sub_num_of_sub;
        private string sub_year_of_enrol;
        private string sub_month_of_enrol;
        private string sub_sub;
        private string sub_level_of_sub;

        // This static field represents a connection to a database.
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // These public properties provide access to the private fields.
        public string Stud_Ic_or_pass_num { get => stud_Ic_or_pass_num; set => stud_Ic_or_pass_num = value; }
        public string Stud_Ic_or_pass { get => stud_Ic_or_pass; set => stud_Ic_or_pass = value; }
        public string S_ID { get => s_ID; set => s_ID = value; }
        public string Stud_contact_no { get => stud_contact_no; set => stud_contact_no = value; }
        public string Stud_house_adr { get => stud_house_adr; set => stud_house_adr = value; }
        public string Stud_email { get => stud_email; set => stud_email = value; }
        public string Student_id { get => student_id; set => student_id = value; }
        public string Stud_gender { get => stud_gender; set => stud_gender = value; }
        public string Pg_email { get => pg_email; set => pg_email = value; }
        public string Pg_contact_no { get => pg_contact_no; set => pg_contact_no = value; }
        public string Pg_occupation { get => pg_occupation; set => pg_occupation = value; }
        public string Pg_relationship { get => pg_relationship; set => pg_relationship = value; }
        public string Pg_ic_or_pass_num { get => pg_ic_or_pass_num; set => pg_ic_or_pass_num = value; }
        public string Pg_ic_or_pass { get => pg_ic_or_pass; set => pg_ic_or_pass = value; }
        public string Pg_house_adr { get => pg_house_adr; set => pg_house_adr = value; }
        public string Pg_gender { get => pg_gender; set => pg_gender = value; }
        public string Activate_acc { get => activate_acc; set => activate_acc = value; }
        public string Account_type { get => account_type; set => account_type = value; }
        public string Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_num_of_sub { get => sub_num_of_sub; set => sub_num_of_sub = value; }
        public string Sub_year_of_enrol { get => sub_year_of_enrol; set => sub_year_of_enrol = value; }
        public string Sub_month_of_enrol { get => sub_month_of_enrol; set => sub_month_of_enrol = value; }
        public string Sub_sub { get => sub_sub; set => sub_sub = value; }
        public string Sub_level_of_sub { get => sub_level_of_sub; set => sub_level_of_sub = value; }
        public string Student_nationality { get => student_nationality; set => student_nationality = value; }
        public string Student_dob { get => student_dob; set => student_dob = value; }

        public Delete_Student(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            // Constructor with 11 parameters to initialize the properties of the Delete_Student class.
            // Assigns the values of the passed parameters to the respective properties of the class.
            S_ID = a;
            Stud_email = b;
            Stud_contact_no = c;
            stud_fname = d;
            stud_lname = e;
            Stud_Ic_or_pass = f;
            Stud_Ic_or_pass_num = g;
            Stud_house_adr = h;
            Stud_gender = i;
            Student_nationality = j;
            Student_dob = k;
        }

        public Delete_Student(string d, string e)
        {
            // Constructor with 2 parameters to initialize the properties of the Delete_Student class.
            // Assigns the values of the passed parameters to the respective properties of the class.
            stud_fname = d;
            stud_lname = e;
        }
        public Delete_Student(string j, string k, string l, string m, string n, string o, string p, string q, string r, string s)
        {
            // Constructor with 10 parameters to initialize the properties of the Delete_Student class.
            // Assigns the values of the passed parameters to the respective properties of the class.
            pg_fname = j;
            pg_lname = k;
            Pg_contact_no = l;
            Pg_email = m;
            Pg_gender = n;
            Pg_house_adr = o;
            Pg_ic_or_pass = p;
            Pg_ic_or_pass_num = q;
            Pg_occupation = r;
            Pg_relationship = s;
        }
        public Delete_Student(string id, string ac, string ad)
        {
            // Constructor with 3 parameters to initialize the properties of the Delete_Student class.
            // Assigns the values of the passed parameters to the respective properties of the class.
            Student_id = id;
            Activate_acc = ac;
            student_name = ad;
        }
        public Delete_Student(string ad)
        {
            // Constructor with 1 parameter to initialize the properties of the Delete_Student class.
            // Assigns the value of the passed parameter to the student_name property of the class.
            student_name = ad;
        }
        public Delete_Student(string s, string t, string u, string x, string y, string z)
        {
            // Constructor with 6 parameters to initialize the properties of the Delete_Student class.
            // Assigns the values of the passed parameters to the respective properties of the class.
            Sub_id = s;
            Sub_level_of_sub = y;
            Sub_month_of_enrol = z;
            Sub_num_of_sub = t;
            Sub_sub = u;
            Sub_year_of_enrol = x;
        }

        public string find_student_id_delete(string un)
        {
            S_ID= un;
            string delete;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*)from STUDENT_T where student_Id =@id", con);
                    SqlCommand cmd2 = new SqlCommand("select count(*) from PARENTS_OR_GUARDIAN_T where stud_id =@sid", con);
                    {
                        cmd.Parameters.AddWithValue("@id",S_ID);
                        cmd2.Parameters.AddWithValue("@sid", S_ID);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            delete = "Student ID exist";
                        }
                        else
                        {
                            delete = "Student ID does not exist";
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // log the error message or display it to the user
                    delete = "An error occurred: " + ex.Message;
                }
            }
            return delete;
        }
        public string student_detail_1(string un)
        {
            string a = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string studentId = reader.GetString(0);
                    a = studentId.ToString();
                }
            }
            con.Close();
            return a;
        }
        public string student_detail_2(string un)
        {
            string b = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string studentfName = reader.GetString(1);
                    b = studentfName.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string student_detail_3(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string studentlname = reader.GetString(2);
                    c = studentlname.ToString();
                }
            }
            con.Close();
            return c;
        }
        public string student_detail_4(string un)
        {
            string d = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_ic_or_passport_num = reader.GetString(3);
                    d = student_ic_or_passport_num.ToString();
                }
            }
            con.Close();
            return d;
        }
        public string student_detail_5(string un)
        {
            string e = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_ic_or_passport = reader.GetString(4);
                    e = student_ic_or_passport.ToString();
                }
            }
            con.Close();
            return e;
        }
        public string student_detail_6(string un)
        {
            string f = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_email = reader.GetString(5);
                    f = student_email.ToString();
                }
            }
            con.Close();
            return f;
        }
        public string student_detail_7(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_contact_no = reader.GetString(6);
                    g = student_contact_no.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string student_detail_8(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_house_adr = reader.GetString(7);
                    g = student_house_adr.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string student_detail_9(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_gender = reader.GetString(8);
                    g = student_gender.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string student_detail_10(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id = @id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime student_dob = reader.GetDateTime(9);
                    g = student_dob.ToString("yyyy-MM-dd");
                }
            }
            con.Close();
            return g;
        }

        public string student_detail_11(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_nationality = reader.GetString(10);
                    g = student_nationality.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string pog_detail_1(string un)
        {
            string b = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pogfName = reader.GetString(1);
                    b = pogfName.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string pog_detail_2(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string poglname = reader.GetString(2);
                    c = poglname.ToString();
                }
            }
            con.Close();
            return c;
        }
        public string pog_detail_3(string un)
        {
            string d = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_email = reader.GetString(3);
                    d = pog_email.ToString();
                }
            }
            con.Close();
            return d;
        }
        public string pog_detail_4(string un)
        {
            string e = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_contact_no = reader.GetString(4);
                    e = pog_contact_no.ToString();
                }
            }
            con.Close();
            return e;
        }
        public string pog_detail_5(string un)
        {
            string f = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_occupation = reader.GetString(5);
                    f = pog_occupation.ToString();
                }
            }
            con.Close();
            return f;
        }
        public string pog_detail_6(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_relationship = reader.GetString(6);
                    g = pog_relationship.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string pog_detail_7(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_ic_or_passport_number = reader.GetString(7);
                    g = pog_ic_or_passport_number.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string pog_detail_8(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_ic_or_passport = reader.GetString(8);
                    g = pog_ic_or_passport.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string pog_detail_10(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pog_gender = reader.GetString(9);
                    g = pog_gender.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string pog_detail_11(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string stud_id = reader.GetString(0);
                    g = stud_id.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string subject_detail_1(string un)
        {
            string a = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
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
        public string subject_detail_2(string un)
        {
            string b = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_id = reader.GetString(0);
                    b = student_id.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string subject_detail_3(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_num_of_sub = reader.GetString(4);
                    c = subject_num_of_sub.ToString();
                }
            }
            con.Close();
            return c;
        }
        public string subject_detail_4(string un)
        {
            string d = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_year_of_enrol = reader.GetString(5);
                    d = subject_year_of_enrol.ToString();
                }
            }
            con.Close();
            return d;
        }
        public string subject_detail_5(string un)
        {
            string e = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_month_of_enrol = reader.GetString(6);
                    e = subject_month_of_enrol.ToString();
                }
            }
            con.Close();
            return e;
        }
        public string subject_detail_6(string un)
        {
            string f = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_1 = reader.GetString(7);
                    f = subject_sub_1.ToString();
                }
            }
            con.Close();
            return f;
        }
        public string subject_detail_7(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string sub_level_of_subject = reader.GetString(10);
                    g = sub_level_of_subject.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string subject_detail_8(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_2 = reader.GetString(8);
                    g = subject_sub_2.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string subject_detail_9(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_sub_3 = reader.GetString(9);
                    g = subject_sub_3.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string subject_detail_10(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_id_sub_2 = reader.GetString(2);
                    g = subject_id_sub_2.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string subject_detail_11(string un)
        {
            string g = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string subject_id_sub_3 = reader.GetString(3);
                    g = subject_id_sub_3.ToString();
                }
            }
            con.Close();
            return g;
        }
        public string account_detail_1(string un)
        {
            string a = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM USER_T WHERE Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
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
        public string account_detail_2(string un)
        {
            string b = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_fname = reader.GetString(1);
                    b = student_fname.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string account_detail_3(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM USER_T WHERE Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_password = reader.GetString(2);
                    c = acc_password.ToString();
                }
            }
            con.Close();
            return c;
        }
        public string account_detail_4(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM USER_T WHERE Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_type = reader.GetString(2);
                    c = acc_type.ToString();
                }
            }
            con.Close();
            return c;
        }

        public string account_detail_5(string un)
        {
            string b = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_lname = reader.GetString(2);
                    b = student_lname.ToString();
                }
            }
            con.Close();
            return b;
        }
        public string delete_data_master(string un)
        {
            string c = string.Empty;
            S_ID = un;
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT_T WHERE student_id = @id", con);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM PARENTS_OR_GUARDIAN_T WHERE stud_id =@id", con);
            SqlCommand cmd3 = new SqlCommand("DELETE FROM SUBJECT_LQT WHERE student_id =@id", con);
            SqlCommand cmd4 = new SqlCommand("DELETE FROM USER_T WHERE Id =@id", con);
            cmd.Parameters.AddWithValue("@id", S_ID);
            cmd2.Parameters.AddWithValue("@id", S_ID);
            cmd3.Parameters.AddWithValue("@id", S_ID);
            cmd4.Parameters.AddWithValue("@id", S_ID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_type = reader.GetString(2);
                    c = acc_type.ToString();
                }
            }
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_type = reader.GetString(2);
                    c = acc_type.ToString();
                }
            }
            using (SqlDataReader reader = cmd3.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_type = reader.GetString(2);
                    c = acc_type.ToString();
                }
            }
            using (SqlDataReader reader = cmd4.ExecuteReader())
            {
                while (reader.Read())
                {
                    string acc_type = reader.GetString(2);
                    c = acc_type.ToString();
                }
            }
            con.Close();
            return c;
        }
    }
}

