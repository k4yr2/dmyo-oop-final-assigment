using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Repositories;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public abstract class DMYOGrid<TModel> where TModel : class
	{
		public abstract BaseRepo<TModel> Repo { get; }

		public abstract void Columns(DataTable table);

		public abstract TModel ToModel(DataGridViewRow row);


		public DataTable GetTable(string query = null)
		{
			DataTable table = new DataTable();
			Columns(table);

			DataManager.FillTable(table, query ?? Repo.ReadAllQuery);
			return table;
		}
	}
}
