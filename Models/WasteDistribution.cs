using System;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteDistribution
	{
		private DateTime m_date;

		private int m_factory;

		private WasteDistributionStatus m_status;

		public WasteDistribution()
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

		public WasteDistributionStatus Status
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
	}

	public enum WasteDistributionStatus
	{
		Demand = 0,
		Grant = 1,
		Complete = 2,
	}
}