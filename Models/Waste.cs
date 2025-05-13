using System;

namespace dmyo_oop_final_assigment.Models
{
	public class Waste
	{
		private DateTime m_date;

		private int m_collection;

		private int m_type;

		private decimal m_quantity;

		public Waste()
		{

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

		public int Collection
		{
			get
			{
				return m_collection;
			}
			set
			{
				m_collection = value;
			}
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
	}
}