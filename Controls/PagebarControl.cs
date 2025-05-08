using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class PagebarControl : UserControl
	{
		public PagebarControl()
		{
			InitializeComponent();
		}

		private void PagebarControl_Resize(object sender, EventArgs e)
		{
			pg_label.Anchor = AnchorStyles.None;
			pg_label.Left = (this.Width - pg_label.Width) / 2;
			pg_label.Top = (this.Height - pg_label.Height) / 2;
		}
	}
}
