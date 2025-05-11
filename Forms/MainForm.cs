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
			dmyoTab.SelectedIndex = (int)page;

			switch (page)
			{
				case DMYOPage.WasteTypes:
					{
						if (grid_wasteTypes.Source == null)
						{
							grid_wasteTypes.Bind(new WasteTypeGrid());
						}
					}
					break;
				case DMYOPage.WasteCategories:
					{
						if (grid_wasteCategories.Source == null)
						{
							grid_wasteCategories.Bind(new WasteCategoryGrid());
						}
					}
					break;
			}
		}

		private void button_wasteTypes_Click(object sender, EventArgs e)
		{
			LoadPage(DMYOPage.WasteTypes);
		}

		private void button_wasteCategories_Click(object sender, EventArgs e)
		{
			LoadPage(DMYOPage.WasteCategories);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}

	public enum DMYOPage
	{
		WasteTypes = 0,
		WasteCategories = 1
	}
}