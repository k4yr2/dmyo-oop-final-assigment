using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteRecycle
	{
		private int m_factory;

		private int m_person;

		private bool m_active;

		private DateTime m_date;

		public WasteRecycle()
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

		public bool Active
		{
			get
			{
				return m_active;
			}
			set
			{
				m_active = value;
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