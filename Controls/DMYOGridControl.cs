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
			view.Columns.Clear();

			if ((m_source = source) == null)
			{
				view.DataSource = new DataTable();
			}
			else
			{
				SetView();
				view.DataSource = source.GetTable();
			}
		}

		private void SetView()
		{
			view.Columns.Add(new DataGridViewColumn()
			{
				Name = "ID",
				DataPropertyName = "id",
				Visible = false
			});

			Source.SetView(view);
		}
	}
}
