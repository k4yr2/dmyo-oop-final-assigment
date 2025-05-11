using System.Data.SqlClient;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Table
{
	public class WasteTypeTable : DMYOTable<WasteType>
	{
		public override string Name => "WasteType";

		public override string[] Params => new string[] { "name", "description" } ;

		public override void SetParameters(WasteType wasteType, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteType.Name);
			command.Parameters.AddWithValue("@description", wasteType.Description);
		}

		public override WasteType GetModel(SqlDataReader reader)
		{
			return new WasteType()
			{
				Name = reader.GetString(1),
				Description = reader.GetString(2)
			};
		}
	}
}