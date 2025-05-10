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
			view.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "ID",
				DataPropertyName = "id",
				Visible = false
			});

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
			view.Visible = false;
			view.AutoGenerateColumns = false;

			for (int i = view.Columns.Count - 1; i > 0; i--)
			{
				view.Columns.RemoveAt(i);
			}

			if ((m_source = source) == null)
			{
				view.DataSource = new DataTable();
			}
			else
			{
				Source.SetView(view);
				view.DataSource = source.GetTable();

				view.Visible = true;
			}
		}
	}
}
