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
			this.components = new System.ComponentModel.Container();
			this.view = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
			this.SuspendLayout();
			// 
			// view
			// 
			this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view.Location = new System.Drawing.Point(0, 30);
			this.view.Name = "view";
			this.view.Size = new System.Drawing.Size(400, 218);
			this.view.TabIndex = 0;
			this.view.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellEndEdit);
			this.view.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.view_UserAddedRow);
			this.view.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.view_UserDeletingRow);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(400, 30);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// DMYOGridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.view);
			this.Name = "DMYOGridControl";
			this.Size = new System.Drawing.Size(400, 244);
			((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView view;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
