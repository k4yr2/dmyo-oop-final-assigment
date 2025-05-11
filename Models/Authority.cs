using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class Authority : DMYOModel
	{
		private string m_password;

		public Authority()
		{

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
	}
}
