using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Repositories
{
	public class WasteTypeRepository : IDataCRUD<WasteType>, IDataQuery<WasteType>
	{
		public SQLData<WasteType> Create(WasteType model)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public SQLData<WasteType> Read(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SQLData<WasteType>> ReadAll()
		{
			throw new NotImplementedException();
		}

		public bool Update(int id, WasteType model)
		{
			throw new NotImplementedException();
		}
	}
}
