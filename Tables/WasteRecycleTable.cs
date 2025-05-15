using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecycleTable : DMYOTable<WasteRecycle>
	{
		public override string Name => nameof(WasteRecycle);

		public override string[] Params => new string[] { "factory", "person", "active", "date" };

		public override void SetParameters(WasteRecycle recycle, SqlCommand command)
		{
			command.Parameters.AddWithValue("@factory", recycle.Factory);
			command.Parameters.AddWithValue("@person", recycle.Person);
			command.Parameters.AddWithValue("@active", recycle.Active);
			command.Parameters.AddWithValue("@date", recycle.Date);
		}

		public override WasteRecycle GetModel(SqlDataReader reader)
		{
			return new WasteRecycle()
			{
				Factory = reader.GetInt32(1),
				Person = reader.GetInt32(2),
				Active = reader.GetBoolean(3),
				Date = reader.GetDateTime(4),
			};
		}
	}
}