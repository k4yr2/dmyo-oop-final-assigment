using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public abstract class BaseModel
	{
		public BaseModel(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
