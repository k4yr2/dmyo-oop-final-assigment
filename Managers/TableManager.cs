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

		private static readonly WasteDistributionTable m_wasteDistribution = new WasteDistributionTable();

		private static readonly WasteDispatchTable m_wasteDispatch = new WasteDispatchTable();

		private static readonly WasteStockTable m_wasteStock = new WasteStockTable();

		private static readonly WasteReceiptTable m_wasteReceipt = new WasteReceiptTable();

		private static readonly WasteHeapTable m_wasteHeap = new WasteHeapTable();

        private static readonly WasteRecycleTable m_wasteRecycle = new WasteRecycleTable();

		private static readonly WasteGainTable m_wasteGain = new WasteGainTable();

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

		public static WasteDistributionTable WasteDistribution
		{
			get
			{
				return m_wasteDistribution;
			}
		}

		public static WasteDispatchTable WasteDispatch
		{
			get
			{
				return m_wasteDispatch;
			}
		}

		public static WasteStockTable WasteStock
		{
			get
			{
				return m_wasteStock;
			}
		}

		public static WasteReceiptTable WasteReceipt
		{
			get
			{
				return m_wasteReceipt;
			}
		}

		public static WasteHeapTable WasteHeap
		{
			get
			{
				return m_wasteHeap;
			}
        }

        public static WasteRecycleTable WasteRecycle
		{
			get
			{
				return m_wasteRecycle;
			}
		}

		public static WasteGainTable WasteGain
		{
			get
			{
				return m_wasteGain;
			}
		}
	}
}