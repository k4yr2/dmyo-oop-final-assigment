using dmyo_oop_final_assigment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Providers
{
	public interface IDataRef<TModel> : IDataReadonlyRef<TModel> where TModel : class
	{
		void Bind(DataObject<TModel> data);
	}
}
