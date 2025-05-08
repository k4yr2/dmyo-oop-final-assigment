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
			
			wt_control1.Bind(data[0]);
			wt_control2.Bind(data[1]);
			wt_control3.Bind(data[2]);
			wt_control4.Bind(data[3]);
			wt_control5.Bind(data[4]);
			wt_controlX.Bind(data[5]);
		}
	}
}
