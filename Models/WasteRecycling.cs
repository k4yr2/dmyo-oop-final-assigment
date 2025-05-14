using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteRecycling
	{
		private DateTime m_date;

		private int m_factory;

		private bool m_active;

		public WasteRecycling()
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
	}
}
