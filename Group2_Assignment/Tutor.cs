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
        //member fields
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

        //Initialize a static SqlConnection object named con with the connection string from the configuration file. 
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

        //constructors
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
        
        //This method is to view the courses taught by the tutor
        public DataTable viewCourse(Tutor tutor)
        {
            // Create a new DataTable to hold the results
            DataTable dt = new DataTable();

            // Open the database connection
            con.Open();

            // Create a new SqlCommand to execute the SQL query
            SqlCommand cmd = new SqlCommand("select sub_id AS 'Subject ID', sub_name AS 'Subject Name', sub_hour AS 'Hour', sub_charges AS 'Charges per hour (RM)' from SUBJECT_T where tutor_id = @a", con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@a", tutor.tutorId);

            // Create a new SqlDataAdapter to fill the DataTable with the results of the SqlCommand
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Fill the DataTable with the results of the SqlCommand
            da.Fill(dt);

            // Close the database connection
            con.Close();

            // Return the DataTable
            return dt;
        }

        //This method is to view the students taught by the tutor based on the subject
        public DataTable viewStudent(string subName, Tutor tutor)
        {
            // Create a new DataTable to hold the results
            DataTable dt = new DataTable();

            // Open the database connection
            con.Open();

            // Create a new SqlCommand to execute the SQL query
            SqlCommand cmd = new SqlCommand("select stu_id AS 'Student ID', stu_name AS 'Student Name', stu_gender AS 'Gender' from SUBJECT_T where sub_id = (select sub_id from SUBJECT_T where sub_name = @a and tutor_id = @b) and tutor_id = @b", con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@a", subName);
            cmd.Parameters.AddWithValue("@b", tutor.tutorId);

            // Create a new SqlDataAdapter to fill the DataTable with the results of the SqlCommand
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Fill the DataTable with the results of the SqlCommand
            da.Fill(dt);

            // Close the database connection
            con.Close();

            // Return the DataTable
            return dt;
        }
        
        //This method is to view the subjects taught by the tutor
        public DataTable viewSubject(Tutor o1)
        {
            // Create a new DataTable to hold the results
            DataTable dt = new DataTable();

            // Open the database connection
            con.Open();

            // Create a new SqlCommand to execute the SQL query
            SqlCommand cmd = new SqlCommand("select sub_name from SUBJECT_T where tutor_id =@a", con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            // Create a new SqlDataAdapter to fill the DataTable with the results of the SqlCommand
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Fill the DataTable with the results of the SqlCommand
            da.Fill(dt);

            // Close the database connection
            con.Close();

            // Return the DataTable
            return dt;
        }

        //This code inserts a new course into the database
        public string addCourse()
        {
            // Create a string to hold the registration status
            string status;

            // Open the database connection
            con.Open();

            // Create a new SqlCommand to insert a new subject record into the database
            SqlCommand cmd = new SqlCommand("insert into SUBJECT_T (sub_id, sub_name, sub_hour, sub_charges, tutor_id) values (@sid, @nm, @hr, @cs, @tid)", con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@sid", subID);
            cmd.Parameters.AddWithValue("@nm", subName);
            cmd.Parameters.AddWithValue("@hr", subHour);
            cmd.Parameters.AddWithValue("@cs", subCharges);
            cmd.Parameters.AddWithValue("@tid", tutorId);

            // Execute the SqlCommand and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Set the registration status based on the number of rows affected
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";

            // Close the database connection
            con.Close();

            // Return the registration status
            return status;
        }

        //This method updates an existing course in the database
        public string updateCourse(string a, string b, string c, string d, string e, string f)
        {
            // Create a string to hold the update status
            string status;

            // Open the database connection
            con.Open();

            // Assign the new values to the instance variables
            newSubID = a;
            newSubName = b;
            SubHour = c;
            SubCharges = d;
            SubID = e;
            SubName = f;

            // Create a new SqlCommand to update the subject record in the database
            SqlCommand cmd = new SqlCommand("update SUBJECT_T set sub_id = @a, sub_name = @b, sub_hour = @c, sub_charges = @d where sub_id = @e and sub_name =@f and tutor_id = @g", con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@a", newSubID);
            cmd.Parameters.AddWithValue("@b", newSubName);
            cmd.Parameters.AddWithValue("@c", SubHour);
            cmd.Parameters.AddWithValue("@d", SubCharges);
            cmd.Parameters.AddWithValue("@e", SubID);
            cmd.Parameters.AddWithValue("@f", SubName);
            cmd.Parameters.AddWithValue("@g", tutorId);

            // Execute the SqlCommand and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Set the update status based on the number of rows affected
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";

            // Close the database connection
            con.Close();

            // Return the update status
            return status;
        }

        // This method deletes a course from the SUBJECT_T table based on the subject ID and tutor ID provided as parameters
        public string deleteCourse(string a, string b, string c, string d)
        {
            // Create a string to hold the update status
            string status;

            // Open the database connection
            con.Open();

            // Assign the values of the parameters to the corresponding class variables
            SubID = a;
            SubName = b;
            SubHour = c;
            SubCharges = d;

            // Create an SQL command to delete the course based on the subject ID and tutor ID
            SqlCommand cmd = new SqlCommand("delete FROM SUBJECT_T where sub_id = @a and tutor_id = @b", con);
            cmd.Parameters.AddWithValue("@a", SubID);
            cmd.Parameters.AddWithValue("@b", tutorId);

            // Execute the SQL command and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Check if any rows were affected and set the status message accordingly
            if (i != 0)
                status = "Deleted Successfully";
            else
                status = "Failed to delete.";

            // Close the database connection and return the status message
            con.Close();
            return status;
        }

        public DataTable viewDay(Tutor o1)
        {
            // Create a new DataTable object
            DataTable dt = new DataTable();

            // Open a database connection
            con.Open();

            // Define a SQL command that selects distinct days from the SCHEDULE_T table where the tutor_id matches the parameter
            SqlCommand cmd = new SqlCommand("select DISTINCT day from SCHEDULE_T where tutor_id =@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            // Use a data adapter to fill the DataTable with the results of the SQL query
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            // Close the database connection
            con.Close();

            // Return the filled DataTable
            return dt;
        }

        // This method is to view the schedule of a tutor
        public DataTable viewSchedule(string day, Tutor tutor)
        {
            // Initialize a new DataTable named "vs"
            DataTable vs = new DataTable();

            // Open a database connection
            con.Open();

            // Initialize a new SqlCommand object named "cmd" with a SQL query to select subject ID, subject name, venue, and time from the SCHEDULE_T table for a specific day and tutor ID
            SqlCommand cmd = new SqlCommand("select sub_id AS 'Subject ID', sub_name AS 'Subject Name', location AS 'Venue', CONVERT(VARCHAR(5), time, 108) AS Time from SCHEDULE_T where day = @a and tutor_id = @b", con);

            // Add two parameters to the SQL command - one for the day and one for the tutor ID
            cmd.Parameters.AddWithValue("@a", day);
            cmd.Parameters.AddWithValue("@b", tutor.tutorId);

            // Initialize a new SqlDataAdapter object named "da" with the SQL command
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Fill the DataTable "vs" with the data returned from the SQL command
            da.Fill(vs);

            // Close the database connection
            con.Close();

            // Return the DataTable "vs"
            return vs;
        }

        // This method updates the schedule of a tutor
        public string updateSchedule(string a, string b, string c, string d, string e)
        {
            // Create a string to hold the update status
            string status;

            // Open a database connection
            con.Open();

            // Assign the values of the parameters to the corresponding class variables
            SubID = a;
            tutorId = b;
            location = c;
            time = d;
            day = e;

            // create a new SQL command to update the schedule table with the new location and time for a specific subject, tutor, and day
            SqlCommand cmd = new SqlCommand("UPDATE SCHEDULE_T SET location = @c, time = @d WHERE sub_id = @a AND tutor_id = @b AND day = @e", con);
            cmd.Parameters.AddWithValue("@a", SubID);
            cmd.Parameters.AddWithValue("@b", tutorId);
            cmd.Parameters.AddWithValue("@c", location);
            cmd.Parameters.AddWithValue("@d", time);
            cmd.Parameters.AddWithValue("@e", Day);

            // execute the command and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // check if any rows were affected and set the status message accordingly
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";

            // close the database connection
            con.Close();

            // return the status message
            return status;
        }

        // This method is used to retrieve a tutor's profile information from the database and store it in a Tutor object
        public static void viewProfile(Tutor o1)
        {
            // Open the database connection
            con.Open();

            // Create a SQL command to select all columns from the TUTOR_T table where tutor_id equals the tutor's ID
            SqlCommand cmd = new SqlCommand("select * from TUTOR_T where tutor_id =@a", con);

            // Add the tutor's ID as a parameter to the command
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            // Execute the command and create a SqlDataReader to read the results
            SqlDataReader rd = cmd.ExecuteReader();

            // If the reader successfully reads a row from the results
            if (rd.Read())
            {
                // Store the values of the row's columns in the Tutor object's properties
                o1.fName = rd["fname"].ToString();
                o1.lName = rd["lname"].ToString();
                o1.teachingEx = rd["teachingEx"].ToString();
                o1.location = rd["officeLocation"].ToString();
                o1.email = rd["email"].ToString();
                o1.contactno = rd["contact_no"].ToString();
            }

            // Close the reader before closing the connection
            rd.Close(); 
            
            // Close the database connection
            con.Close();
        }

        // Define a method to update the tutor's profile
        public string updateProfile(string fn, string ln, string te, string l, string em, string cn)
        {
            // Create a string to hold the update status
            string status;

            // Open a database connection
            con.Open();

            // Assign values to the object's properties
            fName = fn;
            LName = ln;
            TeachingEx = te;
            location = l;
            email = em;
            contactno = cn;

            // Prepare the SQL command to update the profile in the database
            SqlCommand cmd = new SqlCommand("update TUTOR_T set fname = @a, lname = @b, teachingEx = @c, officeLocation = @d, email = @e, contact_no = @f where tutor_id = @g", con);
            cmd.Parameters.AddWithValue("@a", fName);
            cmd.Parameters.AddWithValue("@b", LName);
            cmd.Parameters.AddWithValue("@c", TeachingEx);
            cmd.Parameters.AddWithValue("@d", location);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@f", contactno);
            cmd.Parameters.AddWithValue("@g", tutorId);

            // Execute the command and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Check if any row was updated and return appropriate status message
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";

            // Close the database connection and return the status message
            con.Close();
            return status;
        }

        // This method is used to retrieve the password of a tutor from the database
        public static void viewPassword(Tutor o1)
        {
            // Open a database connection
            con.Open();

            // Create a SQL command to select the password of the tutor with the given id
            SqlCommand cmd = new SqlCommand("select password from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            // Execute the command and read the result
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                // If a result is found, assign the password value to the tutor object
                o1.tutor_pass = rd["password"].ToString();
            }

            // Close the reader and the database connection
            rd.Close();
            con.Close();
        }

        // This method is used to view the security questions and their answers for a Tutor object
        public static void viewSecurityQuestion(Tutor o1)
        {
            // Open a database connection
            con.Open();

            // Define a SQL command to retrieve the security question answers for the given tutor ID
            SqlCommand cmd = new SqlCommand("select ans_Q1, ans_Q2 from USER_T where id=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.tutorId);

            // Execute the SQL command and retrieve the results using a SqlDataReader
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                // If there is a result, set the Tutor object's ans_q1 and ans_q2 properties to the retrieved values
                o1.ans_q1 = rd["ans_Q1"].ToString();
                o1.ans_q2 = rd["ans_Q2"].ToString();
            }

            // Close the SqlDataReader
            rd.Close();

            // Close the database connection
            con.Close();
        }

        // This method updates the security questions and answers for a tutor
        public string updateAns(string a, string b, string c)
        {
            // Create a string to hold the update status
            string status;

            // Open database connection
            con.Open();

            ans_q1 = a;
            ans_q2 = b;
            tutorId = c;

            // Create SQL command to update USER_T table with new answers for given tutor id
            SqlCommand cmd = new SqlCommand("update USER_T set ans_Q1 = @a, ans_Q2 = @b where Id = @c", con);

            // Add parameters to the SQL command for the new answers and tutor id
            cmd.Parameters.AddWithValue("@a", ans_q1);
            cmd.Parameters.AddWithValue("@b", ans_q2);
            cmd.Parameters.AddWithValue("@c", tutorId);

            // Execute the SQL command and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Check if any row was affected and set status message accordingly
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";

            // Close database connection and return status message
            con.Close();
            return status;
        }

        // Method to update the password of a tutor
        public string updatePassword(string a, string b)
        {
            // Create a string to hold the update status
            string status;

            // Open the connection to the database
            con.Open();

            tutor_pass = a;
            tutorId = b;

            // Create a SQL command to update the password in the database
            SqlCommand cmd = new SqlCommand("update USER_T set password = @a where Id = @b", con);
            cmd.Parameters.AddWithValue("@a", tutor_pass);
            cmd.Parameters.AddWithValue("@b", tutorId);

            // Execute the command and get the number of rows affected
            int i = cmd.ExecuteNonQuery();

            // Set the status message based on whether the update was successful
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update.";

            // Close the connection to the database and return the status message
            con.Close();
            return status;
        }


    }
}
