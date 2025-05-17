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
			m_source = source;
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
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();
		}
	}
}
