namespace dmyo_oop_final_assigment.Controls
{
	partial class DMYONav
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
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label.Size = new System.Drawing.Size(90, 30);
			this.label.TabIndex = 0;
			this.label.Text = "label1";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DMYONav
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.label);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(90, 30);
			this.Name = "DMYONav";
			this.Size = new System.Drawing.Size(90, 30);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label;
	}
}
