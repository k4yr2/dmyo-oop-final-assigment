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
		private CollectorDistribution m_host;

        private DMYOData<WasteDistribution> m_distribution;

		private DMYOData<WasteDispatch> m_source;

		private DMYOData<WasteType> m_type;

		private DMYOData<WasteUnit> m_unit;

		private decimal m_dispatch = 0;

		private double m_percent = 0;

		private decimal m_capacity = 0;

		public CollectorDistributionItem(CollectorDistribution host, DMYOData<WasteDistribution> distribution) : this(host, distribution, null)
		{

		}

		public CollectorDistributionItem(CollectorDistribution host, DMYOData<WasteDistribution> distribution, DMYOData<WasteDispatch> source)
		{
			InitializeComponent();

			m_host = host;
			m_host.Form.FormClosed += (s, e) => {
				if(m_source != null)
				{
					m_source.Model.Quantity = m_dispatch;
					TableManager.WasteDispatch.Update(m_source.Id, m_source.Model);
				}
			};

            m_distribution = distribution;
			Bind(source);
		}


		public CollectorDistribution Distribution
		{
			get
			{
				return m_host;
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
				m_capacity = TableManager.Waste.CapacityOfType(m_host.Source.Id, m_type.Id, m_distribution.Id);
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

				switch (m_distribution.Model.Status)
				{
					case WasteStatus.Active:
						quantityPanel.Visible = true;
                        quantityBox.Text = m_source.Model.Quantity.ToString();
						quantityLabel.Visible = false;
                        break;
                    default:
                    case WasteStatus.Processing:
                        quantityPanel.Visible = false;
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
