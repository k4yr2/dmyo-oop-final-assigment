using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Repositories;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public sealed class WasteUnitGrid : DMYOGrid<WasteUnit>
	{
		public override DMYORepo<WasteUnit> Repo
		{
			get
			{
				return RepoManager.WasteUnit;
			}
		}

		public override void SetColumns(DataTable table)
		{
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("abbreviation", typeof(string));
		}

		public override void SetView(DataGridView view)
		{
			view.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "name",
				HeaderText = "Name",
				DataPropertyName = "name",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			});

			view.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "abbreviation",
				HeaderText = "Abbreviation",
				DataPropertyName = "abbreviation",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			});
		}

		public override WasteUnit GetModel(DataGridViewRow row)
		{
			return new WasteUnit()
			{
				Name = row.Cells["name"].Value?.ToString(),
				Abbreviation = row.Cells["abbreviation"].Value?.ToString()
			};
		}
	}
}
