using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public sealed class WasteTypeGrid : DMYOGrid<WasteType>
	{
		public override DMYORepo<WasteType> Repo
		{
			get
			{
				return RepoManager.WasteType;
			}
		}

		public override void SetColumns(DataTable table)
		{
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("description", typeof(string));
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
				Name = "description",
				HeaderText = "Description",
				DataPropertyName = "description",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			});
		}

		public override WasteType GetModel(DataGridViewRow row)
		{
			return new WasteType()
			{
				Name = row.Cells["name"].Value?.ToString(),
				Description = row.Cells["description"].Value?.ToString()
			};
		}

		public override WasteType GetBlankModel(DataGridViewRow row)
		{
			return new WasteType()
			{
				Name = string.Empty,
				Description = string.Empty
			};
		}
	}
}

