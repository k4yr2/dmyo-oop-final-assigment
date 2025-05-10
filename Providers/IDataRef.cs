using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataRef<TModel>
	{
		DMYOData<TModel> Data { get; }
	}
}