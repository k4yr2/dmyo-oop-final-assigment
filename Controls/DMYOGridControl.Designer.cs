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
			((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
			this.SuspendLayout();
			// 
			// view
			// 
			this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view.Dock = System.Windows.Forms.DockStyle.Fill;
			this.view.Location = new System.Drawing.Point(0, 0);
			this.view.Name = "view";
			this.view.Size = new System.Drawing.Size(400, 200);
			this.view.TabIndex = 0;
			this.view.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellValueChanged);
			this.view.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.view_UserAddedRow);
			// 
			// DMYOGridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.view);
			this.Name = "DMYOGridControl";
			this.Size = new System.Drawing.Size(400, 200);
			((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView view;
	}
}
