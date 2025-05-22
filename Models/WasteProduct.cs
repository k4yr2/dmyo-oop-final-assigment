namespace dmyo_oop_final_assigment.Models
{
	public class WasteProduct
	{
		private int m_recycle;

        private int m_type;

        private decimal m_quantity;

		public WasteProduct()
		{

		}


		public int Recycle
		{
			get
			{
				return m_recycle;
			}
			set
			{
				m_recycle = value;
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