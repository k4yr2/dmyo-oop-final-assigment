namespace dmyo_oop_final_assigment.Controls
{
	partial class WasteControl
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
			this.quantityLabel = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.abbrLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(10, 10);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(30, 30);
			this.deleteButton.TabIndex = 0;
			this.deleteButton.Text = "X";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// typeLabel
			// 
			this.typeLabel.Location = new System.Drawing.Point(40, 10);
			this.typeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(120, 30);
			this.typeLabel.TabIndex = 1;
			this.typeLabel.Text = "Blank Type";
			this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// quantityLabel
			// 
			this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.quantityLabel.Location = new System.Drawing.Point(160, 10);
			this.quantityLabel.Margin = new System.Windows.Forms.Padding(0);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Padding = new System.Windows.Forms.Padding(2);
			this.quantityLabel.Size = new System.Drawing.Size(60, 30);
			this.quantityLabel.TabIndex = 1;
			this.quantityLabel.Text = "0";
			this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// updateButton
			// 
			this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.updateButton.Location = new System.Drawing.Point(318, 13);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(24, 24);
			this.updateButton.TabIndex = 0;
			this.updateButton.Text = "🖊️";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// abbrLabel
			// 
			this.abbrLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.abbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.abbrLabel.Location = new System.Drawing.Point(220, 10);
			this.abbrLabel.Margin = new System.Windows.Forms.Padding(0);
			this.abbrLabel.Name = "abbrLabel";
			this.abbrLabel.Padding = new System.Windows.Forms.Padding(2);
			this.abbrLabel.Size = new System.Drawing.Size(30, 30);
			this.abbrLabel.TabIndex = 1;
			this.abbrLabel.Text = "pcs";
			this.abbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WasteControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.abbrLabel);
			this.Controls.Add(this.quantityLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Name = "WasteControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(350, 50);
			this.Load += new System.EventHandler(this.WasteControl_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label abbrLabel;
	}
}
