using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteRecycling
	{
		private int m_factory;

		private int m_person;

		private WasteStatus m_status;

		private DateTime m_date;

		public WasteRecycling()
		{

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