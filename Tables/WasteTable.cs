using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;

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

		public decimal SumOfType(int collection, int type)
		{
			return TableManager.Waste.OfCollectionType(collection, type).Sum(w => w.Model.Quantity);
		}

		public decimal CapacityOfType(int collection, int type, int distribution)
		{
			var distributions = TableManager.WasteDistribution.GetDistributions(collection);

			decimal total = SumOfType(collection, type);

			foreach (var dist in distributions)
			{
				if (total <= 0 || dist.Id == distribution)
					break;

				var dispatch = TableManager.WasteDispatch.GetDispatch(dist.Id, type);
				total -= dispatch.Model.Quantity;
			}

			return Math.Max(total, 0);
		}
	}
}