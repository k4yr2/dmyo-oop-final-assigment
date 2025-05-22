using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class RecyclerRecyclingItem : UserControl, IDataLink<WasteProduct>
	{
		private RecyclerRecycling m_host;

        private DMYOData<WasteRecycling> m_recycling;

		private DMYOData<WasteProduct> m_source;

        private DMYOData<WasteType> m_type;

        private DMYOData<WasteHeap> m_heap;

        private DMYOData<WasteUnit> m_unit;

		private double m_percent = 0;

		private decimal m_capacity = 0;

		public RecyclerRecyclingItem(RecyclerRecycling host, DMYOData<WasteRecycling> recycling) : this(host, recycling, null)
		{

		}

		public RecyclerRecyclingItem(RecyclerRecycling host, DMYOData<WasteRecycling> recycling, DMYOData<WasteProduct> source)
		{
			InitializeComponent();

			m_host = host;
            m_recycling = recycling;
			Bind(source);
		}


		public RecyclerRecycling Host
		{
			get
			{
				return m_host;
			}
		}

		public DMYOData<WasteRecycling> Recycling
		{
			get
			{
				return m_recycling;
			}
        }

        public DMYOData<WasteProduct> Source
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

		public DMYOData<WasteHeap> Heap
		{
			get
			{
				return m_heap;
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


        public void Bind(DMYOData<WasteProduct> source)
		{
			m_source = source;

			if (m_source == null)
			{
                m_type = null;
                m_heap = null;
                m_unit = null;
				m_capacity = 0;
			}
			else
			{
                m_type = TableManager.WasteType.Read(m_source.Model.Type);
                m_heap = TableManager.WasteHeap.Fetch(m_recycling.Model.Factory, m_type.Id);
                m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
                Capacity = m_heap.Model.Quantity;
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
