using dmyo_oop_final_assigment.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Grids
{
	public sealed class WasteUnitGrid : DMYOGrid<WasteUnit>
	{
		public override void Columns(DataTable table)
		{
			table.Columns.Add("name", typeof(string));
			table.Columns.Add("abbreviation", typeof(string));
		}

		public override WasteUnit ToModel(DataGridViewRow row)
		{
			return new WasteUnit()
			{
				Name = row.Cells["name"].Value?.ToString(),
				Abbreviation = row.Cells["abbreviation"].Value?.ToString()
			};
		}
	}
}
