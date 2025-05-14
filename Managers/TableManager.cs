using dmyo_oop_final_assigment.Tables;

namespace dmyo_oop_final_assigment.Managers
{
	public static class TableManager
	{
		private static readonly PersonTable m_person = new PersonTable();

		private static readonly FactoryTable m_factory = new FactoryTable();

		private static readonly FactoryAccessTable m_factoryAccess = new FactoryAccessTable();

		private static readonly WasteTable m_waste = new WasteTable();

		private static readonly WasteTypeTable m_wasteType = new WasteTypeTable();

		private static readonly WasteCategoryTable m_wasteCategory = new WasteCategoryTable();

		private static readonly WasteUnitTable m_wasteUnit = new WasteUnitTable();

		private static readonly WasteCollectionTable m_wasteCollection = new WasteCollectionTable();

		//

		public static PersonTable Person
		{
			get
			{
				return m_person;
			}
		}

		public static FactoryTable Factory
		{
			get
			{
				return m_factory;
			}
		}

		public static FactoryAccessTable FactoryAccess
		{
			get
			{
				return m_factoryAccess;
			}
		}

		public static WasteTable Waste
		{
			get
			{
				return m_waste;
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

		public static WasteUnitTable WasteUnit
		{
			get
			{
				return m_wasteUnit;
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