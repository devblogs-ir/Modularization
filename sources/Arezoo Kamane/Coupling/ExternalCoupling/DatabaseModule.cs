using System.Data.SqlClient;

namespace Coupling.ExternalCoupling
{
    public class DatabaseModule
    {
        private readonly string connectionString;

        public DatabaseModule(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string? GetUserNameById(int userId)
        {
            string? userName = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserName FROM Users WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userName = reader["UserName"].ToString();
                        }
                    }
                }
            }

            return userName;
        }
    }
}
