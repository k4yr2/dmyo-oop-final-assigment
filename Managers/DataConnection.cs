using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Managers
{
	internal static class DataConnection
	{
		// Connection string
		private static string connectionString = "Data Source=localhost;Initial Catalog=dmyo_oop_final_assigment;Integrated Security=True;Trust Server Certificate=True";

		// Connection object
		private static SqlConnection m_connection;


		// Property to get the connection object
		public static SqlConnection Connection
		{
			get
			{
				if (m_connection == null)
				{
					m_connection = new SqlConnection(connectionString);
				}

				return m_connection;
			}
		}

		// Util method to open the connection
		public static void OpenConnection()
		{
			if (m_connection == null)
			{
				m_connection = new SqlConnection(connectionString);
			}

			if (m_connection.State != System.Data.ConnectionState.Open)
			{
				m_connection.Open();
			}
		}

		// Util method to close the connection
		public static void CloseConnection()
		{
			if (m_connection != null && m_connection.State == System.Data.ConnectionState.Open)
			{
				m_connection.Close();
			}
		}
	}
}
