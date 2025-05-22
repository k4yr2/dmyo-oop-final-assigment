namespace dmyo_oop_final_assigment.Models
{
	public class WasteUnit
	{
		private string m_name;

		private string m_abbr;

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

		public string Abbr
		{
			get
			{
				return m_abbr;
			}
			set
			{
				m_abbr = value;
			}
		}
	}
}