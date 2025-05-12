using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteCollection
	{
		private string m_name;

		private int m_user;

		private DateTime m_date;

		private string m_location;

		public WasteCollection()
		{

		}


		public string Name
		{
			get
			{
				return m_name;
			}
			set
			{
				m_name = value;
			}
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

		public string Location
		{
			get
			{
				return m_location;
			}
			set
			{
				m_location = value;
			}
		}
	}
}