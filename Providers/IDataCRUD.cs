using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataCRUD
	{
		string CreateQuery { get; }

		string ReadQuery { get; }

		string UpdateQuery { get; }

		string DeleteQuery { get; }
	}

	public interface IDataCRUD<TModel> : IDataCRUD where TModel : DMYOModel
	{
		DMYOData<TModel> Create(TModel model);

		DMYOData<TModel> Read(int id);

		bool Update(int id, TModel model);

		bool Delete(int id);
	}
}
