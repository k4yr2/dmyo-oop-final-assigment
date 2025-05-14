using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteLoad
	{
		private DateTime m_date;

		private int m_distribution;

		private int m_waste;

		private decimal m_demand;

		private decimal m_granted;

		public WasteLoad()
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

		public decimal Demand
		{
			get
			{
				return m_demand;
			}
			set
			{
				m_demand = value;
			}
		}

		public decimal Granted
		{
			get
			{
				return m_granted;
			}
			set
			{
				m_granted = value;
			}
		}
	}
}