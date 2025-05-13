namespace dmyo_oop_final_assigment.Forms
{
	partial class WasteForm
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
			this.typeLabel = new System.Windows.Forms.Label();
			this.typeBox = new System.Windows.Forms.ComboBox();
			this.quantityLabel = new System.Windows.Forms.Label();
			this.quantityBox = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// typeLabel
			// 
			this.typeLabel.Location = new System.Drawing.Point(9, 9);
			this.typeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(100, 30);
			this.typeLabel.TabIndex = 0;
			this.typeLabel.Text = "Type";
			this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// typeBox
			// 
			this.typeBox.FormattingEnabled = true;
			this.typeBox.Location = new System.Drawing.Point(114, 15);
			this.typeBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 4);
			this.typeBox.Name = "typeBox";
			this.typeBox.Size = new System.Drawing.Size(121, 21);
			this.typeBox.TabIndex = 1;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Location = new System.Drawing.Point(9, 39);
			this.quantityLabel.Margin = new System.Windows.Forms.Padding(0);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(100, 30);
			this.quantityLabel.TabIndex = 0;
			this.quantityLabel.Text = "Quantity";
			this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(114, 45);
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(121, 20);
			this.quantityBox.TabIndex = 2;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(12, 72);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(223, 24);
			this.button.TabIndex = 3;
			this.button.Text = "Add Waste";
			this.button.UseVisualStyleBackColor = true;
			// 
			// WasteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 107);
			this.Controls.Add(this.button);
			this.Controls.Add(this.quantityBox);
			this.Controls.Add(this.typeBox);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.typeLabel);
			this.Name = "WasteForm";
			this.Text = "Waste";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.ComboBox typeBox;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.TextBox quantityBox;
		private System.Windows.Forms.Button button;
	}
}