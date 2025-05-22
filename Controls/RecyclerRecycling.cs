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

            m_form.FormClosing += (s, e) =>
            {
                Save();
            };
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
                Panel.Controls.Add(new RecyclerRecyclingItem(this, Source, product));
            }
        }

        public void Save()
        {
            foreach (var item in Panel.Controls)
            {
                if (item is RecyclerRecyclingItem recyclingItem)
                {
                    var product = recyclingItem.Source;
                    TableManager.WasteProduct.Update(product.Id, product.Model);
                }
            }
        }

        private void completeButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to complete the recycling?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (TableManager.WasteRecycling.Complete(Form.Person.Id))
                {
                    Form.Status = RecyclerStatus.Idle;
                }
                else
                {
                    MessageBox.Show("Failed to complete recycling", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}