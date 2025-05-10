using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Repositories
{
	interface IDMYORepo : IDataCRUD, IDataQuery
	{
		event Action OnChanged;

		string Name { get; }

		string[] Params { get; }
	}

	interface IDMYORepo<TModel> : IDMYORepo, IDataCRUD<TModel>, IDataQuery<TModel> where TModel : DMYOModel
	{
		void SetParameters(TModel model, SqlCommand command);

		TModel GetModel(SqlDataReader reader);
	}

	public abstract class DMYORepo<TModel> : IDMYORepo<TModel> where TModel : DMYOModel
	{
		public event Action OnChanged;

		public abstract string Name { get; }

		public abstract string[] Params { get; }


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

		public string ReadAllQuery
		{
			get
			{
				return $"SELECT * FROM {Name}";
			}
		}


		public abstract void SetParameters(TModel model, SqlCommand command);

		public abstract TModel GetModel(SqlDataReader reader);


		public DMYOData<TModel> Create(TModel model)
		{
			int id = -1;

			DataManager.ExecuteCommand(CreateQuery, (SqlCommand command) =>
			{
				SetParameters(model, command);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			//OnChanged?.Invoke();
			return new DMYOData<TModel>(id, model);
		}

		IDMYOData IDataCRUD.Create(object model)
		{
			return Create((TModel)model);
		}

		public DMYOData<TModel> Read(int id)
		{
			TModel model = default;

			DataManager.ExecuteCommand(ReadQuery, (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					model = GetModel(reader);
				}	
			});

			return new DMYOData<TModel>(id, model);
		}

		IDMYOData IDataCRUD.Read(int id)
		{
			return Read(id);
		}

		public bool Update(int id, TModel model)
		{
			bool affected = false;

			DataManager.ExecuteCommand(UpdateQuery, (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				SetParameters(model, command);

				affected = command.ExecuteNonQuery() > 0;
			});

			//if(affected)
			//	OnChanged?.Invoke();

			return affected;
		}

		bool IDataCRUD.Update(int id, object model)
		{
			return Update(id, (TModel)model);
		}

		public bool Delete(int id)
		{
			bool affected = false;
			DataManager.ExecuteCommand(DeleteQuery, (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			//if (affected)
			//	OnChanged?.Invoke();

			return affected;
		}


		private IEnumerable<DMYOData<TModel>> DoRead(SqlCommand command)
		{
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				yield return new DMYOData<TModel>(id, GetModel(reader));
			}
		}

		public IEnumerable<DMYOData<TModel>> ReadAll()
		{
			return DataManager.ExecuteCommand(ReadAllQuery, DoRead);
		}
	}
}