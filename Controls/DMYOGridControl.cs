using dmyo_oop_final_assigment.Grids;
using dmyo_oop_final_assigment.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class DMYOGridControl<TModel> : UserControl
	{
		private DMYOGrid<TModel> m_source;

		public DMYOGridControl() : this(null)
		{

		}

		public DMYOGridControl(DMYOGrid<TModel> source)
		{
			InitializeComponent();
			Bind(source);
		}


		public DMYOGrid<TModel> Source
		{
			get
			{
				return m_source;
			}
		}

		public void Bind(DMYOGrid<TModel> source)
		{
			if((m_source = source) == null)
			{
				grid.DataSource = new DataTable();
			}
			else
			{
				grid.DataSource = source.GetTable();
			}
		}
	}
}
