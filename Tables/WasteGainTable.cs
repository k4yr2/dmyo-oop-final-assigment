using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteGainTable : DMYOTable<WasteGain>
	{
		public override string Name => "WasteGain";

		public override string[] Params => new string[] { "receipt", "recycle", "quantity", "date" };

		public override void SetParameters(WasteGain recyclate, SqlCommand command)
		{
			command.Parameters.AddWithValue("@receipt", recyclate.Receipt);
			command.Parameters.AddWithValue("@recycle", recyclate.Recycle);
			command.Parameters.AddWithValue("@quantity", recyclate.Quantity);
			command.Parameters.AddWithValue("@date", recyclate.Date);
		}

		public override WasteGain GetModel(SqlDataReader reader)
		{
			return new WasteGain()
			{
				Receipt = reader.GetInt32(1),
				Recycle = reader.GetInt32(2),
				Quantity = reader.GetDecimal(3),
				Date = reader.GetDateTime(4),
			};
		}
	}
}
