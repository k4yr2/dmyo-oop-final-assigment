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
			this.contentPanel = new System.Windows.Forms.Panel();
			this.dataPanel = new System.Windows.Forms.Panel();
			this.collectingControl = new dmyo_oop_final_assigment.Controls.WasteCollectionControl();
			this.managePanel = new System.Windows.Forms.Panel();
			this.addButton = new System.Windows.Forms.Button();
			this.completeButton = new System.Windows.Forms.Button();
			this.selectionPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.dataPanel.SuspendLayout();
			this.managePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectionPanel
			// 
			this.selectionPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
			// contentPanel
			// 
			this.contentPanel.Controls.Add(this.dataPanel);
			this.contentPanel.Controls.Add(this.managePanel);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 40);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(800, 410);
			this.contentPanel.TabIndex = 1;
			// 
			// dataPanel
			// 
			this.dataPanel.Controls.Add(this.collectingControl);
			this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataPanel.Location = new System.Drawing.Point(0, 40);
			this.dataPanel.Name = "dataPanel";
			this.dataPanel.Size = new System.Drawing.Size(800, 370);
			this.dataPanel.TabIndex = 1;
			// 
			// collectingControl
			// 
			this.collectingControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectingControl.Location = new System.Drawing.Point(0, 0);
			this.collectingControl.Name = "collectingControl";
			this.collectingControl.Size = new System.Drawing.Size(800, 370);
			this.collectingControl.TabIndex = 0;
			// 
			// managePanel
			// 
			this.managePanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.managePanel.Controls.Add(this.addButton);
			this.managePanel.Controls.Add(this.completeButton);
			this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.managePanel.Location = new System.Drawing.Point(0, 0);
			this.managePanel.Name = "managePanel";
			this.managePanel.Size = new System.Drawing.Size(800, 40);
			this.managePanel.TabIndex = 0;
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
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
			this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
			// 
			// CollectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.selectionPanel);
			this.Name = "CollectorForm";
			this.Text = "CollectorForm";
			this.Load += new System.EventHandler(this.CollectorForm_Load);
			this.selectionPanel.ResumeLayout(false);
			this.contentPanel.ResumeLayout(false);
			this.dataPanel.ResumeLayout(false);
			this.managePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel selectionPanel;
		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Panel managePanel;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button completeButton;
		private System.Windows.Forms.Panel dataPanel;
		private Controls.WasteCollectionControl collectingControl;
	}
}