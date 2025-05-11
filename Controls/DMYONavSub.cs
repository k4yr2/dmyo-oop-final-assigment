using dmyo_oop_final_assigment.Controls;
using System.ComponentModel;
using System.ComponentModel.Design;
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
				subPanel.Visible = value;
			}
		}

		[Category("NavSub")]
		[Browsable(false)]
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

		private void DMYONavSub_Resize(object sender, System.EventArgs e)
		{
			if(Parent != null)
				Width = Parent.Width;
		}

		private void DMYONavSub_ParentChanged(object sender, System.EventArgs e)
		{
			if (Parent != null)
				Width = Parent.Width;
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