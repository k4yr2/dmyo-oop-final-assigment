using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Tables
{
	public class UserTable : DMYOTable<User>
	{
		public override string Name => "User";

		public override string[] Params => new string[] { "name", "password", "role", "recyclable" };


		public override void SetParameters(User user, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", user.Name);
			command.Parameters.AddWithValue("@password", user.Password);
			command.Parameters.AddWithValue("@role", user.Role);
		}

		public override User GetModel(SqlDataReader reader)
		{
			return new User()
			{
				Name = reader.GetString(1),
				Password = reader.GetString(2),
				Role = (UserRole)reader.GetInt32(3)
			};
		}
	}
}
