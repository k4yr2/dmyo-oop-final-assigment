using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
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

            Refresh();
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

            Panel.Panel.Controls.Clear();

            var factory = Form.Person.Model.Factory;
            if (factory.HasValue)
            {
                foreach (var distribution in TableManager.WasteDistribution.OfSubmitteds(factory.Value))
                {
                    Panel.Panel.Controls.Add(new RecyclerStoringItem(this, distribution));
                }
            }
        }

        private void idleButton_Click(object sender, System.EventArgs e)
        {
            Form.Status = RecyclerStatus.Idle;
        }
    }
}