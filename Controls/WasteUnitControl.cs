using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

			unitGrid.Columns[0].HeaderText = "Name";
			unitGrid.Columns[1].HeaderText = "Abbreviation";
		}
	}
}
