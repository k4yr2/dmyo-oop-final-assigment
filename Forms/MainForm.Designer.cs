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
			this.panel_sidebar = new System.Windows.Forms.Panel();
			this.button_recycling = new System.Windows.Forms.Button();
			this.button_distribution = new System.Windows.Forms.Button();
			this.button_wastes = new System.Windows.Forms.Button();
			this.panel_content = new System.Windows.Forms.Panel();
			this.dmyoGrid = new dmyo_oop_final_assigment.Controls.DMYOGridControl();
			this.panel_banner.SuspendLayout();
			this.panel_sidebar.SuspendLayout();
			this.panel_content.SuspendLayout();
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
			// panel_sidebar
			// 
			this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.panel_sidebar.Controls.Add(this.button_recycling);
			this.panel_sidebar.Controls.Add(this.button_distribution);
			this.panel_sidebar.Controls.Add(this.button_wastes);
			this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_sidebar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.panel_sidebar.Location = new System.Drawing.Point(0, 40);
			this.panel_sidebar.Name = "panel_sidebar";
			this.panel_sidebar.Padding = new System.Windows.Forms.Padding(10);
			this.panel_sidebar.Size = new System.Drawing.Size(200, 320);
			this.panel_sidebar.TabIndex = 3;
			// 
			// button_recycling
			// 
			this.button_recycling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
			this.button_recycling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_recycling.Location = new System.Drawing.Point(19, 110);
			this.button_recycling.Margin = new System.Windows.Forms.Padding(10);
			this.button_recycling.Name = "button_recycling";
			this.button_recycling.Size = new System.Drawing.Size(160, 25);
			this.button_recycling.TabIndex = 0;
			this.button_recycling.Text = "Recycling ";
			this.button_recycling.UseVisualStyleBackColor = false;
			// 
			// button_distribution
			// 
			this.button_distribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
			this.button_distribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_distribution.Location = new System.Drawing.Point(19, 65);
			this.button_distribution.Margin = new System.Windows.Forms.Padding(10);
			this.button_distribution.Name = "button_distribution";
			this.button_distribution.Size = new System.Drawing.Size(160, 25);
			this.button_distribution.TabIndex = 0;
			this.button_distribution.Text = "Distribution";
			this.button_distribution.UseVisualStyleBackColor = false;
			this.button_distribution.Click += new System.EventHandler(this.button_distribution_Click);
			// 
			// button_wastes
			// 
			this.button_wastes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
			this.button_wastes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_wastes.Location = new System.Drawing.Point(20, 20);
			this.button_wastes.Margin = new System.Windows.Forms.Padding(10);
			this.button_wastes.Name = "button_wastes";
			this.button_wastes.Size = new System.Drawing.Size(160, 25);
			this.button_wastes.TabIndex = 0;
			this.button_wastes.Text = "Wastes";
			this.button_wastes.UseVisualStyleBackColor = false;
			this.button_wastes.Click += new System.EventHandler(this.button_wastes_Click);
			// 
			// panel_content
			// 
			this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
			this.panel_content.Controls.Add(this.dmyoGrid);
			this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_content.Location = new System.Drawing.Point(200, 40);
			this.panel_content.Margin = new System.Windows.Forms.Padding(20);
			this.panel_content.Name = "panel_content";
			this.panel_content.Size = new System.Drawing.Size(600, 320);
			this.panel_content.TabIndex = 4;
			// 
			// dmyoGrid
			// 
			this.dmyoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dmyoGrid.Location = new System.Drawing.Point(0, 0);
			this.dmyoGrid.Name = "dmyoGrid";
			this.dmyoGrid.Size = new System.Drawing.Size(600, 320);
			this.dmyoGrid.TabIndex = 0;
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
			this.panel_banner.ResumeLayout(false);
			this.panel_sidebar.ResumeLayout(false);
			this.panel_content.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_banner;
		private System.Windows.Forms.Panel panel_statusbar;
		private System.Windows.Forms.Panel panel_sidebar;
		private System.Windows.Forms.Panel panel_content;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button_wastes;
		private System.Windows.Forms.Button button_recycling;
		private System.Windows.Forms.Button button_distribution;
		private DMYOGridControl dmyoGrid;
	}
}