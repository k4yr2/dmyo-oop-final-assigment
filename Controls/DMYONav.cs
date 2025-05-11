using System.ComponentModel;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class DMYONav : UserControl
	{
		[Category("Nav")]
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

		public DMYONav()
		{
			InitializeComponent();
		}
	}
}
