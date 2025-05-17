using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteDispatchTable : DMYOTable<WasteDispatch>
	{
		public override string Name => "WasteDispatch";

		public override string[] Params => new string[] { "type", "distribution", "quantity", "capacity", "date" };

		public override void SetParameters(WasteDispatch load, SqlCommand command)
		{
			command.Parameters.AddWithValue("@type", load.Type);
			command.Parameters.AddWithValue("@distribution", load.Distribution);
			command.Parameters.AddWithValue("@quantity", load.Quantity);
			command.Parameters.AddWithValue("@capacity", load.Capacity);
			command.Parameters.AddWithValue("@date", load.Date);
		}

		public override WasteDispatch GetModel(SqlDataReader reader)
		{
			return new WasteDispatch()
			{
				Type = reader.GetInt32(1),
				Distribution = reader.GetInt32(2),
				Quantity = reader.GetDecimal(3),
				Capacity = reader.GetDecimal(4),
				Date = reader.GetDateTime(5),
			};
		}
	}
}
