using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void showBox_CheckedChanged(object sender, System.EventArgs e)
		{
			passwordBox.PasswordChar = showBox.Checked ? '\0' : '*';
		}
	}
}
