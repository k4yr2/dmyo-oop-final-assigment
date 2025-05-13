using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class WasteCollectionControl : UserControl, IDataLink<WasteCollection> 
	{
		private DMYOData<WasteCollection> m_source = null;

		public WasteCollectionControl(DMYOData<WasteCollection> source)
		{
			InitializeComponent();
			m_source = source;
		}


		public DMYOData<WasteCollection> Data
		{
			get
			{
				return m_source;
			}
		}

		
		public void Bind(DMYOData<WasteCollection> data)
		{
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			panel.Controls.Clear();
			foreach (var waste in TableManager.Waste.Select($"where collection = {m_source.Id}"))
			{
				var control = new WasteControl(this, waste);
				panel.Controls.Add(control);
			}
		}
	}
}