using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Repositories
{
	public abstract class BaseRepo<TModel> : IDataCRUD<TModel>, IDataQuery<TModel> where TModel : class
	{
		public event Action OnChanged;

		public DataObject<TModel> Create(TModel model)
		{
			var data = OnCreate(model);

			if(data != null)
				OnChanged.Invoke();

			return data;
		}

		public DataObject<TModel> Read(int id)
		{
			return OnRead(id);
		}

		public bool Update(int id, TModel model)
		{
			bool affected = OnUpdate(id, model);

			if (affected) 
				OnChanged.Invoke();

			return affected;
		}

		public bool Delete(int id)
		{
			bool affected = OnDelete(id);

			if (affected)
				OnChanged.Invoke();

			return affected;
		}

		public IEnumerable<DataObject<TModel>> ReadAll()
		{
			return OnReadAll();
		}


		protected abstract DataObject<TModel> OnCreate(TModel model);

		protected abstract DataObject<TModel> OnRead(int id);

		protected abstract bool OnUpdate(int id, TModel model);

		protected abstract bool OnDelete(int id);

		protected abstract IEnumerable<DataObject<TModel>> OnReadAll();
	}
}
