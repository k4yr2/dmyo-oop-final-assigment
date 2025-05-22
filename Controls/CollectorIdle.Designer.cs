namespace dmyo_oop_final_assigment.Controls
{
	partial class CollectorIdle
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
            this.startButton = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.archiveButton = new System.Windows.Forms.Button();
            this.archiveLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(1063, 40);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Collection";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.startButton);
            this.navPanel.Controls.Add(this.label1);
            this.navPanel.Controls.Add(this.archiveButton);
            this.navPanel.Controls.Add(this.archiveLabel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navPanel.Location = new System.Drawing.Point(0, 480);
            this.navPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1200, 74);
            this.navPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 147, 0);
            this.label1.Size = new System.Drawing.Size(1200, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start a new collection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveButton.Enabled = false;
            this.archiveButton.Location = new System.Drawing.Point(1063, 4);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(133, 30);
            this.archiveButton.TabIndex = 2;
            this.archiveButton.Text = "Archive";
            this.archiveButton.UseVisualStyleBackColor = true;
            // 
            // archiveLabel
            // 
            this.archiveLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.archiveLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.archiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.archiveLabel.Location = new System.Drawing.Point(0, 0);
            this.archiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archiveLabel.Name = "archiveLabel";
            this.archiveLabel.Padding = new System.Windows.Forms.Padding(0, 0, 147, 0);
            this.archiveLabel.Size = new System.Drawing.Size(1200, 37);
            this.archiveLabel.TabIndex = 1;
            this.archiveLabel.Text = "Browse collection from archive";
            this.archiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1200, 74);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Collector Form";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 74);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1200, 406);
            this.infoPanel.TabIndex = 9;
            // 
            // CollectorIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.navPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CollectorIdle";
            this.Size = new System.Drawing.Size(1200, 554);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Panel navPanel;
		private System.Windows.Forms.Label archiveLabel;
		private System.Windows.Forms.Button archiveButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Panel infoPanel;
		private System.Windows.Forms.Label label1;
	}
}
