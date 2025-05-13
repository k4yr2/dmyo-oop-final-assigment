using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Managers
{
	internal static class DataManager
	{
		private static string connectionString = "Data Source=localhost;Initial Catalog=dmyo_oop_final_assigment;Integrated Security=True";


		public static void ExecuteCommand(string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{

				}
			}
			finally
			{
				connection.Close();
			}
		}

		public static void ExecuteCommand(string query, Action<SqlCommand> func)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					func.Invoke(command);
				}
			}
		}

		public static IEnumerable<T> ExecuteCommand<T>(string query, Func<SqlCommand, IEnumerable<T>> func)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					foreach (var item in func.Invoke(command))
						yield return item;
				}
			}
		}
	
		public static void FillTable(DataTable table, string query)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
				{
					adapter.Fill(table);
				}
			}
		}
	}
}