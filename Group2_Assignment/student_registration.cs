using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Group2_Assignment
{
    internal class student_registration
    {
        // Declare private fields for student registration
        private string stud_fname;
        private string stud_lname;
        private string stud_Ic_or_pass_num;
        private string stud_Ic_or_pass;
        private string s_ID;
        private string stud_contact_no;
        private string stud_house_adr;
        private string stud_email;
        private string student_id;
        private string stud_gender;
        private string stud_nationality;
        private string stud_dob;

        private string pog_stud_id;
        private string pg_fname;
        private string pg_lname;
        private string pg_email;
        private string pg_contact_no;
        private string pg_occupation;
        private string pg_relationship;
        private string pg_ic_or_pass_num;
        private string pg_ic_or_pass;
        private string pg_gender;

        private string activate_acc;
        private string account_type;
        private string sub_stud_id;
        private string sub_id_1;
        private string sub_id_2;
        private string sub_id_3;
        private string sub_num_of_sub;
        private string sub_year_of_enrol;
        private string sub_month_of_enrol;
        private string sub_level_of_sub;
        private string student_name;
        private string sub1;
        private string sub2;
        private string sub3;
        private string acc_stud_ID;

        // Declare a static SqlConnection object to connect to the database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // Declare public properties for the private fields
        public string Student_id { get => student_id; set => student_id = value; }
        public string Activate_acc { get => activate_acc; set => activate_acc = value; }
        public string Account_type { get => account_type; set => account_type = value; }
        public string Sub_num_of_sub { get => sub_num_of_sub; set => sub_num_of_sub = value; }
        public string Sub_year_of_enrol { get => sub_year_of_enrol; set => sub_year_of_enrol = value; }
        public string Sub_month_of_enrol { get => sub_month_of_enrol; set => sub_month_of_enrol = value; }
        public string Sub_level_of_sub { get => sub_level_of_sub; set => sub_level_of_sub = value; }
        public string Stud_Ic_or_pass_num { get => stud_Ic_or_pass_num; set => stud_Ic_or_pass_num = value; }
        public string Stud_Ic_or_pass { get => stud_Ic_or_pass; set => stud_Ic_or_pass = value; }
        public string S_ID { get => s_ID; set => s_ID = value; }
        public string Stud_contact_no { get => stud_contact_no; set => stud_contact_no = value; }
        public string Stud_house_adr { get => stud_house_adr; set => stud_house_adr = value; }
        public string Stud_email { get => stud_email; set => stud_email = value; }
        public string Stud_gender { get => stud_gender; set => stud_gender = value; }
        public string Pg_email { get => pg_email; set => pg_email = value; }
        public string Pg_contact_no { get => pg_contact_no; set => pg_contact_no = value; }
        public string Pg_occupation { get => pg_occupation; set => pg_occupation = value; }
        public string Pg_relationship { get => pg_relationship; set => pg_relationship = value; }
        public string Pg_ic_or_pass_num { get => pg_ic_or_pass_num; set => pg_ic_or_pass_num = value; }
        public string Pg_ic_or_pass { get => pg_ic_or_pass; set => pg_ic_or_pass = value; }
        public string Pg_gender { get => pg_gender; set => pg_gender = value; }
        public string Stud_nationality { get => stud_nationality; set => stud_nationality = value; }
        public string Stud_dob { get => stud_dob; set => stud_dob = value; }
        public string Pog_stud_id { get => pog_stud_id; set => pog_stud_id = value; }
        public string Sub_stud_id { get => sub_stud_id; set => sub_stud_id = value; }
        public string Sub_id_1 { get => sub_id_1; set => sub_id_1 = value; }
        public string Sub_id_2 { get => sub_id_2; set => sub_id_2 = value; }
        public string Sub_id_3 { get => sub_id_3; set => sub_id_3 = value; }
        public string Sub1 { get => sub1; set => sub1 = value; }
        public string Sub2 { get => sub2; set => sub2 = value; }
        public string Sub3 { get => sub3; set => sub3 = value; }
        public string Acc_stud_ID { get => acc_stud_ID; set => acc_stud_ID = value; }
        public string Sub_id_11 { get => sub_id_1; set => sub_id_1 = value; }

        public student_registration(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            // This constructor takes 11 parameters and initializes the student_registration object's fields with those values
            S_ID = a;
            Stud_email = b;
            Stud_contact_no = c;
            stud_fname = d;
            stud_lname = e;
            Stud_Ic_or_pass = f;
            Stud_Ic_or_pass_num = g;
            Stud_house_adr = h;
            Stud_gender = i;
            Stud_dob = j;
            Stud_nationality = k;
        }

        public student_registration(string d, string e)
        {
            // This constructor takes 2 parameters and initializes the student_registration object's stud_fname and stud_lname fields with those values
            stud_fname = d;
            stud_lname = e;
        }
        public student_registration(string j, string k, string l, string m, string n, string o, string p, string q, string r, string s)
        {
            // This constructor takes 10 parameters and initializes the student_registration object's fields related to the parent/guardian with those values
            pg_fname = j;
            pg_lname = k;
            Pg_contact_no = l;
            Pg_email = m;
            Pg_gender = n;
            Pog_stud_id= o;
            Pg_ic_or_pass = p;
            Pg_ic_or_pass_num = q;
            Pg_occupation = r;
            Pg_relationship = s;
        }
        public student_registration(string id, string ac, string ad)
        {
            // This constructor takes 3 parameters and initializes the student_registration object's fields related to student id, account activation and student name with those values
            Student_id = id;
            Activate_acc = ac;
            student_name = ad;
        }
        public student_registration(string ad)
        {
            // This constructor takes 1 parameter and initializes the student_registration object's student_name field with that value
            student_name = ad;
        }
                
        public string check_student_id(string un)
        {
            string status;
            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) AS student_Count FROM STUDENT_T WHERE student_Id = @sid", con);
            command.Parameters.AddWithValue("@sid", un);

            int count = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (count > 0)
                status = "Student ID Exist";
            else
                status = " ";

            con.Close();
            return status;
        }

        // This method takes in 11 parameters, which represent various pieces of student data.
        public string InsertData_Section_A(string ua, string ub, string uc, string ud, string ue, string uf, string ug, string uh, string ui, string uj, string uk)
        {
            // Declare a string variable named 'status' to hold the result of this method.
            string status;
            // Open a connection to the database.
            con.Open();
            // Set the value of the 'Student_id' variable to the value of the 'ug' parameter.
            Student_id = ug;
            // Set the value of the 'stud_fname' variable to the value of the 'uc' parameter.
            stud_fname = uc;
            // Set the value of the 'stud_lname' variable to the value of the 'ud' parameter.
            stud_lname = ud;
            // Set the value of the 'Stud_Ic_or_pass_num' variable to the value of the 'ue' parameter.
            Stud_Ic_or_pass_num = ue;
            // Set the value of the 'Stud_Ic_or_pass' variable to the value of the 'uf' parameter.
            Stud_Ic_or_pass = uf;
            // Set the value of the 'Stud_email' variable to the value of the 'uj' parameter.
            Stud_email = uj;
            // Set the value of the 'Stud_contact_no' variable to the value of the 'ui' parameter.
            Stud_contact_no = ui;
            // Set the value of the 'Stud_house_adr' variable to the value of the 'uh' parameter.
            Stud_house_adr = uh;
            // Set the value of the 'Stud_gender' variable to the value of the 'uk' parameter.
            Stud_gender = uk;
            // Set the value of the 'Stud_nationality' variable to the value of the 'ua' parameter.
            Stud_nationality = ua;
            // Set the value of the 'Stud_dob' variable to the value of the 'ub' parameter.
            Stud_dob = ub;

            // Declare a new SQL command that inserts data into the 'STUDENT_T' table.
            SqlCommand command = new SqlCommand("INSERT INTO STUDENT_T (student_id, student_fname, student_lname, student_ic_or_passport_num, student_ic_or_passport, student_email, student_contact_no, student_house_adr, student_gender, student_dob, student_nationality) VALUES (@sid, @sfname,@slname, @sipnum, @ip, @email, @scn, @houseadr, @gender, @dob, @nationality)", con);
            // Set the values of the command's parameters using the appropriate variables.
            command.Parameters.AddWithValue("@sid", Student_id);
            command.Parameters.AddWithValue("@sfname", stud_fname);
            command.Parameters.AddWithValue("@slname", stud_lname);
            command.Parameters.AddWithValue("@sipnum", Stud_Ic_or_pass_num);
            command.Parameters.AddWithValue("@ip", Stud_Ic_or_pass);
            command.Parameters.AddWithValue("@email", Stud_email);
            command.Parameters.AddWithValue("@scn", Stud_contact_no);
            command.Parameters.AddWithValue("@houseadr", Stud_house_adr);
            command.Parameters.AddWithValue("@gender", Stud_gender);
            command.Parameters.AddWithValue("@nationality", Stud_nationality);
            // If the 'Stud_dob' variable can be parsed as a DateTime value, set the value of the '@dob' parameter to it.
            if (DateTime.TryParse(Stud_dob, out DateTime d))
            {
                // Adds the DateTime value to the SqlCommand object as a parameter
                command.Parameters.AddWithValue("@dob", d);
            }
            //Else
            else
            {
                //Message box shows the string could not be parsed to a date time value
                MessageBox.Show("The string could not be parsed to a DateTime value");
            }
            // Check the value of "i" and set the "status" variable accordingly
            int i = command.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful";
            else
                status = "Unable to register";
            // Close the database connection
            con.Close();
            // Return the value of "status"
            return status;
        }

        public string InsertData_Section_B(string un, string uo, string up, string uq, string ur, string us, string ut, string uu, string uv, string uw)
        {
            string status;
            con.Open();
            pg_fname = uo;
            pg_lname = up;
            Pg_contact_no = us;
            Pg_email = ut;
            Pg_gender = uw;
            Pog_stud_id = un;
            Pg_ic_or_pass = ur;
            Pg_ic_or_pass_num = uq;
            Pg_occupation = uu;
            Pg_relationship = uv;
            SqlCommand command = new SqlCommand("INSERT INTO PARENTS_OR_GUARDIAN_T (stud_id, pog_fname, pog_lname, pog_email, pog_contact_no, pog_occupation, pog_relationship, pog_ic_or_passport_number, pog_ic_or_passport, pog_gender) VALUES (@pid, @pogfname,@poglname, @pogemail, @pogcn, @pogoccupation, @pogrelationship, @pogipnum, @pogip,@poggender)", con);
            command.Parameters.AddWithValue("@pid", Pog_stud_id);
            command.Parameters.AddWithValue("@pogfname", pg_fname);
            command.Parameters.AddWithValue("@poglname", pg_lname);
            command.Parameters.AddWithValue("@pogemail", Pg_email);
            command.Parameters.AddWithValue("@pogcn", Pg_contact_no);
            command.Parameters.AddWithValue("@pogoccupation", Pg_occupation);
            command.Parameters.AddWithValue("@pogrelationship", Pg_relationship);
            command.Parameters.AddWithValue("@pogipnum", Pg_ic_or_pass_num);
            command.Parameters.AddWithValue("@pogip", Pg_ic_or_pass);
            command.Parameters.AddWithValue("@poggender", Pg_gender);

            int i = command.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful";
            else
                status = "Unable to register";

            con.Close();
            return status;

        }
        public string InsertData_Section_C(string aa, string ab, string ac, string ad, string ae, string af, string ag, string ah, string ai, string aj, string ak)
        {
            string status;
            con.Open();
            Sub_stud_id = aa;
            Sub_id_2 = ab;
            Sub_id_3= ac;
            Sub2 = ad;
            Sub3 = ae;
            Sub_level_of_sub= af;
            Sub_month_of_enrol = ag;
            Sub_year_of_enrol= ah;
            Sub_num_of_sub= ai;
            Sub1 = aj;
            Sub_id_1 = ak;
            SqlCommand command = new SqlCommand("INSERT INTO SUBJECT_LQT (student_id, subject_id_sub_1, subject_id_sub_2, subject_id_sub_3, subject_num_of_sub, subject_year_of_enrol, subject_month_of_enrol, subject_sub_1, subject_sub_2, subject_sub_3, sub_level_of_subject) VALUES (@ssid, @subid1, @subid2, @subid3, @numofsub, @yearofenrol, @monthofenrol, @sub1, @sub2, @sub3, @level)", con);
            command.Parameters.AddWithValue("@ssid", Sub_stud_id);
            command.Parameters.AddWithValue("@subid2", Sub_id_2);
            command.Parameters.AddWithValue("@subid3", Sub_id_3);
            command.Parameters.AddWithValue("@subid1", Sub_id_1);
            command.Parameters.AddWithValue("@numofsub", Sub_num_of_sub);
            command.Parameters.AddWithValue("@yearofenrol", Sub_year_of_enrol);
            command.Parameters.AddWithValue("@monthofenrol", Sub_month_of_enrol);
            command.Parameters.AddWithValue("@sub1", Sub1);
            command.Parameters.AddWithValue("@sub2", Sub2);
            command.Parameters.AddWithValue("@sub3", Sub3);
            command.Parameters.AddWithValue("@level", Sub_level_of_sub);

            int i = command.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful";
            else
                status = "Unable to register";

            con.Close();
            return status;

        }

        public string DisplayData_SectionD_name_1(string ab)
        {
            string a = string.Empty;
            Student_id = ab;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", Student_id);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_fname = reader.GetString(1);
                    a = student_fname.ToString();
                }
            }
            con.Close();
            return a;
        }

        public string DisplayData_SectionD_name_2(string ab)
        {
            string a = string.Empty;
            Student_id = ab;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_Id =@id", con);
            cmd2.Parameters.AddWithValue("@id", Student_id);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string student_lname = reader.GetString(2);
                    a = student_lname.ToString();
                }
            }
            con.Close();
            return a;
        }



        public string InsertData_Section_D(string uf, string ui)
        {
            string status;
            Acc_stud_ID = uf;
            Activate_acc = ui;
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO USER_T (Id, password, role, ans_Q1, ans_Q2) VALUES (@id, 'etc12345','Student', '-', '-')", con);
            command.Parameters.AddWithValue("@id", Acc_stud_ID);

            int i = command.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful";
            else
                status = "Unable to register";

            con.Close();
            return status;

        }
    }
}
