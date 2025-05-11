using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataCollection
	{
		string SelectQuery { get; }

		IDMYOData[] Repo { get; }

		IEnumerable<IDMYOData> Select();
	}

	public interface IDataCollection<TModel> : IDataCollection where TModel : DMYOModel
	{
		new IDMYOData<TModel>[] Repo { get; }

		new IEnumerable<DMYOData<TModel>> Select();
	}
}