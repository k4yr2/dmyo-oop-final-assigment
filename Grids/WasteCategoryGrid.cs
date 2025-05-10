using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public sealed class WasteCategoryGrid : DMYOGrid<WasteCategory>
	{
		public override DMYORepo<WasteCategory> Repo
		{
			get
			{
				return RepoManager.WasteCategory;
			}
		}

		public override void SetColumns(DataTable table)
		{
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("description", typeof(string));
			table.Columns.Add("hazardLevel", typeof(int));
			table.Columns.Add("recyclable", typeof(bool));
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

			view.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "hazardLevel",
				HeaderText = "Hazard Level",
				DataPropertyName = "hazardLevel",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			});

			view.Columns.Add(new DataGridViewCheckBoxColumn()
			{
				Name = "recyclable",
				HeaderText = "Recyclable",
				DataPropertyName = "recyclable",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			});
		}

		public override WasteCategory GetModel(DataGridViewRow row)
		{
			return new WasteCategory()
			{
				Name = row.Cells["name"].Value?.ToString(),
				Description = row.Cells["description"].Value?.ToString(),
				HazardLevel = Convert.ToInt32(row.Cells["hazardLevel"].Value),
				Recyclable = Convert.ToBoolean(row.Cells["recyclable"].Value)
			};
		}

		public override WasteCategory GetBlankModel()
		{
			return new WasteCategory()
			{
				Name = string.Empty,
				Description = string.Empty,
				HazardLevel = 0,
				Recyclable = false
			};
		}

		public override void FillRow(DataGridViewRow row, WasteCategory model)
		{
			row.Cells["name"].Value = model.Name;
			row.Cells["description"].Value = model.Description;
			row.Cells["hazardLevel"].Value = model.HazardLevel;
			row.Cells["recyclable"].Value = model.Recyclable;
		}
	}
}
