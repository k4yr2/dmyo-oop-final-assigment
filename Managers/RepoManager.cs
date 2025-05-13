using dmyo_oop_final_assigment.Models;

namespace dmyo_oop_final_assigment.Managers
{
	static internal class RepoManager
	{
		static readonly DMYORepo<Person> m_person = new DMYORepo<Person>(TableManager.Person);

		static readonly DMYORepo<WasteType> m_wasteType = new DMYORepo<WasteType>(TableManager.WasteType);

		static readonly DMYORepo<WasteCategory> m_wasteCategory = new DMYORepo<WasteCategory>(TableManager.WasteCategory);

		static readonly DMYORepo<WasteCollection> m_wasteCollection = new DMYORepo<WasteCollection>(TableManager.WasteCollection);


		public static DMYORepo<Person> Person
		{
			get
			{
				return m_person;
			}
		}

		public static DMYORepo<WasteType> WasteType
		{
			get
			{
				return m_wasteType;
			}
		}

		public static DMYORepo<WasteCategory> WasteCategory
		{
			get
			{
				return m_wasteCategory;
			}
		}

		public static DMYORepo<WasteCollection> WasteCollection
		{
			get
			{
				return m_wasteCollection;
			}
		}
	}
}