using System;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			sidebarPanel.Controls.Clear();

			var wastes = new DMYONavSub()
			{
				Title = "Wastes",
				EnableSub = false,
				Dock = DockStyle.Top
			};
			sidebarPanel.Controls.Add(wastes);

			var wastes_types = new DMYONavSub()
			{
				Title = "Types",
				EnableSub = false,
				Dock = DockStyle.Top
			};
			wastes.SubPanel.Controls.Add(wastes_types);

			var wastes_categories = new DMYONavSub()
			{
				Title = "Categories",
				EnableSub = false,
				Dock = DockStyle.Top
			};
			wastes.SubPanel.Controls.Add(wastes_categories);

			//

			var distrubition = new DMYONavSub()
			{
				Title = "Disdisdis",
				EnableSub = false,
				Dock = DockStyle.Top
			};
			sidebarPanel.Controls.Add(distrubition);
		}
	}
}