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
			this.panel1 = new System.Windows.Forms.Panel();
			this.managePanel = new System.Windows.Forms.Panel();
			this.dataPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.completeButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.selectionPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.managePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectionPanel
			// 
			this.selectionPanel.CausesValidation = false;
			this.selectionPanel.Controls.Add(this.newButton);
			this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.selectionPanel.Location = new System.Drawing.Point(0, 0);
			this.selectionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.selectionPanel.Name = "selectionPanel";
			this.selectionPanel.Size = new System.Drawing.Size(800, 40);
			this.selectionPanel.TabIndex = 0;
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(5, 5);
			this.newButton.Margin = new System.Windows.Forms.Padding(5);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(140, 30);
			this.newButton.TabIndex = 1;
			this.newButton.Text = "New Collection";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataPanel);
			this.panel1.Controls.Add(this.managePanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 410);
			this.panel1.TabIndex = 1;
			// 
			// managePanel
			// 
			this.managePanel.Controls.Add(this.addButton);
			this.managePanel.Controls.Add(this.completeButton);
			this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.managePanel.Location = new System.Drawing.Point(0, 0);
			this.managePanel.Name = "managePanel";
			this.managePanel.Size = new System.Drawing.Size(798, 40);
			this.managePanel.TabIndex = 0;
			// 
			// dataPanel
			// 
			this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.dataPanel.Location = new System.Drawing.Point(0, 40);
			this.dataPanel.Name = "dataPanel";
			this.dataPanel.Size = new System.Drawing.Size(798, 368);
			this.dataPanel.TabIndex = 1;
			// 
			// completeButton
			// 
			this.completeButton.Location = new System.Drawing.Point(4, 5);
			this.completeButton.Margin = new System.Windows.Forms.Padding(5);
			this.completeButton.Name = "completeButton";
			this.completeButton.Size = new System.Drawing.Size(80, 30);
			this.completeButton.TabIndex = 1;
			this.completeButton.Text = "Complete";
			this.completeButton.UseVisualStyleBackColor = true;
			this.completeButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(94, 5);
			this.addButton.Margin = new System.Windows.Forms.Padding(5);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(50, 30);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// CollectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.selectionPanel);
			this.Name = "CollectorForm";
			this.Text = "CollectorForm";
			this.selectionPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.managePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel selectionPanel;
		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel dataPanel;
		private System.Windows.Forms.Panel managePanel;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button completeButton;
	}
}