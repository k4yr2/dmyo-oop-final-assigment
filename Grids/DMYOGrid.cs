using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public abstract class DMYOGrid
	{
		public abstract DMYORepo Repo { get; }


		public abstract void Columns(DataTable table);

		public DataTable GetTable(string query = null)
		{
			DataTable table = new DataTable();
			Columns(table);

			DataManager.FillTable(table, query ?? Repo.ReadAllQuery);
			return table;
		}

		public virtual int ToID(DataGridViewRow row)
		{
			return Convert.ToInt32(row.Cells["ID"].Value);
		}
	}

	public abstract class DMYOGrid<TModel> : DMYOGrid where TModel : class
	{
		public override DMYORepo Repo
		{
			get
			{
				return RepoX;
			}
		}

		public abstract DMYORepo<TModel> RepoX { get; }


		public abstract TModel ToModel(DataGridViewRow row);

		public DMYOData<TModel> ToData(DataGridViewRow row)
		{
			return new DMYOData<TModel>(ToID(row), ToModel(row));
		}
	}
}
