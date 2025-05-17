namespace dmyo_oop_final_assigment.Pages
{
	partial class CollectorCollection
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
			this.topPanel = new System.Windows.Forms.Panel();
			this.collectionLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.addButton = new System.Windows.Forms.Button();
			this.completeButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.topPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.DarkGray;
			this.topPanel.Controls.Add(this.collectionLabel);
			this.topPanel.Controls.Add(this.cancelButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(600, 40);
			this.topPanel.TabIndex = 0;
			// 
			// collectionLabel
			// 
			this.collectionLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.collectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.collectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.collectionLabel.Location = new System.Drawing.Point(43, 8);
			this.collectionLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.collectionLabel.Name = "collectionLabel";
			this.collectionLabel.Size = new System.Drawing.Size(100, 24);
			this.collectionLabel.TabIndex = 1;
			this.collectionLabel.Text = "Collection";
			this.collectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
			this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(5, 5);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(30, 30);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "X";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.addButton);
			this.panel1.Controls.Add(this.completeButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 420);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 30);
			this.panel1.TabIndex = 2;
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.Location = new System.Drawing.Point(479, 3);
			this.addButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(40, 24);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// completeButton
			// 
			this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.completeButton.Location = new System.Drawing.Point(522, 3);
			this.completeButton.Name = "completeButton";
			this.completeButton.Size = new System.Drawing.Size(75, 24);
			this.completeButton.TabIndex = 0;
			this.completeButton.Text = "Complete";
			this.completeButton.UseVisualStyleBackColor = true;
			// 
			// contentPanel
			// 
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.contentPanel.Location = new System.Drawing.Point(0, 40);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(600, 380);
			this.contentPanel.TabIndex = 3;
			this.contentPanel.WrapContents = false;
			this.contentPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.contentPanel_ControlAdded);
			this.contentPanel.Resize += new System.EventHandler(this.contentPanel_Resize);
			// 
			// CollectorCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.topPanel);
			this.Name = "CollectorCollection";
			this.Size = new System.Drawing.Size(600, 450);
			this.topPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label collectionLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button completeButton;
		private System.Windows.Forms.FlowLayoutPanel contentPanel;
	}
}
