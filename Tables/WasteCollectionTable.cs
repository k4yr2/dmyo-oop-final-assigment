using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
	public class WasteCollectionTable : DMYOTable<WasteCollection>
	{
		public override string Name => "WasteCollection";

		public override string[] Params => new string[] { "person", "status", "date" };

		public override void SetParameters(WasteCollection collection, SqlCommand command)
		{
			command.Parameters.AddWithValue("@person", collection.Person);
			command.Parameters.AddWithValue("@status", collection.Status);
			command.Parameters.AddWithValue("@date", collection.Date);
		}

		public override WasteCollection GetModel(SqlDataReader reader)
		{
			return new WasteCollection()
			{
				Person = reader.GetInt32(1),
				Status = (WasteStatus)reader.GetInt32(2),
				Date = reader.GetDateTime(3),
			};
		}

		//

		public DMYOData<WasteCollection> GetCurrent(int person)
		{
			return Select($"WHERE status IN (0, 1) and person = {person}").FirstOrDefault();
		}
	}
}
