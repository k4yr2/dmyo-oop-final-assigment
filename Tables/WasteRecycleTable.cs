using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecycleTable : DMYOTable<WasteRecycle>
	{
		public override string Name => nameof(WasteRecycle);

		public override string[] Params => new string[] { "factory", "person", "status", "date" };

		public override void SetParameters(WasteRecycle recycle, SqlCommand command)
		{
			command.Parameters.AddWithValue("@factory", recycle.Factory);
			command.Parameters.AddWithValue("@person", recycle.Person);
			command.Parameters.AddWithValue("@status", recycle.Status);
			command.Parameters.AddWithValue("@date", recycle.Date);
		}

		public override WasteRecycle GetModel(SqlDataReader reader)
		{
			return new WasteRecycle()
			{
				Factory = reader.GetInt32(1),
				Person = reader.GetInt32(2),
				Status = (WasteStatus)reader.GetInt32(3),
				Date = reader.GetDateTime(4),
			};
		}
	}
}