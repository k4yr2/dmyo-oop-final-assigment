using System;
using System.Windows.Forms;
using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment
{
	static internal class Program
	{
		static private DMYOData<Authority> m_authority = null;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}


		static public DMYOData<Authority> Authority
		{
			get
			{
				return m_authority;
			}
			set
			{
				if (m_authority != value)
				{
					m_authority = value;
				}
			}
		}
	}
}
