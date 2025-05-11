using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class DMYOModel
	{
		private string m_name;

		public DMYOModel()
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

		public override string ToString()
		{
			return Name;
		}
	}
}
