using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
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
	public partial class WasteTypeControl : UserControl, IDataRef<WasteType>
	{
		private DataObject<WasteType> m_data;

		public WasteTypeControl(DataObject<WasteType> data)
		{
			InitializeComponent();
			m_data = data;
		}

		public DataObject<WasteType> Data => m_data;

		public void Update(DataObject<WasteType> data)
		{
			m_data = data;
		}
	}
}
