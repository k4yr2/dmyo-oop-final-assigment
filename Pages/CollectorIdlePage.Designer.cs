namespace dmyo_oop_final_assigment.Pages
{
	partial class CollectorIdlePage
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
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.navPanel = new System.Windows.Forms.Panel();
			this.statisticLabel = new System.Windows.Forms.Label();
			this.statisticButton = new System.Windows.Forms.Button();
			this.archiveLabel = new System.Windows.Forms.Label();
			this.archiveButton = new System.Windows.Forms.Button();
			this.topPanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.infoPanel = new System.Windows.Forms.Panel();
			this.idleButton = new System.Windows.Forms.Button();
			this.bottomPanel.SuspendLayout();
			this.navPanel.SuspendLayout();
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.LightGray;
			this.bottomPanel.Controls.Add(this.startButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 408);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(582, 30);
			this.bottomPanel.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Location = new System.Drawing.Point(479, 3);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(100, 24);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start Collection";
			this.startButton.UseVisualStyleBackColor = true;
			// 
			// navPanel
			// 
			this.navPanel.Controls.Add(this.archiveButton);
			this.navPanel.Controls.Add(this.archiveLabel);
			this.navPanel.Controls.Add(this.statisticButton);
			this.navPanel.Controls.Add(this.statisticLabel);
			this.navPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.navPanel.Location = new System.Drawing.Point(0, 257);
			this.navPanel.Name = "navPanel";
			this.navPanel.Size = new System.Drawing.Size(582, 151);
			this.navPanel.TabIndex = 5;
			// 
			// statisticLabel
			// 
			this.statisticLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.statisticLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.statisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.statisticLabel.Location = new System.Drawing.Point(0, 0);
			this.statisticLabel.Margin = new System.Windows.Forms.Padding(0);
			this.statisticLabel.Name = "statisticLabel";
			this.statisticLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
			this.statisticLabel.Size = new System.Drawing.Size(582, 30);
			this.statisticLabel.TabIndex = 0;
			this.statisticLabel.Text = "See all your collection statistics";
			this.statisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// statisticButton
			// 
			this.statisticButton.Location = new System.Drawing.Point(479, 3);
			this.statisticButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.statisticButton.Name = "statisticButton";
			this.statisticButton.Size = new System.Drawing.Size(100, 24);
			this.statisticButton.TabIndex = 1;
			this.statisticButton.Text = "Statistics";
			this.statisticButton.UseVisualStyleBackColor = true;
			// 
			// archiveLabel
			// 
			this.archiveLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.archiveLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.archiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.archiveLabel.Location = new System.Drawing.Point(0, 30);
			this.archiveLabel.Name = "archiveLabel";
			this.archiveLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
			this.archiveLabel.Size = new System.Drawing.Size(582, 30);
			this.archiveLabel.TabIndex = 1;
			this.archiveLabel.Text = "Select a collection from the archive and browse";
			this.archiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// archiveButton
			// 
			this.archiveButton.Location = new System.Drawing.Point(479, 33);
			this.archiveButton.Name = "archiveButton";
			this.archiveButton.Size = new System.Drawing.Size(100, 24);
			this.archiveButton.TabIndex = 2;
			this.archiveButton.Text = "Archive";
			this.archiveButton.UseVisualStyleBackColor = true;
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.LightGray;
			this.topPanel.Controls.Add(this.idleButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(582, 40);
			this.topPanel.TabIndex = 7;
			// 
			// titleLabel
			// 
			this.titleLabel.BackColor = System.Drawing.Color.LightSlateGray;
			this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(0, 40);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(582, 60);
			this.titleLabel.TabIndex = 8;
			this.titleLabel.Text = "Collector Form";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// infoPanel
			// 
			this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infoPanel.Location = new System.Drawing.Point(0, 100);
			this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
			this.infoPanel.Name = "infoPanel";
			this.infoPanel.Size = new System.Drawing.Size(582, 157);
			this.infoPanel.TabIndex = 9;
			// 
			// idleButton
			// 
			this.idleButton.Location = new System.Drawing.Point(5, 5);
			this.idleButton.Margin = new System.Windows.Forms.Padding(5);
			this.idleButton.Name = "idleButton";
			this.idleButton.Size = new System.Drawing.Size(30, 30);
			this.idleButton.TabIndex = 0;
			this.idleButton.Text = "I";
			this.idleButton.UseVisualStyleBackColor = true;
			// 
			// CollectorIdlePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.infoPanel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.navPanel);
			this.Controls.Add(this.bottomPanel);
			this.Name = "CollectorIdlePage";
			this.Size = new System.Drawing.Size(582, 438);
			this.bottomPanel.ResumeLayout(false);
			this.navPanel.ResumeLayout(false);
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Panel navPanel;
		private System.Windows.Forms.Button statisticButton;
		private System.Windows.Forms.Label statisticLabel;
		private System.Windows.Forms.Label archiveLabel;
		private System.Windows.Forms.Button archiveButton;
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Button idleButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Panel infoPanel;
	}
}
