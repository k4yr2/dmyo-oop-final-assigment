using dmyo_oop_final_assigment.Forms;
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
	public partial class CollectorWaste : UserControl, IDataLink<Waste>
	{
		private CollectorWasteCollection m_collection = null;

		private DMYOData<Waste> m_source = null;

		private DMYOData<WasteType> m_type = null;


		public CollectorWaste(CollectorWasteCollection container) : this(container, null)
		{

		}

		public CollectorWaste(CollectorWasteCollection collection, DMYOData<Waste> source)
		{
			InitializeComponent();
			m_collection = collection;

			Bind(source);
		}

		//

		public CollectorWasteCollection Collection
		{
			get
			{
				return m_collection;
			}
		}

		public DMYOData<Waste> Source
		{
			get
			{
				return m_source;
			}
		}

		public DMYOData<WasteType> Type
		{
			get
			{
				return m_type;
			}
		}

		//

		public void Bind(DMYOData<Waste> data)
		{
			m_source = data;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			if (m_source== null)
			{
				deleteButton.Enabled = false;
				typeLabel.Text = "Blank Type";
				quantityLabel.Text = "0";
				abbrLabel.Text = "pcs";
				updateButton.Enabled = false;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);

				deleteButton.Enabled = true;
				typeLabel.Text = m_type?.Model.Name ?? "Blank Type";
				quantityLabel.Text = (m_source?.Model.Quantity ?? 0).ToString();
				abbrLabel.Text = "pcs";
				updateButton.Enabled = true;
			}
		}

		//

		private void WasteControl_Load(object sender, EventArgs e)
		{

		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if(m_source == null)
			{
				MessageBox.Show("No data to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if(TableManager.Waste.Delete(m_source.Id))
				{
					m_collection.Refresh();
				}
				else
				{
					MessageBox.Show("Failed to delete data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			if (m_source == null)
			{
				MessageBox.Show("No data to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				new CollectorWasteForm(this).ShowDialog();
			}
		}
	}
}
