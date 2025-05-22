using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerRecycling : UserControl, IDataLink<WasteRecycling>
    {
        private RecyclerForm m_form;

        private DMYOData<WasteRecycling> m_source;

        public RecyclerRecycling(RecyclerForm form, DMYOData<WasteRecycling> source)
        {
            InitializeComponent();
            m_form = form;

            Bind(source);
        }


        public RecyclerForm Form
        {
            get
            {
                return m_form;
            }
        }

        public FlowLayoutPanel Panel
        {
            get
            {
                return contentContainer.Panel;
            }
        }

        public DMYOData<WasteRecycling> Source
        {
            get
            {
                return m_source;
            }
        }

        public void Bind(DMYOData<WasteRecycling> source)
        {
            m_source = source;
            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

            Panel.Controls.Clear();

            foreach (var product in TableManager.WasteProduct.GetProducts(m_source.Id))
            {
                //Panel.Controls.Add(new);
            }
        }
    }
}