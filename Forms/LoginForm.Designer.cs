namespace dmyo_oop_final_assigment.Forms
{
	partial class LoginForm
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.showBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.nameLabel.Location = new System.Drawing.Point(9, 9);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Padding = new System.Windows.Forms.Padding(2);
			this.nameLabel.Size = new System.Drawing.Size(60, 24);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nameBox
			// 
			this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.nameBox.Location = new System.Drawing.Point(71, 12);
			this.nameBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(120, 20);
			this.nameBox.TabIndex = 1;
			// 
			// passwordLabel
			// 
			this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.passwordLabel.Location = new System.Drawing.Point(9, 34);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Padding = new System.Windows.Forms.Padding(2);
			this.passwordLabel.Size = new System.Drawing.Size(60, 24);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// passwordBox
			// 
			this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.passwordBox.Location = new System.Drawing.Point(71, 36);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 1;
			// 
			// loginButton
			// 
			this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.loginButton.Location = new System.Drawing.Point(12, 61);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(179, 23);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Log in";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// showBox
			// 
			this.showBox.AutoSize = true;
			this.showBox.Location = new System.Drawing.Point(176, 40);
			this.showBox.Name = "showBox";
			this.showBox.Size = new System.Drawing.Size(15, 14);
			this.showBox.TabIndex = 3;
			this.showBox.UseVisualStyleBackColor = true;
			this.showBox.CheckedChanged += new System.EventHandler(this.showBox_CheckedChanged);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(204, 89);
			this.Controls.Add(this.showBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.nameLabel);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.CheckBox showBox;
	}
}