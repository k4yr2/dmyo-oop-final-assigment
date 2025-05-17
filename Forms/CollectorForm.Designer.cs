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
			System.Windows.Forms.Label idleTitle;
			this.topPanel = new System.Windows.Forms.Panel();
			this.mainButton = new System.Windows.Forms.Button();
			this.idleContentPanel = new System.Windows.Forms.Panel();
			this.idleBottomPanel = new System.Windows.Forms.Panel();
			this.idleStartButton = new System.Windows.Forms.Button();
			this.collectorTab = new System.Windows.Forms.TabControl();
			this.idlePage = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			idleTitle = new System.Windows.Forms.Label();
			this.topPanel.SuspendLayout();
			this.idleContentPanel.SuspendLayout();
			this.idleBottomPanel.SuspendLayout();
			this.collectorTab.SuspendLayout();
			this.idlePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.LightSlateGray;
			this.topPanel.Controls.Add(this.mainButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(526, 40);
			this.topPanel.TabIndex = 0;
			// 
			// mainButton
			// 
			this.mainButton.Location = new System.Drawing.Point(8, 8);
			this.mainButton.Margin = new System.Windows.Forms.Padding(8);
			this.mainButton.Name = "mainButton";
			this.mainButton.Size = new System.Drawing.Size(24, 24);
			this.mainButton.TabIndex = 1;
			this.mainButton.UseVisualStyleBackColor = true;
			// 
			// idleTitle
			// 
			idleTitle.Dock = System.Windows.Forms.DockStyle.Top;
			idleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			idleTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
			idleTitle.Location = new System.Drawing.Point(0, 0);
			idleTitle.Margin = new System.Windows.Forms.Padding(0);
			idleTitle.Name = "idleTitle";
			idleTitle.Size = new System.Drawing.Size(518, 65);
			idleTitle.TabIndex = 0;
			idleTitle.Text = "DMYO 2025 Collector Form";
			idleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// idleContentPanel
			// 
			this.idleContentPanel.Controls.Add(this.idleBottomPanel);
			this.idleContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idleContentPanel.Location = new System.Drawing.Point(0, 65);
			this.idleContentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.idleContentPanel.Name = "idleContentPanel";
			this.idleContentPanel.Size = new System.Drawing.Size(518, 229);
			this.idleContentPanel.TabIndex = 1;
			// 
			// idleBottomPanel
			// 
			this.idleBottomPanel.BackColor = System.Drawing.Color.DarkGray;
			this.idleBottomPanel.Controls.Add(this.idleStartButton);
			this.idleBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.idleBottomPanel.Location = new System.Drawing.Point(0, 199);
			this.idleBottomPanel.Name = "idleBottomPanel";
			this.idleBottomPanel.Size = new System.Drawing.Size(518, 30);
			this.idleBottomPanel.TabIndex = 0;
			// 
			// idleStartButton
			// 
			this.idleStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.idleStartButton.Location = new System.Drawing.Point(417, 3);
			this.idleStartButton.Name = "idleStartButton";
			this.idleStartButton.Size = new System.Drawing.Size(98, 24);
			this.idleStartButton.TabIndex = 1;
			this.idleStartButton.Text = "Start Collection";
			this.idleStartButton.UseVisualStyleBackColor = true;
			// 
			// collectorTab
			// 
			this.collectorTab.Controls.Add(this.idlePage);
			this.collectorTab.Controls.Add(this.tabPage2);
			this.collectorTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectorTab.ItemSize = new System.Drawing.Size(98, 18);
			this.collectorTab.Location = new System.Drawing.Point(0, 40);
			this.collectorTab.Name = "collectorTab";
			this.collectorTab.Padding = new System.Drawing.Point(0, 0);
			this.collectorTab.SelectedIndex = 0;
			this.collectorTab.Size = new System.Drawing.Size(526, 320);
			this.collectorTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.collectorTab.TabIndex = 2;
			// 
			// idlePage
			// 
			this.idlePage.BackColor = System.Drawing.Color.WhiteSmoke;
			this.idlePage.Controls.Add(this.idleContentPanel);
			this.idlePage.Controls.Add(idleTitle);
			this.idlePage.Location = new System.Drawing.Point(4, 22);
			this.idlePage.Margin = new System.Windows.Forms.Padding(0);
			this.idlePage.Name = "idlePage";
			this.idlePage.Size = new System.Drawing.Size(518, 294);
			this.idlePage.TabIndex = 0;
			this.idlePage.Text = "Idle";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(518, 294);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// CollectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 360);
			this.Controls.Add(this.collectorTab);
			this.Controls.Add(this.topPanel);
			this.Name = "CollectorForm";
			this.Text = "CollectorForm";
			this.topPanel.ResumeLayout(false);
			this.idleContentPanel.ResumeLayout(false);
			this.idleBottomPanel.ResumeLayout(false);
			this.collectorTab.ResumeLayout(false);
			this.idlePage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Button mainButton;
		private System.Windows.Forms.Panel idleContentPanel;
		private System.Windows.Forms.Panel idleBottomPanel;
		private System.Windows.Forms.Button idleStartButton;
		private System.Windows.Forms.TabControl collectorTab;
		private System.Windows.Forms.TabPage idlePage;
		private System.Windows.Forms.TabPage tabPage2;
	}
}