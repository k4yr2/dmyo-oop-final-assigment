using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteReceiptTable : DMYOTable<WasteReceipt>
	{
		public override string Name => "WasteReceipt";

		public override string[] Params => new string[] { "dispatch", "stock", "quantity", "date" };


		public override void SetParameters(WasteReceipt receipt, SqlCommand command)
		{
			command.Parameters.AddWithValue("@dispatch", receipt.Dispatch);
			command.Parameters.AddWithValue("@stock", receipt.Stock);
			command.Parameters.AddWithValue("@quantity", receipt.Quantity);
			command.Parameters.AddWithValue("@date", receipt.Date);

		}

		public override WasteReceipt GetModel(SqlDataReader reader)
		{
			return new WasteReceipt()
			{
				Dispatch = reader.GetInt32(1),
				Stock = reader.GetInt32(2),
				Quantity = reader.GetDecimal(3),
				Date = reader.GetDateTime(4),
			};
		}


        public IEnumerable<DMYOData<WasteReceipt>> GetReceipts(int stock)
        {
            return Select($"where distribution = {stock}");
        }
    }
}