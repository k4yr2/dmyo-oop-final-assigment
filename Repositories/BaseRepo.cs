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

		public string CreateQuery
		{
			get
			{
				var tableParams = string.Join(", ", Params);
				var valueParams = string.Join(", ", Params.Select(p => $"@{p}"));

				return $"INSERT INTO {Name} ({tableParams}) VALUES ({valueParams})";
			}
		}

		public string ReadQuery
		{
			get
			{
				return $"SELECT * FROM {Name} WHERE id = @id";
			}
		}

		public string UpdateQuery
		{
			get
			{
				var setParams = string.Join(", ", Params.Select(p => $"{p} = @{p}"));
				return $"UPDATE {Name} SET {setParams} WHERE id = @id";
			}
		}

		public string DeleteQuery
		{
			get
			{
				return $"DELETE FROM {Name} WHERE id = @id";
			}
		}


		public DataObject<TModel> Create(TModel model)
		{
			int id = -1;

			DataManager.ExecuteCommand(CreateQuery, (SqlCommand command) =>
			{
				OnParameters(model, command);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			OnChanged.Invoke();
			return new DataObject<TModel>(id, model);
		}

		public DataObject<TModel> Read(int id)
		{
			TModel model = null;

			DataManager.ExecuteCommand(ReadQuery, (SqlCommand command) =>
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

			DataManager.ExecuteCommand(UpdateQuery, (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				OnParameters(model, command);

				affected = command.ExecuteNonQuery() > 0;
			});

			if(affected)
				OnChanged.Invoke();

			return affected;
		}

		public bool Delete(int id)
		{
			bool affected = false;
			DataManager.ExecuteCommand(DeleteQuery, (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			if (affected)
				OnChanged.Invoke();

			return affected;
		}


		public int Count()
		{
			int count = 0;
			DataManager.ExecuteCommand($"SELECT COUNT(*) FROM {Name}", (SqlCommand command) =>
			{
				count = (int)command.ExecuteScalar();
			});

			return count;
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

		public IEnumerable<DataObject<TModel>> ReadAll()
		{
			return DataManager.ExecuteCommand($"SELECT * FROM {Name}", DoRead);
		}

		public IEnumerable<DataObject<TModel>> ReadPage(int page, int per)
		{
			return DataManager.ExecuteCommand($"SELECT * FROM {Name} ORDER BY id OFFSET ({page} - 1) * {per} ROWS FETCH NEXT {per} ROWS ONLY", DoRead);
		}


		public abstract string Name { get; }

		public abstract string[] Params { get; }

		protected abstract void OnParameters(TModel model, SqlCommand command);

		protected abstract TModel OnModel(SqlDataReader reader);


	}
}
