using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections;
using System.Data.Common;

namespace Group2_Assignment
{
    internal class Admin
    {
        //member field
        private string fname;
        private string lname;
        private string password;
        private string email;
        private string contactNo;
        private char gender;
        private DateTime DOB;
        private string role;
        private string subject;
        private string Exp;
        private string officeLocation;
        private string UserID;
        private string ans_q1;
        private string ans_q2;


        //Establish connection
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string OfficeLocation { get => officeLocation; set => officeLocation = value; }
        public string WorkingExp { get => Exp; set => Exp = value; }
        public string ID { get => UserID; set => UserID = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Ans_q2 { get; internal set; }
        public string Ans_q1 { get; internal set; }


        //constructor
        public Admin(string id)
        {
            UserID = id;
        }

        public Admin()
        { }

        public Admin(string id, string R, string P, string SQ1, string SQ2)
        {
            UserID = id;
            role = R;
            password = P;
            ans_q1 = SQ1;
            ans_q2 = SQ2;
        }

        public Admin(string id, string F, string L, string E, string CN, string SQ1, string SQ2, char G, 
            DateTime D, string S, string EX, string OL)
        {
            UserID = id;
            fname = F;
            lname = L;
            email = E;
            contactNo = CN;
            ans_q1 = SQ1;
            ans_q2 = SQ2;
            gender = G;
            DOB = D;
            subject = S;
            officeLocation = OL;
            Exp = EX;
        }

        public Admin(string id, string F, string L, string P, string E, string CN, string SQ1, string SQ2, char G, DateTime D, 
            string R, string EX, string OL)
        {
            UserID = id;
            fname = F;
            lname = L;
            password = P;
            email = E;
            contactNo = CN;
            ans_q1 = SQ1;
            ans_q2 = SQ2;
            gender = G;
            DOB = D;
            role = R;
            Exp = EX;
            officeLocation = OL;
        }

        //Add Tutor method
        public string AddTutor()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TUTOR_T (tutor_id, fname, lname, contact_no, email, gender, dob, teachingEx, officeLocation, sub_id) " +
                "values (@id, @f, @l, @num, @em, @g, @dob, @exp, @ofl, @sub)", con);

