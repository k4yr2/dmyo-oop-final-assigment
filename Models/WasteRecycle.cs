using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteRecycle
	{
		private DateTime m_date;

		private int m_factory;

		private bool m_recycling;

		public WasteRecycle()
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

		public int Factory
		{
			get
			{
				return m_factory;
			}
			set
			{
				m_factory = value;
			}
		}

		public bool Recycling
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
	}
}
