using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class FactoryAccessTable : DMYOTable<FactoryAccess>
	{
		public override string Name => "FactoryAccess";

		public override string[] Params => new string[] { "person", "factory", "mode" };


		public override void SetParameters(FactoryAccess user, SqlCommand command)
		{
			command.Parameters.AddWithValue("@person", user.Person);
			command.Parameters.AddWithValue("@factory", user.Factory);
			command.Parameters.AddWithValue("@mode", user.Mode);
		}

		public override FactoryAccess GetModel(SqlDataReader reader)
		{
			return new FactoryAccess()
			{
				Person = reader.GetInt32(1),
				Factory = reader.GetInt32(2),
				Mode = (FactoryAccessMode)reader.GetInt32(3)
			};
		}
	}
}
