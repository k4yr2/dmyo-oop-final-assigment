using System;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Grids;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void LoadPage(DMYOPage page)
		{
			switch (page)
			{
				case DMYOPage.WasteTypes:
					{
						dmyoTab.SelectedIndex = 0;
						if (grid_wasteTypes.Source == null)
						{
							grid_wasteTypes.Bind(new WasteTypeGrid());
						}
					}
					break;
				case DMYOPage.WasteCategories:
					break;
			}
		}

		private void button_wasteTypes_Click(object sender, EventArgs e)
		{
			LoadPage(DMYOPage.WasteTypes);
		}
	}

	public enum DMYOPage
	{
		WasteTypes,
		WasteCategories
	}
}