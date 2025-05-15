using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteTable : DMYOTable<Waste>
	{
		public override string Name => "Waste";

		public override string[] Params => new string[] { "collection", "type", "quantity", "date"};

		public override void SetParameters(Waste waste, SqlCommand command)
		{
			command.Parameters.AddWithValue("@collection", waste.Collection);
			command.Parameters.AddWithValue("@type", waste.Type);
			command.Parameters.AddWithValue("@quantity", waste.Quantity);
			command.Parameters.AddWithValue("@date", waste.Date);
		}

		public override Waste GetModel(SqlDataReader reader)
		{
			return new Waste()
			{
				Collection = reader.GetInt32(1),
				Type = reader.GetInt32(2),
				Quantity = reader.GetDecimal(3),
				Date = reader.GetDateTime(4),
			};
		}
	}
}