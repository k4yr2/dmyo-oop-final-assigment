using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteDispatchTable : DMYOTable<WasteDispatch>
	{
		public override string Name => "WasteDispatch";

		public override string[] Params => new string[] { "waste", "distribution", "quantity", "date" };

		public override void SetParameters(WasteDispatch load, SqlCommand command)
		{
			command.Parameters.AddWithValue("@waste", load.Waste);
			command.Parameters.AddWithValue("@distribution", load.Distribution);
			command.Parameters.AddWithValue("@quantity", load.Quantity);
			command.Parameters.AddWithValue("@date", load.Date);
		}

		public override WasteDispatch GetModel(SqlDataReader reader)
		{
			return new WasteDispatch()
			{
				Waste = reader.GetInt32(1),
				Distribution = reader.GetInt32(2),
				Quantity = reader.GetDecimal(3),
				Date = reader.GetDateTime(4),
			};
		}
	}
}
