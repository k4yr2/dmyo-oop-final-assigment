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
			this.panel_banner = new System.Windows.Forms.Panel();
			this.panel_statusbar = new System.Windows.Forms.Panel();
			this.panel_sidebar = new System.Windows.Forms.Panel();
			this.panel_content = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panel_banner
			// 
			this.panel_banner.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_banner.Location = new System.Drawing.Point(0, 0);
			this.panel_banner.Name = "panel_banner";
			this.panel_banner.Size = new System.Drawing.Size(800, 40);
			this.panel_banner.TabIndex = 1;
			// 
			// panel_statusbar
			// 
			this.panel_statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_statusbar.Location = new System.Drawing.Point(0, 360);
			this.panel_statusbar.Name = "panel_statusbar";
			this.panel_statusbar.Size = new System.Drawing.Size(800, 40);
			this.panel_statusbar.TabIndex = 2;
			// 
			// panel_sidebar
			// 
			this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_sidebar.Location = new System.Drawing.Point(0, 40);
			this.panel_sidebar.Name = "panel_sidebar";
			this.panel_sidebar.Size = new System.Drawing.Size(200, 320);
			this.panel_sidebar.TabIndex = 3;
			// 
			// panel_content
			// 
			this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_content.Location = new System.Drawing.Point(200, 40);
			this.panel_content.Name = "panel_content";
			this.panel_content.Size = new System.Drawing.Size(600, 320);
			this.panel_content.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.panel_content);
			this.Controls.Add(this.panel_sidebar);
			this.Controls.Add(this.panel_statusbar);
			this.Controls.Add(this.panel_banner);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_banner;
		private System.Windows.Forms.Panel panel_statusbar;
		private System.Windows.Forms.Panel panel_sidebar;
		private System.Windows.Forms.Panel panel_content;
	}
}