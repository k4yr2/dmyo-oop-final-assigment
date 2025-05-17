namespace dmyo_oop_final_assigment.Controls
{
	partial class CollectorDistribution
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
			this.distributionLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.pageLabel = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.lastButton = new System.Windows.Forms.Button();
			this.previousButton = new System.Windows.Forms.Button();
			this.firstButton = new System.Windows.Forms.Button();
			this.contentContainer = new dmyo_oop_final_assigment.Controls.ContentContainer();
			this.sendButton = new System.Windows.Forms.Button();
			this.topPanel.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.DarkGray;
			this.topPanel.Controls.Add(this.sendButton);
			this.topPanel.Controls.Add(this.distributionLabel);
			this.topPanel.Controls.Add(this.cancelButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(598, 40);
			this.topPanel.TabIndex = 1;
			// 
			// distributionLabel
			// 
			this.distributionLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.distributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.distributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.distributionLabel.Location = new System.Drawing.Point(43, 8);
			this.distributionLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.distributionLabel.Name = "distributionLabel";
			this.distributionLabel.Size = new System.Drawing.Size(100, 24);
			this.distributionLabel.TabIndex = 1;
			this.distributionLabel.Text = "Distribution";
			this.distributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
			this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(8, 8);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(8);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(24, 24);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "X";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.Silver;
			this.bottomPanel.Controls.Add(this.pageLabel);
			this.bottomPanel.Controls.Add(this.nextButton);
			this.bottomPanel.Controls.Add(this.lastButton);
			this.bottomPanel.Controls.Add(this.previousButton);
			this.bottomPanel.Controls.Add(this.firstButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 424);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(598, 30);
			this.bottomPanel.TabIndex = 3;
			// 
			// pageLabel
			// 
			this.pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.pageLabel.Location = new System.Drawing.Point(82, 0);
			this.pageLabel.Margin = new System.Windows.Forms.Padding(0);
			this.pageLabel.Name = "pageLabel";
			this.pageLabel.Size = new System.Drawing.Size(432, 30);
			this.pageLabel.TabIndex = 2;
			this.pageLabel.Text = "1/1";
			this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nextButton
			// 
			this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nextButton.Location = new System.Drawing.Point(517, 3);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(36, 24);
			this.nextButton.TabIndex = 1;
			this.nextButton.Text = ">";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// lastButton
			// 
			this.lastButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lastButton.Location = new System.Drawing.Point(559, 3);
			this.lastButton.Name = "lastButton";
			this.lastButton.Size = new System.Drawing.Size(36, 24);
			this.lastButton.TabIndex = 1;
			this.lastButton.Text = ">>";
			this.lastButton.UseVisualStyleBackColor = true;
			this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
			// 
			// previousButton
			// 
			this.previousButton.Location = new System.Drawing.Point(43, 3);
			this.previousButton.Name = "previousButton";
			this.previousButton.Size = new System.Drawing.Size(36, 24);
			this.previousButton.TabIndex = 1;
			this.previousButton.Text = "<";
			this.previousButton.UseVisualStyleBackColor = true;
			this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
			// 
			// firstButton
			// 
			this.firstButton.Location = new System.Drawing.Point(3, 3);
			this.firstButton.Name = "firstButton";
			this.firstButton.Size = new System.Drawing.Size(36, 24);
			this.firstButton.TabIndex = 1;
			this.firstButton.Text = "<<";
			this.firstButton.UseVisualStyleBackColor = true;
			this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
			// 
			// contentContainer
			// 
			this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentContainer.Location = new System.Drawing.Point(0, 40);
			this.contentContainer.Margin = new System.Windows.Forms.Padding(0);
			this.contentContainer.Name = "contentContainer";
			this.contentContainer.Size = new System.Drawing.Size(598, 384);
			this.contentContainer.TabIndex = 4;
			// 
			// sendButton
			// 
			this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sendButton.Location = new System.Drawing.Point(526, 8);
			this.sendButton.Margin = new System.Windows.Forms.Padding(8);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(64, 24);
			this.sendButton.TabIndex = 2;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = true;
			this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
			// 
			// CollectorDistribution
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentContainer);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "CollectorDistribution";
			this.Size = new System.Drawing.Size(598, 454);
			this.topPanel.ResumeLayout(false);
			this.bottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label distributionLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button lastButton;
		private System.Windows.Forms.Button previousButton;
		private System.Windows.Forms.Button firstButton;
		private ContentContainer contentContainer;
		private System.Windows.Forms.Label pageLabel;
		private System.Windows.Forms.Button sendButton;
	}
}
