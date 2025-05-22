namespace dmyo_oop_final_assigment.Models
{
	public class Person
	{
		private string m_name;

		private string m_password;

		private PersonRole m_role;

		private int? m_factory;


		public Person()
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

		public string Password
		{
			get
			{
				return m_password;
			}
			set
			{
				m_password = value;
			}
		}

		public PersonRole Role
		{
			get
			{
				return m_role;
			}
			set
			{
				m_role = value;
			}
		}	

		public int? Factory
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
    }

	public enum PersonRole
	{
		Collector = 0,
		Recycler = 1,
		Admin = 2
	}
}
