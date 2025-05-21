using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dmyo_oop_final_assigment.Controls
{
    public partial class RecyclerStock : UserControl, IDataLink<WasteStock>
    {
        private RecyclerForm m_form;

        private DMYOData<WasteStock> m_source;


        public RecyclerStock(RecyclerForm form) : this(form, null)
        {

        }

        public RecyclerStock(RecyclerForm form, DMYOData<WasteStock> source)
        {
            InitializeComponent();
            m_form = form;

            Bind(source);
        }


        public RecyclerForm Form
        {
            get
            {
                return m_form;
            }
        }

        public DMYOData<WasteStock> Source
        {
            get
            {
                return m_source;
            }
        }


        public void Bind(DMYOData<WasteStock> source)
        {
            m_source = source;
            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

        }
    }
}
