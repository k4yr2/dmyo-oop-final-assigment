using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private DMYOData<Person> m_person = null;

		private CollectorState m_state = CollectorState.Idle;

		private DMYOData<WasteCollection> m_current;

		public CollectorForm(DMYOData<Person> person)
		{
			m_person = person;
			InitializeComponent();
			Refresh();
		}


		public DMYOData<Person> Person
		{
			get
			{
				return m_person;
			}
			set
			{
				m_person = value;
			}
		}

		public CollectorState State
		{
			get
			{
				return m_state;
			}
			set
			{
				if(m_state != value)
				{
					m_state = value;
					Refresh();
				}
			}
		}

		public DMYOData<WasteCollection> Current
		{
			get
			{
				return m_current;
			}
			set
			{
				m_current = value;
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			completeButton.Visible = false;
			addButton.Visible = false;
			managePanel.Visible = true;
			dataPanel.Controls.Clear();

			switch (m_state)
			{
				case CollectorState.Idle:
					{
						var collection = TableManager.WasteCollection.GetCollecting(Person.Id);

						if (collection != null)
						{
							m_current = collection;
							State = CollectorState.Collecting;
							return;
						}

						newButton.Enabled = true;
						newButton.Text = "Collect";
						managePanel.Visible = false;
					}
					break;
				case CollectorState.Browsing:
					break;
				case CollectorState.Collecting:
					{
						newButton.Enabled = false;
						newButton.Text = "Collecting";

						completeButton.Visible = true;
						addButton.Visible = true;

						foreach (var data in TableManager.Waste.Select($"where collection = {m_current.Id}"))
						{
							var control = new WasteControl(m_current, data);
							dataPanel.Controls.Add(control);
						}
					}
					break;
				case CollectorState.Distributing:
					break;
			}
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			m_current = TableManager.WasteCollection.Create(new WasteCollection()
			{
				Date = DateTime.Now,
				Person = Person.Id,
				Collecting = true
			});

			State = CollectorState.Collecting;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var form = new WasteForm(m_current);
			form.ShowDialog();

			var control = form.Control;
			dataPanel.Controls.Add(control);
		}

		private void completeButton_Click(object sender, EventArgs e)
		{

		}
	}

	public enum CollectorState
	{
		Idle,
		Browsing,
		Collecting,
		Distributing
	}
}
