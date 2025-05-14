using System;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectingForm : Form
	{
		private CollectingEntry m_control = null;

		private CollectingContainer m_collection = null;

		public CollectingForm()
		{
			InitializeComponent();
			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";
		}

		public CollectingForm(CollectingContainer collection) : this()
		{
			m_control = null;
			m_collection = collection;
			button.Text = "Add";
		}

		public CollectingForm(CollectingEntry control) : this()
		{
			m_control = control;
			m_collection = control.Collection;
			button.Text = "Update";
			typeBox.SelectedValue = control.Source.Model.Type;
			quantityBox.Text = control.Source.Model.Quantity.ToString();
		}


		public CollectingEntry Control => m_control;


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

			if (m_control == null)
			{
				m_control = new CollectingEntry(m_collection, TableManager.Waste.Create(waste));
				m_collection.Panel.Controls.Add(m_control);
			}
			else
			{
				TableManager.Waste.Update(m_control.Source.Id, waste);

				Control.Source.Model = waste;
				Control.Refresh();
			}

			Close();
		}
	}
}
