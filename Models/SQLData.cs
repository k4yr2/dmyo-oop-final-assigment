using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class SQLData<TModel> where TModel : class
	{
		private int m_id;

		private TModel m_model;

		public SQLData(int id, TModel model)
		{
			m_id = id;
			m_model = model;
		}


		public int Id
		{
			get
			{
				return m_id;
			}
		}

		public TModel Model
		{
			get
			{
				return m_model;
			}
			set
			{
				m_model = value;
			}
		}
	}
}
