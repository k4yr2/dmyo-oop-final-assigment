namespace dmyo_oop_final_assigment.Managers
{
	using System;
	using System.Data.SqlClient;

	public static class SqlConnectionManager
	{
		// Connection string
		private static string connectionString = "Data Source=localhost;Initial Catalog=dmyo_oop_final_assigment;Integrated Security=True;Trust Server Certificate=True";

		// Connection object
		private static SqlConnection connection;


		// Util method to open the connection
		private static void OpenConnection()
		{
			if (connection == null)
			{
				connection = new SqlConnection(connectionString);
			}

			if (connection.State != System.Data.ConnectionState.Open)
			{
				connection.Open();
			}
		}

		// Util method to close the connection
		private static void CloseConnection()
		{
			if (connection != null && connection.State == System.Data.ConnectionState.Open)
			{
				connection.Close();
			}
		}
	}
}
