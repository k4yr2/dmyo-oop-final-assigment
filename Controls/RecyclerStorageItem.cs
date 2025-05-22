using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class RecyclerStorageItem : UserControl, IDataLink<WasteHeap>
	{
		private RecyclerStorage m_host;

		private DMYOData<WasteHeap> m_source;

		private DMYOData<WasteType> m_type;

		private DMYOData<WasteUnit> m_unit;

		private DMYOData<WasteReceipt> m_receipt;


		public RecyclerStorageItem(RecyclerStorage host, DMYOData<WasteHeap> source)
		{
			InitializeComponent();

			m_host = host;
			Bind(source);
		}


		public RecyclerStorage Host
		{
			get
			{
				return m_host;
			}
		}

        public DMYOData<WasteHeap> Source
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
            }
		}


        public void Bind(DMYOData<WasteHeap> source)
		{
			m_source = source;

			if (m_source == null)
			{
				m_type = null;
				m_unit = null;
				m_receipt = null;
			}
			else
			{
				m_type = TableManager.WasteType.Read(m_source.Model.Type);
				m_receipt = TableManager.WasteReceipt.GetOf(m_source.Id);
                m_unit = TableManager.WasteUnit.Read(m_type.Model.Unit);
                Quantity = m_source.Model.Quantity;
			}

			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			if(m_source == null)
			{
				typeLabel.Text = "BLANK";
				quantityLabel.Text = "0";
				abbrLabel.Text = "pcs";
			}
			else
			{
				typeLabel.Text = m_type.Model.Name;

				quantityLabel.Text = Quantity.ToString();
				abbrLabel.Text = m_unit.Model.Abbr;
                typeLabel.ForeColor = System.Drawing.Color.Black;
			}
        }
	}
}
