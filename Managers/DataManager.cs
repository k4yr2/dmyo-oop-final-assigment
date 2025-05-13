using dmyo_oop_final_assigment.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace dmyo_oop_final_assigment.Managers
{
	internal static class DataManager
	{
		// Connection string
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

			SqlConnection connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					func.Invoke(command);
				}
			}
			finally
			{
				connection.Close();
			}
		}

		public static IEnumerable<T> ExecuteCommand<T>(string query, Func<SqlCommand, IEnumerable<T>> func)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					foreach (var item in func.Invoke(command))
						yield return item;
				}
			}
			finally
			{
				connection.Close();
			}
		}
	

		public static void FillTable(DataTable table, string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();
				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
				{
					adapter.Fill(table);
				}
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
