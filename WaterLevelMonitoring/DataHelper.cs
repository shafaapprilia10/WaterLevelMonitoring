using Microsoft.Data.SqlClient;

namespace WaterLevelMonitoring
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=WaterLevelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}