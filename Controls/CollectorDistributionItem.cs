using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistributionItem : UserControl, IDataLink<WasteType>
	{
		private CollectorDistribution m_distribution;

		private DMYOData<WasteType> m_source;

		private DMYOData<WasteUnit> m_unit;

		private DMYOData<Waste>[] m_wastes;

		private decimal m_dispatch = 0;

		private double m_percent = 0;

		private decimal m_capacity = 0;

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
				m_capacity = 0;
				m_dispatch = 0;
			}
			else
			{
				m_unit = TableManager.WasteUnit.Read(m_source.Model.Unit);
				m_wastes = TableManager.Waste.OfCollectionType(m_distribution.Source.Id, m_source.Id).ToArray();
				m_capacity = m_wastes.Sum(w => w.Model.Quantity);
				m_dispatch = Math.Min(m_dispatch, m_capacity);
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
				percentLabel.Text = $"%{m_percent:0.00}";
				capacityLabel.Text = "0";
				abbrLabel.Text = "pcs";
			}
			else
			{
				typeLabel.Text = m_source.Model.Name;
				dispatchBox.Enabled = true;
				capacityLabel.Text = m_capacity.ToString();
				abbrLabel.Text = m_unit.Model.Abbr;
			}
		}

		private void dispatchBox_TextChanged(object sender, EventArgs e)
		{
			if(!decimal.TryParse(dispatchBox.Text, out decimal dispatch))
			{
				dispatchBox.Text = dispatch.ToString("0");
				dispatchBox.SelectionStart = 0;
				dispatchBox.SelectionLength = 1;
			}

			if(dispatch >= m_capacity)
			{
				dispatch = m_capacity;
				dispatchBox.Text = m_capacity.ToString("0");
				dispatchBox.SelectionStart = dispatchBox.Text.Length;
				dispatchBox.SelectionLength = 0;
			}

			m_dispatch = dispatch;
			m_percent = m_capacity == 0 ? 0 : (double)(m_dispatch / m_capacity) * 100;	
			percentLabel.Text = $"%{m_percent:0.00}";
		}
	}
}
