using dmyo_oop_final_assigment.Controls;
using System.Drawing;

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
			this.button1 = new System.Windows.Forms.Button();
			this.panel_statusbar = new System.Windows.Forms.Panel();
			this.dmyoPanel = new System.Windows.Forms.Panel();
			this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panel_banner.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_banner
			// 
			this.panel_banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.panel_banner.Controls.Add(this.button1);
			this.panel_banner.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_banner.Location = new System.Drawing.Point(0, 0);
			this.panel_banner.Name = "panel_banner";
			this.panel_banner.Size = new System.Drawing.Size(800, 40);
			this.panel_banner.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(74, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(2, 2);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panel_statusbar
			// 
			this.panel_statusbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
			this.panel_statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_statusbar.Location = new System.Drawing.Point(0, 360);
			this.panel_statusbar.Name = "panel_statusbar";
			this.panel_statusbar.Size = new System.Drawing.Size(800, 40);
			this.panel_statusbar.TabIndex = 2;
			// 
			// dmyoPanel
			// 
			this.dmyoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
			this.dmyoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dmyoPanel.Location = new System.Drawing.Point(0, 40);
			this.dmyoPanel.Margin = new System.Windows.Forms.Padding(20);
			this.dmyoPanel.Name = "dmyoPanel";
			this.dmyoPanel.Size = new System.Drawing.Size(800, 320);
			this.dmyoPanel.TabIndex = 4;
			// 
			// sidebarPanel
			// 
			this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.sidebarPanel.Location = new System.Drawing.Point(0, 40);
			this.sidebarPanel.Name = "sidebarPanel";
			this.sidebarPanel.Size = new System.Drawing.Size(200, 320);
			this.sidebarPanel.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.sidebarPanel);
			this.Controls.Add(this.dmyoPanel);
			this.Controls.Add(this.panel_statusbar);
			this.Controls.Add(this.panel_banner);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel_banner.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_banner;
		private System.Windows.Forms.Panel panel_statusbar;
		private System.Windows.Forms.Panel dmyoPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
	}
}