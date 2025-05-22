namespace dmyo_oop_final_assigment.Models
{
    public class WasteHeap
    {
        public int m_factory;

        public int m_type;

        public decimal m_quantity;

        public WasteHeap()
        {

        }


        public int Factory
        {
            get
            {
                return m_factory;
            }
            set
            {
                m_factory = value;
            }
        }

        public int Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }

        public decimal Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
    }
}