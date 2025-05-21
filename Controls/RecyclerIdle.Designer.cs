namespace dmyo_oop_final_assigment.Controls
{
    partial class RecyclerIdle
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.storageButton = new System.Windows.Forms.Button();
            this.storageLabel = new System.Windows.Forms.Label();
            this.stockButton = new System.Windows.Forms.Button();
            this.storingButton = new System.Windows.Forms.Button();
            this.storingLabel = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1140, 74);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Recycler Form";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.storageButton);
            this.navPanel.Controls.Add(this.storageLabel);
            this.navPanel.Controls.Add(this.stockButton);
            this.navPanel.Controls.Add(this.storingButton);
            this.navPanel.Controls.Add(this.storingLabel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navPanel.Location = new System.Drawing.Point(0, 422);
            this.navPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1140, 80);
            this.navPanel.TabIndex = 10;
            // 
            // storageButton
            // 
            this.storageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storageButton.Location = new System.Drawing.Point(1000, 42);
            this.storageButton.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.storageButton.Name = "storageButton";
            this.storageButton.Size = new System.Drawing.Size(133, 30);
            this.storageButton.TabIndex = 17;
            this.storageButton.Text = "Storage";
            this.storageButton.UseVisualStyleBackColor = true;
            // 
            // storageLabel
            // 
            this.storageLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.storageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storageLabel.Location = new System.Drawing.Point(0, 37);
            this.storageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Padding = new System.Windows.Forms.Padding(0, 0, 147, 0);
            this.storageLabel.Size = new System.Drawing.Size(1140, 37);
            this.storageLabel.TabIndex = 16;
            this.storageLabel.Text = "Browse the storage and recycle";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stockButton
            // 
            this.stockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockButton.Location = new System.Drawing.Point(1000, 41);
            this.stockButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(133, 30);
            this.stockButton.TabIndex = 13;
            this.stockButton.Text = "Stock";
            this.stockButton.UseVisualStyleBackColor = true;
            // 
            // storingButton
            // 
            this.storingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storingButton.Location = new System.Drawing.Point(1000, 4);
            this.storingButton.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.storingButton.Name = "storingButton";
            this.storingButton.Size = new System.Drawing.Size(133, 30);
            this.storingButton.TabIndex = 11;
            this.storingButton.Text = "Storing";
            this.storingButton.UseVisualStyleBackColor = true;
            this.storingButton.Click += new System.EventHandler(this.storingButton_Click);
            // 
            // storingLabel
            // 
            this.storingLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.storingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.storingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storingLabel.Location = new System.Drawing.Point(0, 0);
            this.storingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.storingLabel.Name = "storingLabel";
            this.storingLabel.Padding = new System.Windows.Forms.Padding(0, 0, 147, 0);
            this.storingLabel.Size = new System.Drawing.Size(1140, 37);
            this.storingLabel.TabIndex = 1;
            this.storingLabel.Text = "Store the requests submitted to the factory";
            this.storingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RecyclerIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecyclerIdle";
            this.Size = new System.Drawing.Size(1140, 502);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label storingLabel;
        private System.Windows.Forms.Button storingButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Button storageButton;
    }
}
