using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment
{
	internal class DMYORepo<TModel>
	{
		private IDMYOTable<TModel> m_table;

		private List<DMYOData<TModel>> m_list = new List<DMYOData<TModel>>();

		public DMYORepo(IDMYOTable<TModel> table)
		{
			m_table = table;
		}


		public IDMYOTable<TModel> Table
		{
			get
			{
				return m_table;
			}
		}

		public IEnumerable<DMYOData<TModel>> Datas
		{
			get
			{
				return m_list;
			}
		}


		public void Refresh()
		{
			m_list.Clear();
			m_list.AddRange(m_table.Select());
		}

		public DMYOData<TModel> Find(int id)
		{
			return Datas.Where(d => d.Id == id).FirstOrDefault();
		}
	}
}
