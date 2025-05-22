using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteTypeTable : DMYOTable<WasteType>
	{
		public override string Name => "WasteType";

		public override string[] Params => new string[] { "name", "description", "category", "unit" } ;

		public override void SetParameters(WasteType wasteType, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteType.Name);
			command.Parameters.AddWithValue("@description", wasteType.Description);
			command.Parameters.AddWithValue("@category", wasteType.Category);
			command.Parameters.AddWithValue("@unit", wasteType.Unit);
		}

		public override WasteType GetModel(SqlDataReader reader)
		{
			return new WasteType()
			{
				Name = reader.GetString(1),
				Description = reader.GetString(2),
				Category = reader.GetInt32(3),
				Unit = reader.GetInt32(4)
			};
		}


		public IEnumerable<DMYOData<WasteType>> OfCollection(int id)
		{
			string query = $@"
				SELECT wt.*
				FROM Waste w
				JOIN WasteType wt ON w.type = wt.id
				WHERE w.collection = {id}
				  AND w.id IN (
					  SELECT MIN(id)
					  FROM Waste
					  WHERE collection = {id}
					  GROUP BY type
				 );";
			
			return DataManager.ExecuteCommand(query, DoSelect);
		}
	}
}