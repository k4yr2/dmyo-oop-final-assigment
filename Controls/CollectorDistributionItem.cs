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

		private decimal m_quantity = 0;

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
					m_source.Model.Quantity = m_quantity;
					TableManager.WasteDispatch.Update(m_source.Id, m_source.Model);
				}
			};

            m_distribution = distribution;
			Bind(source);
		}


		public CollectorDistribution Host
		{
			get
			{
				return m_host;
			}
		}

		public DMYOData<WasteDistribution> Distribution
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

		public DMYOData<WasteType> Type
		{
			get
			{
				return m_type;
			}
        }

		public DMYOData<WasteUnit> Unit
		{
			get
			{
				return m_unit;
			}
		}

		public decimal Quantity
		{
			get
			{
				return m_quantity;
			}
			set
			{
				m_quantity = value;
				quantityBox.Text = m_quantity.ToString("0.00");
                Percent = m_capacity == 0 ? 0 : (double)(m_quantity / m_capacity) * 100;
            }
		}

		public double Percent
		{
			get
			{
				return m_percent;
			}
			set
			{
				m_percent = value;
				percentLabel.Text = $"%{m_percent:0.00}";
            }
		}

		public decimal Capacity
		{
			get
			{
				return m_capacity;
            }
			set
			{
				m_capacity = value;
                capacityLabel.Text = m_capacity.ToString("0.00");
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
				m_quantity = 0;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);
				m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
                Capacity = TableManager.Waste.CapacityOfType(m_host.Source.Id, m_type.Id, m_distribution.Id);
                Quantity = Math.Min(m_source.Model.Quantity, m_capacity);
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
			if(!decimal.TryParse(quantityBox.Text, out decimal quantity))
			{
				quantityBox.Text = quantity.ToString("0");
				quantityBox.SelectionStart = 0;
				quantityBox.SelectionLength = 1;

				return;
			}

			if(quantity >= m_capacity)
			{
                quantity = m_capacity;
			}

			Quantity = quantity;
		}
	}
}
