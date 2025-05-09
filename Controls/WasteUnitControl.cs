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

			DataManager.FillTable(table, $"SELECT name, abbreviation FROM {RepoManager.WasteUnit.Name}");

			unitGrid.DataSource = table;
		}
	}
}
