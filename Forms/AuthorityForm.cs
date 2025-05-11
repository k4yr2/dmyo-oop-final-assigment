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
	public partial class AuthorityForm : Form
	{
		public AuthorityForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string name = nameBox.Text;
			string password = passwordBox.Text;

			var data =
			TableManager.Authority.Select($"WHERE name = '{name}' and password = '{password}'").FirstOrDefault();
		
			if(data != null)
			{
				Program.Authority = data;
				MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			else
			{
				MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
