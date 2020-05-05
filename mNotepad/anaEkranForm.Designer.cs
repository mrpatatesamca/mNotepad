namespace mNotepad
{
    partial class anaEkranForm
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranForm));
            this.ustmenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.dosyaButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.araclarButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.yardimButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.kodlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.karaktersayiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.karakterkodlamaLabel = new System.Windows.Forms.Label();
            this.ustmenuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustmenuToolStrip
            // 
            this.ustmenuToolStrip.BackColor = System.Drawing.Color.White;
            this.ustmenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ustmenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaButton,
            this.araclarButton,
            this.metinButton,
            this.yardimButton});
            this.ustmenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ustmenuToolStrip.Name = "ustmenuToolStrip";
            this.ustmenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ustmenuToolStrip.Size = new System.Drawing.Size(439, 25);
            this.ustmenuToolStrip.TabIndex = 0;
            this.ustmenuToolStrip.Text = "ustmenuToolStrip";
            // 
            // dosyaButton
            // 
            this.dosyaButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem});
            this.dosyaButton.Image = ((System.Drawing.Image)(resources.GetObject("dosyaButton.Image")));
            this.dosyaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dosyaButton.Name = "dosyaButton";
            this.dosyaButton.Size = new System.Drawing.Size(68, 22);
            this.dosyaButton.Text = "Dosya";
            // 
            // araclarButton
            // 
            this.araclarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.araclarButton.Image = ((System.Drawing.Image)(resources.GetObject("araclarButton.Image")));
            this.araclarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.araclarButton.Name = "araclarButton";
            this.araclarButton.Size = new System.Drawing.Size(73, 22);
            this.araclarButton.Text = "Araçlar";
            // 
            // yardimButton
            // 
            this.yardimButton.Image = ((System.Drawing.Image)(resources.GetObject("yardimButton.Image")));
            this.yardimButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardimButton.Name = "yardimButton";
            this.yardimButton.Size = new System.Drawing.Size(73, 22);
            this.yardimButton.Text = "Yardım";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // metinButton
            // 
            this.metinButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kodlamaToolStripMenuItem,
            this.yazıTipiToolStripMenuItem});
            this.metinButton.Image = ((System.Drawing.Image)(resources.GetObject("metinButton.Image")));
            this.metinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.metinButton.Name = "metinButton";
            this.metinButton.Size = new System.Drawing.Size(67, 22);
            this.metinButton.Text = "Metin";
            // 
            // kodlamaToolStripMenuItem
            // 
            this.kodlamaToolStripMenuItem.Name = "kodlamaToolStripMenuItem";
            this.kodlamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kodlamaToolStripMenuItem.Text = "Kodlama";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            // 
            // editorRichTextBox
            // 
            this.editorRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.editorRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorRichTextBox.EnableAutoDragDrop = true;
            this.editorRichTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editorRichTextBox.Location = new System.Drawing.Point(0, 27);
            this.editorRichTextBox.Name = "editorRichTextBox";
            this.editorRichTextBox.Size = new System.Drawing.Size(592, 274);
            this.editorRichTextBox.TabIndex = 1;
            this.editorRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.karakterkodlamaLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.karaktersayiLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 27);
            this.panel1.TabIndex = 2;
            // 
            // karaktersayiLabel
            // 
            this.karaktersayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.karaktersayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.karaktersayiLabel.Location = new System.Drawing.Point(3, 0);
            this.karaktersayiLabel.Name = "karaktersayiLabel";
            this.karaktersayiLabel.Size = new System.Drawing.Size(114, 27);
            this.karaktersayiLabel.TabIndex = 3;
            this.karaktersayiLabel.Text = "Karakter: 2147483647";
            this.karaktersayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(123, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satır: 2147483647";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karakterkodlamaLabel
            // 
            this.karakterkodlamaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.karakterkodlamaLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.karakterkodlamaLabel.Location = new System.Drawing.Point(345, 0);
            this.karakterkodlamaLabel.Name = "karakterkodlamaLabel";
            this.karakterkodlamaLabel.Size = new System.Drawing.Size(91, 27);
            this.karakterkodlamaLabel.TabIndex = 5;
            this.karakterkodlamaLabel.Text = "UTF-8";
            this.karakterkodlamaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // anaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(439, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editorRichTextBox);
            this.Controls.Add(this.ustmenuToolStrip);
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "anaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mNotepad - \"DUZENLENEN_DOSYA_DOLU\"";
            this.Load += new System.EventHandler(this.anaEkranForm_Load);
            this.ustmenuToolStrip.ResumeLayout(false);
            this.ustmenuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ustmenuToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton dosyaButton;
        private System.Windows.Forms.ToolStripDropDownButton araclarButton;
        private System.Windows.Forms.ToolStripDropDownButton yardimButton;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton metinButton;
        private System.Windows.Forms.ToolStripMenuItem kodlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox editorRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label karaktersayiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label karakterkodlamaLabel;
    }
}

