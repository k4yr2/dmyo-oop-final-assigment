using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorWaste : UserControl, IDataLink<Waste>
	{
		private DMYOData<Waste> m_source;

		public CollectorWaste() : this(null)
		{

		}

		public CollectorWaste(DMYOData<Waste> source)
		{
			InitializeComponent();
			Bind(source);
		}


		public DMYOData<Waste> Source
		{
			get
			{
				return m_source;
			}
		}


		public void Bind(DMYOData<Waste> source)
		{
			m_source = source;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();
		}
	}
}
