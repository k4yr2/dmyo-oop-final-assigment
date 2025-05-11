namespace dmyo_oop_final_assigment.Controls
{
	partial class DMYOGridControl
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
			this.view = new System.Windows.Forms.DataGridView();
			this.panelAdmin = new System.Windows.Forms.Panel();
			this.panel = new System.Windows.Forms.Panel();
			this.panelUser = new System.Windows.Forms.Panel();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.refreshButton = new System.Windows.Forms.Button();
			this.searchLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
			this.panel.SuspendLayout();
			this.panelUser.SuspendLayout();
			this.SuspendLayout();
			// 
			// view
			// 
			this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.view.Location = new System.Drawing.Point(0, 30);
			this.view.Name = "view";
			this.view.Size = new System.Drawing.Size(400, 214);
			this.view.TabIndex = 1;
			// 
			// panelAdmin
			// 
			this.panelAdmin.AutoSize = true;
			this.panelAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelAdmin.Location = new System.Drawing.Point(0, 0);
			this.panelAdmin.MinimumSize = new System.Drawing.Size(120, 30);
			this.panelAdmin.Name = "panelAdmin";
			this.panelAdmin.Size = new System.Drawing.Size(120, 30);
			this.panelAdmin.TabIndex = 2;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.panelUser);
			this.panel.Controls.Add(this.panelAdmin);
			this.panel.Controls.Add(this.view);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(400, 244);
			this.panel.TabIndex = 0;
			// 
			// panelUser
			// 
			this.panelUser.AutoSize = true;
			this.panelUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelUser.Controls.Add(this.searchLabel);
			this.panelUser.Controls.Add(this.refreshButton);
			this.panelUser.Controls.Add(this.searchBox);
			this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUser.Location = new System.Drawing.Point(120, 0);
			this.panelUser.Margin = new System.Windows.Forms.Padding(0);
			this.panelUser.MinimumSize = new System.Drawing.Size(240, 30);
			this.panelUser.Name = "panelUser";
			this.panelUser.Padding = new System.Windows.Forms.Padding(5);
			this.panelUser.Size = new System.Drawing.Size(280, 30);
			this.panelUser.TabIndex = 3;
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(90, 5);
			this.searchBox.Margin = new System.Windows.Forms.Padding(0);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(120, 20);
			this.searchBox.TabIndex = 0;
			// 
			// refreshButton
			// 
			this.refreshButton.Location = new System.Drawing.Point(215, 5);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(60, 20);
			this.refreshButton.TabIndex = 1;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			// 
			// searchLabel
			// 
			this.searchLabel.Location = new System.Drawing.Point(41, 5);
			this.searchLabel.Margin = new System.Windows.Forms.Padding(0);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(49, 20);
			this.searchLabel.TabIndex = 2;
			this.searchLabel.Text = "Search :";
			this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DMYOGridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel);
			this.Name = "DMYOGridControl";
			this.Size = new System.Drawing.Size(400, 244);
			((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.panelUser.ResumeLayout(false);
			this.panelUser.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView view;
		private System.Windows.Forms.Panel panelAdmin;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Panel panelUser;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.Button refreshButton;
	}
}
