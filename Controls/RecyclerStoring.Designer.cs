namespace dmyo_oop_final_assigment.Controls
{
    partial class RecyclerStoring
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.idleButton = new System.Windows.Forms.Button();
            this.storingLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.Controls.Add(this.storingLabel);
            this.topPanel.Controls.Add(this.idleButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(659, 40);
            this.topPanel.TabIndex = 1;
            // 
            // idleButton
            // 
            this.idleButton.BackColor = System.Drawing.Color.Gainsboro;
            this.idleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idleButton.Location = new System.Drawing.Point(8, 8);
            this.idleButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.idleButton.Name = "idleButton";
            this.idleButton.Size = new System.Drawing.Size(24, 24);
            this.idleButton.TabIndex = 1;
            this.idleButton.Text = "I";
            this.idleButton.UseVisualStyleBackColor = false;
            // 
            // storingLabel
            // 
            this.storingLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.storingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storingLabel.Location = new System.Drawing.Point(38, 8);
            this.storingLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.storingLabel.Name = "storingLabel";
            this.storingLabel.Size = new System.Drawing.Size(80, 24);
            this.storingLabel.TabIndex = 1;
            this.storingLabel.Text = "Storing";
            this.storingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecyclerStoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Name = "RecyclerStoring";
            this.Size = new System.Drawing.Size(659, 346);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label storingLabel;
        private System.Windows.Forms.Button idleButton;
    }
}
