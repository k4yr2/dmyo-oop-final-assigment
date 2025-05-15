using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteGain
	{
		private int m_receipt;

		private int m_recycle;

		private decimal m_quantity;

		private DateTime m_date;

		public WasteGain()
		{

		}


		public int Receipt
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

		public int Recycle
		{
			get
			{
				return m_recycle;
			}
			set
			{
				m_recycle = value;
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