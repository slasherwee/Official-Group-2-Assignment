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

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Password { get => password; set => password = value; }

        //constructor
        public Users(string a)
        {
            id = a;//ETC_TUTOR001
        }

        public Users(string a, string b)
        {
            id = a;//ETC_TUTOR001
            password = b;//john
        }

        public Users(string a, string b, string c)
        {
            id = a;//ETC_TUTOR001
            ans_sq1 = b;
            ans_sq2 = c;
        }


        //method
        public string login(string un) //un=john
        {
            string? status = null;
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            //SqlCommand cmd = new SqlCommand("select count(*)from users where username = '" + username + "' and password ='" + password + "'", con);
            SqlCommand cmd = new SqlCommand("select count(*) from USER_T where id=@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());//execute the command,convert into int for if and else statement

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from USER_T where id=@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", id);
                cmd2.Parameters.AddWithValue("@b", password);
                string userRole = cmd2.ExecuteScalar().ToString(); //string userRole="admin"

                if (userRole == "tutor")
                {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redirects to Tutor Portal form
                    Tutor_Portal a = new Tutor_Portal(un, lp.BackColor);//un=jeremy
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redicrects to Student Portal form
                    Student_Portal s = new Student_Portal(un);
                    s.ShowDialog();
                }
                else if (userRole == "admin")
                 {
                    LoginPage lp = new LoginPage();
                    lp.Hide();
                    //redirect to AdminHome form
                    frmAdminMenu am = new frmAdminMenu(un);
                    am.ShowDialog();
                 }

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

        public string forgot_password(string un) //un=john
        {
            string? status = null;
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            //SqlCommand cmd = new SqlCommand("select count(*)from users where username = '" + username + "' and password ='" + password + "'", con);
            SqlCommand cmd = new SqlCommand("select count(*) from USER_T where id=@a and ans_Q1 =@b and ans_Q2 =@c", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.Parameters.AddWithValue("@b", ans_sq1);
            cmd.Parameters.AddWithValue("@c", ans_sq2);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());//execute the command,convert into int for if and else statement

            if (count > 0)
            {
                Forgot_Password_Page1_ fp = new Forgot_Password_Page1_();
                fp.Hide();
                //redirect to reset password page
                ResetPassword rp = new ResetPassword(un);
                rp.ShowDialog();
            }
            else
                status = "Incorrect details provided";
            con.Close();

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
                //redirect to AdminHome form
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
