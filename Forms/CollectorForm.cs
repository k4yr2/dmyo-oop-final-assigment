using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private DMYOData<User> m_user = null;

		private CollectorState m_state = CollectorState.Idle;

		public CollectorForm(DMYOData<User> user)
		{
			m_user = user;
			InitializeComponent();
		}


		public DMYOData<User> User
		{
			get
			{
				return m_user;
			}
			set
			{
				m_user = value;
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
				m_state = value;
			}
		}


		public override void Refresh()
		{
			base.Refresh();

			switch (m_state)
			{
				case CollectorState.Idle:
					break;
				case CollectorState.Browsing:
					break;
				case CollectorState.Collecting:
					break;
				case CollectorState.Distributing:
					break;
			}
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
