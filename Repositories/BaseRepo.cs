using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Repositories
{
	public abstract class BaseRepo<TModel> : IDataCRUD<TModel>, IDataQuery<TModel> where TModel : class
	{
		public event Action OnChanged;

		public DataObject<TModel> Create(TModel model)
		{
			int id = -1;

			var tableParams = string.Join(", ", Params);
			var valueParams = string.Join(", ", Params.Select(p => $"@{p}"));

			DataManager.ExecuteCommand($"INSERT INTO {Name} ({tableParams}) VALUES ({valueParams})", (SqlCommand command) =>
			{
				OnCreate(command);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			return new DataObject<TModel>(id, model);
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


		public abstract string Name { get; }

		public abstract string[] Params { get; }

		protected abstract void OnCreate(TModel model, SqlCommand command);
	}
}
