using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;
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


		public IEnumerable<DMYOData<Waste>> OfCollectionType(int collection, int type)
		{
			string query = $@"
				SELECT *
				FROM Waste
				WHERE collection = {collection}
				  AND type = {type}
				  AND id IN (
					  SELECT MIN(id)
					  FROM Waste
					  WHERE collection = {collection}
					    AND type = {type}
					  GROUP BY date
				  );";

			return DataManager.ExecuteCommand(query, DoSelect);
		}
	}
}