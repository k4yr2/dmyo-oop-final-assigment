using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class DMYONavSub : UserControl
	{
		[Category("NavSub")]
		[Browsable(true)]
		public string Title
		{
			get
			{
				return label.Text;
			}
			set
			{
				label.Text = value;
			}
		}

		[Category("NavSub")]
		[Browsable(true)]
		public bool EnableSub
		{
			get
			{
				return subPanel.Visible;
			}
			set
			{
				subPanel.Visible = value;
			}
		}

		[Category("NavSub")]
		[Browsable(false)]
		public Panel SubPanel
		{
			get
			{
				return subPanel;
			}
		}

		public DMYONavSub()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, System.EventArgs e)
		{
			EnableSub = !EnableSub;
		}
	}
}
