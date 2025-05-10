using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataCRUD<TModel>
	{
		DMYOData<TModel> Create(TModel model);

		DMYOData<TModel> Read(int id);

		bool Update(int id, TModel model);

		bool Delete(int id);
	}
}
