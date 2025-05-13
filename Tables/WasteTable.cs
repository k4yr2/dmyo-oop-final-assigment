using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteTable : DMYOTable<Waste>
	{
		public override string Name => "Waste";

		public override string[] Params => new string[] { "date", "collection", "type", "quantity" };

		public override void SetParameters(Waste waste, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", waste.Date);
			command.Parameters.AddWithValue("@collection", waste.Collection);
			command.Parameters.AddWithValue("@type", waste.Type);
			command.Parameters.AddWithValue("@quantity", waste.Quantity);
		}

		public override Waste GetModel(SqlDataReader reader)
		{
			return new Waste()
			{
				Date = reader.GetDateTime(1),
				Collection = reader.GetInt32(2),
				Type = reader.GetInt32(3),
				Quantity = reader.GetInt32(4)
			};
		}
	}
}