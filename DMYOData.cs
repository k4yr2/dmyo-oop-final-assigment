﻿namespace dmyo_oop_final_assigment
{
	public interface IDMYOData
	{
		int Id { get; }

		object Model { get; set; }
	}

	public interface IDMYOData<TModel> : IDMYOData
	{
		new TModel Model { get; set; }
	}

	public class DMYOData<TModel> : IDMYOData<TModel>, IDMYOData
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

		object IDMYOData.Model
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

		public string Display
		{
			get
			{
				return Model?.ToString() ?? "BLANK";
			}
		}
	}
}
