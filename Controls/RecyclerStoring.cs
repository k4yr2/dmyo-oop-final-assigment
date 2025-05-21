using dmyo_oop_final_assigment.Forms;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerStoring : UserControl
    {
        private RecyclerForm m_form;

        public RecyclerStoring(RecyclerForm form)
        {
            InitializeComponent();
            m_form = form;
        }


        public RecyclerForm Form
        {
            get
            {
                return m_form;
            }
        }

        public ContentContainer Panel
        {
            get
            {
                return contentContainer;
            }
        }


        public override void Refresh()
        {
            base.Refresh();

            Panel.Controls.Clear();
        }
    }
}