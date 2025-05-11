using dmyo_oop_final_assigment.Grids;
using dmyo_oop_final_assigment.Managers;
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

		public string SearchText
		{
			get
			{
				return searchBox.Text;
			}
			set
			{
				searchBox.Text = value;
			}
		}	

		public void Bind(IDMYOGrid source)
		{
			m_source = source;
			view.Visible = false;
			view.AutoGenerateColumns = false;
			view.AllowUserToAddRows = true;

			for (int i = view.Columns.Count - 1; i > 0; i--)
			{
				view.Columns.RemoveAt(i);
			}

			if ((m_source = Source) == null)
			{
				view.DataSource = new DataTable();
			}
			else
			{
				Source.SetView(view);
				view.Visible = true;
			}

			RefreshData();
		}


		public void RefreshData()
		{
			if (Source != null)
			{
				string search = string.IsNullOrWhiteSpace(SearchText) ? "%" : $"%{SearchText}%";
				view.DataSource = Source.GetTable($"SELECT * FROM {Source.Table.Name} WHERE name COLLATE Latin1_General_CI_AI LIKE '{search}'");
			}
		}


		private void view_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var row = View.Rows[e.RowIndex];
			if (row.IsNewRow) return;

			m_source.Table.Update(m_source.GetID(row), m_source.GetModel(row));

		}

		private void view_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			/*var data = m_source.Table.Create(m_source.GetBlankModel());
			var row = View.Rows[View.Rows.Count - 2];

			row.Cells["ID"].Value = data.Id;
			m_source.FillRow(row, data.Model);*/
		}

		private void view_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			m_source.Table.Delete(m_source.GetID(e.Row));

		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void searchBox_TextChanged(object sender, EventArgs e)
		{
			RefreshData();
		}
	}
}
