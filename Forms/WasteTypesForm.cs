using System;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class WasteTypesForm : Form
	{
		public WasteTypesForm()
		{
			InitializeComponent();
		}

		private void WasteTypesForm_Load(object sender, EventArgs e)
		{
			wt_panel.Controls.Clear();
			int top = 10;
			for (int i = 0; i < 3; i++)
			{
				Control control = new WasteTypeControl();
				wt_panel.Controls.Add(control);

				control.Left = 10; control.Top = top;
				control.Width = wt_panel.Width - 20;

				control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

				top += control.Height + 10;
			}
		}
	}
}
