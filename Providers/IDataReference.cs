using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataReference<TModel> where TModel : class
	{
		DataObject<TModel> Object { get; set; }
	}
}