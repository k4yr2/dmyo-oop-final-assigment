namespace dmyo_oop_final_assigment.Controls
{
	partial class CollectorDistributionItem
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
			System.Windows.Forms.Label abbrLabel;
			this.label1 = new System.Windows.Forms.Label();
			this.quantityLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.seperatorLabel = new System.Windows.Forms.Label();
			this.percentLabel = new System.Windows.Forms.Label();
			abbrLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "BLANK";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// abbrLabel
			// 
			abbrLabel.Dock = System.Windows.Forms.DockStyle.Right;
			abbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			abbrLabel.Location = new System.Drawing.Point(386, 0);
			abbrLabel.Name = "abbrLabel";
			abbrLabel.Size = new System.Drawing.Size(40, 30);
			abbrLabel.TabIndex = 1;
			abbrLabel.Text = "pcs";
			abbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.quantityLabel.Location = new System.Drawing.Point(346, 0);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(40, 30);
			this.quantityLabel.TabIndex = 2;
			this.quantityLabel.Text = "0";
			this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(258, 5);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(60, 20);
			this.textBox1.TabIndex = 3;
			// 
			// seperatorLabel
			// 
			this.seperatorLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.seperatorLabel.Location = new System.Drawing.Point(326, 0);
			this.seperatorLabel.Name = "seperatorLabel";
			this.seperatorLabel.Size = new System.Drawing.Size(20, 30);
			this.seperatorLabel.TabIndex = 4;
			this.seperatorLabel.Text = "/";
			this.seperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// percentLabel
			// 
			this.percentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.percentLabel.Location = new System.Drawing.Point(220, 0);
			this.percentLabel.Name = "percentLabel";
			this.percentLabel.Size = new System.Drawing.Size(30, 30);
			this.percentLabel.TabIndex = 5;
			this.percentLabel.Text = "%0";
			this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CollectorDistributionItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.percentLabel);
			this.Controls.Add(this.seperatorLabel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(abbrLabel);
			this.Controls.Add(this.label1);
			this.Name = "CollectorDistributionItem";
			this.Size = new System.Drawing.Size(426, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label seperatorLabel;
		private System.Windows.Forms.Label percentLabel;
	}
}
