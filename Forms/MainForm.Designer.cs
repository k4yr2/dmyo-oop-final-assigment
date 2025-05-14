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
			this.loginControlPanel = new System.Windows.Forms.Panel();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.loginPanel = new System.Windows.Forms.Panel();
			this.loginContentPanel = new System.Windows.Forms.Panel();
			this.loginTopPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bodyPanel = new System.Windows.Forms.Panel();
			this.bannerPanel.SuspendLayout();
			this.loginControlPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.loginPanel.SuspendLayout();
			this.loginContentPanel.SuspendLayout();
			this.bodyPanel.SuspendLayout();
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
			this.bannerPanel.Size = new System.Drawing.Size(741, 60);
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
			// loginControlPanel
			// 
			this.loginControlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.loginControlPanel.Controls.Add(this.loginButton);
			this.loginControlPanel.Controls.Add(this.passwordBox);
			this.loginControlPanel.Controls.Add(this.nameBox);
			this.loginControlPanel.Controls.Add(this.passwordLabel);
			this.loginControlPanel.Controls.Add(this.nameLabel);
			this.loginControlPanel.Location = new System.Drawing.Point(0, 0);
			this.loginControlPanel.Margin = new System.Windows.Forms.Padding(0);
			this.loginControlPanel.Name = "loginControlPanel";
			this.loginControlPanel.Size = new System.Drawing.Size(200, 92);
			this.loginControlPanel.TabIndex = 2;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(95, 63);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(100, 24);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Log in";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(95, 35);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(5);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 4;
			this.passwordBox.Text = "demirci";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(95, 5);
			this.nameBox.Margin = new System.Windows.Forms.Padding(5);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(100, 20);
			this.nameBox.TabIndex = 4;
			this.nameBox.Text = "sinan";
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
			// contentPanel
			// 
			this.contentPanel.Controls.Add(this.loginPanel);
			this.contentPanel.Controls.Add(this.panel1);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 0);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(741, 344);
			this.contentPanel.TabIndex = 4;
			// 
			// loginPanel
			// 
			this.loginPanel.Controls.Add(this.loginContentPanel);
			this.loginPanel.Controls.Add(this.loginTopPanel);
			this.loginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.loginPanel.Location = new System.Drawing.Point(0, 182);
			this.loginPanel.Margin = new System.Windows.Forms.Padding(0);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(741, 132);
			this.loginPanel.TabIndex = 4;
			// 
			// loginContentPanel
			// 
			this.loginContentPanel.Controls.Add(this.loginControlPanel);
			this.loginContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginContentPanel.Location = new System.Drawing.Point(0, 40);
			this.loginContentPanel.Name = "loginContentPanel";
			this.loginContentPanel.Size = new System.Drawing.Size(741, 92);
			this.loginContentPanel.TabIndex = 4;
			// 
			// loginTopPanel
			// 
			this.loginTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.loginTopPanel.Location = new System.Drawing.Point(0, 0);
			this.loginTopPanel.Margin = new System.Windows.Forms.Padding(0);
			this.loginTopPanel.Name = "loginTopPanel";
			this.loginTopPanel.Size = new System.Drawing.Size(741, 40);
			this.loginTopPanel.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 314);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 30);
			this.panel1.TabIndex = 3;
			// 
			// bodyPanel
			// 
			this.bodyPanel.Controls.Add(this.contentPanel);
			this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bodyPanel.Location = new System.Drawing.Point(0, 60);
			this.bodyPanel.Name = "bodyPanel";
			this.bodyPanel.Size = new System.Drawing.Size(741, 344);
			this.bodyPanel.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 404);
			this.Controls.Add(this.bodyPanel);
			this.Controls.Add(this.bannerPanel);
			this.Name = "MainForm";
			this.Text = "5";
			this.bannerPanel.ResumeLayout(false);
			this.bannerPanel.PerformLayout();
			this.loginControlPanel.ResumeLayout(false);
			this.loginControlPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.loginPanel.ResumeLayout(false);
			this.loginContentPanel.ResumeLayout(false);
			this.bodyPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel bannerPanel;
		private System.Windows.Forms.Label bannerTitle;
		private System.Windows.Forms.Panel loginControlPanel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Panel bodyPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Panel loginContentPanel;
		private System.Windows.Forms.Panel loginTopPanel;
	}
}