using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using System;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Pages
{
	public partial class CollectorIdlePage : UserControl
	{
		private CollectorForm m_form;

		public CollectorIdlePage(CollectorForm form)
		{
			InitializeComponent();
			m_form = form;
		}


		public CollectorForm Form
		{
			get
			{
				return m_form;
			}
		}


		private void startButton_Click(object sender, EventArgs e)
		{
			if(TableManager.WasteCollection.Start(m_form.Person.Id) != null)
				Form.Refresh();
		}
	}
}