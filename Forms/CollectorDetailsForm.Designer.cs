﻿namespace dmyo_oop_final_assigment.Forms
{
	partial class CollectorDetailsForm
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
			this.quantityLabel = new System.Windows.Forms.Label();
			this.typeBox = new System.Windows.Forms.ComboBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.quantityBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// typeLabel
			// 
			this.typeLabel.Location = new System.Drawing.Point(0, 0);
			this.typeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.typeLabel.Size = new System.Drawing.Size(75, 30);
			this.typeLabel.TabIndex = 0;
			this.typeLabel.Text = "Type";
			this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Location = new System.Drawing.Point(0, 30);
			this.quantityLabel.Margin = new System.Windows.Forms.Padding(0);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.quantityLabel.Size = new System.Drawing.Size(75, 30);
			this.quantityLabel.TabIndex = 0;
			this.quantityLabel.Text = "Quantity";
			this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// typeBox
			// 
			this.typeBox.FormattingEnabled = true;
			this.typeBox.Location = new System.Drawing.Point(78, 6);
			this.typeBox.Name = "typeBox";
			this.typeBox.Size = new System.Drawing.Size(120, 21);
			this.typeBox.TabIndex = 1;
			// 
			// applyButton
			// 
			this.applyButton.Location = new System.Drawing.Point(3, 63);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(195, 24);
			this.applyButton.TabIndex = 3;
			this.applyButton.Text = "applyButton";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(78, 36);
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(120, 20);
			this.quantityBox.TabIndex = 4;
			this.quantityBox.TextChanged += new System.EventHandler(this.quantityBox_TextChanged);
			// 
			// CollectorDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(204, 93);
			this.Controls.Add(this.quantityBox);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.typeBox);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.typeLabel);
			this.Name = "CollectorDetailsForm";
			this.Text = "CollectorDetailsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.ComboBox typeBox;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.TextBox quantityBox;
	}
}