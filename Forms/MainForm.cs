using dmyo_oop_final_assigment.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


		private void loginButton_Click(object sender, EventArgs e)
		{
			var person = TableManager.Person.Select($"WHERE name = '{nameBox.Text}' and password = '{passwordBox.Text}'")
				.FirstOrDefault();

			if (person == null)
			{
				MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Form form;
				switch (person.Model.Role)
				{
					case Models.PersonRole.Collector:
						form = new CollectorForm(person);
						break;
					default:
						form = null;
						break;
				}

				if (form != null)
				{
					form.Show();
					form.Focus();
				}
			}
		}

		private void contentPanel_Paint(object sender, PaintEventArgs e)
		{
			quickAdminPanel.Width = (Width - 200) / 3;
			quickCollectorPanel.Width = (Width - 200) / 3;
			quickRecyclerPanel.Width = (Width - 200) / 3;
		}

		private void contentPanel_Resize(object sender, EventArgs e)
		{
			quickAdminPanel.Width = (Width - 200) / 3;
			quickCollectorPanel.Width = (Width - 200) / 3;
			quickRecyclerPanel.Width = (Width - 200) / 3;
		}
	}
}
