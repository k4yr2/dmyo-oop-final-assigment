using dmyo_oop_final_assigment.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteStockTable : DMYOTable<WasteStock>
	{
		public override string Name => "WasteStock";

		public override string[] Params => new string[] { "person", "distribution", "status", "date" };

		public override void SetParameters(WasteStock stock, SqlCommand command)
		{
			command.Parameters.AddWithValue("@person", stock.Person);
			command.Parameters.AddWithValue("@distribution", stock.Distribution);
			command.Parameters.AddWithValue("@status", stock.Status);
            command.Parameters.AddWithValue("@date", stock.Date);
		}

		public override WasteStock GetModel(SqlDataReader reader)
		{
			return new WasteStock()
			{
				Person = reader.GetInt32(1),
				Distribution = reader.GetInt32(2),
				Status = (WasteStatus)reader.GetInt32(3),
                Date = reader.GetDateTime(4),
			};
		}


		public DMYOData<WasteStock> GetCurrent(int person)
		{
			return Select($"WHERE status IN (0, 1) and person = {person}").FirstOrDefault();
        }

		public DMYOData<WasteStock> Init(int person, int distribution) 
		{ 
			var stock = GetCurrent(person);

			if (stock == null)
			{
				return Create(new WasteStock()
				{
					Person = person,
					Distribution = distribution,
					Status = WasteStatus.Active,
					Date = DateTime.Now
				});
			}
			else
			{
				return null;
			}
		}
    }
}
