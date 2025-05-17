using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorWaste : UserControl, IDataLink<Waste>
	{
		private CollectorCollection m_collection;

		private DMYOData<Waste> m_source;

		private DMYOData<WasteType> m_type;

		private DMYOData<WasteCategory> m_category;

		private DMYOData<WasteUnit> m_unit;

		public CollectorWaste(CollectorCollection collection) : this(collection, null)
		{

		}

		public CollectorWaste(CollectorCollection collection, DMYOData<Waste> source)
		{
			InitializeComponent();

			m_collection = collection;
			Bind(source);
		}


		public CollectorCollection Collection
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


		public void Bind(DMYOData<Waste> source)
		{
			m_source = source;
			
			if(m_source == null)
			{
				m_type = null;
				m_category = null;
				m_unit = null;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);
				m_category = TableManager.WasteCategory.Read(m_type.Model.Category);
				m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
			}

			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();
			if(m_source == null)
			{
				deleteButton.Enabled = false;
				detailButton.Enabled = false;

				typeLabel.Text = "Blank Type";
				quantityLabel.Text = "0";
				abbrLabel.Text = "pcs";
			}
			else
			{
				deleteButton.Enabled = true;
				detailButton.Enabled = true;

				typeLabel.Text = m_type.Model.Name;
				quantityLabel.Text = m_source.Model.Quantity.ToString();
				abbrLabel.Text = m_unit.Model.Abbr;
			}
		}

		private void detailButton_Click(object sender, System.EventArgs e)
		{
			var form = new CollectorDetailsForm(this);
			form.StartPosition = FormStartPosition.CenterScreen;
			form.ShowDialog();
		}

		private void deleteButton_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Are you sure you want to delete this waste?", 
				"Delete Waste", 
				MessageBoxButtons.YesNo, 
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				int index = Collection.Panel.Controls.IndexOf(this);
				if (index >= 0)
				{
					if (TableManager.Waste.Delete(Source.Id))
					{
						Collection.Panel.Controls.RemoveAt(index);
					}
					else
					{
						MessageBox.Show(Collection, "Failed to delete waste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
