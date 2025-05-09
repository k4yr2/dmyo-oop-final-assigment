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
		public override string Name => "WasteType";

		public override string[] Params => new string[] { "name", "description" } ;

		protected override void OnParameters(WasteType wasteType, SqlCommand command)
		{
			command.Parameters.AddWithValue("@name", wasteType.Name);
			command.Parameters.AddWithValue("@description", wasteType.Description);
		}

		protected override WasteType OnModel(SqlDataReader reader)
		{
			return new WasteType()
			{
				Name = reader.GetString(1),
				Description = reader.GetString(2)
			};
		}
	}
}