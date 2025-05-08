using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
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
			Bind(data);
		}

		public DataObject<WasteType> Data => m_data;

		public void Bind(DataObject<WasteType> data)
		{
			m_data = data;
			Visible = true;

			if (data == null)
			{
				wt_description.ReadOnly = false;
				wt_name.Visible = false;
				wt_nameBox.Visible = true;

				wt_delete.Visible = false;
				wt_create.Visible = true;

				wt_nameBox.Text = "New type";
				wt_description.Text = "no description entered";
			}
			else
			{

				if (data.Model == null)
				{
					Visible = false;
				}
				else
				{
					wt_name.Text = data.Model.Name;

					wt_name.Visible = true;
					wt_nameBox.Visible = false;

					wt_delete.Visible = true;
					wt_create.Visible = false;

					wt_description.ReadOnly = true;
					wt_description.Text = data.Model.Description.ToString();
				}
			}
		}

		private void wt_delete_Click(object sender, EventArgs e)
		{
			if(Data != null)
				RepoManager.WasteType.Delete(Data.Id);
		}

		private void wt_nameBox_Enter(object sender, EventArgs e)
		{
			if(Data == null)
			{
				wt_nameBox.Text = "";
			}
		}

		private void wt_nameBox_Leave(object sender, EventArgs e)
		{
			if (Data == null)
			{
				if(wt_nameBox.Text == "")
				{
					wt_nameBox.Text = "New type";
				}
			}
		}

		private void wt_description_Enter(object sender, EventArgs e)
		{
			if (Data == null)
			{
				wt_description.Text = "";
			}
		}

		private void wt_description_Leave(object sender, EventArgs e)
		{
			if (Data == null)
			{
				if (wt_description.Text == "")
				{
					wt_description.Text = "no description entered";
				}
			}
		}

		private void WasteTypeControl_Leave(object sender, EventArgs e)
		{
			if (Data == null)
			{
				wt_nameBox.Text = "New type";
				wt_description.Text = "no description entered";
			}
		}

		private void wt_create_Click(object sender, EventArgs e)
		{
			if (Data == null)
			{
				RepoManager.WasteType.Create(new WasteType(wt_nameBox.Text, wt_description.Text));
			}
		}
	}
}