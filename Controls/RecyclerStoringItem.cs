using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerStoringItem : UserControl, IDataLink<WasteDistribution>
    {
        private RecyclerStoring m_host;

        private DMYOData<WasteDistribution> m_source;

        public RecyclerStoringItem(RecyclerStoring host) : this(host, null)
        {

        }

        public RecyclerStoringItem(RecyclerStoring host, DMYOData<WasteDistribution> source)
        {
            InitializeComponent();

            m_host = host;
            Bind(source);
        }


        public RecyclerStoring Host
        {
            get
            {
                return m_host;
            }
        }

        public DMYOData<WasteDistribution> Source
        {
            get
            {
                return m_source;
            }
        }


        public void Bind(DMYOData<WasteDistribution> data)
        {

        }
    }
}