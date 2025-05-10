using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteCategory : DMYOModel
	{
		private string m_description;

		private WasteHazardLevel m_hazardLevel;

		private bool m_recyclable;


		public WasteCategory()
		{

		}

		public string Description
		{
			get
			{
				return m_description;
			}
			set
			{
				m_description = value;
			}
		}

		public WasteHazardLevel HazardLevel
		{
			get
			{
				return m_hazardLevel;
			}
			set
			{
				m_hazardLevel = value;
			}
		}

		public bool Recyclable
		{
			get
			{
				return m_recyclable;
			}
			set
			{
				m_recyclable = value;
			}
		}
	}

	public enum WasteHazardLevel
	{
		Low,
		Medium,
		High
	}
}
