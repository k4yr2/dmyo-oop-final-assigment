namespace dmyo_oop_final_assigment.Managers
{
	public interface ICRUDManager<TModel>
	{
		TModel Create();

		TModel Read(int id);

		bool Update(int id);

		bool Delete(int id);
	}
}
