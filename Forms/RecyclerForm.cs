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
            switch (m_status)
            {
                case RecyclerStatus.Idle:
                default:
                    control = new RecyclerIdle(this);
                    break;
            }

            //control.Dock = DockStyle.Fill;
            //Controls.Clear();
            //Controls.Add(control);
        }
    }

    public enum RecyclerStatus
    {
        Idle = 0
    }
}
