using dmyo_oop_final_assigment.Table;

namespace dmyo_oop_final_assigment.Managers
{
	public static class TableManager
	{
		public static WasteTypeTable m_wasteType = new WasteTypeTable();

		public static WasteCategoryTable m_wasteCategory = new WasteCategoryTable();

		//

		public static WasteTypeTable WasteType
		{
			get
			{
				return m_wasteType;
			}
		}

		public static WasteCategoryTable WasteCategory
		{
			get
			{
				return m_wasteCategory;
			}
		}
	}
}
