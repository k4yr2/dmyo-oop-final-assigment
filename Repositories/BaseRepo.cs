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
				OnParameters(model, command);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			return new DataObject<TModel>(id, model);
		}

		public DataObject<TModel> Read(int id)
		{
			TModel model = null;

			DataManager.ExecuteCommand($"SELECT * FROM {Name} WHERE id = @id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					model = OnModel(reader);
				}	
			});

			return new DataObject<TModel>(id, model);
		}

		public bool Update(int id, TModel model)
		{
			bool affected = false;
			var setParams = string.Join(", ", Params.Select(p => $"{p} = @{p}"));

			DataManager.ExecuteCommand($"UPDATE {Name} SET {setParams} WHERE id = @id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				OnParameters(model, command);

				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		public bool Delete(int id)
		{
			bool affected = false;
			DataManager.ExecuteCommand($"DELETE FROM {Name} WHERE id = @id", (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			return affected;
		}

		public IEnumerable<DataObject<TModel>> ReadAll()
		{
			return DataManager.ExecuteCommand($"SELECT * FROM {Name}", DoRead);
		}

		private IEnumerable<DataObject<TModel>> DoRead(SqlCommand command)
		{
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				yield return new DataObject<TModel>(id, OnModel(reader));
			}
		}



		public abstract string Name { get; }

		public abstract string[] Params { get; }

		protected abstract void OnParameters(TModel model, SqlCommand command);

		protected abstract TModel OnModel(SqlDataReader reader);
	}
}
