namespace mNotepad
{
    partial class dosyaKaydetUyariForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dosyaKaydetUyariForm));
            this.label1 = new System.Windows.Forms.Label();
            this.kaydetmedencikButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belgenizde yapmış olduğunuz değişiklikler henüz kaydedilmedi! Kaydetmeden çıkarsa" +
    "nız yapmış olduğunuz değişiklikler kaybolacaktır! Kaydetmeden çıkmak istediğiniz" +
    "e emin misiniz?";
            // 
            // kaydetmedencikButton
            // 
            this.kaydetmedencikButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kaydetmedencikButton.Location = new System.Drawing.Point(146, 119);
            this.kaydetmedencikButton.Name = "kaydetmedencikButton";
            this.kaydetmedencikButton.Size = new System.Drawing.Size(98, 23);
            this.kaydetmedencikButton.TabIndex = 3;
            this.kaydetmedencikButton.Text = "Kaydetmeden Çık";
            this.kaydetmedencikButton.UseVisualStyleBackColor = true;
            this.kaydetmedencikButton.Click += new System.EventHandler(this.kaydetmedencikButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iptalButton.Location = new System.Drawing.Point(42, 119);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(98, 23);
            this.iptalButton.TabIndex = 4;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::mNotepad.Properties.Resources.caution_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dosyaKaydetUyariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(287, 152);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.kaydetmedencikButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dosyaKaydetUyariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Değişikliklerden Vazgeçmek Üzeresiniz!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dosyaKaydetUyariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kaydetmedencikButton;
        private System.Windows.Forms.Button iptalButton;
    }
}