using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Pages;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorDetailsForm : Form
	{
		private CollectorCollection m_collection;

		private CollectorWaste m_waste;

		public CollectorDetailsForm(CollectorCollection collection) : this(collection, null)
		{

		}

		public CollectorDetailsForm(CollectorWaste waste) : this(waste.Collection, waste)
		{

		}

		private CollectorDetailsForm(CollectorCollection collection, CollectorWaste waste)
		{
			InitializeComponent();

			m_collection = collection;
			m_waste = waste;

			Refresh();
		}


		public CollectorCollection Collection
		{
			get
			{
				return m_collection;
			}
		}

		public CollectorWaste Waste
		{
			get
			{
				return m_waste;
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";

			if (m_waste == null)
			{
				applyButton.Text = "Create";
			}
			else
			{
				applyButton.Text = "Update";
			}
		}
	}
}
