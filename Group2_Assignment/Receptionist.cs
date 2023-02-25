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
        private string fName;
        private string lName;
        private string workingEx;
        private string location;
        private string email;
        private string contactno;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string WorkingEx { get => workingEx; set => workingEx = value; }
        public string Location { get => location; set => location = value; }
        public string Email { get => email; set => email = value; }
        public string Contactno { get => contactno; set => contactno = value; }
        public string Receptionist_id { get => receptionist_id; set => receptionist_id = value; }

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
    }
}
