using dmyo_oop_final_assigment.Controls;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace dmyo_oop_final_assigment.Controls
{
	[Designer(typeof(DMYONavSubDesigner))]
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
				if(subPanel.Visible != value)
				{
					subPanel.Visible = value;
					var preferredSize = GetPreferredSize(new Size(Width, 0));
					Height = preferredSize.Height;
				}
			}
		}

		[Category("NavSub")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public FlowLayoutPanel SubPanel
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

public class DMYONavSubDesigner : ControlDesigner
{
	public override void Initialize(IComponent component)
	{
		base.Initialize(component);

		if (component is DMYONavSub control)
		{
			// SubPanel üzerinde çalışılmasına izin ver
			EnableDesignMode(control.SubPanel, "SubPanel");
		}
	}
}