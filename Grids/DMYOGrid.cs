using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Table;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public interface IDMYOGrid
	{
		IDMYOTable Table { get; }

		DataTable GetTable(string query = null);

		void SetColumns(DataTable table);

		void SetView(DataGridView view);


		int GetID(DataGridViewRow row);

		DMYOModel GetModel(DataGridViewRow row);

		DMYOModel GetBlankModel();

		IDMYOData GetData(DataGridViewRow row);

		void FillRow(DataGridViewRow row, DMYOModel model);
	}

	public interface IDMYOGrid<TModel> : IDMYOGrid where TModel : DMYOModel
	{
		new DMYOTable<TModel> Table { get; }

		new TModel GetModel(DataGridViewRow row);

		new TModel GetBlankModel();

		new DMYOData<TModel> GetData(DataGridViewRow row);

		void FillRow(DataGridViewRow row, TModel model);
	}

	public abstract class DMYOGrid<TModel> : IDMYOGrid<TModel> where TModel : DMYOModel
	{
		public abstract DMYOTable<TModel> Table { get; }

		IDMYOTable IDMYOGrid.Table => Table;


		public DataTable GetTable(string query = null)
		{
			DataTable table = new DataTable();
			SetColumns(table);

			DataManager.FillTable(table, query ?? Table.SelectQuery);
			return table;
		}

		public abstract void SetColumns(DataTable table);

		public abstract void SetView(DataGridView view);


		public virtual int GetID(DataGridViewRow row)
		{
			return Convert.ToInt32(row.Cells["ID"].Value);
		}

		public abstract TModel GetModel(DataGridViewRow row);

		DMYOModel IDMYOGrid.GetModel(DataGridViewRow row)
		{
			return GetModel(row);
		}

		public abstract TModel GetBlankModel();

		DMYOModel IDMYOGrid.GetBlankModel()
		{
			return GetBlankModel();
		}

		public DMYOData<TModel> GetData(DataGridViewRow row)
		{
			return new DMYOData<TModel>(GetID(row), GetModel(row));
		}

		IDMYOData IDMYOGrid.GetData(DataGridViewRow row)
		{
			return GetData(row);
		}

		public abstract void FillRow(DataGridViewRow row, TModel model);

		void IDMYOGrid.FillRow(DataGridViewRow row, DMYOModel model)
		{
			FillRow(row, (TModel)model);
		}
	}
}
