using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public abstract class DMYOGrid<TModel> where TModel : class
	{
		public abstract void Columns(DataTable table);

		public abstract TModel ToModel(DataGridViewRow row);
	}
}
