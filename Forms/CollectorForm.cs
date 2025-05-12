using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		private DMYOData<User> m_user = null;

		private CollectorState m_state = CollectorState.Idle;

		private DMYOData<WasteCollection> m_current;

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

			switch (m_state)
			{
				case CollectorState.Idle:
					{
						var collection = TableManager.WasteCollection.GetCollection(User.Id);

						if (collection != null)
						{
							m_current = collection;
							m_state = CollectorState.Collecting;
							return;
						}
					}
					break;
				case CollectorState.Browsing:
					break;
				case CollectorState.Collecting:
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
				User = m_user.Id,
				Collection = true
			});

			m_state = CollectorState.Collecting;
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
