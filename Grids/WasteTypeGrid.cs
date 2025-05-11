using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Table;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public sealed class WasteTypeGrid : DMYOGrid<WasteType>
	{
		public override DMYOTable<WasteType> Table
		{
			get
			{
				return TableManager.WasteType;
			}
		}

		public override void SetColumns(DataTable table)
		{
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("description", typeof(string));
			table.Columns.Add("category", typeof(int));
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

			view.Columns.Add(new DataGridViewComboBoxColumn()
			{
				Name = "category",
				HeaderText = "Category",
				DataPropertyName = "category",
				DataSource = TableManager.WasteCategory.Select().ToList(),
				DisplayMember = "Model",
				ValueMember = "Id",
				FlatStyle = FlatStyle.Flat,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});
		}

		public override WasteType GetModel(DataGridViewRow row)
		{
			return new WasteType()
			{
				Name = row.Cells["name"].Value?.ToString(),
				Description = row.Cells["description"].Value?.ToString(),
				Category = Convert.ToInt32(row.Cells["category"].Value)
			};
		}

		public override WasteType GetBlankModel()
		{
			return new WasteType()
			{
				Name = string.Empty,
				Description = string.Empty,
				Category = 0
			};
		}

		public override void FillRow(DataGridViewRow row, WasteType model)
		{
			row.Cells["name"].Value = model.Name;
			row.Cells["description"].Value = model.Description;
			row.Cells["category"].Value = model.Category;
		}
	}
}

