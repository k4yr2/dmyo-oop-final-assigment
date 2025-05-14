using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteDistributionTable : DMYOTable<WasteDistribution>
	{
		public override string Name => "WasteDistribution";

		public override string[] Params => new string[] { "date", "factory", "status" };

		public override void SetParameters(WasteDistribution waste, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", waste.Date);
			command.Parameters.AddWithValue("@factory", waste.Factory);
			command.Parameters.AddWithValue("@status", waste.Status);
		}

		public override WasteDistribution GetModel(SqlDataReader reader)
		{
			return new WasteDistribution()
			{
				Date = reader.GetDateTime(1),
				Factory = reader.GetInt32(2),
				Status = (WasteDistributionStatus)reader.GetInt32(3),
			};
		}
	}
}
