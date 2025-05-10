using dmyo_oop_final_assigment.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button_wastes_Click(object sender, EventArgs e)
		{
			dmyoGrid.Bind(new WasteUnitGrid());
		}

		private void button_distribution_Click(object sender, EventArgs e)
		{
			dmyoGrid.Bind(new WasteCategoryGrid());
		}
	}
}