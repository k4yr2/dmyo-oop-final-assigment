using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
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

        public FlowLayoutPanel Panel
        {
            get
            {
                return contentContainer1.Panel;
            }
        }


        public override void Refresh()
        {
            base.Refresh();

            Panel.Controls.Clear();
            foreach (var heap in TableManager.WasteHeap.OfFactory(Form.Person.Model.Factory.Value))
            {
                if(heap.Model.Quantity > 0)
                    Panel.Controls.Add(new RecyclerStorageItem(this, heap));
            }
        }

        private void idleButton_Click(object sender, System.EventArgs e)
        {
            Form.Status = RecyclerStatus.Idle;
        }

        private void recycleButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the collection?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (TableManager.WasteRecycling.Init(Form.Person.Id) != null)
                {
                    Form.Status = RecyclerStatus.Recycling;
                }
                else
                {
                    MessageBox.Show("Failed to start recycling", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}