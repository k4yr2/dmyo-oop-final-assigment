using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Pages;
using System.ComponentModel;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private DMYOData<Person> m_person;

		private CollectorStatus m_status;

		public CollectorForm() : this(null) 
		{ 

		}

		public CollectorForm(DMYOData<Person> person)
		{
			InitializeComponent();

			m_person = person;
			m_status = CollectorStatus.Idle;
			Refresh();
		}


		public DMYOData<Person> Person
		{
			get
			{
				return m_person;
			}
		}

		public CollectorStatus Status
		{
			get
			{
				return m_status;
			}
			set
			{
				if (m_status != value)
				{
					m_status = value;
					Refresh();
				}
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			var collection =
			TableManager.WasteCollection.GetCurrent(Person.Id);

			if(collection != null)
			{
				m_status = CollectorStatus.Collection;
			}

			UserControl control;
			switch (m_status)
			{
				case CollectorStatus.Collection:
					control = new CollectorCollectionPage(this, collection);
					break;
				case CollectorStatus.Idle:
				default:
					control = new CollectorIdlePage(this);
					break;
			}

			control.Dock = DockStyle.Fill;
			Controls.Clear();
			Controls.Add(control);
		}
	}

	public enum CollectorStatus
	{
		Idle = 0,
		View = 1,
		ViewAll = 2,
		Collection = 4,
		Distrubution = 8
	}
}
