using System;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class WasteDetailForm : Form
	{
		private CollectingContainer m_container = null;

		private CollectingEntry m_entry = null;

		public WasteDetailForm()
		{
			InitializeComponent();
			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";
		}

		public WasteDetailForm(CollectingContainer container) : this()
		{
			m_container = container;
			m_entry = null;

			button.Text = "Add";
		}

		public WasteDetailForm(CollectingEntry entry) : this()
		{
			m_container = entry.Collection;
			m_entry = entry;

			button.Text = "Update";
			typeBox.SelectedValue = entry.Source.Model.Type;
			quantityBox.Text = entry.Source.Model.Quantity.ToString();
		}


		public CollectingEntry Control => m_entry;


		private void button_Click(object sender, EventArgs e)
		{
			if(!decimal.TryParse(quantityBox.Text, out decimal quantity))
			{
				MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var waste = new Waste()
			{
				Date = DateTime.Now,
				Collection = m_container.Source.Id,
				Type = (int)typeBox.SelectedValue,
				Quantity = quantity,
			};

			if (m_entry == null)
			{
				m_entry = new CollectingEntry(m_container, TableManager.Waste.Create(waste));
				m_container.Panel.Controls.Add(m_entry);
			}
			else
			{
				TableManager.Waste.Update(m_entry.Source.Id, waste);

				Control.Source.Model = waste;
				Control.Refresh();
			}

			Close();
		}
	}
}
