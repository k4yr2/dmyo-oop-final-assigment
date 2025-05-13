using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Managers
{
	internal static class DataManager
	{
		private static string connectionString = "Data Source=localhost;Initial Catalog=dmyo_oop_final_assigment;Integrated Security=True";


		public static void UseConnection(Action<SqlConnection> action)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					action.Invoke(connection);
				}
				finally
				{
					connection.Close();
				}
			}
		}

		public static T[] UseConnection<T>(Func<SqlConnection, IEnumerable<T>> func)
		{
			T[] array = Array.Empty<T>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					array = func?.Invoke(connection).ToArray();
				}
				finally
				{
					connection.Close();
				}
			}

			return array;
		}

		public static void ExecuteCommand(string query)
		{
			ExecuteCommand(query, null);
		}

		public static void ExecuteCommand(string query, Action<SqlCommand> act)
		{
			UseConnection((connection) =>
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					act?.Invoke(command);
				}
			});
		}

		public static T[] ExecuteCommand<T>(string query, Func<SqlCommand, IEnumerable<T>> func)
		{
			return UseConnection((connection) =>
			{
				IEnumerable<T> array = Enumerable.Empty<T>();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					array = func?.Invoke(command);
				}

				return array;
			});
		}


		public static void FillTable(DataTable table, string query)
		{
			UseConnection((connection) =>
			{
				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
				{
					adapter.Fill(table);
				}
			});
		}
	}
}