using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerStoringItem : UserControl, IDataLink<WasteDistribution>
    {
        private RecyclerStoring m_host;

        private DMYOData<WasteDistribution> m_source;

        private DMYOData<WasteCollection> m_collection;

        private DMYOData<Person> m_person;

        public RecyclerStoringItem(RecyclerStoring host) : this(host, null)
        {

        }

        public RecyclerStoringItem(RecyclerStoring host, DMYOData<WasteDistribution> source)
        {
            InitializeComponent();

            m_host = host;
            Bind(source);
        }


        public RecyclerStoring Host
        {
            get
            {
                return m_host;
            }
        }

        public DMYOData<WasteDistribution> Source
        {
            get
            {
                return m_source;
            }
        }

        public DMYOData<WasteCollection> Collection
        {
            get
            {
                return m_collection;
            }
        }

        public DMYOData<Person> Person
        {
            get
            {
                return m_person;
            }
        }


        public void Bind(DMYOData<WasteDistribution> data)
        {
            m_source = data;

            if (m_source == null)
            {
                m_collection = null;
                m_person = null;
            }
            else
            {
                m_collection = TableManager.WasteCollection.Read(m_source.Model.Collection);
                m_person = TableManager.Person.Read(m_collection.Model.Person);
            }

            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

            dateLabel.Text = (m_source?.Model.Date ?? DateTime.MinValue).ToString("dd/MM/yyyy HH:mm");
            nameLabel.Text = m_person?.Model.Name ?? "Unknown";
        }
    }
}