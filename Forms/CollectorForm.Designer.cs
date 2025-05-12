namespace dmyo_oop_final_assigment.Forms
{
	partial class CollectorForm
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
			this.selectionPanel = new System.Windows.Forms.Panel();
			this.newButton = new System.Windows.Forms.Button();
			this.selectionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectionPanel
			// 
			this.selectionPanel.Controls.Add(this.newButton);
			this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.selectionPanel.Location = new System.Drawing.Point(0, 0);
			this.selectionPanel.Name = "selectionPanel";
			this.selectionPanel.Size = new System.Drawing.Size(800, 40);
			this.selectionPanel.TabIndex = 0;
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(5, 5);
			this.newButton.Margin = new System.Windows.Forms.Padding(5);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(120, 30);
			this.newButton.TabIndex = 1;
			this.newButton.Text = "New Collection";
			this.newButton.UseVisualStyleBackColor = true;
			// 
			// CollectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.selectionPanel);
			this.Name = "CollectorForm";
			this.Text = "CollectorForm";
			this.selectionPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel selectionPanel;
		private System.Windows.Forms.Button newButton;
	}
}