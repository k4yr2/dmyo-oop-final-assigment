using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistributionItem : UserControl, IDataLink<WasteType>
	{
		private CollectorDistribution m_distribution;

		private DMYOData<WasteType> m_source;

		private DMYOData<WasteCategory> m_category;

		private DMYOData<WasteUnit> m_unit;

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
				m_category = null;
				m_unit = null;
			}
			else
			{
				m_category = TableManager.WasteCategory.Read(m_source.Model.Category);
				m_unit = TableManager.WasteUnit.Read(m_source.Model.Unit);
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
				quantityLabel.Text = "0";
				abbrLabel.Text = m_unit.Model.Abbr;
			}
		}
	}
}
