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
			this.bannerPanel = new System.Windows.Forms.Panel();
			this.bannerTitle = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.bannerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bannerPanel
			// 
			this.bannerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
			this.bannerPanel.Controls.Add(this.bannerTitle);
			this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.bannerPanel.Location = new System.Drawing.Point(0, 0);
			this.bannerPanel.Name = "bannerPanel";
			this.bannerPanel.Padding = new System.Windows.Forms.Padding(10);
			this.bannerPanel.Size = new System.Drawing.Size(800, 60);
			this.bannerPanel.TabIndex = 0;
			// 
			// bannerTitle
			// 
			this.bannerTitle.AutoSize = true;
			this.bannerTitle.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bannerTitle.ForeColor = System.Drawing.SystemColors.Control;
			this.bannerTitle.Location = new System.Drawing.Point(3, 10);
			this.bannerTitle.Name = "bannerTitle";
			this.bannerTitle.Size = new System.Drawing.Size(562, 41);
			this.bannerTitle.TabIndex = 1;
			this.bannerTitle.Text = "DMYO 2025 Waste-Recycling Project";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(713, 209);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 244);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.bannerPanel);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.bannerPanel.ResumeLayout(false);
			this.bannerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel bannerPanel;
		private System.Windows.Forms.Label bannerTitle;
		private System.Windows.Forms.Button startButton;
	}
}