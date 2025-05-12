namespace dmyo_oop_final_assigment.Models
{
	public interface IDMYOData
	{
		int Id { get; }

		DMYOModel Model { get; set; }
	}

	public interface IDMYOData<TModel> : IDMYOData where TModel : DMYOModel
	{
		new TModel Model { get; set; }
	}

	public class DMYOData<TModel> : IDMYOData<TModel>, IDMYOData where TModel : DMYOModel
	{
		public static DMYOData<TModel> Blank
		{
			get
			{
				return new DMYOData<TModel>(-500, default);
			}
		}

		private int m_id;

		private TModel m_model;

		public DMYOData(int id, TModel model)
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

		DMYOModel IDMYOData.Model
		{
			get
			{
				return m_model;
			}
			set
			{
				m_model = (TModel)value;
			}
		}
	}
}
