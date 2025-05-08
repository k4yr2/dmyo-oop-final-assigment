namespace dmyo_oop_final_assigment.Models
{
	public class DataObject<TModel> where TModel : class
	{
		private int m_id;

		private TModel m_model;

		public DataObject(int id, TModel model)
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
