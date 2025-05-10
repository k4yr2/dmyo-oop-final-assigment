namespace dmyo_oop_final_assigment.Models
{
	public class WasteUnit : DMYOModel
	{
		private string m_abbreviation;

		public WasteUnit()
		{

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
