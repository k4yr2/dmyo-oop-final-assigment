using System.ComponentModel;
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

		public DMYONavSub()
		{
			InitializeComponent();
		}
	}
}
