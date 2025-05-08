using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmyo_oop_final_assigment.Models
{
	public class WasteType : BaseModel
	{
		public WasteType(int id, string name, string description) : base(id)
		{
			Name = name;
			Description = description;
		}

		public string Name { get; }

		public string Description { get; }
	}	
}
