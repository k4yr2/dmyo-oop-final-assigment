namespace dmyo_oop_final_assigment.Controls
{
    partial class RecyclerRecycling
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
            this.completeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contentContainer = new dmyo_oop_final_assigment.Controls.ContentContainer();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.Controls.Add(this.storageLabel);
            this.topPanel.Controls.Add(this.completeButton);
            this.topPanel.Controls.Add(this.cancelButton);
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
            this.storageLabel.Text = "Recycle";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(611, 9);
            this.completeButton.Margin = new System.Windows.Forms.Padding(11, 10, 4, 10);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(100, 30);
            this.completeButton.TabIndex = 1;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = false;
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
            // 
            // contentContainer
            // 
            this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer.Location = new System.Drawing.Point(0, 49);
            this.contentContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(724, 333);
            this.contentContainer.TabIndex = 3;
            // 
            // RecyclerRecycling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.topPanel);
            this.Name = "RecyclerRecycling";
            this.Size = new System.Drawing.Size(724, 382);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Button cancelButton;
        private ContentContainer contentContainer;
        private System.Windows.Forms.Button completeButton;
    }
}
