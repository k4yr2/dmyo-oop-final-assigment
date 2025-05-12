using dmyo_oop_final_assigment.Managers;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class GatewayForm : Form
	{
		public GatewayForm()
		{
			InitializeComponent();
		}

		private void showBox_CheckedChanged(object sender, System.EventArgs e)
		{
			passwordBox.PasswordChar = showBox.Checked ? '\0' : '*';
		}

		private void loginButton_Click(object sender, System.EventArgs e)
		{
			var user =
			TableManager.User.Select($"WHERE name = '{nameBox.Text}' and password = '{passwordBox.Text}'")
				.FirstOrDefault();

			if (user == null)
			{
				MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				switch(user.Model.Role)
				{
					case Models.UserRole.Collector:
						new CollectorForm(user).Show();
						break;
					case Models.UserRole.Recycler:
						//new RecyclerForm().Show();
						break;
					case Models.UserRole.Admin:
						//new AdminForm().Show();
						break;
				}

				Close();
			}
		}
	}
}
