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
		private WasteCollectionControl m_collection = null;

		private WasteControl m_waste = null;

		public WasteDetailForm()
		{
			InitializeComponent();
			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";
		}

		public WasteDetailForm(WasteCollectionControl container) : this()
		{
			m_collection = container;
			m_waste = null;

			button.Text = "Add";
		}

		public WasteDetailForm(WasteControl entry) : this()
		{
			m_collection = entry.Collection;
			m_waste = entry;

			button.Text = "Update";
			typeBox.SelectedValue = entry.Source.Model.Type;
			quantityBox.Text = entry.Source.Model.Quantity.ToString();
		}


		public WasteControl Control => m_waste;


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
				Collection = m_collection.Source.Id,
				Type = (int)typeBox.SelectedValue,
				Quantity = quantity,
			};

			if (m_waste == null)
			{
				m_waste = new WasteControl(m_collection, TableManager.Waste.Create(waste));
				m_collection.Panel.Controls.Add(m_waste);
			}
			else
			{
				TableManager.Waste.Update(m_waste.Source.Id, waste);

				Control.Source.Model = waste;
				Control.Refresh();
			}

			Close();
		}
	}
}
