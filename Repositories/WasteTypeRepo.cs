using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Repositories
{
	public class WasteTypeRepo : BaseRepo<WasteType>
	{
		public override string Name => "WasteTypes";

		public override string[] Params => new string[] { "name", "description" } ;

		protected override void OnCreate(WasteType wasteType, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteType.Name);
			command.Parameters.AddWithValue("@description", wasteType.Description);
		}

		protected override WasteType OnRead(SqlDataReader reader)
		{
			return new WasteType(reader.GetString(1), reader.GetString(2));
		}

		protected override bool OnUpdate(int id, WasteType model)
		{
			bool affected = false;
			DataManager.ExecuteCommand("UPDATE WasteTypes SET name = @Name, description = @Description WHERE id = @Id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Id", id);
				command.Parameters.AddWithValue("@Name", model.Name);
				command.Parameters.AddWithValue("@Description", model.Description);

				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		protected override bool OnDelete(int id)
		{
			bool affected = false;
			DataManager.ExecuteCommand("DELETE FROM WasteTypes WHERE id = @Id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@Id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		protected override IEnumerable<DataObject<WasteType>> OnReadAll()
		{
			List<DataObject<WasteType>> list = null;

			DataManager.ExecuteCommand("SELECT * FROM WasteTypes", (SqlCommand command) =>
			{
				SqlDataReader reader = command.ExecuteReader();
				list = new List<DataObject<WasteType>>();

				while (reader.Read())
				{
					int id = reader.GetInt32(0);
					WasteType wasteType = new WasteType(reader.GetString(1), reader.GetString(2));

					list.Add(new DataObject<WasteType>(id, wasteType));
				}
			});

			return list;
		}
	}
}