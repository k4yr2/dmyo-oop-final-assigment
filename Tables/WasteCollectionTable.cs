using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteCollectionTable : DMYOTable<WasteCollection>
	{
		public override string Name => "WasteCollection";

		public override string[] Params => new string[] { "person", "status", "date" };

		public override void SetParameters(WasteCollection collection, SqlCommand command)
		{
			command.Parameters.AddWithValue("@person", collection.Person);
			command.Parameters.AddWithValue("@status", collection.Status);
			command.Parameters.AddWithValue("@date", collection.Date);
		}

		public override WasteCollection GetModel(SqlDataReader reader)
		{
			return new WasteCollection()
			{
				Person = reader.GetInt32(1),
				Status = (WasteStatus)reader.GetInt32(2),
				Date = reader.GetDateTime(3),
			};
		}

		//

		public DMYOData<WasteCollection> GetCurrent(int person)
		{
			return Select($"WHERE status IN (0, 1) and person = {person}").FirstOrDefault();
		}

		public IEnumerable<DMYOData<Waste>> GetWastes(int id)
		{
			var collection = Select($"WHERE id = {id}").FirstOrDefault();

			if (collection == null)
				return null;

			return TableManager.Waste.Select($"WHERE collection = {collection.Id}");
		}

		public DMYOData<WasteCollection> Start(int person)
		{
			var collection = GetCurrent(person);

			if (collection == null)
			{
				return Create(new WasteCollection()
				{
					Person = person,
					Status = WasteStatus.Active,
					Date = DateTime.Now
				});
			}

			return null;
		}

		public bool Cancel(int person)
		{
			var collection = GetCurrent(person);

			if (collection == null)
				return false;

			collection.Model.Status = WasteStatus.Cancelled;
			Update(collection.Id, collection.Model);

			return true;
		}	

		public bool Distrubute(int person)
		{
			var collection = GetCurrent(person);

			if (collection == null)
				return false;

			collection.Model.Status = WasteStatus.Processing;
			Update(collection.Id, collection.Model);

			return true;
		}

		public bool Complete(int person)
		{
			var collection = GetCurrent(person);
			if (collection == null)
				return false;

			collection.Model.Status = WasteStatus.Completed;
			Update(collection.Id, collection.Model);
			return true;
        }
    }
}