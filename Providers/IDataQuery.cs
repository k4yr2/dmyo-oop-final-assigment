using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	internal interface IDataQuery<TModel>
	{
		int Count();

		IEnumerable<DMYOData<TModel>> ReadAll();

		IEnumerable<DMYOData<TModel>> ReadPage(int page, int per);
	}
}