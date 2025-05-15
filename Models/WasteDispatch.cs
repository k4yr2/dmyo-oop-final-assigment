using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteDispatch
	{
		private int m_waste;

		private int m_distribution;

		private decimal m_quantity;

		private DateTime m_date;

		public WasteDispatch()
		{

		}


		public int Waste
		{
			get
			{
				return m_waste;
			}
			set
			{
				m_waste = value;
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