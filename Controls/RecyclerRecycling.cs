using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerRecycling : UserControl
    {
        private RecyclerForm m_form;

        public RecyclerRecycling(RecyclerForm form)
        {
            InitializeComponent();
            m_form = form;

            Refresh();
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


        public override void Refresh()
        {
            base.Refresh();

            Panel.Controls.Clear();
        }
    }
}