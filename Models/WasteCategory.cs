namespace dmyo_oop_final_assigment.Models
{
	public class WasteCategory
	{
		private string m_name;

		private string m_description;

		private int m_hazardLevel;

		private bool m_recyclable;

		public WasteCategory()
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

		public int HazardLevel
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
}