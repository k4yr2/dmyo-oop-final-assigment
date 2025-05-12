namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataLink<TModel> : IDataRef<TModel>
	{
		void Bind(DMYOData<TModel> data);
	}
}
