using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecycleTable : DMYOTable<WasteRecycle>
	{
		public override string Name => nameof(WasteRecycle);

		public override string[] Params => new string[] { "date", "factory", "recycling" };

		public override void SetParameters(WasteRecycle recycling, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", recycling.Date);
			command.Parameters.AddWithValue("@factory", recycling.Factory);
			command.Parameters.AddWithValue("@recycling", recycling.Recycling);
		}

		public override WasteRecycle GetModel(SqlDataReader reader)
		{
			return new WasteRecycle()
			{
				Date = reader.GetDateTime(1),
				Factory = reader.GetInt32(2),
				Recycling = reader.GetBoolean(3),
			};
		}
	}
}