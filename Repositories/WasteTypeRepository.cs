using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Repositories
{
	public class WasteTypeRepository : BaseRepository<WasteType>
	{
		public override SQLData<WasteType> Create(WasteType model)
		{
			throw new NotImplementedException();
		}

		public override SQLData<WasteType> Read(int id)
		{
			throw new NotImplementedException();
		}

		public override bool Update(int id, WasteType model)
		{
			throw new NotImplementedException();
		}

		public override bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public override IEnumerable<SQLData<WasteType>> ReadAll()
		{
			throw new NotImplementedException();
		}
	}
}