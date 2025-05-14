namespace dmyo_oop_final_assigment.Models
{
	public class Factory
	{
		private string m_name;

		private string m_location;

		public Factory()
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