using dmyo_oop_final_assigment.Models;
using System;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class PersonTable : DMYOTable<Person>
	{
		public override string Name => "Person";

		public override string[] Params => new string[] { "name", "password", "role", "factory" };


		public override void SetParameters(Person user, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", user.Name);
			command.Parameters.AddWithValue("@password", user.Password);
			command.Parameters.AddWithValue("@role", user.Role);
			command.Parameters.AddWithValue("@factory", (object)user.Factory ?? DBNull.Value);
        }

		public override Person GetModel(SqlDataReader reader)
		{
			return new Person()
			{
				Name = reader.GetString(1),
				Password = reader.GetString(2),
				Role = (PersonRole)reader.GetInt32(3),
				Factory = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
            };
		}
	}
}
