namespace dmyo_oop_final_assigment.Controls
{
	partial class PagebarControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pg_first = new System.Windows.Forms.Button();
			this.pg_previous = new System.Windows.Forms.Button();
			this.pg_label = new System.Windows.Forms.Label();
			this.pg_next = new System.Windows.Forms.Button();
			this.pg_last = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pg_first
			// 
			this.pg_first.Location = new System.Drawing.Point(5, 3);
			this.pg_first.Name = "pg_first";
			this.pg_first.Size = new System.Drawing.Size(35, 25);
			this.pg_first.TabIndex = 0;
			this.pg_first.Text = "<<";
			this.pg_first.UseVisualStyleBackColor = true;
			this.pg_first.Click += new System.EventHandler(this.pg_first_Click);
			// 
			// pg_previous
			// 
			this.pg_previous.Location = new System.Drawing.Point(46, 3);
			this.pg_previous.Name = "pg_previous";
			this.pg_previous.Size = new System.Drawing.Size(35, 25);
			this.pg_previous.TabIndex = 0;
			this.pg_previous.Text = "<";
			this.pg_previous.UseVisualStyleBackColor = true;
			this.pg_previous.Click += new System.EventHandler(this.pg_previous_Click);
			// 
			// pg_label
			// 
			this.pg_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pg_label.AutoSize = true;
			this.pg_label.Location = new System.Drawing.Point(87, 9);
			this.pg_label.Name = "pg_label";
			this.pg_label.Size = new System.Drawing.Size(24, 13);
			this.pg_label.TabIndex = 1;
			this.pg_label.Text = "1/1";
			// 
			// pg_next
			// 
			this.pg_next.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pg_next.Location = new System.Drawing.Point(118, 3);
			this.pg_next.Name = "pg_next";
			this.pg_next.Size = new System.Drawing.Size(35, 25);
			this.pg_next.TabIndex = 0;
			this.pg_next.Text = ">";
			this.pg_next.UseVisualStyleBackColor = true;
			this.pg_next.Click += new System.EventHandler(this.pg_next_Click);
			// 
			// pg_last
			// 
			this.pg_last.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pg_last.Location = new System.Drawing.Point(159, 3);
			this.pg_last.Name = "pg_last";
			this.pg_last.Size = new System.Drawing.Size(35, 25);
			this.pg_last.TabIndex = 0;
			this.pg_last.Text = ">>";
			this.pg_last.UseVisualStyleBackColor = true;
			this.pg_last.Click += new System.EventHandler(this.pg_last_Click);
			// 
			// PagebarControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pg_label);
			this.Controls.Add(this.pg_last);
			this.Controls.Add(this.pg_next);
			this.Controls.Add(this.pg_previous);
			this.Controls.Add(this.pg_first);
			this.Name = "PagebarControl";
			this.Size = new System.Drawing.Size(199, 30);
			this.Resize += new System.EventHandler(this.PagebarControl_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button pg_first;
		private System.Windows.Forms.Button pg_previous;
		private System.Windows.Forms.Label pg_label;
		private System.Windows.Forms.Button pg_next;
		private System.Windows.Forms.Button pg_last;
	}
}
