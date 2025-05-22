using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class RecyclerStockItem : UserControl, IDataLink<WasteReceipt>
	{
		private RecyclerStock m_host;

        private DMYOData<WasteStock> m_stock;

		private DMYOData<WasteReceipt> m_source;

		private DMYOData<WasteDispatch> m_dispatch;

        private DMYOData<WasteType> m_type;

		private DMYOData<WasteUnit> m_unit;

		private double m_percent = 0;

		private decimal m_capacity = 0;

		public RecyclerStockItem(RecyclerStock host, DMYOData<WasteStock> stock) : this(host, stock, null)
		{

		}

		public RecyclerStockItem(RecyclerStock host, DMYOData<WasteStock> stock, DMYOData<WasteReceipt> source)
		{
			InitializeComponent();

			m_host = host;
            m_stock = stock;
			Bind(source);
		}


		public RecyclerStock Host
		{
			get
			{
				return m_host;
			}
		}

		public DMYOData<WasteStock> Stock
		{
			get
			{
				return m_stock;
			}
        }

        public DMYOData<WasteReceipt> Source
		{
			get
			{
				return m_source;
			}
		}

		public DMYOData<WasteDispatch> Dispatch
		{
			get
			{
				return m_dispatch;
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


        public void Bind(DMYOData<WasteReceipt> source)
		{
			m_source = source;

			if (m_source == null)
			{
				m_dispatch = null;
                m_type = null;
				m_unit = null;
				m_capacity = 0;
			}
			else
			{
				m_dispatch = TableManager.WasteDispatch.Read(m_source.Model.Dispatch);
                m_type = TableManager.WasteType.Read(m_dispatch.Model.Type);
				m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);

                Capacity = m_dispatch.Model.Quantity;
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
			}
        }

		private void dispatchBox_TextChanged(object sender, EventArgs e)
		{
			if(!decimal.TryParse(quantityBox.Text, out decimal quantity))
			{
				quantityBox.Text = quantity.ToString("0");

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
