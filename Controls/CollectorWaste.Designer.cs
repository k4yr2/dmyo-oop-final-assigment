namespace dmyo_oop_final_assigment.Controls
{
	partial class CollectorWaste
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.typeLabel = new System.Windows.Forms.Label();
			this.abbrLabel = new System.Windows.Forms.Label();
			this.detailButton = new System.Windows.Forms.Button();
			this.quantityLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
			this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
			this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteButton.Location = new System.Drawing.Point(8, 8);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(24, 24);
			this.deleteButton.TabIndex = 0;
			this.deleteButton.Text = "X";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// typeLabel
			// 
			this.typeLabel.Location = new System.Drawing.Point(38, 8);
			this.typeLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(144, 24);
			this.typeLabel.TabIndex = 1;
			this.typeLabel.Text = "Blank Type";
			this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// abbrLabel
			// 
			this.abbrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.abbrLabel.Location = new System.Drawing.Point(276, 8);
			this.abbrLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.abbrLabel.Name = "abbrLabel";
			this.abbrLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.abbrLabel.Size = new System.Drawing.Size(48, 24);
			this.abbrLabel.TabIndex = 2;
			this.abbrLabel.Text = "pcs";
			this.abbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// detailButton
			// 
			this.detailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.detailButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
			this.detailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
			this.detailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.detailButton.Location = new System.Drawing.Point(330, 10);
			this.detailButton.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(20, 20);
			this.detailButton.TabIndex = 0;
			this.detailButton.Text = "🖊️";
			this.detailButton.UseVisualStyleBackColor = true;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityLabel.Location = new System.Drawing.Point(222, 8);
			this.quantityLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.quantityLabel.Size = new System.Drawing.Size(48, 24);
			this.quantityLabel.TabIndex = 2;
			this.quantityLabel.Text = "0";
			this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CollectorWaste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.abbrLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.deleteButton);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(360, 40);
			this.Name = "CollectorWaste";
			this.Size = new System.Drawing.Size(360, 40);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label abbrLabel;
		private System.Windows.Forms.Button detailButton;
		private System.Windows.Forms.Label quantityLabel;
	}
}
