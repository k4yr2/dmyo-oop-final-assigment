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
			this.quickPresetPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.quickCollectorButton_SinanDemirci = new System.Windows.Forms.Button();
			this.loginTopPanel = new System.Windows.Forms.Panel();
			this.quickLoginLabel = new System.Windows.Forms.Label();
			this.loginLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bodyPanel = new System.Windows.Forms.Panel();
			this.quickAdminPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.quickCollectorPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.quickRecyclerPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.quickAdminButton_dmyo2025 = new System.Windows.Forms.Button();
			this.githubLink = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.bannerPanel.SuspendLayout();
			this.loginControlPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.loginPanel.SuspendLayout();
			this.loginContentPanel.SuspendLayout();
			this.quickPresetPanel.SuspendLayout();
			this.loginTopPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.bodyPanel.SuspendLayout();
			this.quickAdminPanel.SuspendLayout();
			this.quickCollectorPanel.SuspendLayout();
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
			this.bannerPanel.Size = new System.Drawing.Size(726, 60);
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
			this.loginControlPanel.BackColor = System.Drawing.Color.Gainsboro;
			this.loginControlPanel.Controls.Add(this.loginButton);
			this.loginControlPanel.Controls.Add(this.passwordBox);
			this.loginControlPanel.Controls.Add(this.nameBox);
			this.loginControlPanel.Controls.Add(this.passwordLabel);
			this.loginControlPanel.Controls.Add(this.nameLabel);
			this.loginControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
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
			this.contentPanel.Size = new System.Drawing.Size(726, 344);
			this.contentPanel.TabIndex = 4;
			this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
			this.contentPanel.Resize += new System.EventHandler(this.contentPanel_Resize);
			// 
			// loginPanel
			// 
			this.loginPanel.Controls.Add(this.loginContentPanel);
			this.loginPanel.Controls.Add(this.loginTopPanel);
			this.loginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.loginPanel.Location = new System.Drawing.Point(0, 182);
			this.loginPanel.Margin = new System.Windows.Forms.Padding(0);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(726, 132);
			this.loginPanel.TabIndex = 4;
			// 
			// loginContentPanel
			// 
			this.loginContentPanel.Controls.Add(this.quickPresetPanel);
			this.loginContentPanel.Controls.Add(this.loginControlPanel);
			this.loginContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginContentPanel.Location = new System.Drawing.Point(0, 40);
			this.loginContentPanel.Name = "loginContentPanel";
			this.loginContentPanel.Size = new System.Drawing.Size(726, 92);
			this.loginContentPanel.TabIndex = 4;
			// 
			// quickPresetPanel
			// 
			this.quickPresetPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
			this.quickPresetPanel.Controls.Add(this.quickAdminPanel);
			this.quickPresetPanel.Controls.Add(this.quickCollectorPanel);
			this.quickPresetPanel.Controls.Add(this.quickRecyclerPanel);
			this.quickPresetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quickPresetPanel.Location = new System.Drawing.Point(200, 0);
			this.quickPresetPanel.Margin = new System.Windows.Forms.Padding(0);
			this.quickPresetPanel.Name = "quickPresetPanel";
			this.quickPresetPanel.Size = new System.Drawing.Size(526, 92);
			this.quickPresetPanel.TabIndex = 3;
			this.quickPresetPanel.WrapContents = false;
			// 
			// quickCollectorButton_SinanDemirci
			// 
			this.quickCollectorButton_SinanDemirci.Location = new System.Drawing.Point(5, 5);
			this.quickCollectorButton_SinanDemirci.Margin = new System.Windows.Forms.Padding(5);
			this.quickCollectorButton_SinanDemirci.Name = "quickCollectorButton_SinanDemirci";
			this.quickCollectorButton_SinanDemirci.Size = new System.Drawing.Size(120, 30);
			this.quickCollectorButton_SinanDemirci.TabIndex = 5;
			this.quickCollectorButton_SinanDemirci.Text = "Sinan Demirci";
			this.quickCollectorButton_SinanDemirci.UseVisualStyleBackColor = true;
			this.quickCollectorButton_SinanDemirci.Click += new System.EventHandler(this.quickCollectorButton_SinanDemirci_Click);
			// 
			// loginTopPanel
			// 
			this.loginTopPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.loginTopPanel.Controls.Add(this.quickLoginLabel);
			this.loginTopPanel.Controls.Add(this.loginLabel);
			this.loginTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.loginTopPanel.Location = new System.Drawing.Point(0, 0);
			this.loginTopPanel.Margin = new System.Windows.Forms.Padding(0);
			this.loginTopPanel.Name = "loginTopPanel";
			this.loginTopPanel.Size = new System.Drawing.Size(726, 40);
			this.loginTopPanel.TabIndex = 3;
			// 
			// quickLoginLabel
			// 
			this.quickLoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quickLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.quickLoginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.quickLoginLabel.Location = new System.Drawing.Point(200, 0);
			this.quickLoginLabel.Margin = new System.Windows.Forms.Padding(0);
			this.quickLoginLabel.Name = "quickLoginLabel";
			this.quickLoginLabel.Size = new System.Drawing.Size(526, 40);
			this.quickLoginLabel.TabIndex = 0;
			this.quickLoginLabel.Text = "Quick Login";
			this.quickLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loginLabel
			// 
			this.loginLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.loginLabel.Location = new System.Drawing.Point(0, 0);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(200, 40);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Login";
			this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.githubLink);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 314);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(726, 30);
			this.panel1.TabIndex = 3;
			// 
			// bodyPanel
			// 
			this.bodyPanel.Controls.Add(this.contentPanel);
			this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bodyPanel.Location = new System.Drawing.Point(0, 60);
			this.bodyPanel.Name = "bodyPanel";
			this.bodyPanel.Size = new System.Drawing.Size(726, 344);
			this.bodyPanel.TabIndex = 3;
			// 
			// quickAdminPanel
			// 
			this.quickAdminPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.quickAdminPanel.Controls.Add(this.quickAdminButton_dmyo2025);
			this.quickAdminPanel.Location = new System.Drawing.Point(0, 0);
			this.quickAdminPanel.Margin = new System.Windows.Forms.Padding(0);
			this.quickAdminPanel.Name = "quickAdminPanel";
			this.quickAdminPanel.Size = new System.Drawing.Size(150, 92);
			this.quickAdminPanel.TabIndex = 6;
			// 
			// quickCollectorPanel
			// 
			this.quickCollectorPanel.AutoScroll = true;
			this.quickCollectorPanel.BackColor = System.Drawing.Color.Gainsboro;
			this.quickCollectorPanel.Controls.Add(this.quickCollectorButton_SinanDemirci);
			this.quickCollectorPanel.Location = new System.Drawing.Point(150, 0);
			this.quickCollectorPanel.Margin = new System.Windows.Forms.Padding(0);
			this.quickCollectorPanel.Name = "quickCollectorPanel";
			this.quickCollectorPanel.Size = new System.Drawing.Size(150, 92);
			this.quickCollectorPanel.TabIndex = 6;
			// 
			// quickRecyclerPanel
			// 
			this.quickRecyclerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.quickRecyclerPanel.Location = new System.Drawing.Point(300, 0);
			this.quickRecyclerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.quickRecyclerPanel.Name = "quickRecyclerPanel";
			this.quickRecyclerPanel.Size = new System.Drawing.Size(150, 92);
			this.quickRecyclerPanel.TabIndex = 6;
			// 
			// quickAdminButton_dmyo2025
			// 
			this.quickAdminButton_dmyo2025.Location = new System.Drawing.Point(5, 5);
			this.quickAdminButton_dmyo2025.Margin = new System.Windows.Forms.Padding(5);
			this.quickAdminButton_dmyo2025.Name = "quickAdminButton_dmyo2025";
			this.quickAdminButton_dmyo2025.Size = new System.Drawing.Size(120, 30);
			this.quickAdminButton_dmyo2025.TabIndex = 5;
			this.quickAdminButton_dmyo2025.Text = "dmyo 2025";
			this.quickAdminButton_dmyo2025.UseVisualStyleBackColor = true;
			this.quickAdminButton_dmyo2025.Click += new System.EventHandler(this.quickAdminButton_dmyo2025_Click);
			// 
			// githubLink
			// 
			this.githubLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.githubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.githubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.githubLink.LinkColor = System.Drawing.Color.Blue;
			this.githubLink.Location = new System.Drawing.Point(0, 0);
			this.githubLink.Margin = new System.Windows.Forms.Padding(0);
			this.githubLink.Name = "githubLink";
			this.githubLink.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.githubLink.Size = new System.Drawing.Size(353, 30);
			this.githubLink.TabIndex = 0;
			this.githubLink.TabStop = true;
			this.githubLink.Text = "dmyo-oop-final-assigment";
			this.githubLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
			this.linkLabel1.Location = new System.Drawing.Point(642, 0);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.linkLabel1.Size = new System.Drawing.Size(84, 30);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "k4yr2";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 404);
			this.Controls.Add(this.bodyPanel);
			this.Controls.Add(this.bannerPanel);
			this.Name = "MainForm";
			this.Text = "0";
			this.bannerPanel.ResumeLayout(false);
			this.bannerPanel.PerformLayout();
			this.loginControlPanel.ResumeLayout(false);
			this.loginControlPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.loginPanel.ResumeLayout(false);
			this.loginContentPanel.ResumeLayout(false);
			this.quickPresetPanel.ResumeLayout(false);
			this.loginTopPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.bodyPanel.ResumeLayout(false);
			this.quickAdminPanel.ResumeLayout(false);
			this.quickCollectorPanel.ResumeLayout(false);
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
		private System.Windows.Forms.FlowLayoutPanel quickPresetPanel;
		private System.Windows.Forms.Label quickLoginLabel;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Button quickCollectorButton_SinanDemirci;
		private System.Windows.Forms.FlowLayoutPanel quickAdminPanel;
		private System.Windows.Forms.FlowLayoutPanel quickCollectorPanel;
		private System.Windows.Forms.Button quickAdminButton_dmyo2025;
		private System.Windows.Forms.FlowLayoutPanel quickRecyclerPanel;
		private System.Windows.Forms.LinkLabel githubLink;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}