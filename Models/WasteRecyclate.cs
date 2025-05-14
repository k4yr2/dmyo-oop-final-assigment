using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteRecyclate
	{
		private DateTime m_date;

		private int m_recycling;

		private int m_load;

		private decimal m_gain;

		public WasteRecyclate()
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

		public int Recycling
		{
			get
			{
				return m_recycling;
			}
			set
			{
				m_recycling = value;
			}
		}

		public int Load
		{
			get
			{
				return m_load;
			}
			set
			{
				m_load = value;
			}
		}

		public decimal Gain
		{
			get
			{
				return m_gain;
			}
			set
			{
				m_gain = value;
			}
		}
	}
}