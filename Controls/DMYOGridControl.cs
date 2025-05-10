using dmyo_oop_final_assigment.Grids;
using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class DMYOGridControl : UserControl
	{
		private DMYOGrid<DMYOModel> m_source;

		public DMYOGridControl(DMYOGrid<DMYOModel> source)
		{
			InitializeComponent();
			Bind(source);
		}


		public DMYOGrid<DMYOModel> Source
		{
			get
			{
				return m_source;
			}
		}

		public void Bind(DMYOGrid<DMYOModel> source)
		{
			m_source = source;
			grid.DataSource = source.GetTable();
		}
	}
}
