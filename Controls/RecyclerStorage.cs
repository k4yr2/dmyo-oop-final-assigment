using dmyo_oop_final_assigment.Forms;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerStorage : UserControl
    {
        private RecyclerForm m_form;

        public RecyclerStorage(RecyclerForm form)
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
    }
}