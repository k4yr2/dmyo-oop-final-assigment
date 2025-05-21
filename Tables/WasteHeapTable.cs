using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace dmyo_oop_final_assigment.Tables
{
    internal class WasteHeapTable : DMYOTable<WasteHeap>
    {
        public override string Name => "WasteHeap";

        public override string[] Params => new string[] { "factory", "type", "quantity" };


        public override void SetParameters(WasteHeap heap, SqlCommand command)
        {
            command.Parameters.AddWithValue("@factory", heap.Factory);
            command.Parameters.AddWithValue("@type", heap.Type);
            command.Parameters.AddWithValue("@quantity", heap.Quantity);

        }

        public override WasteHeap GetModel(SqlDataReader reader)
        {
            return new WasteHeap()
            {
                Factory = reader.GetInt32(1),
                Type = reader.GetInt32(2),
                Quantity = reader.GetDecimal(3),
            };
        }

        public IEnumerable<DMYOData<WasteHeap>> OfFactory(int factory)
        {
            foreach (var type in TableManager.WasteType.Select())
            {
                yield return Fetch(factory, type.Id);
            }
        }

        public DMYOData<WasteHeap> Fetch(int factory, int type)
        {
            var heap = Select($"where factory = {factory} and type = {type}").FirstOrDefault();

            if (heap == null)
            {
                heap = Create(new WasteHeap()
                {
                    Factory = factory,
                    Type = type,
                    Quantity = 0
                });
            }

            return heap;
        }
    }
}
