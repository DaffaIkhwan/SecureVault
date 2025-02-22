using System.Data.SqlClient;

namespace SecureVault.Services
{
    public class SecurityService
    {
        private readonly string _connectionString = "YourConnectionStringHere";

        public bool IsUserValid(string username)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
