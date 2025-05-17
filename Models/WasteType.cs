namespace dmyo_oop_final_assigment.Models
{
	public class WasteType
	{
		private string m_name;

		private string m_description;

		private int m_category;

		private int m_unit;

		public WasteType()
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

		public int Category
		{
			get
			{
				return m_category;
			}
			set
			{
				m_category = value;
			}
		}

		public int Unit
		{
			get
			{
				return m_unit;
			}
			set
			{
				m_unit = value;
			}
		}


		public override string ToString()
		{
			return Name;
		}
	}	
}