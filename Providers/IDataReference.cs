using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Models
{
	public interface IDataReference<TModel> where TModel : class
	{
		DataObject<TModel> Object { get; set; }
	}
}