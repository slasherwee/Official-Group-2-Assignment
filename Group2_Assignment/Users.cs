using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Assignment
{
    internal class Users
    {
        //member field
        private string id;
        private string password;
        private string ans_sq1;
        private string ans_sq2;

        // This is a SqlConnection object for connecting to the database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // This is a property for getting and setting the value of the "password" field.
        public string Password { get => password; set => password = value; }

        //Overloaded constructors
        public Users(string a)
        {
            id = a;//ETC_TUTOR001
        }

        public Users(string a, string b)
        {
            id = a;//ETC_TUTOR001
            password = b;//John@123
        }

        public Users(string a, string b, string c)
        {
            id = a;//ETC_TUTOR001
            ans_sq1 = b;
            ans_sq2 = c;
        }


        //methods

        // This is a method that logs in the user with the specified username and password.
        // The parameter "un" is the username.
        public string login(string un) //un=ETC_TUTOR001    
        {
            // Set the "status" variable to null.
            string? status = null;

            // Open the connection to the database.
            con.Open();

            // Create a SqlCommand object to select the count of rows with the specified username and password.
            SqlCommand cmd = new SqlCommand("select count(*) from USER_T where id=@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.Parameters.AddWithValue("@b", password);

            // Execute the query and get the count of rows returned.
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            // If the count of rows returned is greater than zero, the username and password are correct.
            if (count > 0)
            {
                // Create a SqlCommand object to select the role of the user with the specified username and password.
                SqlCommand cmd2 = new SqlCommand("select role from USER_T where id=@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", id);
                cmd2.Parameters.AddWithValue("@b", password);
                string userRole = cmd2.ExecuteScalar().ToString();

                // If the user role is "tutor", redirect to the Tutor Portal form.
                if (userRole == "tutor")
                {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redirects to Tutor Portal form
                    Tutor_Portal a = new Tutor_Portal(un, lp.BackColor);//un=ETC_TUTOR001
                    a.ShowDialog();
                }

                // If the user role is "student", redirect to the Student Portal form.
                else if (userRole == "student")
                {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redicrects to Student Portal form
                    Student_Portal s = new Student_Portal(un, lp.BackColor);
                    s.ShowDialog();
                }

                // If the user role is "admin", redirect to the AdminHome form.
                else if (userRole == "admin")
                 {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redirect to AdminHome form
                    frmAdminMenu am = new frmAdminMenu(un);
                    am.ShowDialog();
                 }

                // If the user role is "receptionist", redirect to the Receptionist form.
                else if (userRole == "receptionist")
                {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redirect to Receptionist form
                    frm_Main_Menu rep = new frm_Main_Menu(un);
                    rep.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();

            return status;
        }

        // Method to handle forgot password functionality
        public string forgot_password(string un) //un=ETC_TUTOR001
        {
            // Variable to store status of the operation, initialized to null
            string? status = null;

            // Open database connection
            con.Open();

            // SQL query to count number of rows that match the provided user ID and security question answers
            SqlCommand cmd = new SqlCommand("select count(*) from USER_T where id=@a and ans_Q1 =@b and ans_Q2 =@c", con);
            
            cmd.Parameters.AddWithValue("@a", id);// Add user ID parameter to the query
            cmd.Parameters.AddWithValue("@b", ans_sq1); // Add first security question answer parameter to the query
            cmd.Parameters.AddWithValue("@c", ans_sq2);// Add second security question answer parameter to the query

            // Execute the query and store the result in count variable
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            // If there is at least one matching row in the database
            if (count > 0)
            {
                // Create a new instance of Forgot_Password_Page1_ form
                Forgot_Password_Page1_ fp = new Forgot_Password_Page1_();
                fp.Hide();

                // Redirect to reset password page by creating a new instance of ResetPassword form
                ResetPassword rp = new ResetPassword(un);

                // Display the ResetPassword form as a dialog
                rp.ShowDialog();
            }
            else
                // If no matching rows found, set status to "Incorrect details provided"
                status = "Incorrect details provided";

            // Close database connection
            con.Close();

            // Return the status of the operation
            return status;
        }

        public static void viewPassword(Users o1)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

            SqlCommand cmd = new SqlCommand("select password from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.id);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                o1.password = rd["password"].ToString();
            }
            rd.Close();
            con.Close();
        }

        public string updatePassword(string a, string b)
        {
            string status;
            con.Open();
            password = a;
            id = b;

            SqlCommand cmd = new SqlCommand("update USER_T set password = @a where Id = @b", con);
            cmd.Parameters.AddWithValue("@a", password);
            cmd.Parameters.AddWithValue("@b", id);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                status = "Update Successfully";
                ResetPassword rp = new ResetPassword();
                rp.Hide();
                //redirect to LoginPage form
                LoginPage lp = new LoginPage();
                lp.ShowDialog();
            }

            else
                status = "Unable to update.";
            
            con.Close();
            
            return status;
        }

    }
}
