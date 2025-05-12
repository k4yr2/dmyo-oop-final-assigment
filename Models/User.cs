namespace dmyo_oop_final_assigment.Models
{
	public class User
	{
		private string m_name;

		private string m_password;

		private UserRole m_role;

		public User()
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

		public UserRole Role
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
	}

	public enum UserRole
	{
		Collector = 0,
		Recycler = 1,
		Admin = 2
	}
}
