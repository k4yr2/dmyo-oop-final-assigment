using dmyo_oop_final_assigment.Forms;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerIdle : UserControl
    {
        private RecyclerForm m_form;

        public RecyclerIdle(RecyclerForm form)
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

        private void storingButton_Click(object sender, System.EventArgs e)
        {
            Form.Status = RecyclerStatus.Storing;
        }
    }
}