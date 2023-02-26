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
    // Declaring a class named Subject_price_calculator, which is internal (i.e., accessible within the same assembly)
    internal class Subject_price_calculator
    {
        // This public class is used to represent the calculation of payment totoal in the payment system.
        public class SubjectPriceCalculator
        {
            // The connection string used for the database
            private readonly string _connectionString;

            // Constructor for the SubjectPriceCalculator class that takes in a connection string as a parameter
            public SubjectPriceCalculator(string connectionString)
            {
                // The connection string is stored in the private field _connectionString
                _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            }

            // This method calculates the total price of a list of subject codes //
            public decimal CalculateTotalPrice(IEnumerable<string> subjectCodes)
            {
                // Check if the subject codes are null //
                if (subjectCodes == null)
                {
                    // Throw an ArgumentNullException if subjectCodes is null //
                    throw new ArgumentNullException(nameof(subjectCodes));
                }
                // Create a new list to hold the prices of each subject //
                var subjectPrices = new List<decimal>();

                // Loop through each subject code in the list of subject codes //
                foreach (var subjectCode in subjectCodes)
                {
                    // Get the price of the subject from the database //
                    var price = GetSubjectPriceFromDatabase(subjectCode);
                    // Add the subject price to the list of subject prices //
                    subjectPrices.Add(price);
                }
                // Return the total price of all the subjects //
                return subjectPrices.Sum();
            }

            // This method retrieves the price of a subject from the database //
            private decimal GetSubjectPriceFromDatabase(string subjectCode)
            {
                // Check if the subject code is null or empty //
                if (string.IsNullOrEmpty(subjectCode))
                {
                    // Throw an ArgumentException if the subject code is null or empty //
                    throw new ArgumentException("Subject code cannot be null or empty", nameof(subjectCode));
                }
                // Create a new SQL connection using the connection string "myCS" //
                SqlConnection connection  = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                // Create a new SQL command to retrieve the subject price from the database //
                using (var command = new SqlCommand("SELECT subject_price FROM PRICE_T WHERE subject_id = @Code", connection))
                {
                    // Add the subject code as a parameter to the SQL command //
                    command.Parameters.AddWithValue("@Code", subjectCode);
                    // Open the SQL connection */
                    connection.Open();
                    // Execute the SQL command and retrieve the result //
                    var result = command.ExecuteScalar();
                    // Check if the result is null or DBNull.Value //
                    if (result == null || result == DBNull.Value)
                    {
                        // Throw an ArgumentException if the subject code is not found in the database //
                        throw new ArgumentException($"Subject with code '{subjectCode}' not found in database", nameof(subjectCode));
                    }
                    // Return the subject price as a decimal //
                    return (decimal)result;
                }
            }
        }

    }
}
