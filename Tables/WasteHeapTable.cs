using dmyo_oop_final_assigment.Models;
using System.Data.SqlClient;

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
    }
}
