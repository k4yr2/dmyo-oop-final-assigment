using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteLoadTable : DMYOTable<WasteLoad>
	{
		public override string Name => "WasteLoad";

		public override string[] Params => new string[] { "date", "distribution", "waste", "demand", "granted" };

		public override void SetParameters(WasteLoad load, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", load.Date);
			command.Parameters.AddWithValue("@distribution", load.Distribution);
			command.Parameters.AddWithValue("@waste", load.Waste);
			command.Parameters.AddWithValue("@demand", load.Demand);
			command.Parameters.AddWithValue("@granted", load.Granted);
		}

		public override WasteLoad GetModel(SqlDataReader reader)
		{
			return new WasteLoad()
			{
				Date = reader.GetDateTime(1),
				Distribution = reader.GetInt32(2),
				Waste = reader.GetInt32(3),
				Demand = reader.GetDecimal(4),
				Granted = reader.GetDecimal(5)
			};
		}
	}
}
