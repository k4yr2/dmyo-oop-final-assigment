namespace dmyo_oop_final_assigment.Forms
{
	partial class NewWasteTypeForm
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
			this.wt_description = new System.Windows.Forms.Label();
			this.wt_apply = new System.Windows.Forms.Button();
			this.wt_delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// wt_name
			// 
			this.wt_name.AutoSize = true;
			this.wt_name.Location = new System.Drawing.Point(12, 9);
			this.wt_name.Name = "wt_name";
			this.wt_name.Size = new System.Drawing.Size(35, 13);
			this.wt_name.TabIndex = 0;
			this.wt_name.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 51);
			this.richTextBox1.MaxLength = 250;
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
			// wt_description
			// 
			this.wt_description.AutoSize = true;
			this.wt_description.Location = new System.Drawing.Point(12, 35);
			this.wt_description.Name = "wt_description";
			this.wt_description.Size = new System.Drawing.Size(60, 13);
			this.wt_description.TabIndex = 0;
			this.wt_description.Text = "Description";
			// 
			// wt_apply
			// 
			this.wt_apply.Location = new System.Drawing.Point(114, 137);
			this.wt_apply.Name = "wt_apply";
			this.wt_apply.Size = new System.Drawing.Size(98, 23);
			this.wt_apply.TabIndex = 6;
			this.wt_apply.Text = "Add";
			this.wt_apply.UseVisualStyleBackColor = true;
			// 
			// wt_delete
			// 
			this.wt_delete.Enabled = false;
			this.wt_delete.Location = new System.Drawing.Point(10, 137);
			this.wt_delete.Name = "wt_delete";
			this.wt_delete.Size = new System.Drawing.Size(98, 23);
			this.wt_delete.TabIndex = 7;
			this.wt_delete.Text = "Delete";
			this.wt_delete.UseVisualStyleBackColor = true;
			// 
			// WasteTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 167);
			this.Controls.Add(this.wt_delete);
			this.Controls.Add(this.wt_apply);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.wt_name);
			this.Controls.Add(this.wt_description);
			this.Name = "WasteTypesForm";
			this.Text = "Waste Types";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label wt_name;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label wt_description;
		private System.Windows.Forms.Button wt_delete;
		private System.Windows.Forms.Button wt_apply;
	}
}