using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataControl<TModel> : IDataReference<TModel> where TModel : class
	{

	}
}
