using dmyo_oop_final_assigment.Controls;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Forms
{
    public partial class RecyclerForm : Form
    {
        private DMYOData<Person> m_person;

        private RecyclerStatus m_status;

        public RecyclerForm() : this(null)
        {

        }

        public RecyclerForm(DMYOData<Person> person)
        {
            InitializeComponent();

            m_person = person;
            m_status = RecyclerStatus.Idle;
            Refresh();
        }


        public DMYOData<Person> Person
        {
            get
            {
                return m_person;
            }
        }

        public RecyclerStatus Status
        {
            get
            {
                return m_status;
            }
            set
            {
                if (m_status != value)
                {
                    m_status = value;
                    Refresh();
                }
            }
        }


        public override void Refresh()
        {
            base.Refresh();

            UserControl control;

            var stock = TableManager.WasteStock.GetCurrent(Person.Id);
            var recycling = TableManager.WasteRecycling.GetCurrent(Person.Id);

            if (recycling != null)
            {
                m_status = RecyclerStatus.Recycling;
            }
            else if (stock != null)
            {
                m_status = RecyclerStatus.Stock;
            }

            var status = m_status;
            switch (m_status)
            {
                case RecyclerStatus.Storing:
                    control = new RecyclerStoring(this);
                    break;
                case RecyclerStatus.Stock:
                    control = new RecyclerStock(this, stock);
                    break;
                case RecyclerStatus.Storage:
                    control = new RecyclerStorage(this);
                    break;
                case RecyclerStatus.Recycling:
                    control = new RecyclerRecycling(this, recycling);
                    break;
                case RecyclerStatus.Idle:
                default:
                    control = new RecyclerIdle(this);
                    break;
            }

            if(status == m_status)
            {
                control.Dock = DockStyle.Fill;
                Controls.Clear();
                Controls.Add(control);
            }
        }
    }

    public enum RecyclerStatus
    {
        Idle = 0,
        Storing = 1,
        Stock = 2,
        Storage = 3,
        Recycling = 4,
    }
}