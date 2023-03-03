using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Collections;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace Group2_Assignment
{
    internal class Income
    {
        //member field
        private string TotalIncome;
        private int Month;
        private int Year;

        //constructor
        public Income()
        {
        }

        public Income(int M, int Y)
        {
            Month = M;
            Year= Y;
        }

        public Income(int y)
        {
            Year = y;
        }

        //Establish connection
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string TotalIncome1 { get => TotalIncome; set => TotalIncome = value; }

        public DataTable ViewIncomeReport()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select receipt_no, student_id, payment_date, payment_method, payment_total  from RECEIPT_T ", con);
            //Creating a DataTable 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter use to fill datatable from data source
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static ArrayList ViewMonth()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("SELECT DATENAME(month, payment_date) FROM RECEIPT_T GROUP BY DATENAME(month, payment_date) ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            rd.Close(); //Close the reader
            con.Close(); //Close connection
            return nm;
        }

        public static ArrayList ViewYear()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            //SqlCommand objectName = new Constructor(sqlQuery, connectionString);
            SqlCommand cmd = new SqlCommand("SELECT DATENAME(year, payment_date) FROM RECEIPT_T GROUP BY DATENAME(year, payment_date) ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            rd.Close(); //Close the reader
            con.Close(); //Close connection
            return nm;
        }

        public DataTable ViewIncomeReportSortMonthYear(int Month, int Year)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select receipt_no, student_id, payment_date, payment_method, payment_total  from RECEIPT_T " +
                "WHERE MONTH(payment_date) = @m AND YEAR(payment_date) = @y", con);
            cmd.Parameters.AddWithValue("@m", Month);
            cmd.Parameters.AddWithValue("@y", Year);
            //Creating a DataTable 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter use to fill datatable from data source
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ViewIncomeReportSortYear(int Year)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select receipt_no, student_id, payment_date, payment_method, payment_total  from RECEIPT_T " +
                "WHERE YEAR(payment_date) = @y", con);
            cmd.Parameters.AddWithValue("@y", Year);
            //Creating a DataTable 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter use to fill datatable from data source
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void SortMonthYear(Income o1)
        {
            con.Open();
            SqlCommand Total = new SqlCommand("select sum(payment_total) from RECEIPT_T WHERE MONTH(payment_date) = @m AND YEAR(payment_date) = @y", con);
            Total.Parameters.AddWithValue("@m", o1.Month);
            Total.Parameters.AddWithValue("@y", o1.Year);

            o1.TotalIncome = Total.ExecuteScalar().ToString();
            con.Close(); //Close connection
        }

        public static void SortYear(Income o1)
        {
            con.Open();
            SqlCommand Total = new SqlCommand("select sum(payment_total) from RECEIPT_T WHERE YEAR(payment_date) = @y ", con);
            Total.Parameters.AddWithValue("@y", o1.Year);

            o1.TotalIncome = Total.ExecuteScalar().ToString();
            con.Close(); //Close connection
        }


    }
}
