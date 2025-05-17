using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteDispatch
	{
		private int m_type;

		private int m_distribution;

		private decimal m_quantity;

		private decimal m_capacity;

		private DateTime m_date;

		public WasteDispatch()
		{

		}


		public int Type
		{
			get
			{
				return m_type;
			}
			set
			{
				m_type = value;
			}
		}

		public int Distribution
		{
			get
			{
				return m_distribution;
			}
			set
			{
				m_distribution = value;
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

		public decimal Capacity
		{
			get
			{
				return m_capacity;
			}
			set
			{
				m_capacity = value;
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