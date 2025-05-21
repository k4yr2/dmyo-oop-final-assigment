using dmyo_oop_final_assigment.Forms;
using dmyo_oop_final_assigment.Managers;
using dmyo_oop_final_assigment.Models;
using dmyo_oop_final_assigment.Providers;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dmyo_oop_final_assigment.Controls
{
	public partial class CollectorDistribution : UserControl, IDataLink<WasteCollection>
	{
		private CollectorForm m_form;

		private DMYOData<WasteCollection> m_source;

		private DMYOData<WasteDistribution>[] m_distributions;

		private int m_index = 0;

		public CollectorDistribution(CollectorForm form, DMYOData<WasteCollection> source)
		{
			InitializeComponent();

			m_form = form;
			Bind(source);

			m_form.FormClosing += (s, e) =>
			{
				Save();
			};
		}


		public CollectorForm Form
		{
			get
			{
				return m_form;
			}
		}

		public DMYOData<WasteCollection> Source
		{
			get
			{
				return m_source;
			}
		}

		public DMYOData<WasteDistribution>[] Distributions
		{
			get
			{
				return m_distributions;
			}
		}

		public FlowLayoutPanel Panel
		{
			get
			{
				return contentContainer.Panel;
			}
		}

		public int Index
		{
			get
			{
				return m_index;
			}
			set
			{
				m_index = value;
				RefreshPage();
			}
		}	


		public void Bind(DMYOData<WasteCollection> source)
		{
			m_source = source;
			Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();
			Panel.Controls.Clear();

			factoryBox.DataSource = TableManager.Factory.Select().ToList();
			factoryBox.DisplayMember = "Display";
			factoryBox.ValueMember = "Id";
            factoryBox.SelectedItem = null;

            if (m_source == null)
			{
				m_distributions = Array.Empty<DMYOData<WasteDistribution>>();
			}
			else
			{
				var distributions = TableManager.WasteDistribution.GetDistributions(m_source.Id).ToList();

				if(distributions.Count == 0 || distributions.Last().Model.Status == WasteStatus.Completed)
				{
					distributions.Add(TableManager.WasteDistribution.GetInstance(m_source.Id));
					m_index = distributions.Count - 1;
				}

				m_distributions = distributions.ToArray();
				RefreshPage();
			}
		}

		public void RefreshPage()
		{
			Panel.Controls.Clear();
			var distribution = Distributions[Index];

			pageLabel.Text = $"Page {Index + 1} of {Distributions.Length}";

			foreach (var type in TableManager.WasteDispatch.Select($"where distribution = {distribution.Id}"))
			{
				Panel.Controls.Add(new CollectorDistributionItem(this, distribution, type));
			}

			if(distribution.Model.Status == WasteStatus.Active)
			{
				sendButton.Enabled = true;
				factoryBox.Enabled = true;

                factoryBox.SelectedItem = null;
            }
            else
			{
				sendButton.Enabled = false;
				factoryBox.Enabled = false;

				if(!Form.Person.Model.Factory.HasValue)
				{
					factoryBox.Text = "BLANK";
                }
            }
		}

		public void Save()
		{
            var distribution = Distributions[Index] ?? null;

            if (distribution != null && distribution.Model.Status == WasteStatus.Active)
			{
				distribution.Model.Factory = factoryBox.SelectedItem == null ? (int?)null : ((DMYOData<Factory>)factoryBox.SelectedItem).Id;
                TableManager.WasteDistribution.Update(distribution.Id, distribution.Model);
            }

            foreach (var item in Panel.Controls.OfType<CollectorDistributionItem>())
			{
                TableManager.WasteDispatch.Update(item.Source.Id, item.Source.Model);
            }
		}

		private void firstButton_Click(object sender, EventArgs e)
		{
			Index = 0;
		}

		private void previousButton_Click(object sender, EventArgs e)
		{
			Index = Math.Max(0, Index - 1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Index = Math.Min(Distributions.Length - 1, Index + 1);
		}

		private void lastButton_Click(object sender, EventArgs e)
		{
			Index = Distributions.Length - 1;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to cancel the collection?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				TableManager.WasteCollection.Cancel(Form.Person.Id);
				Form.Status = CollectorStatus.Idle;
			}
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to send the distribution?", "Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Save();

                if (TableManager.WasteDistribution.Send(m_source.Id))
				{
                    Refresh();
                }
            }
		}
	}
}
