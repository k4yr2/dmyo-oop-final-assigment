using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteUnitTable : DMYOTable<WasteUnit>
	{
		public override string Name => "WasteUnit";

		public override string[] Params => new string[] { "name", "abbr" };

		public override void SetParameters(WasteUnit waste, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", waste.Name);
			command.Parameters.AddWithValue("@abbr", waste.Abbr);
		}

		public override WasteUnit GetModel(SqlDataReader reader)
		{
			return new WasteUnit()
			{
				Name = reader.GetString(1),
				Abbr = reader.GetString(2),
			};
		}
	}
}
