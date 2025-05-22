using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteProductTable : DMYOTable<WasteProduct>
	{
		public override string Name => "WasteProduct";

		public override string[] Params => new string[] { "recycling", "type", "quantity" };

		public override void SetParameters(WasteProduct recyclate, SqlCommand command)
		{
			command.Parameters.AddWithValue("@recycling", recyclate.Recycling);
            command.Parameters.AddWithValue("@type", recyclate.Type);
            command.Parameters.AddWithValue("@quantity", recyclate.Quantity);
		}

		public override WasteProduct GetModel(SqlDataReader reader)
		{
			return new WasteProduct()
			{
				Recycling = reader.GetInt32(1),
                Type = reader.GetInt32(2),
                Quantity = reader.GetDecimal(3)
			};
		}


        public IEnumerable<DMYOData<WasteProduct>> GetProducts(int recycling)
        {
            return Select($"where recycling = {recycling}");
        }
    }
}
