using dmyo_oop_final_assigment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Managers
{
	public static class RepoManager
	{
		public static WasteTypeRepo m_wasteType = new WasteTypeRepo();

		//

		public static WasteTypeRepo WasteType
		{
			get
			{
				return m_wasteType;
			}
		}
	}
}
