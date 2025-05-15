using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteCollection
	{
		private int m_person;

		private WasteStatus m_status;

		private DateTime m_date;


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

	public enum WasteStatus
	{
		Active = 0,
		Processing = 1,
		Completed = 2,
		Cancelled = 3,
	}
}