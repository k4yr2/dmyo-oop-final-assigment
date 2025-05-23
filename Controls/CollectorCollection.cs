﻿using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorCollection : UserControl, IDataLink<WasteCollection>
	{
		private CollectorForm m_form;

		private DMYOData<WasteCollection> m_source;

		public CollectorCollection(CollectorForm form, DMYOData<WasteCollection> source)
		{
			InitializeComponent();

			m_form = form;
			Bind(source);
		}


		public CollectorForm Form
		{
			get
			{
				return m_form;
			}
		}

		public DMYOData<WasteCollection> Source
		{
			get
			{
				return m_source;
			}
		}

		public FlowLayoutPanel Panel
		{
			get
			{
				return contentContainer.Panel;
			}
		}


		public void Bind(DMYOData<WasteCollection> source)
		{
			m_source = source;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();

			Panel.Controls.Clear();
			completeButton.Enabled = false;

			foreach (var waste in TableManager.WasteCollection.GetWastes(Source.Id))
			{
				Panel.Controls.Add(new CollectorCollectionItem(this, waste));
			}
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to cancel the collection?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				TableManager.WasteCollection.Cancel(Form.Person.Id);
				Form.Status = CollectorStatus.Idle;
			}
		}

		private void addButton_Click(object sender, System.EventArgs e)
		{
			var form = new CollectorDetailsForm(this);
			form.StartPosition = FormStartPosition.CenterScreen;
			form.ShowDialog(this);
		}

		private void completeButton_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to complete the collection?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				if (TableManager.WasteCollection.Distrubute(Form.Person.Id))
				{
					Form.Refresh();
				}
				else
				{
					MessageBox.Show("You cannot complete a collection that is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void contentContainer_Load(object sender, System.EventArgs e)
		{
			Panel.ControlAdded += (s, _) =>
			{
				completeButton.Enabled = true;
			};

			Panel.ControlRemoved += (s, _) =>
			{
				if (Panel.Controls.Count == 0)
				{
					completeButton.Enabled = false;
				}
			};
		}
	}
}