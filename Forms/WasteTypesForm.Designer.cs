namespace dmyo_oop_final_assigment.Forms
{
	partial class WasteTypesForm
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
			this.wt_name = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.wt_group = new System.Windows.Forms.GroupBox();
			this.wt_description = new System.Windows.Forms.Label();
			this.wt_group.SuspendLayout();
			this.SuspendLayout();
			// 
			// wt_name
			// 
			this.wt_name.AutoSize = true;
			this.wt_name.Location = new System.Drawing.Point(6, 22);
			this.wt_name.Name = "wt_name";
			this.wt_name.Size = new System.Drawing.Size(35, 13);
			this.wt_name.TabIndex = 0;
			this.wt_name.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 64);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(200, 80);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(15, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(0, 0);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Description";
			// 
			// wt_group
			// 
			this.wt_group.Controls.Add(this.richTextBox1);
			this.wt_group.Controls.Add(this.textBox1);
			this.wt_group.Controls.Add(this.wt_description);
			this.wt_group.Controls.Add(this.wt_name);
			this.wt_group.Location = new System.Drawing.Point(12, 12);
			this.wt_group.Name = "wt_group";
			this.wt_group.Size = new System.Drawing.Size(215, 155);
			this.wt_group.TabIndex = 5;
			this.wt_group.TabStop = false;
			this.wt_group.Text = "Waste Type";
			// 
			// wt_description
			// 
			this.wt_description.AutoSize = true;
			this.wt_description.Location = new System.Drawing.Point(6, 48);
			this.wt_description.Name = "wt_description";
			this.wt_description.Size = new System.Drawing.Size(60, 13);
			this.wt_description.TabIndex = 0;
			this.wt_description.Text = "Description";
			// 
			// WasteTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 308);
			this.Controls.Add(this.wt_group);
			this.Controls.Add(this.groupBox1);
			this.Name = "WasteTypesForm";
			this.Text = "Waste Types";
			this.wt_group.ResumeLayout(false);
			this.wt_group.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label wt_name;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox wt_group;
		private System.Windows.Forms.Label wt_description;
	}
}