using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
	public partial class CollectorForm : Form
	{
		public CollectorForm()
		{
			InitializeComponent();
		}
	}

	public enum CollectorStatus
	{
		Idle = 0,
		View = 1,
		ViewAll = 2,
		Collection = 4,
		Distrubution = 8
	}
}
