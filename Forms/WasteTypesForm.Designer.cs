namespace dmyo_oop_final_assigment.Forms
{
	partial class WasteTypesForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.wt_panel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// wt_panel
			// 
			this.wt_panel.AutoScroll = true;
			this.wt_panel.AutoScrollMargin = new System.Drawing.Size(0, 10);
			this.wt_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wt_panel.Location = new System.Drawing.Point(0, 0);
			this.wt_panel.Name = "wt_panel";
			this.wt_panel.Size = new System.Drawing.Size(350, 362);
			this.wt_panel.TabIndex = 0;
			// 
			// WasteTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 362);
			this.Controls.Add(this.wt_panel);
			this.Name = "WasteTypesForm";
			this.Text = "Waste Types";
			this.Load += new System.EventHandler(this.WasteTypesForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel wt_panel;
	}
}