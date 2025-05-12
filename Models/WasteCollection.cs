using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteCollection
	{
		private int m_user;

		private DateTime m_date;

		private bool m_collection;

		public WasteCollection()
		{

		}


		public int User
		{
			get
			{
				return m_user;
			}
			set
			{
				m_user = value;
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

		public bool Collection
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
	}
}