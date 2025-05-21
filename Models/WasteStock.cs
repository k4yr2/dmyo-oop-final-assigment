using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteStock
	{
		private int m_person;

		private int m_distribution;

		private WasteStatus m_status;

        private DateTime m_date;

		public WasteStock()
		{

		}


		public int Person
		{
			get
			{
				return m_person;
			}
			set
			{
				m_person = value;
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

		public WasteStatus Status
		{
			get
			{
				return m_status;
			}
			set
			{
				m_status = value;
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
