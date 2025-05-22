namespace dmyo_oop_final_assigment.Controls
{
    partial class RecyclerStorage
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
            this.storageLabel = new System.Windows.Forms.Label();
            this.idleButton = new System.Windows.Forms.Button();
            this.contentContainer1 = new dmyo_oop_final_assigment.Controls.ContentContainer();
            this.recycleButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.Controls.Add(this.storageLabel);
            this.topPanel.Controls.Add(this.recycleButton);
            this.topPanel.Controls.Add(this.idleButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(724, 49);
            this.topPanel.TabIndex = 2;
            // 
            // storageLabel
            // 
            this.storageLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storageLabel.Location = new System.Drawing.Point(51, 10);
            this.storageLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(106, 29);
            this.storageLabel.TabIndex = 1;
            this.storageLabel.Text = "Storage";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idleButton
            // 
            this.idleButton.BackColor = System.Drawing.Color.Gainsboro;
            this.idleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idleButton.Location = new System.Drawing.Point(11, 10);
            this.idleButton.Margin = new System.Windows.Forms.Padding(11, 10, 4, 10);
            this.idleButton.Name = "idleButton";
            this.idleButton.Size = new System.Drawing.Size(32, 30);
            this.idleButton.TabIndex = 1;
            this.idleButton.Text = "I";
            this.idleButton.UseVisualStyleBackColor = false;
            this.idleButton.Click += new System.EventHandler(this.idleButton_Click);
            // 
            // contentContainer1
            // 
            this.contentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer1.Location = new System.Drawing.Point(0, 49);
            this.contentContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentContainer1.Name = "contentContainer1";
            this.contentContainer1.Size = new System.Drawing.Size(724, 333);
            this.contentContainer1.TabIndex = 3;
            // 
            // recycleButton
            // 
            this.recycleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recycleButton.BackColor = System.Drawing.Color.Gainsboro;
            this.recycleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recycleButton.Location = new System.Drawing.Point(611, 9);
            this.recycleButton.Margin = new System.Windows.Forms.Padding(11, 10, 4, 10);
            this.recycleButton.Name = "recycleButton";
            this.recycleButton.Size = new System.Drawing.Size(100, 30);
            this.recycleButton.TabIndex = 1;
            this.recycleButton.Text = "Recycle";
            this.recycleButton.UseVisualStyleBackColor = false;
            this.recycleButton.Click += new System.EventHandler(this.recycleButton_Click);
            // 
            // RecyclerStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentContainer1);
            this.Controls.Add(this.topPanel);
            this.Name = "RecyclerStorage";
            this.Size = new System.Drawing.Size(724, 382);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Button idleButton;
        private ContentContainer contentContainer1;
        private System.Windows.Forms.Button recycleButton;
    }
}
