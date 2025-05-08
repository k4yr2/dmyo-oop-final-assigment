using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class WasteTypeControl : UserControl, IDataRef<WasteType>
	{
		private DataObject<WasteType> m_data;

		public WasteTypeControl() : this(null)
		{

		}	

		public WasteTypeControl(DataObject<WasteType> data)
		{
			InitializeComponent();
			Update(data);
		}

		public DataObject<WasteType> Data => m_data;

		public void Update(DataObject<WasteType> data)
		{
			m_data = data;

			if(data == null)
			{
				wt_name.Text = "BLANK";
				wt_description.Text = "no description entered";
			}
			else
			{
				wt_name.Text = data.Model.Name;
				wt_description.Text = data.Model.Description.ToString();
			}
		}

		private void wt_delete_Click(object sender, EventArgs e)
		{
			if(Data != null)
				RepoManager.WasteType.Delete(Data.Id);
		}
	}
}
