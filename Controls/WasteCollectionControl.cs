using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class WasteCollectionControl : UserControl, IDataLink<WasteCollection> 
	{
		private DMYOData<WasteCollection> m_source = null;

		public WasteCollectionControl() : this(null)
		{

		}

		public WasteCollectionControl(DMYOData<WasteCollection> source)
		{
			InitializeComponent();
			Bind(source);
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
			m_source = data;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			panel.Controls.Clear();

			if(m_source == null)
			{
				
			}
			else
			{
				foreach (var waste in TableManager.Waste.Select($"where collection = {m_source.Id}"))
				{
					var control = new WasteControl(this, waste)
					{
						Width = Width - 25
					};
					panel.Controls.Add(control);
				}
			}
		}

		private void panel_Resize(object sender, System.EventArgs e)
		{
			foreach (var item in panel.Controls.OfType<WasteControl>())
			{
				item.Width = Width - 25;
			}
		}
	}
}