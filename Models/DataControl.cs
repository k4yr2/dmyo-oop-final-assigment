using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Models
{
	public abstract class DataControl<TModel> : UserControl where TModel : class
	{
		private DataObject<TModel> m_object;

		public DataObject<TModel> Object
		{
			get
			{
				return m_object;
			}
			set
			{
				m_object = value;
				OnUpdate();
			}
		}

		public abstract void OnUpdate();
	}
}
