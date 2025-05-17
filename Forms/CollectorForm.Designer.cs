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
			this.idlePanel = new System.Windows.Forms.Panel();
			this.idleContentPanel = new System.Windows.Forms.Panel();
			this.idleBottomPanel = new System.Windows.Forms.Panel();
			this.idleStartButton = new System.Windows.Forms.Button();
			idleTitle = new System.Windows.Forms.Label();
			this.topPanel.SuspendLayout();
			this.idlePanel.SuspendLayout();
			this.idleContentPanel.SuspendLayout();
			this.idleBottomPanel.SuspendLayout();
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
			// idlePanel
			// 
			this.idlePanel.Controls.Add(this.idleContentPanel);
			this.idlePanel.Controls.Add(idleTitle);
			this.idlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idlePanel.Location = new System.Drawing.Point(0, 40);
			this.idlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.idlePanel.Name = "idlePanel";
			this.idlePanel.Size = new System.Drawing.Size(526, 298);
			this.idlePanel.TabIndex = 1;
			// 
			// idleTitle
			// 
			idleTitle.Dock = System.Windows.Forms.DockStyle.Top;
			idleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			idleTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
			idleTitle.Location = new System.Drawing.Point(0, 0);
			idleTitle.Margin = new System.Windows.Forms.Padding(0);
			idleTitle.Name = "idleTitle";
			idleTitle.Size = new System.Drawing.Size(526, 100);
			idleTitle.TabIndex = 0;
			idleTitle.Text = "DMYO 2025 Collector Form";
			idleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// idleContentPanel
			// 
			this.idleContentPanel.Controls.Add(this.idleBottomPanel);
			this.idleContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idleContentPanel.Location = new System.Drawing.Point(0, 100);
			this.idleContentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.idleContentPanel.Name = "idleContentPanel";
			this.idleContentPanel.Size = new System.Drawing.Size(526, 198);
			this.idleContentPanel.TabIndex = 1;
			// 
			// idleBottomPanel
			// 
			this.idleBottomPanel.BackColor = System.Drawing.Color.DarkGray;
			this.idleBottomPanel.Controls.Add(this.idleStartButton);
			this.idleBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.idleBottomPanel.Location = new System.Drawing.Point(0, 168);
			this.idleBottomPanel.Name = "idleBottomPanel";
			this.idleBottomPanel.Size = new System.Drawing.Size(526, 30);
			this.idleBottomPanel.TabIndex = 0;
			// 
			// idleStartButton
			// 
			this.idleStartButton.Location = new System.Drawing.Point(425, 3);
			this.idleStartButton.Name = "idleStartButton";
			this.idleStartButton.Size = new System.Drawing.Size(98, 24);
			this.idleStartButton.TabIndex = 1;
			this.idleStartButton.Text = "Start Collection";
			this.idleStartButton.UseVisualStyleBackColor = true;
			// 
			// CollectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 338);
			this.Controls.Add(this.idlePanel);
			this.Controls.Add(this.topPanel);
			this.Name = "CollectorForm";
			this.Text = "CollectorForm";
			this.topPanel.ResumeLayout(false);
			this.idlePanel.ResumeLayout(false);
			this.idleContentPanel.ResumeLayout(false);
			this.idleBottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Button mainButton;
		private System.Windows.Forms.Panel idlePanel;
		private System.Windows.Forms.Panel idleContentPanel;
		private System.Windows.Forms.Panel idleBottomPanel;
		private System.Windows.Forms.Button idleStartButton;
	}
}