namespace dmyo_oop_final_assigment.Controls
{
	partial class RecyclerStorageItem
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
            this.abbrLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abbrLabel
            // 
            this.abbrLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.abbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.abbrLabel.Location = new System.Drawing.Point(694, 0);
            this.abbrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.abbrLabel.Name = "abbrLabel";
            this.abbrLabel.Size = new System.Drawing.Size(53, 49);
            this.abbrLabel.TabIndex = 1;
            this.abbrLabel.Text = "pcs";
            this.abbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typeLabel.Location = new System.Drawing.Point(0, 0);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.typeLabel.Size = new System.Drawing.Size(213, 49);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "BLANK";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityLabel.Location = new System.Drawing.Point(614, 0);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(80, 49);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "0";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecyclerStorageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.abbrLabel);
            this.Controls.Add(this.typeLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(533, 49);
            this.Name = "RecyclerStorageItem";
            this.Size = new System.Drawing.Size(747, 49);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.Label abbrLabel;
    }
}
