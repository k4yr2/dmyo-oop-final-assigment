using dmyo_oop_final_assigment.Forms;
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
	}
}
