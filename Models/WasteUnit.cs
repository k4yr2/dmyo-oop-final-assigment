namespace dmyo_oop_final_assigment.Models
{
	public class WasteUnit
	{
		private string m_name;

		private string m_abbreviation;

		public WasteUnit()
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

		public string Abbreviation
		{
			get
			{
				return m_abbreviation;
			}
			set
			{
				m_abbreviation = value;
			}
		}
	}
}
