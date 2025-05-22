using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteProductTable : DMYOTable<WasteProduct>
	{
		public override string Name => "WasteProduct";

		public override string[] Params => new string[] { "recycle", "type", "quantity" };

		public override void SetParameters(WasteProduct recyclate, SqlCommand command)
		{
			command.Parameters.AddWithValue("@recycle", recyclate.Recycle);
            command.Parameters.AddWithValue("@type", recyclate.Type);
            command.Parameters.AddWithValue("@quantity", recyclate.Quantity);
		}

		public override WasteProduct GetModel(SqlDataReader reader)
		{
			return new WasteProduct()
			{
				Recycle = reader.GetInt32(1),
                Type = reader.GetInt32(2),
                Quantity = reader.GetDecimal(3)
			};
		}
	}
}
