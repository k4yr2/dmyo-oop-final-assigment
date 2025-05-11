using System.ComponentModel;

namespace dmyo_oop_final_assigment.Controls
{
	partial class DMYONavSub
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
			this.bodyPanel = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.subPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.bodyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bodyPanel
			// 
			this.bodyPanel.Controls.Add(this.label);
			this.bodyPanel.Controls.Add(this.button);
			this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.bodyPanel.Location = new System.Drawing.Point(0, 0);
			this.bodyPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bodyPanel.Name = "bodyPanel";
			this.bodyPanel.Size = new System.Drawing.Size(90, 30);
			this.bodyPanel.TabIndex = 0;
			// 
			// label
			// 
			this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label.Location = new System.Drawing.Point(30, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(60, 30);
			this.label.TabIndex = 2;
			this.label.Text = "label1";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button
			// 
			this.button.FlatAppearance.BorderSize = 0;
			this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button.Location = new System.Drawing.Point(5, 5);
			this.button.Margin = new System.Windows.Forms.Padding(5);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(20, 20);
			this.button.TabIndex = 1;
			this.button.Text = ">";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// subPanel
			// 
			this.subPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.subPanel.AutoSize = true;
			this.subPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.subPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.subPanel.Location = new System.Drawing.Point(30, 30);
			this.subPanel.Margin = new System.Windows.Forms.Padding(0);
			this.subPanel.Name = "subPanel";
			this.subPanel.Size = new System.Drawing.Size(0, 0);
			this.subPanel.TabIndex = 1;
			this.subPanel.WrapContents = false;
			// 
			// DMYONavSub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.Controls.Add(this.subPanel);
			this.Controls.Add(this.bodyPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(90, 30);
			this.Name = "DMYONavSub";
			this.Size = new System.Drawing.Size(90, 30);
			this.Resize += new System.EventHandler(this.DMYONavSub_Resize);
			this.ParentChanged += new System.EventHandler(this.DMYONavSub_ParentChanged);
			this.bodyPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel bodyPanel;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.FlowLayoutPanel subPanel;
	}
}
