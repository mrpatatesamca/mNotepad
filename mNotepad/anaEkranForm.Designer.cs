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
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araclarButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.kodlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.karakterkodlamaLabel = new System.Windows.Forms.Label();
            this.satirsayiLabel = new System.Windows.Forms.Label();
            this.karaktersayiLabel = new System.Windows.Forms.Label();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.farklıKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.dosyaButton.Image = global::mNotepad.Properties.Resources.file;
            this.dosyaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dosyaButton.Name = "dosyaButton";
            this.dosyaButton.Size = new System.Drawing.Size(68, 22);
            this.dosyaButton.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = global::mNotepad.Properties.Resources.new_file;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::mNotepad.Properties.Resources.folder;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::mNotepad.Properties.Resources.save;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Image = global::mNotepad.Properties.Resources.save;
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::mNotepad.Properties.Resources.print;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // araclarButton
            // 
            this.araclarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.araclarButton.Image = global::mNotepad.Properties.Resources.toolbox;
            this.araclarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.araclarButton.Name = "araclarButton";
            this.araclarButton.Size = new System.Drawing.Size(73, 22);
            this.araclarButton.Text = "Araçlar";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Image = global::mNotepad.Properties.Resources.setting;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // metinButton
            // 
            this.metinButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kodlamaToolStripMenuItem,
            this.yazıTipiToolStripMenuItem});
            this.metinButton.Image = global::mNotepad.Properties.Resources.text;
            this.metinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.metinButton.Name = "metinButton";
            this.metinButton.Size = new System.Drawing.Size(67, 22);
            this.metinButton.Text = "Metin";
            // 
            // kodlamaToolStripMenuItem
            // 
            this.kodlamaToolStripMenuItem.Name = "kodlamaToolStripMenuItem";
            this.kodlamaToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.kodlamaToolStripMenuItem.Text = "Kodlama";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Image = global::mNotepad.Properties.Resources.font;
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi ve Biçimlendirme";
            // 
            // yardimButton
            // 
            this.yardimButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardimButton.Image = global::mNotepad.Properties.Resources.provider;
            this.yardimButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardimButton.Name = "yardimButton";
            this.yardimButton.Size = new System.Drawing.Size(73, 22);
            this.yardimButton.Text = "Yardım";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.karakterkodlamaLabel);
            this.panel1.Controls.Add(this.satirsayiLabel);
            this.panel1.Controls.Add(this.karaktersayiLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 27);
            this.panel1.TabIndex = 2;
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
            // satirsayiLabel
            // 
            this.satirsayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.satirsayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.satirsayiLabel.Location = new System.Drawing.Point(123, 0);
            this.satirsayiLabel.Name = "satirsayiLabel";
            this.satirsayiLabel.Size = new System.Drawing.Size(96, 27);
            this.satirsayiLabel.TabIndex = 4;
            this.satirsayiLabel.Text = "Satır: 2147483647";
            this.satirsayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LineNumberTextBox.Location = new System.Drawing.Point(0, 25);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(30, 229);
            this.LineNumberTextBox.TabIndex = 3;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(30, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 229);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::mNotepad.Properties.Resources.info;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // anaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(439, 281);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LineNumberTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ustmenuToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "anaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mNotepad - \"DUZENLENEN_DOSYA_YOLU\"";
            this.Load += new System.EventHandler(this.anaEkranForm_Load);
            this.Resize += new System.EventHandler(this.anaEkranForm_Resize);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label karaktersayiLabel;
        private System.Windows.Forms.Label satirsayiLabel;
        private System.Windows.Forms.Label karakterkodlamaLabel;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

