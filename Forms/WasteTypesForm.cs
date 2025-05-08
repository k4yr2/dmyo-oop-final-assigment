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

		}
	}
}
