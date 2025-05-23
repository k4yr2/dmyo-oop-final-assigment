﻿using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorDetailsForm : Form
	{
		private CollectorCollection m_collection;

		private CollectorCollectionItem m_waste;

		public CollectorDetailsForm(CollectorCollection collection) : this(collection, null)
		{

		}

		public CollectorDetailsForm(CollectorCollectionItem waste) : this(waste.Host, waste)
		{

		}

		private CollectorDetailsForm(CollectorCollection collection, CollectorCollectionItem waste)
		{
			InitializeComponent();

			m_collection = collection;
			m_waste = waste;

			Refresh();
		}


		public CollectorCollection Collection
		{
			get
			{
				return m_collection;
			}
		}

		public CollectorCollectionItem Waste
		{
			get
			{
				return m_waste;
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			typeBox.DataSource = TableManager.WasteType.Select().ToList();
			typeBox.ValueMember = "Id";
			typeBox.DisplayMember = "Display";

			if (m_waste == null)
			{
				applyButton.Text = "Create";
				quantityBox.Text = "1";
			}
			else
			{
				quantityBox.Text = m_waste.Source.Model.Quantity.ToString();
				typeBox.SelectedValue = m_waste.Source.Model.Type;
				applyButton.Text = "Update";
			}

			quantityBox.Focus();
		}

		private void applyButton_Click(object sender, System.EventArgs e)
		{
			var waste = new Waste()
			{
				Collection = m_collection.Source.Id,
				Type = Convert.ToInt32(typeBox.SelectedValue),
				Quantity = Convert.ToDecimal(quantityBox.Text)
			};

			if (m_waste == null)
			{
				waste.Date = DateTime.Now;
				var data = TableManager.Waste.Create(waste);
				m_collection.Panel.Controls.Add(new CollectorCollectionItem(m_collection, data));
			}
			else
			{
				waste.Date = m_waste.Source.Model.Date;
				TableManager.Waste.Update(m_waste.Source.Id, waste);

				m_waste.Source.Model = waste;
				m_waste.Bind(m_waste.Source);
			}

			Close();
		}

		private void quantityBox_TextChanged(object sender, EventArgs e)
		{
			if(decimal.TryParse(quantityBox.Text, out _))
			{
				applyButton.Enabled = true;
			}
			else
			{
				applyButton.Enabled = false;
			}
		}
	}
}
