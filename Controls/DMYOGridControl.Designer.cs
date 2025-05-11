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
			((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
			this.panel.SuspendLayout();
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
			this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUser.Location = new System.Drawing.Point(120, 0);
			this.panelUser.MinimumSize = new System.Drawing.Size(240, 30);
			this.panelUser.Name = "panelUser";
			this.panelUser.Size = new System.Drawing.Size(280, 30);
			this.panelUser.TabIndex = 3;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView view;
		private System.Windows.Forms.Panel panelAdmin;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Panel panelUser;
	}
}
