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
			this.panel_content = new System.Windows.Forms.Panel();
			this.panel_sidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.dmyoTab = new System.Windows.Forms.TabControl();
			this.tab_wasteTypes = new System.Windows.Forms.TabPage();
			this.tab_wasteCategories = new System.Windows.Forms.TabPage();
			this.grid_wasteTypes = new dmyo_oop_final_assigment.Controls.DMYOGridControl();
			this.dmyoNavSub1 = new dmyo_oop_final_assigment.Controls.DMYONavSub();
			this.button_wasteTypes = new System.Windows.Forms.Button();
			this.button_wasteCategories = new System.Windows.Forms.Button();
			this.grid_wasteCategories = new dmyo_oop_final_assigment.Controls.DMYOGridControl();
			this.panel_banner.SuspendLayout();
			this.dmyoPanel.SuspendLayout();
			this.panel_content.SuspendLayout();
			this.panel_sidebar.SuspendLayout();
			this.dmyoTab.SuspendLayout();
			this.tab_wasteTypes.SuspendLayout();
			this.tab_wasteCategories.SuspendLayout();
			this.dmyoNavSub1.SubPanel.SuspendLayout();
			this.dmyoNavSub1.SuspendLayout();
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
			this.dmyoPanel.Controls.Add(this.panel_content);
			this.dmyoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dmyoPanel.Location = new System.Drawing.Point(0, 40);
			this.dmyoPanel.Margin = new System.Windows.Forms.Padding(20);
			this.dmyoPanel.Name = "dmyoPanel";
			this.dmyoPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.dmyoPanel.Size = new System.Drawing.Size(800, 320);
			this.dmyoPanel.TabIndex = 4;
			// 
			// panel_content
			// 
			this.panel_content.Controls.Add(this.dmyoTab);
			this.panel_content.Controls.Add(this.panel_sidebar);
			this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_content.Location = new System.Drawing.Point(5, 0);
			this.panel_content.Name = "panel_content";
			this.panel_content.Size = new System.Drawing.Size(795, 320);
			this.panel_content.TabIndex = 0;
			// 
			// panel_sidebar
			// 
			this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.panel_sidebar.Controls.Add(this.dmyoNavSub1);
			this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
			this.panel_sidebar.Name = "panel_sidebar";
			this.panel_sidebar.Size = new System.Drawing.Size(200, 320);
			this.panel_sidebar.TabIndex = 2;
			// 
			// dmyoTab
			// 
			this.dmyoTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.dmyoTab.Controls.Add(this.tab_wasteTypes);
			this.dmyoTab.Controls.Add(this.tab_wasteCategories);
			this.dmyoTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dmyoTab.Location = new System.Drawing.Point(200, 0);
			this.dmyoTab.Margin = new System.Windows.Forms.Padding(0);
			this.dmyoTab.Multiline = true;
			this.dmyoTab.Name = "dmyoTab";
			this.dmyoTab.SelectedIndex = 0;
			this.dmyoTab.Size = new System.Drawing.Size(595, 320);
			this.dmyoTab.TabIndex = 3;
			// 
			// tab_wasteTypes
			// 
			this.tab_wasteTypes.Controls.Add(this.grid_wasteTypes);
			this.tab_wasteTypes.Location = new System.Drawing.Point(4, 4);
			this.tab_wasteTypes.Name = "tab_wasteTypes";
			this.tab_wasteTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tab_wasteTypes.Size = new System.Drawing.Size(587, 294);
			this.tab_wasteTypes.TabIndex = 0;
			this.tab_wasteTypes.Text = "types";
			this.tab_wasteTypes.UseVisualStyleBackColor = true;
			// 
			// tab_wasteCategories
			// 
			this.tab_wasteCategories.Controls.Add(this.grid_wasteCategories);
			this.tab_wasteCategories.Location = new System.Drawing.Point(4, 4);
			this.tab_wasteCategories.Name = "tab_wasteCategories";
			this.tab_wasteCategories.Padding = new System.Windows.Forms.Padding(3);
			this.tab_wasteCategories.Size = new System.Drawing.Size(587, 294);
			this.tab_wasteCategories.TabIndex = 1;
			this.tab_wasteCategories.Text = "categories";
			this.tab_wasteCategories.UseVisualStyleBackColor = true;
			// 
			// grid_wasteTypes
			// 
			this.grid_wasteTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_wasteTypes.Location = new System.Drawing.Point(3, 3);
			this.grid_wasteTypes.Name = "grid_wasteTypes";
			this.grid_wasteTypes.Size = new System.Drawing.Size(581, 288);
			this.grid_wasteTypes.TabIndex = 0;
			// 
			// dmyoNavSub1
			// 
			this.dmyoNavSub1.BackColor = System.Drawing.SystemColors.Control;
			this.dmyoNavSub1.EnableSub = true;
			this.dmyoNavSub1.Location = new System.Drawing.Point(0, 0);
			this.dmyoNavSub1.Margin = new System.Windows.Forms.Padding(0);
			this.dmyoNavSub1.MinimumSize = new System.Drawing.Size(180, 30);
			this.dmyoNavSub1.Name = "dmyoNavSub1";
			this.dmyoNavSub1.Size = new System.Drawing.Size(200, 80);
			// 
			// dmyoNavSub1.SubPanel
			// 
			this.dmyoNavSub1.SubPanel.Controls.Add(this.button_wasteTypes);
			this.dmyoNavSub1.SubPanel.Controls.Add(this.button_wasteCategories);
			this.dmyoNavSub1.SubPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.dmyoNavSub1.SubPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.dmyoNavSub1.SubPanel.Location = new System.Drawing.Point(30, 30);
			this.dmyoNavSub1.SubPanel.Margin = new System.Windows.Forms.Padding(0);
			this.dmyoNavSub1.SubPanel.MinimumSize = new System.Drawing.Size(30, 30);
			this.dmyoNavSub1.SubPanel.Name = "SubPanel";
			this.dmyoNavSub1.SubPanel.Size = new System.Drawing.Size(170, 50);
			this.dmyoNavSub1.SubPanel.TabIndex = 1;
			this.dmyoNavSub1.SubPanel.WrapContents = false;
			this.dmyoNavSub1.TabIndex = 1;
			this.dmyoNavSub1.Title = "Waste";
			// 
			// button_wasteTypes
			// 
			this.button_wasteTypes.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_wasteTypes.FlatAppearance.BorderSize = 0;
			this.button_wasteTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_wasteTypes.Location = new System.Drawing.Point(0, 0);
			this.button_wasteTypes.Margin = new System.Windows.Forms.Padding(0);
			this.button_wasteTypes.Name = "button_wasteTypes";
			this.button_wasteTypes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.button_wasteTypes.Size = new System.Drawing.Size(170, 25);
			this.button_wasteTypes.TabIndex = 0;
			this.button_wasteTypes.Text = "Types";
			this.button_wasteTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_wasteTypes.UseVisualStyleBackColor = false;
			this.button_wasteTypes.Click += new System.EventHandler(this.button_wasteTypes_Click);
			// 
			// button_wasteCategories
			// 
			this.button_wasteCategories.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_wasteCategories.FlatAppearance.BorderSize = 0;
			this.button_wasteCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_wasteCategories.Location = new System.Drawing.Point(0, 25);
			this.button_wasteCategories.Margin = new System.Windows.Forms.Padding(0);
			this.button_wasteCategories.Name = "button_wasteCategories";
			this.button_wasteCategories.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.button_wasteCategories.Size = new System.Drawing.Size(170, 25);
			this.button_wasteCategories.TabIndex = 0;
			this.button_wasteCategories.Text = "Categories";
			this.button_wasteCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_wasteCategories.UseVisualStyleBackColor = false;
			this.button_wasteCategories.Click += new System.EventHandler(this.button_wasteCategories_Click);
			// 
			// grid_wasteCategories
			// 
			this.grid_wasteCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_wasteCategories.Location = new System.Drawing.Point(3, 3);
			this.grid_wasteCategories.Name = "grid_wasteCategories";
			this.grid_wasteCategories.Size = new System.Drawing.Size(581, 288);
			this.grid_wasteCategories.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.dmyoPanel);
			this.Controls.Add(this.panel_statusbar);
			this.Controls.Add(this.panel_banner);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panel_banner.ResumeLayout(false);
			this.dmyoPanel.ResumeLayout(false);
			this.panel_content.ResumeLayout(false);
			this.panel_sidebar.ResumeLayout(false);
			this.dmyoTab.ResumeLayout(false);
			this.tab_wasteTypes.ResumeLayout(false);
			this.tab_wasteCategories.ResumeLayout(false);
			this.dmyoNavSub1.SubPanel.ResumeLayout(false);
			this.dmyoNavSub1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_banner;
		private System.Windows.Forms.Panel panel_statusbar;
		private System.Windows.Forms.Panel dmyoPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel_content;
		private System.Windows.Forms.TabControl dmyoTab;
		private System.Windows.Forms.TabPage tab_wasteTypes;
		private System.Windows.Forms.TabPage tab_wasteCategories;
		private System.Windows.Forms.FlowLayoutPanel panel_sidebar;
		private DMYONavSub dmyoNavSub1;
		private System.Windows.Forms.Button button_wasteTypes;
		private System.Windows.Forms.Button button_wasteCategories;
		private DMYOGridControl grid_wasteTypes;
		private DMYOGridControl grid_wasteCategories;
	}
}