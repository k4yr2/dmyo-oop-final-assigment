using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment
{
	public interface IDMYOTable : IDataCRUD, IDataCollection
	{
		event Action OnChanged;

		string Name { get; }

		string[] Params { get; }

		void SetParameters(object model, SqlCommand command);

		object GetModel(SqlDataReader reader);
	}

	public interface IDMYOTable<TModel> : IDMYOTable, IDataCRUD<TModel>, IDataCollection<TModel>
	{
		void SetParameters(TModel model, SqlCommand command);

		new TModel GetModel(SqlDataReader reader);
	}

	public abstract class DMYOTable<TModel> : IDMYOTable<TModel>
	{
		public event Action OnChanged;

		public abstract string Name { get; }

		public abstract string[] Params { get; }


		public string CreateQuery
		{
			get
			{
				var tableParams = string.Join(", ", Params.Select(p => $"[{p}]"));
				var valueParams = string.Join(", ", Params.Select(p => $"@{p}"));

				return $"INSERT INTO [{Name}] ({tableParams}) VALUES ({valueParams}); SELECT SCOPE_IDENTITY();";
			}
		}

		public string ReadQuery
		{
			get
			{
				return $"SELECT * FROM [{Name}] WHERE id = @id";
			}
		}

		public string UpdateQuery
		{
			get
			{
				var setParams = string.Join(", ", Params.Select(p => $"{p} = @{p}"));
				return $"UPDATE [{Name}] SET {setParams} WHERE id = @id";
			}
		}

		public string DeleteQuery
		{
			get
			{
				return $"DELETE FROM [{Name}] WHERE id = @id";
			}
		}

		public string SelectQuery
		{
			get
			{
				return $"SELECT * FROM [{Name}]";
			}
		}


		public abstract void SetParameters(TModel model, SqlCommand command);

		void IDMYOTable.SetParameters(object model, SqlCommand command)
		{
			SetParameters((TModel)model, command);
		}

		public abstract TModel GetModel(SqlDataReader reader);

		object IDMYOTable.GetModel(SqlDataReader reader)
		{
			return GetModel(reader);
		}


		public DMYOData<TModel> Create(TModel model, string query = null)
		{
			int id = -1;

			DataManager.ExecuteCommand(_Query(CreateQuery, query), (SqlCommand command) =>
			{
				SetParameters(model, command);
				id = Convert.ToInt32(command.ExecuteScalar());
			});

			//OnChanged?.Invoke();
			return new DMYOData<TModel>(id, model);
		}

		IDMYOData IDataCRUD.Create(object model, string query)
		{
			return Create((TModel)model, query);
		}

		public DMYOData<TModel> Read(int id, string query = null)
		{
			bool found = false;
			TModel model = default;

			DataManager.ExecuteCommand(_Query(ReadQuery, query), (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					model = GetModel(reader);
					found = true;
				}	
			});

			if(found)
			{
				return new DMYOData<TModel>(id, model);
			}

			return null;
		}

		IDMYOData IDataCRUD.Read(int id, string query)
		{
			return Read(id, query);
		}

		public bool Update(int id, TModel model, string query = null)
		{
			bool affected = false;

			DataManager.ExecuteCommand(_Query(UpdateQuery, query), (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("@id", id);
				SetParameters(model, command);

				affected = command.ExecuteNonQuery() > 0;
			});

			//if(affected)
			//	OnChanged?.Invoke();

			return affected;
		}

		bool IDataCRUD.Update(int id, object model, string query)
		{
			return Update(id, (TModel)model, query);
		}

		public bool Delete(int id, string query = null)
		{
			bool affected = false;
			DataManager.ExecuteCommand(_Query(DeleteQuery, query), (SqlCommand command) =>
			{
				command.Parameters.AddWithValue("id", id);
				affected = command.ExecuteNonQuery() > 0;
			});

			//if (affected)
			//	OnChanged?.Invoke();

			return affected;
		}


		private IEnumerable<DMYOData<TModel>> DoSelect(SqlCommand command)
		{
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				yield return new DMYOData<TModel>(id, GetModel(reader));
			}
		}

		public IEnumerable<DMYOData<TModel>> Select(string query = null)
		{
			return DataManager.ExecuteCommand(_Query(SelectQuery, query), DoSelect);
		}

		IEnumerable<IDMYOData> IDataCollection.Select(string query)
		{
			return Select(query);
		}


		private static string _Query(string q1, string q2 = null)
		{
			if(q2 == null)
			{
				return q1;
			}

			return $"{q1} {q2}";
		}
	}
}