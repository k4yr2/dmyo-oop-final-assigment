using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	internal interface IDataQuery
	{
		IEnumerable<SQLModel<TModel>> ReadAll<TModel>() where TModel : class;
	}
}