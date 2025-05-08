using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataReadonlyRef<TModel> where TModel : class
	{
		DataObject<TModel> Object { get; }
	}
}