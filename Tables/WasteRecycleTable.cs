using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecycleTable : DMYOTable<WasteRecycle>
	{
		public override string Name => nameof(WasteRecycle);

		public override string[] Params => new string[] { "factory", "person", "status", "date" };

		public override void SetParameters(WasteRecycle recycle, SqlCommand command)
		{
			command.Parameters.AddWithValue("@factory", recycle.Factory);
			command.Parameters.AddWithValue("@person", recycle.Person);
			command.Parameters.AddWithValue("@status", recycle.Status);
			command.Parameters.AddWithValue("@date", recycle.Date);
		}

		public override WasteRecycle GetModel(SqlDataReader reader)
		{
			return new WasteRecycle()
			{
				Factory = reader.GetInt32(1),
				Person = reader.GetInt32(2),
				Status = (WasteStatus)reader.GetInt32(3),
				Date = reader.GetDateTime(4),
			};
		}


        public DMYOData<WasteRecycle> GetCurrent(int person)
        {
            return Select($"WHERE status IN (0, 1) and person = {person}").FirstOrDefault();
        }

        public DMYOData<WasteRecycle> Init(int person, int distribution)
        {
            var recycle = GetCurrent(person);

            if (recycle == null)
            {
                recycle = Create(new WasteRecycle()
                {
                    Factory = TableManager.Person.Read(person).Model.Factory.Value,
                    Person = person,
                    Status = WasteStatus.Active,
                    Date = DateTime.Now
                });

                foreach (var heap in TableManager.WasteHeap.OfFactory(recycle.Model.Factory))
                {
                    TableManager.WasteProduct.Create(new WasteProduct()
                    {
                        Recycle = recycle.Id,
                        Type = heap.Model.Type,
                        Quantity = 0,
                    });
                }

                return recycle;
            }
            else
            {
                return null;
            }
        }
    }
}