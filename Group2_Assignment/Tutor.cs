using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group2_Assignment
{
    internal class Tutor
    {
        private string tutorId;
        private string tutor_pass;
        private string ans_q1;
        private string ans_q2;
        private string fName;
        private string lName;
        private string teachingEx;
        private string location;
        private string email;
        private string contactno;
        private string subID;
        private string subName;
        private string subHour;
        private string subCharges;
        private string day;
        private string classLocation;
        private string time;
        private string newSubID;
        private string newSubName;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string FName
        { get => fName; set => fName = value; }


        public string LName { get => lName; set => lName = value; }


        public string Location { get => location; set => location = value; }

        public string Email { get => email; set => email = value; }

        public string Contactno { get => contactno; set => contactno = value; }

        public string SubID { get => subID; set => subID = value; }

        public string SubName { get => subName; set => subName = value; }


        public string SubHour { get => subHour; set => subHour = value; }

        public string SubCharges { get => subCharges; set => subCharges = value; }
        public string Day { get => day; set => day = value; }
        public string ClassLocation { get => classLocation; set => classLocation = value; }
        public string Time { get => time; set => time = value; }
        public string TeachingEx { get => teachingEx; set => teachingEx = value; }
        public string Tutor_pass { get => tutor_pass; set => tutor_pass = value; }
        public string Ans_q1 { get => ans_q1; set => ans_q1 = value; }
        public string Ans_q2 { get => ans_q2; set => ans_q2 = value; }

        public Tutor(string a)
        {
            tutorId = a;
        }

        public Tutor(string a, string b, string c, string d, string e)
        {
            subID = a;
            subName = b;
            subHour = c;
            subCharges = d;
            tutorId = e;
        }


        public DataTable viewCourse(Tutor tutor)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select sub_id AS 'Subject ID', sub_name AS 'Subject Name', sub_hour AS 'Hour', sub_charges AS 'Charges per hour (RM)' from SUBJECT_T where tutor_id = @a", con);
            cmd.Parameters.AddWithValue("@a", tutor.tutorId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable viewStudent(string subName, Tutor tutor)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select stu_id AS 'Student ID', stu_name AS 'Student Name', stu_gender AS 'Gender' from SUBJECT_T where sub_id = (select sub_id from SUBJECT_T where sub_name = @a and tutor_id = @b) and tutor_id = @b", con);
            cmd.Parameters.AddWithValue("@a", subName);
            cmd.Parameters.AddWithValue("@b", tutor.tutorId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable viewSubject(Tutor o1)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select sub_name from SUBJECT_T where tutor_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public string addCourse()
        {
            string status;
            con.Open();
            // Insert subject record
            SqlCommand cmd = new SqlCommand("insert into SUBJECT_T (sub_id, sub_name, sub_hour, sub_charges, tutor_id) values (@sid, @nm, @hr, @cs, @tid)", con);

            cmd.Parameters.AddWithValue("@sid", subID);
            cmd.Parameters.AddWithValue("@nm", subName);
            cmd.Parameters.AddWithValue("@hr", subHour);
            cmd.Parameters.AddWithValue("@cs", subCharges);
            cmd.Parameters.AddWithValue("@tid", tutorId);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";

            con.Close();

            return status;
        }

        public string updateCourse(string a, string b, string c, string d, string e,string f)
        {
            string status;
            con.Open();
            newSubID = a;
            newSubName = b;
            SubHour = c;
            SubCharges = d;
            SubID = e;
            SubName = f;

            SqlCommand cmd = new SqlCommand("update SUBJECT_T set sub_id = @a, sub_name = @b, sub_hour = @c, sub_charges = @d where sub_id = @e and sub_name =@f and tutor_id = @g", con);
            cmd.Parameters.AddWithValue("@a", newSubID);
            cmd.Parameters.AddWithValue("@b", newSubName);
            cmd.Parameters.AddWithValue("@c", SubHour);
            cmd.Parameters.AddWithValue("@d", SubCharges);
            cmd.Parameters.AddWithValue("@e", SubID);
            cmd.Parameters.AddWithValue("@f", SubName);
            cmd.Parameters.AddWithValue("@g", tutorId);


            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public string deleteCourse(string a, string b, string c, string d)
        {
            string status;
            con.Open();
            SubID = a;
            SubName = b;
            SubHour = c;
            SubCharges = d;

            SqlCommand cmd = new SqlCommand("delete FROM SUBJECT_T where sub_id = @a and tutor_id = @b", con);
            cmd.Parameters.AddWithValue("@a", SubID);
            cmd.Parameters.AddWithValue("@b", tutorId);


            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Deleted Successfully";
            else
                status = "Failed to delete.";
            con.Close();
            return status;
        }

        public DataTable viewDay(Tutor o1)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select DISTINCT day from SCHEDULE_T where tutor_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable viewSchedule(string day, Tutor tutor)
        {
            DataTable vs = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select sub_id AS 'Subject ID', sub_name AS 'Subject Name', location AS 'Venue', CONVERT(VARCHAR(5), time, 108) AS Time from SCHEDULE_T where day = @a and tutor_id = @b", con);
            cmd.Parameters.AddWithValue("@a", day);
            cmd.Parameters.AddWithValue("@b", tutor.tutorId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(vs);
            con.Close();
            return vs;
        }

        public string updateSchedule(string a, string b, string c, string d, string e)
        {
            string status;
            con.Open();
            SubID = a;
            tutorId = b;
            location = c;
            time = d;
            day = e;

            SqlCommand cmd = new SqlCommand("UPDATE SCHEDULE_T SET location = @c, time = @d WHERE sub_id = @a AND tutor_id = @b AND day = @e", con);
            cmd.Parameters.AddWithValue("@a", SubID);
            cmd.Parameters.AddWithValue("@b", tutorId);
            cmd.Parameters.AddWithValue("@c", location);
            cmd.Parameters.AddWithValue("@d", time);
            cmd.Parameters.AddWithValue("@e", Day);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }
        public static void viewProfile(Tutor o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TUTOR_T where tutor_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.fName = rd["fname"].ToString();
                o1.lName = rd["lname"].ToString();
                o1.teachingEx = rd["teachingEx"].ToString();
                o1.location = rd["officeLocation"].ToString();
                o1.email = rd["email"].ToString();
                o1.contactno = rd["contact_no"].ToString();
            }
            rd.Close(); // Close the reader before closing the connection
            con.Close();
        }

        public string updateProfile(string fn, string ln, string te, string l, string em, string cn)
        {
            string status;
            con.Open();
            fName = fn;
            LName = ln;
            TeachingEx = te;
            location = l;
            email = em;
            contactno = cn;

            SqlCommand cmd = new SqlCommand("update TUTOR_T set fname = @a, lname = @b, teachingEx = @c, officeLocation = @d, email = @e, contact_no = @f where tutor_id = @g", con);
            cmd.Parameters.AddWithValue("@a", fName);
            cmd.Parameters.AddWithValue("@b", LName);
            cmd.Parameters.AddWithValue("@c", TeachingEx);
            cmd.Parameters.AddWithValue("@d", location);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@f", contactno);
            cmd.Parameters.AddWithValue("@g", tutorId);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public static void viewPassword(Tutor o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select password from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.tutor_pass = rd["password"].ToString();
            }
            rd.Close();
            con.Close();
        }

        public static void viewSecurityQuestion(Tutor o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select ans_Q1, ans_Q2 from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.ans_q1 = rd["ans_Q1"].ToString();
                o1.ans_q2 = rd["ans_Q2"].ToString();
            }
            rd.Close();
            con.Close();
        }

        public string updateAns(string a, string b, string c)
        {
            string status;
            con.Open();

            ans_q1 = a;
            ans_q2 = b;
            tutorId = c;

            SqlCommand cmd = new SqlCommand("update USER_T set ans_Q1 = @a, ans_Q2 = @b where Id = @c", con);
            cmd.Parameters.AddWithValue("@a", ans_q1);
            cmd.Parameters.AddWithValue("@b", ans_q2);
            cmd.Parameters.AddWithValue("@c", tutorId);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public string updatePassword(string a, string b)
        {
            string status;
            con.Open();
            tutor_pass = a;
            tutorId = b;

            SqlCommand cmd = new SqlCommand("update USER_T set password = @a where Id = @b", con);
            cmd.Parameters.AddWithValue("@a", tutor_pass);
            cmd.Parameters.AddWithValue("@b", tutorId);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }


    }
}
