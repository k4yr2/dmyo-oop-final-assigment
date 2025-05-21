using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistributionItem : UserControl, IDataLink<WasteDispatch>
	{
		private CollectorDistribution m_distribution;

		private int m_index;

		private DMYOData<WasteDispatch> m_source;

		private DMYOData<WasteType> m_type;

		private DMYOData<WasteUnit> m_unit;

		private decimal m_dispatch = 0;

		private double m_percent = 0;

		private decimal m_capacity = 0;

		public CollectorDistributionItem(CollectorDistribution distribution, int index) : this(distribution, index, null)
		{

		}

		public CollectorDistributionItem(CollectorDistribution distribution, int index, DMYOData<WasteDispatch> source)
		{
			InitializeComponent();

			m_distribution = distribution;
			m_distribution.Form.FormClosed += (s, e) => {
				if(m_source != null)
				{
					m_source.Model.Quantity = m_dispatch;
					TableManager.WasteDispatch.Update(m_source.Id, m_source.Model);
				}
			};

			m_index = index;
			Bind(source);
		}


		public CollectorDistribution Distribution
		{
			get
			{
				return m_distribution;
			}
		}

		public DMYOData<WasteDispatch> Source
		{
			get
			{
				return m_source;
			}
		}


		public void Bind(DMYOData<WasteDispatch> source)
		{
			m_source = source;

			if (m_source == null)
			{
				m_type = null;
				m_unit = null;
				m_capacity = 0;
				m_dispatch = 0;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);
				m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
				m_capacity = TableManager.Waste.CapacityOfType(m_distribution.Source.Id, m_type.Id, m_distribution.Distributions[m_index].Id);
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
				quantityBox.Enabled = false;
				quantityBox.Text = "0";
				percentLabel.Text = $"%{m_percent:0.00}";
				capacityLabel.Text = "0";
				abbrLabel.Text = "pcs";
			}
			else
			{
				typeLabel.Text = m_type.Model.Name;

				capacityLabel.Text = m_capacity.ToString();
				abbrLabel.Text = m_unit.Model.Abbr;

				switch (m_distribution.Source.Model.Status)
				{
					case WasteStatus.Active:
						quantityBox.Visible = true;
                        quantityBox.Text = m_source.Model.Quantity.ToString();
						quantityLabel.Visible = false;
                        break;
                    default:
                    case WasteStatus.Processing:
						quantityBox.Visible = false;
						quantityLabel.Visible = true;
                        quantityLabel.Text = m_source.Model.Quantity.ToString();
                        break;
				}
			}
        }

		private void dispatchBox_TextChanged(object sender, EventArgs e)
		{
			if(!decimal.TryParse(quantityBox.Text, out decimal dispatch))
			{
				quantityBox.Text = dispatch.ToString("0");
				quantityBox.SelectionStart = 0;
				quantityBox.SelectionLength = 1;
			}

			if(dispatch >= m_capacity)
			{
				dispatch = m_capacity;
				quantityBox.Text = m_capacity.ToString("0");
				quantityBox.SelectionStart = quantityBox.Text.Length;
				quantityBox.SelectionLength = 0;
			}

			m_dispatch = dispatch;
			m_percent = m_capacity == 0 ? 0 : (double)(m_dispatch / m_capacity) * 100;	
			percentLabel.Text = $"%{m_percent:0.00}";
		}
	}
}
