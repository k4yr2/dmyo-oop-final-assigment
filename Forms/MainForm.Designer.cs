namespace dmyo_oop_final_assigment.Forms
{
	partial class MainForm
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
			this.panel_top = new System.Windows.Forms.Panel();
			this.panel_bottom = new System.Windows.Forms.Panel();
			this.panel_left = new System.Windows.Forms.Panel();
			this.panel_content = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panel_top
			// 
			this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_top.Location = new System.Drawing.Point(0, 0);
			this.panel_top.Name = "panel_top";
			this.panel_top.Size = new System.Drawing.Size(800, 60);
			this.panel_top.TabIndex = 1;
			// 
			// panel_bottom
			// 
			this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_bottom.Location = new System.Drawing.Point(0, 361);
			this.panel_bottom.Name = "panel_bottom";
			this.panel_bottom.Size = new System.Drawing.Size(800, 40);
			this.panel_bottom.TabIndex = 2;
			// 
			// panel_left
			// 
			this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_left.Location = new System.Drawing.Point(0, 60);
			this.panel_left.Name = "panel_left";
			this.panel_left.Size = new System.Drawing.Size(200, 301);
			this.panel_left.TabIndex = 3;
			// 
			// panel_content
			// 
			this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_content.Location = new System.Drawing.Point(200, 60);
			this.panel_content.Name = "panel_content";
			this.panel_content.Size = new System.Drawing.Size(600, 301);
			this.panel_content.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 401);
			this.Controls.Add(this.panel_content);
			this.Controls.Add(this.panel_left);
			this.Controls.Add(this.panel_bottom);
			this.Controls.Add(this.panel_top);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_top;
		private System.Windows.Forms.Panel panel_bottom;
		private System.Windows.Forms.Panel panel_left;
		private System.Windows.Forms.Panel panel_content;
	}
}