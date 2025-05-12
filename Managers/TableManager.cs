using dmyo_oop_final_assigment.Tables;

namespace dmyo_oop_final_assigment.Managers
{
	public static class TableManager
	{
		private static readonly UserTable m_userTable = new UserTable();

		private static readonly WasteTypeTable m_wasteType = new WasteTypeTable();

		private static readonly WasteCategoryTable m_wasteCategory = new WasteCategoryTable();

		private static readonly WasteCollectionTable m_wasteCollection = new WasteCollectionTable();

		//

		public static UserTable User
		{
			get
			{
				return m_userTable;
			}
		}

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

		public static WasteCollectionTable WasteCollection
		{
			get
			{
				return m_wasteCollection;
			}
		}
	}
}