using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataQuery
	{
		string ReadAllQuery { get; }
	}	

	public interface IDataQuery<TModel> : IDataQuery where TModel : DMYOModel
	{
		IEnumerable<DMYOData<TModel>> ReadAll();
	}
}