using System;
using System.Data;
using System.Data.SqlClient;

namespace PharmacistModule
{
    public static class DatabaseHelper
    {
        // Connection string configured for your server and database
        private static readonly string connectionString = "Server=localhost;Database=Medimate;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>
        /// Gets a new, open connection to the SQL Server database.
        /// </summary>
        /// <returns>An open SqlConnection object.</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Executes a non-query command (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">The SQL query string.</param>
        /// <param name="parameters">An array of SqlParameters for the query.</param>
        /// <returns>The number of rows affected.</returns>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
