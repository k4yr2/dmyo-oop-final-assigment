namespace dmyo_oop_final_assigment.Controls
{
	partial class WasteTypeControl
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
			this.wt_name = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.wt_description = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// wt_name
			// 
			this.wt_name.AutoSize = true;
			this.wt_name.Location = new System.Drawing.Point(3, 6);
			this.wt_name.Name = "wt_name";
			this.wt_name.Size = new System.Drawing.Size(42, 13);
			this.wt_name.TabIndex = 0;
			this.wt_name.Text = "BLANK";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(6, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// wt_description
			// 
			this.wt_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.wt_description.Location = new System.Drawing.Point(76, 29);
			this.wt_description.Name = "wt_description";
			this.wt_description.ReadOnly = true;
			this.wt_description.Size = new System.Drawing.Size(221, 64);
			this.wt_description.TabIndex = 2;
			this.wt_description.Text = "";
			// 
			// WasteTypeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.wt_description);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.wt_name);
			this.Name = "WasteTypeControl";
			this.Size = new System.Drawing.Size(300, 100);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label wt_name;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox wt_description;
	}
}
