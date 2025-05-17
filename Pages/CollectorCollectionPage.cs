using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Pages
{
	public partial class CollectorCollectionPage : UserControl
	{
		private CollectorForm m_form;

		private DMYOData<WasteCollection> m_collection;

		public CollectorCollectionPage(CollectorForm form, DMYOData<WasteCollection> collection)
		{
			InitializeComponent();

			m_form = form;
			m_collection = collection;
			Refresh();
		}


		public CollectorForm Form
		{
			get
			{
				return m_form;
			}
		}

		public DMYOData<WasteCollection> Collection
		{
			get
			{
				return m_collection;
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			contentPanel.Controls.Clear();

			foreach (var waste in TableManager.WasteCollection.GetWastes(Collection.Id))
			{
				contentPanel.Controls.Add(new CollectorWaste(waste));
			}
		}
	}
}
