using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class ContentContainer : UserControl
	{
		public ContentContainer()
		{
			InitializeComponent();
		}

		public FlowLayoutPanel Panel
		{
			get
			{
				return panel;
			}
		}

		public override void Refresh()
		{
			base.Refresh();

			var controls = panel.Controls.OfType<Control>().ToArray();
			for (int i = 0; i < controls.Length; i++)
			{
				controls[i].Width = panel.Width;

				if (i % 2 == 0)
				{
					controls[i].BackColor = Color.Gainsboro;
				}
				else
				{
					controls[i].BackColor = Color.WhiteSmoke;
				}
			}
		}


		private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
		{
			Refresh();
		}

		private void panel_Resize(object sender, System.EventArgs e)
		{
			foreach (var control in panel.Controls.OfType<Control>())
			{
				control.Width = panel.Width;
			}
		}
	}
}
