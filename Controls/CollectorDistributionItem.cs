using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistributionItem : UserControl, IDataLink<WasteType>
	{
		private CollectorDistribution m_distribution;

		private DMYOData<WasteType> m_source;

		private DMYOData<WasteUnit> m_unit;

		private DMYOData<Waste>[] m_wastes;

		public CollectorDistributionItem(CollectorDistribution distribution) : this(distribution, null)
		{

		}

		public CollectorDistributionItem(CollectorDistribution distribution, DMYOData<WasteType> source)
		{
			InitializeComponent();

			m_distribution = distribution;
			Bind(source);
		}


		public CollectorDistribution Distribution
		{
			get
			{
				return m_distribution;
			}
		}

		public DMYOData<WasteType> Source
		{
			get
			{
				return m_source;
			}
		}


		public void Bind(DMYOData<WasteType> source)
		{
			m_source = source;

			if (m_source == null)
			{
				m_unit = null;
				m_wastes = Array.Empty<DMYOData<Waste>>();
			}
			else
			{
				m_unit = TableManager.WasteUnit.Read(m_source.Model.Unit);
				m_wastes = TableManager.Waste.OfCollectionType(m_distribution.Source.Id, m_source.Id).ToArray();
			}

			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			if(m_source == null)
			{
				typeLabel.Text = "BLANK";
				dispatchBox.Enabled = false;
				quantityLabel.Text = "0";
				abbrLabel.Text = "pcs";
			}
			else
			{
				typeLabel.Text = m_source.Model.Name;
				dispatchBox.Enabled = true;
				quantityLabel.Text = m_wastes.Sum(w => w.Model.Quantity).ToString();
				abbrLabel.Text = m_unit.Model.Abbr;
			}
		}
	}
}