            cmd.Parameters.AddWithValue("@id", UserID);
            cmd.Parameters.AddWithValue("@f", fname);
            cmd.Parameters.AddWithValue("@l", lname);
            cmd.Parameters.AddWithValue("@num", contactNo);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@g", gender);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(DOB) );
            cmd.Parameters.AddWithValue("@sub", subject);
            cmd.Parameters.AddWithValue("@exp", int.Parse(Exp));
            cmd.Parameters.AddWithValue("@ofl", officeLocation);
            
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                status = "Registration Successful";
            }
            else
            {
                status = "Unable to register";
            }
            con.Close();
            return status;
        }
    

        public string AddTutortoUser()
        {
            string status;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("insert into USER_T (id, password, role, ans_Q1, ans_Q2) values (@id, @pass, @role, @question1, @question2)", con);
            cmd2.Parameters.AddWithValue("@id", UserID);
            cmd2.Parameters.AddWithValue("@pass", password);
            cmd2.Parameters.AddWithValue("@role", role);
            cmd2.Parameters.AddWithValue("@question1", ans_q1);
            cmd2.Parameters.AddWithValue("@question2", ans_q2);

            int x = cmd2.ExecuteNonQuery();
            if (x != 0)
            {
                status = "Done";
            }
            else
            {
                status = " ";
            }
            con.Close();
            return status;
        }

        //Add Receptionist method
        //Has return value
        //No parameters
        public string AddReceptionist()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RECEPTIONIST_T (receptionist_id, receptionist_fname, receptionist_lname, receptionist_gender, receptionist_DOB, receptionist_working_exp, receptionist_office_location, receptionist_email, receptionist_contact_no) " +
                "values (@id, @f, @l, @g, @dob, @exp, @ofl, @em, @num)", con);
            SqlCommand cmd2 = new SqlCommand("insert into USER_T (id, password, role, ans_Q1, ans_Q2) values (@id, @pass, @role, @question1, @question2)", con);
            cmd.Parameters.AddWithValue("@id", UserID);
            cmd2.Parameters.AddWithValue("@id", UserID);
            cmd.Parameters.AddWithValue("@f", fname);
            cmd.Parameters.AddWithValue("@l", lname);
            cmd.Parameters.AddWithValue("@num", contactNo);
            cmd.Parameters.AddWithValue("@em", email);
            cmd2.Parameters.AddWithValue("@pass", password);
            cmd2.Parameters.AddWithValue("@question1", ans_q1);
            cmd2.Parameters.AddWithValue("@question2", ans_q2);
            cmd2.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(DOB));
            cmd.Parameters.AddWithValue("@exp", int.Parse(Exp));
            cmd.Parameters.AddWithValue("@ofl", officeLocation);
            cmd.Parameters.AddWithValue("@g", gender);

            cmd2.ExecuteNonQuery();
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                status = "Registration Successful";
            }
            else
            {
                status = "Unable to register";
            }
            con.Close();
            return status;
        }

        

        //View Tutor ID and to Create Tutor ID method
        //No return value
        //Has a parameter
        public static void CreateNewTutorID(Admin o1)
        {
            // Open Connection
            con.Open();
            SqlCommand command = new SqlCommand("select count(tutor_id) from TUTOR_T", con);
            int i = Convert.ToInt32(command.ExecuteScalar().ToString());
            int count = i + 1;
            if (count < 10)
            {
                o1.UserID = "ETC_TUTOR00" + (count).ToString();
            }
            else if(count >= 10)
            {
                o1.UserID = "ETC_TUTOR0" + (count).ToString();
            }
            else if (count >= 100)
            {
                o1.UserID = "ETC_TUTOR" + (count).ToString();
            }
            con.Close();
        }

        public static void CreateNewReceptionistID(Admin o1)
        {
            // Open Connection
            con.Open();
            SqlCommand command = new SqlCommand("select count(receptionist_id) from RECEPTIONIST_T", con);
            int i = Convert.ToInt32(command.ExecuteScalar().ToString());
            int count = i + 1;
            if (count < 10)
            {
                o1.UserID = "ETC_REP00" + (count).ToString();
            }
            else if (count >= 10)
            {
                o1.UserID = "ETC_REP0" + (count).ToString();
            }
            else if (count >= 100)
            {
                o1.UserID = "ETC_REP" + (count).ToString();
            }
            con.Close();
        }


        //View Profile method
        //No return value
        //Has a parameters
        public static void ViewProfile(Admin o1)
        {
            con.Open();
            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("select * from ADMIN_T where admin_id = '" + o1.UserID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.fname = rd.GetString(1);
                o1.lname = rd.GetString(2);
                o1.email = rd.GetString(3);
                o1.contactNo = rd.GetString(4);
                o1.Exp = rd.GetString(5);
                o1.officeLocation = rd.GetString(6);
            }
            rd.Close(); //Close the reader
            con.Close(); //Close connection
        }

        //Update Profile method
        public string UpdateProfile(string f, string l, string em, string num, string exp, string ofl)
        {
            string status;
            con.Open();
            fname = f;
            lname = l;
            email = em;
            contactNo = num;
            Exp = exp;
            officeLocation = ofl;

            SqlCommand cmd = new SqlCommand("update ADMIN_T set admin_fname = @f, admin_lname = @l, admin_working_exp = @exp, admin_office_location = @ofl, admin_email = @em, admin_contact_no = @num where admin_id= @id", con);
            cmd.Parameters.AddWithValue("@f", fname);
            cmd.Parameters.AddWithValue("@l", lname);
            cmd.Parameters.AddWithValue("@exp", Exp);
            cmd.Parameters.AddWithValue("@ofl", officeLocation);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@num", contactNo);
            cmd.Parameters.AddWithValue("@id", UserID);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully";
            }
            else
            {
                status = "Update Fail";
            }
            con.Close(); //Close connection
            return status;
        }

        public static void ViewPassword(Admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from USER_T where id='" + o1.UserID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.password = rd.GetString(1);
            }
            con.Close();
        }


        public string UpdatePassword(string pw)
        {
            string status;
            con.Open();
            password = pw;

            SqlCommand cmd = new SqlCommand("update USER_T set password='" + password + "' where id ='" + UserID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Password Successfully.";
            }
            else
            {
                status = "Unable to Update Password.";
            }
            con.Close();

            return status;
        }

        public static void viewSecurityQuestion(Admin o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select ans_Q1, ans_Q2 from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.UserID);

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
            UserID = c;

            SqlCommand cmd = new SqlCommand("update USER_T set ans_Q1 = @a, ans_Q2 = @b where Id = @c", con);
            cmd.Parameters.AddWithValue("@a", ans_q1);
            cmd.Parameters.AddWithValue("@b", ans_q2);
            cmd.Parameters.AddWithValue("@c", UserID);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public static ArrayList TutorID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select tutor_id from TUTOR_T group by tutor_id", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ReceptionistID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select receptionist_id from RECEPTIONIST_T group by receptionist_id", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }


        public  DataTable ViewTutorForDelete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TUTOR_T ", con);

            //Creating a DataTable 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter use to fill datatable from data source
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public  DataTable ViewReceptionistForDelete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RECEPTIONIST_T", con);
            //Creating a DataTable 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter use to fill datatable from data source
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public string deleteTutor(Admin o1)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TUTOR_T where tutor_id = @id", con);
            SqlCommand cmd2 = new SqlCommand("delete from USER_T where id = @id", con);
            SqlCommand cmd3 = new SqlCommand("delete from PAYROLL_T where salary_user_id = @id", con);
            cmd.Parameters.AddWithValue("@id", o1.UserID);
            cmd2.Parameters.AddWithValue("@id", o1.UserID);
            cmd3.Parameters.AddWithValue("@id", o1.UserID);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Tutor has been deleted successfully.";
            else
                status = "Unable to delete request.";
            con.Close();
            return status;
        }

        public string deleteReceptionist(Admin o1)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from RECEPTIONIST_T where receptionist_id= @id", con);
            SqlCommand cmd2 = new SqlCommand("delete from USER_T where id = @id", con);
            SqlCommand cmd3 = new SqlCommand("delete from PAYROLL_T where salary_user_id = @id", con);
            cmd.Parameters.AddWithValue("@id", o1.UserID);
            cmd2.Parameters.AddWithValue("@id", o1.UserID);
            cmd3.Parameters.AddWithValue("@id", o1.UserID);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Receptionist has been deleted successfully.";
            else
                status = "Unable to delete request.";
            con.Close();
            return status;
        }

    }
}
