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

		private void Login(string name, string password)
		{
			var person = TableManager.Person.Select($"WHERE name = '{name}' and password = '{password}'")
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

		private void loginButton_Click(object sender, EventArgs e)
		{
			Login(nameBox.Text, passwordBox.Text);
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

		private void quickCollectorButton_SinanDemirci_Click(object sender, EventArgs e)
		{
			Login("sinan", "demirci");
		}

		private void quickAdminButton_dmyo2025_Click(object sender, EventArgs e)
		{
			Login("dmyo", "2025");
		}
	}
}
