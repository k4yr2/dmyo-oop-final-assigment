using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class WasteTypesForm : Form
	{
		public WasteTypesForm()
		{
			InitializeComponent();
			RefreshData();
		}

		private void WasteTypesForm_Load(object sender, EventArgs e)
		{
			RepoManager.WasteType.OnChanged += RefreshData;
			pagebarControl1.OnSet += RefreshData;

		}

		private void RefreshData()
		{
			pagebarControl1.Count = (int)Math.Ceiling(RepoManager.WasteType.Count() / 5d);

			var data = RepoManager.WasteType.ReadPage(pagebarControl1.Current, 5)
				.Concat(Enumerable.Repeat<DataObject<WasteType>>(null, 5))
				.Take(5).ToArray();
			
			wt_control1.Update(data[0]);
			wt_control2.Update(data[1]);
			wt_control3.Update(data[2]);
			wt_control4.Update(data[3]);
			wt_control5.Update(data[4]);
		}
	}
}
