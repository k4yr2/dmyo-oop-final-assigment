using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteCollectionTable : DMYOTable<WasteCollection>
	{
		public override string Name => "WasteCollection";

		public override string[] Params => new string[] { "date", "user", "collecting" };

		public override void SetParameters(WasteCollection collection, SqlCommand command)
		{
			command.Parameters.AddWithValue("@date", collection.Date);
			command.Parameters.AddWithValue("@user", collection.User);
			command.Parameters.AddWithValue("@collecting", collection.Collecting);
		}

		public override WasteCollection GetModel(SqlDataReader reader)
		{
			return new WasteCollection()
			{
				Date = reader.GetDateTime(1),
				User = reader.GetInt32(2),
				Collecting = reader.GetBoolean(3)
			};
		}

		//

		public DMYOData<WasteCollection> GetCollection(int user)
		{
			return Select($"WHERE collecting = 1 and [user] = {user}").FirstOrDefault();
		}
	}
}
