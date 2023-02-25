using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Group2_Assignment
{
    internal class Payroll
    {

        //member field
        private string UserID;
        private string totalSalary;
        private string SalaryID;
        private string role;
        private int workingHour;
        private string SubjectID;
        private decimal BasicSalary;
        private decimal TotalAmount;

        public string TotalSalary { get => totalSalary; set => totalSalary = value; }
        public string Sid { get => SalaryID; set => SalaryID = value; }

        public Payroll()
        {

        }

        public Payroll(string id)
        {
            UserID = id;
        }

        public Payroll(string sid, string uid, string r, string subid, decimal bs, int h)
        {
            SalaryID = sid;
            UserID = uid;
            role = r;
            workingHour = h;
            SubjectID = subid;
            BasicSalary = bs;
        }


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static void CreateNewSalaryID(Payroll o1)
        {
            // Open Connection
            con.Open();
            SqlCommand command = new SqlCommand("select count(salary_id) from PAYROLL_T", con);
            SqlCommand cmd2 = new SqlCommand("select salary_id from PAYROLL_T", con);
            int i = Convert.ToInt32(command.ExecuteScalar().ToString());
            int count = i + 1;
            if (count < 10)
            {
                o1.SalaryID = "ETC_SALARY00" + (count).ToString();
            }
            else if (count >= 10)
            {
                o1.SalaryID = "ETC_SALARY0" + (count).ToString();
            }
            else if (count >= 100)
            {
                o1.SalaryID = "ETC_SALARY" + (count).ToString();
            }
            con.Close();
        }

        public string AddSalary()
        {
            string status;
            con.Open();
            TotalAmount = Convert.ToDecimal(workingHour) * BasicSalary;
            SqlCommand cmd = new SqlCommand("insert into PAYROLL_T (salary_id, salary_user_id, salary_user_role, salary_working_hour, salary_subject_id, " +
                "basic_salary_amount, total_salary_amount) values (@sid, @uid,@r, @h, @subid, @bs, @ta)", con);
            SqlCommand command = new SqlCommand("select count(salary_id) from PAYROLL_T", con);
            cmd.Parameters.AddWithValue("@sid", SalaryID);
            cmd.Parameters.AddWithValue("@uid", UserID);
            cmd.Parameters.AddWithValue("@ta", TotalAmount);
            cmd.Parameters.AddWithValue("@r", role);
            cmd.Parameters.AddWithValue("@h", workingHour);
            cmd.Parameters.AddWithValue("@bs", BasicSalary);
            if (!string.IsNullOrEmpty(SubjectID))
            {
                cmd.Parameters.AddWithValue("@subid", SubjectID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@subid", DBNull.Value);
            }

            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                status = "Payroll updated";
            }
            else
            {
                status = "Payroll not updated";
            }
            con.Close();
            return status;

        }

        public static ArrayList ViewSalaryID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_id from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewSalaryUserID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_user_id from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewSalaryUserRole()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_user_role from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewSalaryHour()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_working_hour from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd["salary_working_hour"].ToString());
            }
            con.Close();
            return nm;
        }


        public static ArrayList ViewSalarySubjectID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_subject_id from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewBasicSalary()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select basic_salary_amount from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd["basic_salary_amount"].ToString());
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewTotalSalary()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select total_salary_amount from PAYROLL_T", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd["total_salary_amount"].ToString());
            }
            con.Close();
            return nm;
        }

        public static ArrayList FindSalaryTutorID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_user_id from PAYROLL_T where salary_user_role = 'tutor' group by salary_user_id", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList FindSalaryReceptionistID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select salary_user_id from PAYROLL_T where salary_user_role = 'receptionist' group by salary_user_id", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static void FindTotalSalary(Payroll o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(total_salary_amount) from PAYROLL_T where salary_user_id ='" + o1.UserID + "'", con);
            string Sum = cmd.ExecuteScalar().ToString();
            o1.totalSalary = Sum;
            con.Close();
        }
    }
}
