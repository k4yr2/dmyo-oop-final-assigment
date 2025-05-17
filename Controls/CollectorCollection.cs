using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Pages
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
				return contentPanel;
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

			contentPanel.Controls.Clear();
			completeButton.Enabled = false;

			foreach (var waste in TableManager.WasteCollection.GetWastes(Source.Id))
			{
				contentPanel.Controls.Add(new CollectorWaste(this, waste));
			}
		}

		public void RefreshBackgrounds()
		{
			var controls = contentPanel.Controls.OfType<Control>().ToArray();
			for (int i = 0; i < controls.Length; i++)
			{
				if (i % 2 == 0)
				{
					controls[i].BackColor = Color.Gainsboro;
				}
				else
				{
					controls[i].BackColor = Color.WhiteSmoke;
				}
			}
		}

		private void contentPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			e.Control.Width = contentPanel.Width;
			completeButton.Enabled = true;

			RefreshBackgrounds();
		}

		private void contentPanel_Resize(object sender, System.EventArgs e)
		{
			foreach (var control in contentPanel.Controls.OfType<Control>())
			{
				control.Width = contentPanel.Width;
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
			form.ShowDialog(this);
		}

		private void contentPanel_ControlRemoved(object sender, ControlEventArgs e)
		{
			if(contentPanel.Controls.Count == 0)
			{
				completeButton.Enabled = false;
			}
		}
	}
}