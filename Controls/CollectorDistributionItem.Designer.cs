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
            this.abbrLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.quantityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // abbrLabel
            // 
            this.abbrLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.abbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.abbrLabel.Location = new System.Drawing.Point(520, 0);
            this.abbrLabel.Name = "abbrLabel";
            this.abbrLabel.Size = new System.Drawing.Size(40, 40);
            this.abbrLabel.TabIndex = 1;
            this.abbrLabel.Text = "pcs";
            this.abbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typeLabel.Location = new System.Drawing.Point(0, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.typeLabel.Size = new System.Drawing.Size(160, 40);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "BLANK";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // capacityLabel
            // 
            this.capacityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.capacityLabel.Location = new System.Drawing.Point(460, 0);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(60, 40);
            this.capacityLabel.TabIndex = 2;
            this.capacityLabel.Text = "0";
            this.capacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.seperatorLabel.Location = new System.Drawing.Point(430, 0);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(30, 40);
            this.seperatorLabel.TabIndex = 4;
            this.seperatorLabel.Text = "/";
            this.seperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(0, 10);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(10);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(60, 20);
            this.quantityBox.TabIndex = 3;
            this.quantityBox.TextChanged += new System.EventHandler(this.dispatchBox_TextChanged);
            // 
            // quantityPanel
            // 
            this.quantityPanel.Controls.Add(this.quantityBox);
            this.quantityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.quantityPanel.Location = new System.Drawing.Point(370, 0);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(60, 40);
            this.quantityPanel.TabIndex = 8;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityLabel.Location = new System.Drawing.Point(310, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(60, 40);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "0";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentLabel
            // 
            this.percentLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.percentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.percentLabel.Location = new System.Drawing.Point(250, 0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(60, 40);
            this.percentLabel.TabIndex = 11;
            this.percentLabel.Text = "%0";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CollectorDistributionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.seperatorLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.abbrLabel);
            this.Controls.Add(this.typeLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(400, 40);
            this.Name = "CollectorDistributionItem";
            this.Size = new System.Drawing.Size(560, 40);
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label capacityLabel;
		private System.Windows.Forms.Label seperatorLabel;
		private System.Windows.Forms.Label abbrLabel;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label percentLabel;
    }
}
