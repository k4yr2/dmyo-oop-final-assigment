using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteCollection
	{
		private int m_person;

		private DateTime m_date;

		private bool m_collecting;

		public WasteCollection()
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

		public bool Collecting
		{
			get
			{
				return m_collecting;
			}
			set
			{
				m_collecting = value;
			}
		}
	}
}