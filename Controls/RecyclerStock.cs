﻿using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
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

        private DMYOData<WasteDistribution> m_distribution;

        private DMYOData<WasteCollection> m_collection;

        private DMYOData<Person> m_person;


        public RecyclerStock(RecyclerForm form) : this(form, null)
        {

        }

        public RecyclerStock(RecyclerForm form, DMYOData<WasteStock> source)
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

        public DMYOData<WasteStock> Source
        {
            get
            {
                return m_source;
            }
        }

        public FlowLayoutPanel Panel
        {
            get
            {
                return contentContainer.Panel;
            }
        }


        public void Bind(DMYOData<WasteStock> source)
        {
            m_source = source;
            if(m_source == null)
            {
                m_distribution = null;
                m_collection = null;
                m_person = null;
            }
            else
            {
                m_distribution = TableManager.WasteDistribution.Read(m_source.Model.Distribution);
                m_collection = TableManager.WasteCollection.Read(m_distribution.Model.Collection);
                m_person = TableManager.Person.Read(m_collection.Model.Person);
            }

            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();
            stockLabel.Text = m_person?.Model.Name ?? "0";

            Panel.Controls.Clear();
            foreach (var receipt in TableManager.WasteReceipt.GetReceipts(Source.Id))
            {
                Panel.Controls.Add(new RecyclerStockItem(this, Source, receipt));
            }
        }

        public void Save()
        {
            foreach (var item in Panel.Controls.OfType<RecyclerStockItem>())
            {
                var receipt = item.Source;
                TableManager.WasteReceipt.Update(receipt.Id, receipt.Model);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the stock?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Save();

                if (TableManager.WasteStock.Cancel(Form.Person.Id))
                {
                    Form.Status = RecyclerStatus.Idle;
                }
                else
                {
                    MessageBox.Show("Failed to cancel the collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to complete the stock?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Save();

                if (TableManager.WasteStock.Complete(Form.Person.Id))
                {
                    Form.Status = RecyclerStatus.Idle;
                }
                else
                {
                    MessageBox.Show("Failed to complete the collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
