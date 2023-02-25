using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace Group2_Assignment
{
    internal class Receptionist
    {
        private string receptionist_id;
        private string receptionist_pass;
        private string fName;
        private string lName;
        private string workingEx;
        private string location;
        private string email;
        private string contactno;
        private string answer_1;
        private string answer_2;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string WorkingEx { get => workingEx; set => workingEx = value; }
        public string Location { get => location; set => location = value; }
        public string Email { get => email; set => email = value; }
        public string Contactno { get => contactno; set => contactno = value; }
        public string Receptionist_id { get => receptionist_id; set => receptionist_id = value; }
        public string Receptionist_pass { get => receptionist_pass; set => receptionist_pass = value; }
        public string Answer_1 { get => answer_1; set => answer_1 = value; }
        public string Answer_2 { get => answer_2; set => answer_2 = value; }

        public Receptionist(string a)
        {
            receptionist_id = a;
        }
        public static void viewProfile(Receptionist o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RECEPTIONIST_T where receptionist_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.receptionist_id);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.fName = rd["receptionist_fname"].ToString();
                o1.lName = rd["receptionist_lname"].ToString();
                o1.workingEx = rd["receptionist_working_exp"].ToString();
                o1.location = rd["receptionist_office_location"].ToString();
                o1.email = rd["receptionist_email"].ToString();
                o1.contactno = rd["receptionist_contact_no"].ToString();
            }
            rd.Close(); // Close the reader before closing the connection
            con.Close();
        }

        public string updateProfile(string dn, string gn, string he, string ln, string fm, string hn)
        {
            string status;
            con.Open();
            fName = dn;
            lName = gn;
            workingEx = he;
            location = ln;
            email = fm;
            contactno = hn;

            SqlCommand cmd = new SqlCommand("update RECEPTIONIST_T set receptionist_fname = @a, receptionist_lname = @b, receptionist_working_exp = @c, receptionist_office_location = @d, receptionist_email = @e, receptionist_contact_no = @f where receptionist_id = @g", con);
            cmd.Parameters.AddWithValue("@a", fName);
            cmd.Parameters.AddWithValue("@b", lName);
            cmd.Parameters.AddWithValue("@c", WorkingEx);
            cmd.Parameters.AddWithValue("@d", location);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@f", contactno);
            cmd.Parameters.AddWithValue("@g", receptionist_id);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }
        public static void ViewSecurityQuestion(Receptionist o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ans_Q1, ans_Q2 FROM USER_T WHERE Id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.Receptionist_id);

            SqlDataReader rep = cmd.ExecuteReader();
            if (rep.Read())
            {
                o1.answer_1 = rep["ans_Q1"].ToString();
                o1.answer_2 = rep["ans_Q2"].ToString();
            }
            rep.Close();
            con.Close();
        }

        public string UpdateSecurityQuestionAns(string ra, string rb, string rc)
        {
            string status;
            con.Open();

            answer_1 = ra;
            answer_2 = rb;
            Receptionist_id = rc;

            SqlCommand cmd = new SqlCommand("UPDATE USER_T SET ans_Q1 = @a, ans_Q2 = @b WHERE Id = @c", con);
            cmd.Parameters.AddWithValue("@a", answer_1);
            cmd.Parameters.AddWithValue("@b", answer_2);
            cmd.Parameters.AddWithValue("@c", Receptionist_id);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update";
            con.Close();
            return status;
        }
        public static void viewPassword(Receptionist o1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select password from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.receptionist_id);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.receptionist_pass = rd["password"].ToString();
            }
            rd.Close();
            con.Close();
        }
        public string updatePassword(string a, string b)
        {
            string status;
            con.Open();
            receptionist_pass = a;
            receptionist_id = b;

            SqlCommand cmd = new SqlCommand("update USER_T set password = @a where Id = @b", con);
            cmd.Parameters.AddWithValue("@a", receptionist_pass);
            cmd.Parameters.AddWithValue("@b", receptionist_id);

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
