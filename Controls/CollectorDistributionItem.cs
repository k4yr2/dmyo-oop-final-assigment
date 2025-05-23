﻿using dmyo_oop_final_assigment.Managers;
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

		private DMYOData<WasteReceipt> m_receipt;

		private double m_percent = 0;

		private decimal m_capacity = 0;

		public CollectorDistributionItem(CollectorDistribution host, DMYOData<WasteDistribution> distribution) : this(host, distribution, null)
		{

		}

		public CollectorDistributionItem(CollectorDistribution host, DMYOData<WasteDistribution> distribution, DMYOData<WasteDispatch> source)
		{
			InitializeComponent();

			m_host = host;
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

		public DMYOData<WasteReceipt> Receipt
		{
			get
			{
				return m_receipt;
			}
			set
			{
				m_receipt = value;
			}
        }

        public decimal Quantity
		{
			get
			{
				return Source.Model.Quantity;
			}
			set
			{
                Source.Model.Quantity = value;
				quantityBox.Text = Source.Model.Quantity.ToString("0.00");
                Percent = m_capacity == 0 ? 0 : (double)(Source.Model.Quantity / m_capacity) * 100;
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
				m_receipt = null;
				m_capacity = 0;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);
				m_receipt = TableManager.WasteReceipt.GetOf(m_source.Id);
                m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
                Capacity = TableManager.Waste.CapacityOf(m_host.Source.Id, m_type.Id, m_distribution.Id);
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
                typeLabel.ForeColor = System.Drawing.Color.Black;

                switch (m_distribution.Model.Status)
				{
					case WasteStatus.Active:
						quantityPanel.Visible = true;
                        quantityBox.Text = m_source.Model.Quantity.ToString();
						quantityLabel.Visible = false;
						receiptLabel.Visible = false;
                        break;
					case WasteStatus.Cancelled:
                        quantityPanel.Visible = false;
                        quantityLabel.Visible = true;
                        quantityLabel.Text = m_source.Model.Quantity.ToString();
						typeLabel.ForeColor = System.Drawing.Color.Red;
                        receiptLabel.Visible = false;
                        break;
					case WasteStatus.Completed:
						quantityPanel.Visible = false;
						quantityLabel.Visible = true;
						quantityLabel.Text = m_source.Model.Quantity.ToString();
						typeLabel.ForeColor = System.Drawing.Color.Green;
						receiptLabel.Visible = true;
						receiptLabel.Text = m_receipt?.Model.Quantity.ToString() ?? "0";
                        receiptLabel.ForeColor = System.Drawing.Color.Green;
                        break;
                    default:
                    case WasteStatus.Processing:
                        quantityPanel.Visible = false;
						quantityLabel.Visible = true;
                        quantityLabel.Text = m_source.Model.Quantity.ToString();
                        receiptLabel.Visible = false;
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
