using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteReceipt
	{
		private int m_dispatch;

		private int m_stock;

		private decimal m_quantity;

		private DateTime m_date;

		public WasteReceipt()
		{

		}


		public int Dispatch
		{
			get
			{
				return m_dispatch;
			}
			set
			{
				m_dispatch = value;
			}
		}

		public int Stock
		{
			get
			{
				return m_stock;
			}
			set
			{
				m_stock = value;
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
			}
		}

		public DateTime Date
		{
			get
			{
				return m_date;
			}
			set
			{
				m_date = value;
			}
		}
	}
}