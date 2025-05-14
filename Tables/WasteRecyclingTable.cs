using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecyclingTable : DMYOTable<WasteRecycling>
	{
		public override string Name => "WasteRecycling";

		public override string[] Params => new string[] { "date", "factory", "active" };

		public override void SetParameters(WasteRecycling recycling, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", recycling.Date);
			command.Parameters.AddWithValue("@factory", recycling.Factory);
			command.Parameters.AddWithValue("@active", recycling.Active);
		}

		public override WasteRecycling GetModel(SqlDataReader reader)
		{
			return new WasteRecycling()
			{
				Date = reader.GetDateTime(1),
				Factory = reader.GetInt32(2),
				Active = reader.GetBoolean(3),
			};
		}
	}
}
