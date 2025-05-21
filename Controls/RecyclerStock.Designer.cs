namespace dmyo_oop_final_assigment.Controls
{
    partial class RecyclerStock
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
            this.storingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.Controls.Add(this.seperatorLabel);
            this.topPanel.Controls.Add(this.stockLabel);
            this.topPanel.Controls.Add(this.storingLabel);
            this.topPanel.Controls.Add(this.cancelButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(614, 40);
            this.topPanel.TabIndex = 2;
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
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(8, 8);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(24, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // stockLabel
            // 
            this.stockLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.stockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockLabel.Location = new System.Drawing.Point(142, 8);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(80, 24);
            this.stockLabel.TabIndex = 1;
            this.stockLabel.Text = "STOCK";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.Location = new System.Drawing.Point(124, 0);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(12, 40);
            this.seperatorLabel.TabIndex = 2;
            this.seperatorLabel.Text = "/";
            this.seperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecyclerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Name = "RecyclerStock";
            this.Size = new System.Drawing.Size(614, 438);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label seperatorLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label storingLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}
