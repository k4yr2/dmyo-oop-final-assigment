using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Table;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Tables
{
	public class AuthorityTable : DMYOTable<Authority>
	{
		public override string Name => "Authority";

		public override string[] Params => new string[] { "name", "password" };

		public override void SetParameters(Authority authority, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", authority.Name);
			command.Parameters.AddWithValue("@password", authority.Password);
		}

		public override Authority GetModel(SqlDataReader reader)
		{
			return new Authority()
			{
				Name = reader.GetString(1),
				Password = reader.GetString(2)
			};
		}
	}
}
