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
			this.panel1 = new System.Windows.Forms.Panel();
			this.wt_control3 = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.wt_control2 = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.wt_control1 = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.wt_controlX = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.wt_control5 = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.wt_control4 = new dmyo_oop_final_assigment.Controls.WasteTypeControl();
			this.pagebarControl1 = new dmyo_oop_final_assigment.Controls.PagebarControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.wt_control3);
			this.panel1.Controls.Add(this.wt_control2);
			this.panel1.Controls.Add(this.wt_control1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(306, 312);
			this.panel1.TabIndex = 0;
			// 
			// wt_control3
			// 
			this.wt_control3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_control3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_control3.Location = new System.Drawing.Point(3, 211);
			this.wt_control3.Name = "wt_control3";
			this.wt_control3.Size = new System.Drawing.Size(300, 98);
			this.wt_control3.TabIndex = 0;
			// 
			// wt_control2
			// 
			this.wt_control2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_control2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_control2.Location = new System.Drawing.Point(3, 107);
			this.wt_control2.Name = "wt_control2";
			this.wt_control2.Size = new System.Drawing.Size(300, 98);
			this.wt_control2.TabIndex = 0;
			// 
			// wt_control1
			// 
			this.wt_control1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_control1.Location = new System.Drawing.Point(3, 3);
			this.wt_control1.Name = "wt_control1";
			this.wt_control1.Size = new System.Drawing.Size(300, 98);
			this.wt_control1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.wt_controlX);
			this.panel2.Controls.Add(this.wt_control5);
			this.panel2.Controls.Add(this.wt_control4);
			this.panel2.Location = new System.Drawing.Point(325, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(306, 312);
			this.panel2.TabIndex = 0;
			// 
			// wt_controlX
			// 
			this.wt_controlX.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_controlX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_controlX.Location = new System.Drawing.Point(3, 211);
			this.wt_controlX.Name = "wt_controlX";
			this.wt_controlX.Size = new System.Drawing.Size(300, 98);
			this.wt_controlX.TabIndex = 0;
			// 
			// wt_control5
			// 
			this.wt_control5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_control5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_control5.Location = new System.Drawing.Point(3, 107);
			this.wt_control5.Name = "wt_control5";
			this.wt_control5.Size = new System.Drawing.Size(300, 98);
			this.wt_control5.TabIndex = 0;
			// 
			// wt_control4
			// 
			this.wt_control4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.wt_control4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.wt_control4.Location = new System.Drawing.Point(3, 3);
			this.wt_control4.Name = "wt_control4";
			this.wt_control4.Size = new System.Drawing.Size(300, 98);
			this.wt_control4.TabIndex = 0;
			// 
			// pagebarControl1
			// 
			this.pagebarControl1.Count = 1;
			this.pagebarControl1.Current = 1;
			this.pagebarControl1.Location = new System.Drawing.Point(133, 330);
			this.pagebarControl1.Name = "pagebarControl1";
			this.pagebarControl1.Size = new System.Drawing.Size(375, 30);
			this.pagebarControl1.TabIndex = 1;
			// 
			// WasteTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 363);
			this.Controls.Add(this.pagebarControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "WasteTypesForm";
			this.Text = "Waste Types";
			this.Load += new System.EventHandler(this.WasteTypesForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Controls.WasteTypeControl wt_control3;
		private Controls.WasteTypeControl wt_control2;
		private Controls.WasteTypeControl wt_control1;
		private System.Windows.Forms.Panel panel2;
		private Controls.WasteTypeControl wt_controlX;
		private Controls.WasteTypeControl wt_control5;
		private Controls.WasteTypeControl wt_control4;
		private Controls.PagebarControl pagebarControl1;
	}
}