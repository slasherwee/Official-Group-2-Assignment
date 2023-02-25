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
    internal class Subject_price_calculator
    {
        public class SubjectPriceCalculator
        {
            private readonly string _connectionString;

            public SubjectPriceCalculator(string connectionString)
            {
                _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            }

            public decimal CalculateTotalPrice(IEnumerable<string> subjectCodes)
            {
                if (subjectCodes == null)
                {
                    throw new ArgumentNullException(nameof(subjectCodes));
                }

                var subjectPrices = new List<decimal>();
                foreach (var subjectCode in subjectCodes)
                {
                    var price = GetSubjectPriceFromDatabase(subjectCode);
                    subjectPrices.Add(price);
                }

                return subjectPrices.Sum();
            }

            private decimal GetSubjectPriceFromDatabase(string subjectCode)
            {
                if (string.IsNullOrEmpty(subjectCode))
                {
                    throw new ArgumentException("Subject code cannot be null or empty", nameof(subjectCode));
                }

                SqlConnection connection  = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                using (var command = new SqlCommand("SELECT subject_price FROM PRICE_T WHERE subject_id = @Code", connection))
                {
                    command.Parameters.AddWithValue("@Code", subjectCode);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        throw new ArgumentException($"Subject with code '{subjectCode}' not found in database", nameof(subjectCode));
                    }

                    return (decimal)result;
                }
            }
        }

    }
}
