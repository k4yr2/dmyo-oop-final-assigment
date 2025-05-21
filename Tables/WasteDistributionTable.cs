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
			command.Parameters.AddWithValue("@factory", distribution.Factory.HasValue ? (object)distribution.Factory.Value : DBNull.Value);
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


		public IEnumerable<DMYOData<WasteDistribution>> GetDistributions(int collection, params int[] status)
		{
			if(status.Length == 0)
				status = new int[] { 0, 1, 2, 3 };

            return Select($"where collection = {collection} and status IN ({string.Join(",", status)}) order by status desc");
		}

		public IEnumerable<DMYOData<WasteDistribution>> OfSubmitteds(int factory)
		{
			return Select($@"where factory = {factory} 
			and status = 1 
			and collection in (select id from WasteCollection where status = 1 and WasteCollection.id = id)	
			order by date desc");
        }

        public DMYOData<WasteDistribution> GetCurrent(int collection)
		{
			return Select($"WHERE status IN (0, 1) and collection = {collection}").FirstOrDefault();
		}

		public bool Send(int collection)
		{
			var distribution = GetCurrent(collection);

			if (distribution != null)
			{
				distribution.Model.Status = WasteStatus.Processing;

				Update(distribution.Id, distribution.Model);
				return true;
			}

			return false;
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
