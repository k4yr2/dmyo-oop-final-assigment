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
	public partial class PagebarControl : UserControl
	{
		private int m_current = 0;

		private int m_count = 0;

		public event Action OnSet;

		public PagebarControl()
		{
			InitializeComponent();
			Set(1, 1);
		}


		public int Current
		{
			get => m_current;
			set => Set(value, m_count);
		}

		public int Count
		{
			get => m_count;
			set => Set(m_current, value);
		}


		private void PagebarControl_Resize(object sender, EventArgs e)
		{
			pg_label.Anchor = AnchorStyles.None;
			pg_label.Left = (Width - pg_label.Width) / 2;
			pg_label.Top = (Height - pg_label.Height) / 2;
		}

		public void Set(int current, int count)
		{
			count = Math.Max(count, 1);
			current = Math.Max(current, 1);
			current = Math.Min(current, count);

			if (m_current != current || m_count != count)
			{
				pg_label.Text = $"{m_current = current} / {m_count = count}";

				if(m_current == 1)
				{
					pg_first.Enabled = false;
					pg_previous.Enabled = false;
				}
				else
				{
					pg_first.Enabled = true;
					pg_previous.Enabled = true;
				}

				if(m_current == m_count)
				{
					pg_next.Enabled = false;
					pg_last.Enabled = false;
				}
				else
				{
					pg_next.Enabled = true;
					pg_last.Enabled = true;
				}

				OnSet?.Invoke();
			}
		}

		private void pg_first_Click(object sender, EventArgs e)
		{
			Set(1, m_count);
		}

		private void pg_previous_Click(object sender, EventArgs e)
		{
			Set(m_current - 1, m_count);
		}

		private void pg_next_Click(object sender, EventArgs e)
		{
			Set(m_current + 1, m_count);
		}

		private void pg_last_Click(object sender, EventArgs e)
		{
			Set(m_count, m_count);
		}
	}
}
