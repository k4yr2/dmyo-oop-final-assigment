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
			this.loginPanel = new System.Windows.Forms.Panel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bannerPanel.SuspendLayout();
			this.loginPanel.SuspendLayout();
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
			// loginPanel
			// 
			this.loginPanel.Controls.Add(this.button1);
			this.loginPanel.Controls.Add(this.passwordBox);
			this.loginPanel.Controls.Add(this.nameBox);
			this.loginPanel.Controls.Add(this.passwordLabel);
			this.loginPanel.Controls.Add(this.nameLabel);
			this.loginPanel.Location = new System.Drawing.Point(10, 66);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(200, 92);
			this.loginPanel.TabIndex = 2;
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(0, 0);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Padding = new System.Windows.Forms.Padding(5);
			this.nameLabel.Size = new System.Drawing.Size(90, 30);
			this.nameLabel.TabIndex = 3;
			this.nameLabel.Text = "Name";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(95, 5);
			this.nameBox.Margin = new System.Windows.Forms.Padding(5);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(100, 20);
			this.nameBox.TabIndex = 4;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Location = new System.Drawing.Point(0, 30);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Padding = new System.Windows.Forms.Padding(5);
			this.passwordLabel.Size = new System.Drawing.Size(90, 30);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(95, 35);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(5);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(95, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 24);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 244);
			this.Controls.Add(this.loginPanel);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.bannerPanel);
			this.Name = "MainForm";
			this.Text = "5";
			this.bannerPanel.ResumeLayout(false);
			this.bannerPanel.PerformLayout();
			this.loginPanel.ResumeLayout(false);
			this.loginPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel bannerPanel;
		private System.Windows.Forms.Label bannerTitle;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label nameLabel;
	}
}