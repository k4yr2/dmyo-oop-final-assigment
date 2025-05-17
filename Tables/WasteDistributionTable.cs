using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteDistributionTable : DMYOTable<WasteDistribution>
	{
		public override string Name => "WasteDistribution";

		public override string[] Params => new string[] { "collection", "factory", "status", "date" };

		public override void SetParameters(WasteDistribution distribution, SqlCommand command)
		{
			command.Parameters.AddWithValue("@collection", distribution.Collection);
			command.Parameters.AddWithValue("@factory", (object)distribution.Factory ?? DBNull.Value);
			command.Parameters.AddWithValue("@status", distribution.Status);
			command.Parameters.AddWithValue("@date", distribution.Date);
		}

		public override WasteDistribution GetModel(SqlDataReader reader)
		{
			return new WasteDistribution()
			{
				Collection = reader.GetInt32(1),
				Factory = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
				Status = (WasteStatus)reader.GetInt32(3),
				Date = reader.GetDateTime(4),
			};
		}


		public IEnumerable<DMYOData<WasteDistribution>> GetDistributions(int collection)
		{
			return Select($"where collection = {collection} and status IN (0, 1, 2) order by status desc");
		}

		public DMYOData<WasteDistribution> GetCurrent(int collection)
		{
			return Select($"WHERE status IN (0, 1) and collection = {collection}").FirstOrDefault();
		}

		public DMYOData<WasteDistribution> GetInstance(int collection)
		{
			if(GetCurrent(collection) == null)
			{
				var distribution = Create(new WasteDistribution()
				{
					Collection = collection,
					Factory = null,
					Status = WasteStatus.Active,
					Date = DateTime.Now
				});

				foreach (var type in TableManager.WasteType.OfCollection(collection))
				{
					if(TableManager.Waste.CapacityOfType(collection, type.Id, distribution.Id) > 0)
					{
						TableManager.WasteDispatch.Create(new WasteDispatch()
						{
							Distribution = distribution.Id,
							Type = type.Id,
							Quantity = 0,
							Capacity = TableManager.Waste.CapacityOfType(collection, type.Id, distribution.Id),
							Date = DateTime.Now
						});
					}
				}

				return distribution;
			}

			return null;
		}
	}
}
