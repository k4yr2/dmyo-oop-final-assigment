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
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.storingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contentContainer = new dmyo_oop_final_assigment.Controls.ContentContainer();
            this.completeButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.Controls.Add(this.completeButton);
            this.topPanel.Controls.Add(this.seperatorLabel);
            this.topPanel.Controls.Add(this.stockLabel);
            this.topPanel.Controls.Add(this.storingLabel);
            this.topPanel.Controls.Add(this.cancelButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(819, 49);
            this.topPanel.TabIndex = 2;
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.Location = new System.Drawing.Point(165, 0);
            this.seperatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(16, 49);
            this.seperatorLabel.TabIndex = 2;
            this.seperatorLabel.Text = "/";
            this.seperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockLabel
            // 
            this.stockLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.stockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockLabel.Location = new System.Drawing.Point(189, 10);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(106, 29);
            this.stockLabel.TabIndex = 1;
            this.stockLabel.Text = "STOCK";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storingLabel
            // 
            this.storingLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.storingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storingLabel.Location = new System.Drawing.Point(51, 10);
            this.storingLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.storingLabel.Name = "storingLabel";
            this.storingLabel.Size = new System.Drawing.Size(106, 29);
            this.storingLabel.TabIndex = 1;
            this.storingLabel.Text = "Storing";
            this.storingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(11, 10);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(11, 10, 4, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(32, 30);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // contentContainer
            // 
            this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer.Location = new System.Drawing.Point(0, 49);
            this.contentContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(819, 490);
            this.contentContainer.TabIndex = 3;
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(735, 9);
            this.completeButton.Margin = new System.Windows.Forms.Padding(11, 10, 4, 10);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(80, 30);
            this.completeButton.TabIndex = 3;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // RecyclerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecyclerStock";
            this.Size = new System.Drawing.Size(819, 539);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label seperatorLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label storingLabel;
        private System.Windows.Forms.Button cancelButton;
        private ContentContainer contentContainer;
        private System.Windows.Forms.Button completeButton;
    }
}
