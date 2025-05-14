using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteRecyclateTable : DMYOTable<WasteRecyclate>
	{
		public override string Name => "WasteRecyclate";

		public override string[] Params => new string[] { "date", "recycling", "load", "gain" };

		public override void SetParameters(WasteRecyclate recyclate, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", recyclate.Date);
			command.Parameters.AddWithValue("@recycling", recyclate.Recycling);
			command.Parameters.AddWithValue("@load", recyclate.Load);
			command.Parameters.AddWithValue("@gain", recyclate.Gain);
		}

		public override WasteRecyclate GetModel(SqlDataReader reader)
		{
			return new WasteRecyclate()
			{
				Date = reader.GetDateTime(1),
				Recycling = reader.GetInt32(2),
				Load = reader.GetInt32(3),
				Gain = reader.GetDecimal(4)
			};
		}
	}
}
