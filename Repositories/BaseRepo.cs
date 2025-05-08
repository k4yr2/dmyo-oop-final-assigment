using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Repositories
{
	public abstract class BaseRepo<TModel> : IDataCRUD<TModel>, IDataQuery<TModel> where TModel : class
	{
		public abstract DataObject<TModel> Create(TModel model);

		public abstract DataObject<TModel> Read(int id);

		public abstract bool Update(int id, TModel model);

		public abstract bool Delete(int id);

		public abstract IEnumerable<DataObject<TModel>> ReadAll();
	}
}
