using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataQuery
	{
		int CountQuery { get; }

		string ReadAllQuery { get; }

		string ReadPageQuery { get; }
	}	

	public interface IDataQuery<TModel> : IDataQuery where TModel : DMYOModel
	{
		int Count();

		IEnumerable<DMYOData<TModel>> ReadAll();

		IEnumerable<DMYOData<TModel>> ReadPage(int page, int per);
	}
}