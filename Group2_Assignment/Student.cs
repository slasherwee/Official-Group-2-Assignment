using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Group2_Assignment
{
    internal class Student
    {
        private string studId;
        private string firstName;
        private string lastName;
        private string ic;
        private string gender;
        private string email;
        private string contactNo;
        private string nationality;
        private string houseAdd;
        private string level;
        private string yearOfEnrolment;
        private string noOfSub;
        private string sub1;
        private string sub2;
        private string sub3;
        private string sub1Code;
        private string sub2Code;
        private string sub3Code;
        private string day;
        private string date;
        private string currentSubID;
        private string currentSubName;
        private string currentTutor;
        private string newSubID;
        private string newSubName;
        private string newTutor;
        private string requestID;
        private string password;
        private string newPass;
        private string ans_q1;
        private string ans_q2;
        private string newSubNameSelected;
        private string currentSubNameSelected;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string StudId { get => studId; set => studId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Ic { get => ic; set => ic = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string HouseAdd { get => houseAdd; set => houseAdd = value; }
        public string Level { get => level; set => level = value; }
        public string YearOfEnrolment { get => yearOfEnrolment; set => yearOfEnrolment = value; }
        public string NoOfSub { get => noOfSub; set => noOfSub = value; }
        public string Sub1 { get => sub1; set => sub1 = value; }
        public string Sub2 { get => sub2; set => sub2 = value; }
        public string Sub3 { get => sub3; set => sub3 = value; }
        public string Sub1Code { get => sub1Code; set => sub1Code = value; }
        public string Sub2Code { get => sub2Code; set => sub2Code = value; }
        public string Sub3Code { get => sub3Code; set => sub3Code = value; }
        public string Day { get => day; set => day = value; }
        public string CurrentSubName { get => currentSubName; set => currentSubName = value; }
        public string Date { get => date; set => date = value; }
        public string CurrentTutor { get => currentTutor; set => currentTutor = value; }
        public string CurrentSubID { get => currentSubID; set => currentSubID = value; }
        public string NewSubID { get => newSubID; set => newSubID = value; }
        public string NewSubName { get => newSubName; set => newSubName = value; }
        public string NewTutor { get => newTutor; set => newTutor = value; }
        public string RequestID { get => requestID; set => requestID = value; }
        public string Password { get => password; set => password = value; }
        public string NewPass { get => newPass; set => newPass = value; }
        public string NewSubNameSelected { get => newSubNameSelected; set => newSubNameSelected = value; }
        public string CurrentSubNameSelected { get => currentSubNameSelected; set => currentSubNameSelected = value; }
        public string Ans_q1 { get => ans_q1; set => ans_q1 = value; }
        public string Ans_q2 { get => ans_q2; set => ans_q2 = value; }

        public Student(string n)
        {
            studId = n;
        }

        public Student(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            date = a;
            currentSubID = b;
            currentSubName = c;
            currentTutor = d;
            newSubID = e;
            newSubName = f;
            newTutor = g;
            studId = h;
        }

        public Student(string a, string b)
        {
            studId = a;
            requestID = b;
        }

        public static void viewProfile(Student o1)
        {
            //static method so that it can be called by class name
            //o1 is passsed to the method viewProfile
            con.Open();
            //student personal information
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_T WHERE student_Id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.studId);
            SqlDataReader rd = cmd.ExecuteReader(); //read multiple column
            while (rd.Read())
            {
                o1.firstName = rd.GetString(1);
                o1.lastName = rd.GetString(2);
                o1.ic = rd.GetString(4);
                o1.email = rd.GetString(5);
                o1.contactNo = rd.GetString(6);
                o1.houseAdd = rd.GetString(7);
                o1.gender = rd.GetString(8);
                o1.nationality = rd.GetString(10);
            }
            rd.Close();

            //student subject enrolment information
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SUBJECT_LQT WHERE student_id=@a", con);
            cmd2.Parameters.AddWithValue("@a", o1.studId);
            SqlDataReader rd2 = cmd2.ExecuteReader(); //read multiple column
            while (rd2.Read())
            {
                o1.sub1Code = rd2.GetString(1);
                o1.sub2Code = rd2.GetString(2);
                o1.sub3Code = rd2.GetString(3);
                o1.noOfSub = rd2.GetString(4);
                o1.yearOfEnrolment = rd2.GetString(5);
                o1.sub1 = rd2.GetString(7);
                o1.sub2 = rd2.GetString(8);
                o1.sub3 = rd2.GetString(9);
                o1.level = rd2.GetString(10);
            }
            rd2.Close();
            con.Close();
        }

        public string updateProfile(string fn, string ln, string em, string cn, string add, string id)
        {
            string status;
            con.Open();

            firstName = fn;
            lastName = ln;
            email = em;
            contactNo = cn;
            houseAdd = add;
            studId = id;

            SqlCommand cmd = new SqlCommand("UPDATE STUDENT_T SET student_fname = @a, student_lname = @b, student_email = @c, student_contact_no = @d, student_house_adr = @e WHERE student_Id = @f", con);
            cmd.Parameters.AddWithValue("@a", firstName);
            cmd.Parameters.AddWithValue("@b", lastName);
            cmd.Parameters.AddWithValue("@c", email);
            cmd.Parameters.AddWithValue("@d", contactNo);
            cmd.Parameters.AddWithValue("@e", houseAdd);
            cmd.Parameters.AddWithValue("@f", studId);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Updated successfully.";
            else
                status = "Unable to update.";
            con.Close();

            return status;
        }

        public DataTable viewDay(Student o1)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT day FROM SCHEDULE_T WHERE stud_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.studId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable viewSchedule(string day, Student student)
        {
            DataTable vs = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT tutor_id, sub_id, sub_name, location, time FROM SCHEDULE_T WHERE day = @a AND stud_id = @b", con);
            cmd.Parameters.AddWithValue("@a", day);
            cmd.Parameters.AddWithValue("@b", student.studId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(vs);
            con.Close();
            return vs;
        }

        public string changeSubject()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO REQUEST_T(request_date, current_sub_id, current_sub_name, current_tutor, new_sub_id, new_sub_name, new_tutor, student_id) VALUES(@a, @b, @c, @d, @e, @f, @g, @h)", con);
            cmd.Parameters.AddWithValue("@a", date);
            cmd.Parameters.AddWithValue("@b", currentSubID);
            cmd.Parameters.AddWithValue("@c", currentSubName);
            cmd.Parameters.AddWithValue("@d", currentTutor);
            cmd.Parameters.AddWithValue("@e", newSubID);
            cmd.Parameters.AddWithValue("@f", newSubName);
            cmd.Parameters.AddWithValue("@g", newTutor);
            cmd.Parameters.AddWithValue("@h", studId);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Request has been sent successfully.";
            else
                status = "Unable to send request.";
            con.Close();
            return status;
        }

        public DataTable viewRequestStatus(Student o1)
        {
            DataTable vrs = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT request_id, request_date, current_sub_id, current_sub_name, current_tutor, new_sub_id, new_sub_name, new_tutor, request_status FROM REQUEST_T WHERE student_id = @a", con);
            cmd.Parameters.AddWithValue("@a", studId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(vrs);
            con.Close();
            return vrs;
        }

        public string deleteRequest()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM REQUEST_T WHERE request_id = @a AND student_id = @b", con);
            cmd.Parameters.AddWithValue("@a", requestID);
            cmd.Parameters.AddWithValue("@b", studId);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Request has been deleted successfully.";
            else
                status = "Request not found. Unable to delete request.";
            con.Close();
            return status;
        }

        public DataTable viewFee(Student o1)
        {
            DataTable vf = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT receipt_no, payment_total, payment_date, payment_method, payment_remarks FROM RECEIPT_T WHERE student_id = @a ORDER BY payment_date DESC", con);
            cmd.Parameters.AddWithValue("@a", studId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(vf);
            con.Close();
            return vf;
        }

        public DataTable viewFeeOldestDate(Student o1)
        {
            DataTable vf = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT receipt_no, payment_total, payment_date, payment_method, payment_remarks FROM RECEIPT_T WHERE student_id = @a", con);
            cmd.Parameters.AddWithValue("@a", studId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(vf);
            con.Close();
            return vf;
        }

        public static void viewPassword(Student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM USER_T WHERE Id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.studId);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.password = rd.GetString(1);
            }
            rd.Close();
            con.Close();
        }

        public string changePassword(string a, string b)
        {
            string status;
            con.Open();

            studId = a;
            newPass = b;

            SqlCommand cmd = new SqlCommand("UPDATE USER_T SET password = @b WHERE Id = @a", con);
            cmd.Parameters.AddWithValue("@a", studId);
            cmd.Parameters.AddWithValue("@b", newPass);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Updated successfully.";
            else
                status = "Unable to update.";
            con.Close();

            return status;
        }

        public static void viewCurrentSubName(string subID, Student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT sub_name FROM SUBJECT_T WHERE sub_id = @a", con);
            cmd.Parameters.AddWithValue("@a", subID);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.currentSubNameSelected = rd["sub_name"].ToString();
            }
            rd.Close();
            con.Close();
        }

        public static void viewNewSubName(string subID, Student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT sub_name FROM ALLSUBJECT_T WHERE sub_id = @a", con);
            cmd.Parameters.AddWithValue("@a", subID);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.newSubNameSelected = rd["sub_name"].ToString();
            }
            rd.Close();
            con.Close();
        }

        public List<string> viewAllSubID()
        {
            List <string> allSubjects = new List<string>();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT sub_id FROM ALLSUBJECT_T", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                allSubjects.Add(dr["sub_id"].ToString());
            }
            con.Close();
            return allSubjects;
        }

        public List<string> viewCurrentSubID()
        {
            List<string> currentSubjects = new List<string>();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT sub_id FROM SUBJECT_T WHERE stu_id = @a", con);
            cmd.Parameters.AddWithValue("@a", studId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                currentSubjects.Add(dr["sub_id"].ToString());
            }
            con.Close();
            return currentSubjects;
        }

        public List<string> viewCurrentTutor(string currentSubID)
        {
            List<string> currentTutor = new List<string>();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tutor_name FROM SUBJECT_T WHERE stu_id = @a AND sub_id = @b", con);
            cmd.Parameters.AddWithValue("@a", studId);
            cmd.Parameters.AddWithValue("@b", currentSubID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                currentTutor.Add(dr["tutor_name"].ToString());
            }
            con.Close();
            return currentTutor;
        }

        public List<string> viewNewTutor(string newSubID)
        {
            List<string> newTutor = new List<string>();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tutor_name FROM ALLSUBJECT_T WHERE sub_id = @a", con);
            cmd.Parameters.AddWithValue("@a", newSubID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                newTutor.Add(dr["tutor_name"].ToString());
            }
            con.Close();
            return newTutor;
        }

        public static void viewSecurityQuestion(Student o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select ans_Q1, ans_Q2 from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.studId);

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
            studId = c;

            SqlCommand cmd = new SqlCommand("update USER_T set ans_Q1 = @a, ans_Q2 = @b where Id = @c", con);
            cmd.Parameters.AddWithValue("@a", ans_q1);
            cmd.Parameters.AddWithValue("@b", ans_q2);
            cmd.Parameters.AddWithValue("@c", studId);

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
