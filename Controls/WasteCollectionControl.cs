using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class WasteCollectionControl : UserControl
	{
		private WasteCollection m_collection = null;

		public WasteCollectionControl(WasteCollection collection)
		{
			InitializeComponent();
			m_collection = collection;
		}


		public WasteCollection Collection
		{
			get
			{
				return m_collection;
			}
			set
			{
				m_collection = value;
				Refresh();
			}
		}
	}
}
