using dmyo_oop_final_assigment.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace dmyo_oop_final_assigment.Managers
{
	internal static class DataManager
	{
		// Connection string
		private static string connectionString = "Data Source=localhost;Initial Catalog=dmyo_oop_final_assigment;Integrated Security=True";

		// Connection object
		private static SqlConnection m_connection;


		// Property to get the connection object
		private static SqlConnection Connection
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
		private static void OpenConnection()
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
		private static void CloseConnection()
		{
			if (m_connection != null && m_connection.State == System.Data.ConnectionState.Open)
			{
				m_connection.Close();
			}
		}

		public static void ExecuteCommand(string query)
		{
			try
			{
				OpenConnection();
				using (SqlCommand command = new SqlCommand(query, Connection))
				{

				}
			}
			finally
			{
				CloseConnection();
			}
		}

		public static void ExecuteCommand(string query, Action<SqlCommand> func)
		{
			try
			{
				OpenConnection();
				using (SqlCommand command = new SqlCommand(query, Connection))
				{
					func.Invoke(command);
				}
			}
			finally
			{
				CloseConnection();
			}
		}

		public static IEnumerable<T> ExecuteCommand<T>(string query, Func<SqlCommand, IEnumerable<T>> func)
		{
			try
			{
				OpenConnection();
				using (SqlCommand command = new SqlCommand(query, Connection))
				{
					foreach (var item in func.Invoke(command))
						yield return item;
				}
			}
			finally
			{
				CloseConnection();
			}
		}
	}
}
