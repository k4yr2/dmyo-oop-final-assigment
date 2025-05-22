namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataCRUD
	{
		string CreateQuery { get; }

		string ReadQuery { get; }

		string UpdateQuery { get; }

		string DeleteQuery { get; }


		IDMYOData Create(object model, string query = null);

		IDMYOData Read(int id, string query = null);

		bool Update(int id, object model, string query = null);

		bool Delete(int id, string query = null);
	}

	public interface IDataCRUD<TModel> : IDataCRUD
	{
		DMYOData<TModel> Create(TModel model, string query = null);

		new DMYOData<TModel> Read(int id, string query = null);

		bool Update(int id, TModel model, string query = null);
	}
}
