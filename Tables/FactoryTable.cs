using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Tables
{
	public class FactoryTable : DMYOTable<Factory>
	{
		public override string Name => "Factory";

		public override string[] Params => new string[] { "name" };


		public override void SetParameters(Factory user, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", user.Name);
		}

		public override Factory GetModel(SqlDataReader reader)
		{
			return new Factory()
			{
				Name = reader.GetString(1)
			};
		}
	}
}
