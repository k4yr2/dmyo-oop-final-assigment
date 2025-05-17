using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistribution : UserControl, IDataLink<WasteCollection>
	{
		private CollectorForm m_form;

		private DMYOData<WasteCollection> m_source;

		private DMYOData<WasteDistribution>[] m_distributions;

		public CollectorDistribution(CollectorForm form, DMYOData<WasteCollection> source)
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

			if (m_source == null)
			{
				m_distributions = Array.Empty<DMYOData<WasteDistribution>>();
			}
			else
			{
				m_distributions = TableManager.WasteDistribution.GetDistributions(m_source.Id).ToArray();
			}
		}
	}
}
