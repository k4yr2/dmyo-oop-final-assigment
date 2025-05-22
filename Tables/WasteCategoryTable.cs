using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteCategoryTable : DMYOTable<WasteCategory>
	{
		public override string Name => "WasteCategory";

		public override string[] Params => new string[] { "name", "description", "hazardLevel", "recyclable" };


		public override void SetParameters(WasteCategory wasteUnit, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteUnit.Name);
			command.Parameters.AddWithValue("@description", wasteUnit.Description);
			command.Parameters.AddWithValue("@hazardLevel", wasteUnit.HazardLevel);
			command.Parameters.AddWithValue("@recyclable", wasteUnit.Recyclable);
		}

		public override WasteCategory GetModel(SqlDataReader reader)
		{
			return new WasteCategory()
			{
				Name = reader.GetString(1),
				Description = reader.GetString(2),
				HazardLevel = reader.GetInt32(3),
				Recyclable = reader.GetBoolean(4)
			};
		}
	}
}
