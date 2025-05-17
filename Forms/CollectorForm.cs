using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private DMYOData<Person> m_person;

		private CollectorStatus m_status;

		public CollectorForm(DMYOData<Person> person)
		{
			InitializeComponent();

			m_person = person;
			Status = CollectorStatus.Idle;
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
			idlePanel.Visible = false;

			switch (m_status)
			{
				case CollectorStatus.View:
					break;
				case CollectorStatus.ViewAll:
					break;
				case CollectorStatus.Collection:
					break;
				case CollectorStatus.Distrubution:
					break;
				case CollectorStatus.Idle:
				default:
					idlePanel.Visible = true;
					break;
			}	
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
