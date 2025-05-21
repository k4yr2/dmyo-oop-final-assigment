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
            this.stockButton = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.distributionButton = new System.Windows.Forms.Button();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.archivesLabel = new System.Windows.Forms.Label();
            this.archivesButton = new System.Windows.Forms.Button();
            this.recyclingLabel = new System.Windows.Forms.Label();
            this.recyclingButton = new System.Windows.Forms.Button();
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
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(855, 60);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Recycler Form";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.recyclingButton);
            this.navPanel.Controls.Add(this.recyclingLabel);
            this.navPanel.Controls.Add(this.archivesButton);
            this.navPanel.Controls.Add(this.archivesLabel);
            this.navPanel.Controls.Add(this.stockButton);
            this.navPanel.Controls.Add(this.stockLabel);
            this.navPanel.Controls.Add(this.distributionButton);
            this.navPanel.Controls.Add(this.distributionLabel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navPanel.Location = new System.Drawing.Point(0, 288);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(855, 120);
            this.navPanel.TabIndex = 10;
            // 
            // stockButton
            // 
            this.stockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockButton.Location = new System.Drawing.Point(750, 33);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(100, 24);
            this.stockButton.TabIndex = 13;
            this.stockButton.Text = "Stock";
            this.stockButton.UseVisualStyleBackColor = true;
            // 
            // stockLabel
            // 
            this.stockLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stockLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockLabel.Location = new System.Drawing.Point(0, 30);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
            this.stockLabel.Size = new System.Drawing.Size(855, 30);
            this.stockLabel.TabIndex = 12;
            this.stockLabel.Text = "Browse the factory\'s stocks";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distributionButton
            // 
            this.distributionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distributionButton.Location = new System.Drawing.Point(750, 3);
            this.distributionButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.distributionButton.Name = "distributionButton";
            this.distributionButton.Size = new System.Drawing.Size(100, 24);
            this.distributionButton.TabIndex = 11;
            this.distributionButton.Text = "Distribution";
            this.distributionButton.UseVisualStyleBackColor = true;
            // 
            // distributionLabel
            // 
            this.distributionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.distributionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.distributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.distributionLabel.Location = new System.Drawing.Point(0, 0);
            this.distributionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
            this.distributionLabel.Size = new System.Drawing.Size(855, 30);
            this.distributionLabel.TabIndex = 1;
            this.distributionLabel.Text = "Evaluate the distributions submitted to the factory";
            this.distributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // archivesLabel
            // 
            this.archivesLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.archivesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.archivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.archivesLabel.Location = new System.Drawing.Point(0, 60);
            this.archivesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.archivesLabel.Name = "archivesLabel";
            this.archivesLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
            this.archivesLabel.Size = new System.Drawing.Size(855, 30);
            this.archivesLabel.TabIndex = 14;
            this.archivesLabel.Text = "Browse the recycling archives";
            this.archivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // archivesButton
            // 
            this.archivesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.archivesButton.Location = new System.Drawing.Point(750, 63);
            this.archivesButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.archivesButton.Name = "archivesButton";
            this.archivesButton.Size = new System.Drawing.Size(100, 24);
            this.archivesButton.TabIndex = 15;
            this.archivesButton.Text = "Archive";
            this.archivesButton.UseVisualStyleBackColor = true;
            // 
            // recyclingLabel
            // 
            this.recyclingLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recyclingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recyclingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recyclingLabel.Location = new System.Drawing.Point(0, 90);
            this.recyclingLabel.Name = "recyclingLabel";
            this.recyclingLabel.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
            this.recyclingLabel.Size = new System.Drawing.Size(855, 30);
            this.recyclingLabel.TabIndex = 16;
            this.recyclingLabel.Text = "Start a new recycling process";
            this.recyclingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recyclingButton
            // 
            this.recyclingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recyclingButton.Location = new System.Drawing.Point(750, 94);
            this.recyclingButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.recyclingButton.Name = "recyclingButton";
            this.recyclingButton.Size = new System.Drawing.Size(100, 24);
            this.recyclingButton.TabIndex = 17;
            this.recyclingButton.Text = "Recycling";
            this.recyclingButton.UseVisualStyleBackColor = true;
            // 
            // RecyclerIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "RecyclerIdle";
            this.Size = new System.Drawing.Size(855, 408);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.Button distributionButton;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Label recyclingLabel;
        private System.Windows.Forms.Button archivesButton;
        private System.Windows.Forms.Label archivesLabel;
        private System.Windows.Forms.Button recyclingButton;
    }
}
