using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	internal interface IDataQuery<TModel> where TModel : class
	{
		IEnumerable<DataObject<TModel>> ReadAll();

		IEnumerable<DataObject<TModel>> ReadPage(int page, int per);
	}
}