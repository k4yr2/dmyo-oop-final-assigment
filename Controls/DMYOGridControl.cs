using dmyo_oop_final_assigment.Grids;
using dmyo_oop_final_assigment.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class DMYOGridControl : UserControl
	{
		private IDMYOGrid m_source;

		public DMYOGridControl() : this(null)
		{

		}

		public DMYOGridControl(IDMYOGrid source)
		{
			InitializeComponent();
			Bind(source);
		}

		public DataGridView View
		{
			get
			{
				return view;
			}
		}

		public IDMYOGrid Source
		{
			get
			{
				return m_source;
			}
		}

		public void Bind(IDMYOGrid source)
		{
			if((m_source = source) == null)
			{
				view.DataSource = new DataTable();
			}
			else
			{
				view.DataSource = source.GetTable();
			}
		}
	}
}
