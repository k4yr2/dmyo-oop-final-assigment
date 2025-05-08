using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Managers
{
	public interface ICRUDManager<TModel> where TModel : class
	{
		SQLModel<TModel> Create(TModel model);

		SQLModel<TModel> Read(int id);

		bool Update(int id, TModel model);

		bool Delete(int id);
	}
}
