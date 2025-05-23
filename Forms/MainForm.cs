﻿using dmyo_oop_final_assigment.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
					case Models.PersonRole.Recycler:
						form = new RecyclerForm(person);
                        break;
                    default:
						form = null;
						MessageBox.Show("Invalid role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
				}

				if (form != null)
				{
					form.StartPosition = FormStartPosition.CenterScreen;
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


        private void quickLogin_dmyo_2025_Click(object sender, EventArgs e)
        {
            Login("dmyo", "2025");
        }

        private void quickLogin_sinan_demirci_Click(object sender, EventArgs e)
        {
            Login("sinan", "demirci");
        }

        private void quickLogin_semih_altun_Click(object sender, EventArgs e)
        {
            Login("semih", "altun");
        }

        private void quickLogin_serhat_genc_Click(object sender, EventArgs e)
        {
            Login("serhat", "genc");
        }

        private void quickLogin_kayra_ozkaya_Click(object sender, EventArgs e)
        {
            Login("kayra", "ozkaya");
        }


        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/k4yr2/dmyo-oop-final-assigment",
				UseShellExecute = true
			});
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/k4yr2",
				UseShellExecute = true
			});
		}
    }
}