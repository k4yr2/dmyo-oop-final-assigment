using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataControl<TModel> : IDataLink<TModel> where TModel : class
	{
		DataView View { get; set; }
	}
}