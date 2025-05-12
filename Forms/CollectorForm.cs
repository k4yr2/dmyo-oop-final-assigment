using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private CollectorState m_state = CollectorState.Idle;

		public CollectorForm()
		{
			InitializeComponent();
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
