using System;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class WasteForm : Form
	{
		private WasteControl m_control = null;

		private WasteCollectionControl m_collection = null;

		public WasteForm()
		{
			InitializeComponent();
			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";
		}

		public WasteForm(WasteCollectionControl collection) : this()
		{
			m_control = null;
			m_collection = collection;
			button.Text = "Add";
		}

		public WasteForm(WasteControl control) : this()
		{
			m_control = control;
			m_collection = control.Collection;
			button.Text = "Update";
			typeBox.SelectedValue = control.Data.Model.Type;
			quantityBox.Text = control.Data.Model.Quantity.ToString();
		}


		public WasteControl Control => m_control;


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
				Collection = m_collection.Data.Id,
				Type = (int)typeBox.SelectedValue,
				Quantity = quantity,
			};

			if (m_control == null)
			{
				m_control = new WasteControl(m_collection, TableManager.Waste.Create(waste));
				m_collection.Panel.Controls.Add(m_control);
			}
			else
			{
				TableManager.Waste.Update(m_control.Data.Id, waste);

				Control.Data.Model = waste;
				Control.Refresh();
			}

			Close();
		}
	}
}
