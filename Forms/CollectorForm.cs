using dmyo_oop_final_assigment.Models;
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

			switch (m_status)
			{
				case CollectorStatus.View:
					collectorTab.SelectedIndex = 1;
					break;
				case CollectorStatus.ViewAll:
					collectorTab.SelectedIndex = 2;
					break;
				case CollectorStatus.Collection:
					collectorTab.SelectedIndex = 3;
					break;
				case CollectorStatus.Distrubution:
					collectorTab.SelectedIndex = 4;
					break;
				case CollectorStatus.Idle:
				default:
					collectorTab.SelectedIndex = 0;
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
