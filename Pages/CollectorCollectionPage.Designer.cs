namespace dmyo_oop_final_assigment.Pages
{
	partial class CollectorCollectionPage
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
			this.idleButton = new System.Windows.Forms.Button();
			this.collectionLabel = new System.Windows.Forms.Label();
			this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.LightGray;
			this.topPanel.Controls.Add(this.collectionLabel);
			this.topPanel.Controls.Add(this.idleButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(600, 40);
			this.topPanel.TabIndex = 0;
			// 
			// idleButton
			// 
			this.idleButton.Location = new System.Drawing.Point(5, 5);
			this.idleButton.Margin = new System.Windows.Forms.Padding(5);
			this.idleButton.Name = "idleButton";
			this.idleButton.Size = new System.Drawing.Size(30, 30);
			this.idleButton.TabIndex = 1;
			this.idleButton.Text = "I";
			this.idleButton.UseVisualStyleBackColor = true;
			// 
			// collectionLabel
			// 
			this.collectionLabel.BackColor = System.Drawing.Color.Silver;
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
			// contentPanel
			// 
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.contentPanel.Location = new System.Drawing.Point(0, 40);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(600, 410);
			this.contentPanel.TabIndex = 1;
			this.contentPanel.WrapContents = false;
			// 
			// CollectorCollectionPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "CollectorCollectionPage";
			this.Size = new System.Drawing.Size(600, 450);
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label collectionLabel;
		private System.Windows.Forms.Button idleButton;
		private System.Windows.Forms.FlowLayoutPanel contentPanel;
	}
}
