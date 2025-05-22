using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteDistribution
	{
		private int m_collection;

		private int? m_factory;

		private WasteStatus m_status;

		private DateTime m_date;

		public WasteDistribution()
		{

		}


		public int Collection
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

		public int? Factory
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