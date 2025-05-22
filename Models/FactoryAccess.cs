namespace dmyo_oop_final_assigment.Models
{
	public class FactoryAccess
	{
		private int m_person;

		private int m_factory;

		public FactoryAccessMode m_mode;

		public FactoryAccess()
		{

		}


		public int Person
		{
			get
			{
				return m_person;
			}
			set
			{
				m_person = value;
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

		public FactoryAccessMode Mode
		{
			get
			{
				return m_mode;
			}
			set
			{
				m_mode = value;
			}
		}
	}

	public enum FactoryAccessMode
	{
		Read = 0,
		Write = 1,
		Admin = 2,
	}
}