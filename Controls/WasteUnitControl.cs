using dmyo_oop_final_assigment.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class WasteUnitControl : UserControl
	{
		public WasteUnitControl()
		{
			InitializeComponent();
		}

		private void WasteUnitControl_Load(object sender, EventArgs e)
		{
			unitGrid.AllowUserToAddRows = true;
			unitGrid.AllowUserToDeleteRows = true;
			unitGrid.ReadOnly = false;

			DataTable table = new DataTable();
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("abbreviation", typeof(string));

			DataManager.FillTable(table, RepoManager.WasteUnit.SelectQuery);

			unitGrid.DataSource = table;
		}

		private void UpdateCellValue(int rowIndex)
		{
			int id = Convert.ToInt32(unitGrid.Rows[rowIndex].Cells["Id"].Value);

			string name = unitGrid.Rows[rowIndex].Cells["name"].Value?.ToString();
			string abbreviation = unitGrid.Rows[rowIndex].Cells["abbreviation"].Value?.ToString();

			RepoManager.WasteUnit.Update(id, new Models.WasteUnit()
			{
				Name = name,
				Abbreviation = abbreviation
			});
		}

		private void unitGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0)
			{
				UpdateCellValue(rowIndex);
			}
		}

		private void unitGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			int id = Convert.ToInt32(unitGrid.Rows[e.Row.Index].Cells["Id"].Value);

			RepoManager.WasteUnit.Delete(id);
		}
	}
}
