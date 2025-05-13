using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class WasteForm : Form
	{
		private WasteControl m_data = null;

		private DMYOData<WasteCollection> m_collection = null;

		public WasteForm()
		{
			InitializeComponent();
			typeBox.DataSource = TableManager.WasteCategory.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";
		}

		public WasteForm(DMYOData<WasteCollection> collection) : this()
		{
			m_data = null;
			m_collection = collection;
			button.Text = "Add";
		}

		public WasteForm(WasteControl data) : this()
		{
			m_data = data;
			m_collection = data.Collection;
			button.Text = "Update";
		}


		public WasteControl Data => m_data;


		private void button_Click(object sender, EventArgs e)
		{
			if(!int.TryParse(quantityBox.Text, out int quantity))
			{
				MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var waste = new Waste()
			{
				Date = DateTime.Now,
				Type = (int)typeBox.SelectedValue,
				Quantity = quantity,
			};

			if (m_data == null)
			{
				TableManager.Waste.Create(waste);
			}
			else
			{
				TableManager.Waste.Update(m_data.Data.Id, waste);
			}

			Close();
		}
	}
}
