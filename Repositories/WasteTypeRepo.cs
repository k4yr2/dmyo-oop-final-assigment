using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Repositories
{
	public class WasteTypeRepo : BaseRepo<WasteType>
	{
		public override DataObject<WasteType> Create(WasteType model)
		{
			int id = -1;

			DataManager.ExecuteCommand("INSERT INTO WasteTypes (name, description) VALUES (@Name, @Description)", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Name", model.Name);
				command.Parameters.AddWithValue("@Description", model.Description);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			return new DataObject<WasteType>(id, model);
		}

		public override DataObject<WasteType> Read(int id)
		{
			WasteType wasteType = null;

			DataManager.ExecuteCommand("SELECT * FROM WasteTypes WHERE Id = @Id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Id", id);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
					wasteType = new WasteType(reader.GetString(1), reader.GetString(2));
			});

			return new DataObject<WasteType>(id, wasteType);
		}

		public override bool Update(int id, WasteType model)
		{
			bool affected = false;
			DataManager.ExecuteCommand("UPDATE WasteTypes SET Name = @Name, Description = @Description WHERE Id = @Id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Id", id);
				command.Parameters.AddWithValue("@Name", model.Name);
				command.Parameters.AddWithValue("@Description", model.Description);

				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		public override bool Delete(int id)
		{
			bool affected = false;
			DataManager.ExecuteCommand("DELETE FROM WasteTypes WHERE Id = @Id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		public override IEnumerable<DataObject<WasteType>> ReadAll()
		{
			SqlDataReader reader = null;
			DataManager.ExecuteCommand("SELECT * FROM WasteTypes", (SqlCommand command) =>
			{
				reader = command.ExecuteReader();
			});

			while(reader.Read())
			{
				int id = reader.GetInt32(0);
				WasteType wasteType = new WasteType(reader.GetString(1), reader.GetString(2));

				yield return new DataObject<WasteType>(id, wasteType);
			}
		}
	}
}