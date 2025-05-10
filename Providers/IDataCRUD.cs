using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataCRUD
	{
		string CreateQuery { get; }

		string ReadQuery { get; }

		string UpdateQuery { get; }

		string DeleteQuery { get; }


		IDMYOData Create(object model);

		IDMYOData Read(int id);

		bool Update(int id, object model);

		bool Delete(int id);
	}

	public interface IDataCRUD<TModel> : IDataCRUD where TModel : DMYOModel
	{
		DMYOData<TModel> Create(TModel model);

		new DMYOData<TModel> Read(int id);

		bool Update(int id, TModel model);
	}
}
