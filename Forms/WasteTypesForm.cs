using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;

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
			RefreshData();
			RepoManager.WasteType.OnChanged += RefreshData;
		}

		private void RefreshData()
		{
			wt_panel.Controls.Clear();

			wt_panel.SuspendLayout();
			int top = 10;

			List<WasteTypeControl> list = new List<WasteTypeControl>();

			foreach (var wt in RepoManager.WasteType.ReadAll())
			{
				WasteTypeControl control = new WasteTypeControl(wt);
				list.Add(control);

				control.Left = 10; control.Top = top;
				control.Width = wt_panel.Width - 20;

				control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

				top += control.Height + 10;
			}

			wt_panel.Controls.AddRange(list.ToArray());
			wt_panel.ResumeLayout();

		}
	}
}
