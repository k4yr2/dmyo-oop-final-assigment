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
			this.wt_delete = new System.Windows.Forms.Button();
			this.wt_nameBox = new System.Windows.Forms.TextBox();
			this.wt_create = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// wt_name
			// 
			this.wt_name.AutoSize = true;
			this.wt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.wt_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.wt_name.Location = new System.Drawing.Point(4, 6);
			this.wt_name.Name = "wt_name";
			this.wt_name.Size = new System.Drawing.Size(66, 20);
			this.wt_name.TabIndex = 4;
			this.wt_name.Text = "BLANK";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Location = new System.Drawing.Point(6, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// wt_description
			// 
			this.wt_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.wt_description.BackColor = System.Drawing.SystemColors.Control;
			this.wt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.wt_description.Location = new System.Drawing.Point(76, 29);
			this.wt_description.Name = "wt_description";
			this.wt_description.ReadOnly = true;
			this.wt_description.Size = new System.Drawing.Size(218, 64);
			this.wt_description.TabIndex = 2;
			this.wt_description.Text = "";
			this.wt_description.Enter += new System.EventHandler(this.wt_description_Enter);
			this.wt_description.Leave += new System.EventHandler(this.wt_description_Leave);
			// 
			// wt_delete
			// 
			this.wt_delete.BackColor = System.Drawing.Color.Tomato;
			this.wt_delete.Location = new System.Drawing.Point(271, 3);
			this.wt_delete.Name = "wt_delete";
			this.wt_delete.Size = new System.Drawing.Size(23, 23);
			this.wt_delete.TabIndex = 3;
			this.wt_delete.Text = "X";
			this.wt_delete.UseVisualStyleBackColor = false;
			this.wt_delete.Click += new System.EventHandler(this.wt_delete_Click);
			// 
			// wt_nameBox
			// 
			this.wt_nameBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.wt_nameBox.Location = new System.Drawing.Point(6, 5);
			this.wt_nameBox.Name = "wt_nameBox";
			this.wt_nameBox.Size = new System.Drawing.Size(127, 20);
			this.wt_nameBox.TabIndex = 0;
			this.wt_nameBox.Visible = false;
			this.wt_nameBox.Enter += new System.EventHandler(this.wt_nameBox_Enter);
			this.wt_nameBox.Leave += new System.EventHandler(this.wt_nameBox_Leave);
			// 
			// wt_create
			// 
			this.wt_create.Location = new System.Drawing.Point(271, 3);
			this.wt_create.Name = "wt_create";
			this.wt_create.Size = new System.Drawing.Size(23, 23);
			this.wt_create.TabIndex = 5;
			this.wt_create.Text = "+";
			this.wt_create.UseVisualStyleBackColor = true;
			this.wt_create.Visible = false;
			this.wt_create.Click += new System.EventHandler(this.wt_create_Click);
			// 
			// WasteTypeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.wt_create);
			this.Controls.Add(this.wt_nameBox);
			this.Controls.Add(this.wt_delete);
			this.Controls.Add(this.wt_description);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.wt_name);
			this.Name = "WasteTypeControl";
			this.Size = new System.Drawing.Size(300, 98);
			this.Leave += new System.EventHandler(this.WasteTypeControl_Leave);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label wt_name;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox wt_description;
		private System.Windows.Forms.Button wt_delete;
		private System.Windows.Forms.TextBox wt_nameBox;
		private System.Windows.Forms.Button wt_create;
	}
}
