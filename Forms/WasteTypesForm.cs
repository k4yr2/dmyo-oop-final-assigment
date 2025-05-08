using System;
using System.Linq;
using System.Windows.Forms;
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
			RefreshData();
		}

		private void RefreshData()
		{
			int count = (int)Math.Ceiling(RepoManager.WasteType.Count() / 5d);

			if(count > 0)
				pagebarControl1.Count = count;

			var data = RepoManager.WasteType.ReadPage(pagebarControl1.Current, 5)
				.Concat(new DataObject<WasteType>[] { null })
				.Concat(Enumerable.Repeat(DataObject<WasteType>.Blank, 5))
				.Take(6).ToArray();
			
			wt_control1.Update(data[0]);
			wt_control2.Update(data[1]);
			wt_control3.Update(data[2]);
			wt_control4.Update(data[3]);
			wt_control5.Update(data[4]);
			wt_controlX.Update(data[5]);
		}
	}
}
