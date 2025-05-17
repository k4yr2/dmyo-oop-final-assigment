using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Pages
{
	public partial class CollectorCollectionPage : UserControl, IDataLink<WasteCollection>
	{
		private CollectorForm m_form;

		private DMYOData<WasteCollection> m_source;

		public CollectorCollectionPage(CollectorForm form, DMYOData<WasteCollection> source)
		{
			InitializeComponent();

			m_form = form;
			Bind(source);
		}


		public CollectorForm Form
		{
			get
			{
				return m_form;
			}
		}

		public DMYOData<WasteCollection> Source
		{
			get
			{
				return m_source;
			}
		}


		public void Bind(DMYOData<WasteCollection> source)
		{
			m_source = source;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			contentPanel.Controls.Clear();

			foreach (var waste in TableManager.WasteCollection.GetWastes(Source.Id))
			{
				contentPanel.Controls.Add(new CollectorWaste(waste));
			}
		}

		private void contentPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			e.Control.Width = contentPanel.Width;
		}

		private void contentPanel_Resize(object sender, System.EventArgs e)
		{
			foreach (var control in contentPanel.Controls.OfType<Control>())
			{
				control.Width = contentPanel.Width;
			}
		}
	}
}