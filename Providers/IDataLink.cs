using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataLink<TModel> : IDataRef<TModel> where TModel : DMYOModel
	{
		void Bind(DMYOData<TModel> data);
	}
}
