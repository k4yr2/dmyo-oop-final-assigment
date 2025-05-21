using dmyo_oop_final_assigment.Managers;
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

		public DMYOData<WasteStock> GetOf(int distribution)
		{
			return Select($"WHERE distribution = {distribution}").FirstOrDefault();
        }


        public DMYOData<WasteStock> Init(int person, int distribution) 
		{ 
			var stock = GetCurrent(person);

			if (stock == null)
			{
				stock = Create(new WasteStock()
				{
					Person = person,
					Distribution = distribution,
					Status = WasteStatus.Active,
					Date = DateTime.Now
				});

				foreach (var dispatch in TableManager.WasteDispatch.GetDispatchs(stock.Model.Distribution))
				{
                    TableManager.WasteReceipt.Create(new WasteReceipt()
                    {
						Dispatch = dispatch.Id,
                        Stock = stock.Id,
						Quantity = 0,
						Date = DateTime.Now,
                    });
                }

                return stock;
			}
			else
			{
				return null;
			}
		}

		public bool Cancel(int person)
		{
			var stock = GetCurrent(person);
			if (stock != null)
			{
				stock.Model.Status = WasteStatus.Cancelled;
				Update(stock.Id, stock.Model);

				var distribution = TableManager.WasteDistribution.Read(stock.Model.Distribution);
				if(distribution != null)
				{
					distribution.Model.Status = WasteStatus.Cancelled;
					TableManager.WasteDistribution.Update(distribution.Id, distribution.Model);
                }

				return true;
			}
			else
			{
				return false;
            }
        }
    }
}
