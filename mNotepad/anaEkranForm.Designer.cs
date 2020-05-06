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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranForm));
            this.ustmenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.dosyaButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodlamaButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.aNSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araclarButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.karakterkodlamaLabel = new System.Windows.Forms.Label();
            this.satirsayiLabel = new System.Windows.Forms.Label();
            this.karaktersayiLabel = new System.Windows.Forms.Label();
            this.duzenlemeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopyalaMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.kesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.silMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tumunusecMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.gerialMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ilerialMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.kodlamaRenklendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phytonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustmenuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.duzenlemeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustmenuToolStrip
            // 
            this.ustmenuToolStrip.BackColor = System.Drawing.Color.White;
            this.ustmenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ustmenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaButton,
            this.toolStripDropDownButton1,
            this.metinButton,
            this.kodlamaButton,
            this.araclarButton,
            this.yardimButton});
            this.ustmenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ustmenuToolStrip.Name = "ustmenuToolStrip";
            this.ustmenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ustmenuToolStrip.Size = new System.Drawing.Size(567, 25);
            this.ustmenuToolStrip.TabIndex = 0;
            this.ustmenuToolStrip.Text = "ustmenuToolStrip";
            // 
            // dosyaButton
            // 
            this.dosyaButton.AutoToolTip = false;
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
            this.yeniToolStripMenuItem.ToolTipText = "Düzenlemek için yeni bir pencere açar.";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::mNotepad.Properties.Resources.folder;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.ToolTipText = "Bir metin belgesini düzenlemek üzere açar.";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::mNotepad.Properties.Resources.save;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.ToolTipText = "Değişiklikleri kaydeder.";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Image = global::mNotepad.Properties.Resources.save;
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.ToolTipText = "Var olan dosyadan bağımsız olarak başka bir dosyaya kayıt eder.";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::mNotepad.Properties.Resources.print;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.ToolTipText = "Yazdığınız yazıları bastırmak üzere yazıcıya gönderir.";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem,
            this.geriAlToolStripMenuItem,
            this.ileriAlToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::mNotepad.Properties.Resources.edit;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripDropDownButton1.Text = "Düzenle";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.silToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // ileriAlToolStripMenuItem
            // 
            this.ileriAlToolStripMenuItem.Name = "ileriAlToolStripMenuItem";
            this.ileriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.ileriAlToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ileriAlToolStripMenuItem.Text = "İleri Al";
            this.ileriAlToolStripMenuItem.Click += new System.EventHandler(this.ileriAlToolStripMenuItem_Click);
            // 
            // metinButton
            // 
            this.metinButton.AutoToolTip = false;
            this.metinButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıTipiToolStripMenuItem});
            this.metinButton.Image = global::mNotepad.Properties.Resources.text;
            this.metinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.metinButton.Name = "metinButton";
            this.metinButton.Size = new System.Drawing.Size(67, 22);
            this.metinButton.Text = "Metin";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazıTipiToolStripMenuItem.Image = global::mNotepad.Properties.Resources.font;
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi ve Biçimlendirme";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // kodlamaButton
            // 
            this.kodlamaButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNSIToolStripMenuItem,
            this.uTF8ToolStripMenuItem,
            this.kodlamaRenklendirmeToolStripMenuItem});
            this.kodlamaButton.Image = global::mNotepad.Properties.Resources.coding2;
            this.kodlamaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kodlamaButton.Name = "kodlamaButton";
            this.kodlamaButton.Size = new System.Drawing.Size(83, 22);
            this.kodlamaButton.Text = "Kodlama";
            // 
            // aNSIToolStripMenuItem
            // 
            this.aNSIToolStripMenuItem.Name = "aNSIToolStripMenuItem";
            this.aNSIToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aNSIToolStripMenuItem.Text = "ANSI";
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            // 
            // araclarButton
            // 
            this.araclarButton.AutoToolTip = false;
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
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // yardimButton
            // 
            this.yardimButton.AutoToolTip = false;
            this.yardimButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardimButton.Image = global::mNotepad.Properties.Resources.provider;
            this.yardimButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardimButton.Name = "yardimButton";
            this.yardimButton.Size = new System.Drawing.Size(73, 22);
            this.yardimButton.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::mNotepad.Properties.Resources.info;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.karakterkodlamaLabel);
            this.panel1.Controls.Add(this.satirsayiLabel);
            this.panel1.Controls.Add(this.karaktersayiLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 27);
            this.panel1.TabIndex = 2;
            // 
            // karakterkodlamaLabel
            // 
            this.karakterkodlamaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.karakterkodlamaLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.karakterkodlamaLabel.Location = new System.Drawing.Point(344, 0);
            this.karakterkodlamaLabel.Name = "karakterkodlamaLabel";
            this.karakterkodlamaLabel.Size = new System.Drawing.Size(220, 27);
            this.karakterkodlamaLabel.TabIndex = 5;
            this.karakterkodlamaLabel.Text = "UTF-8";
            this.karakterkodlamaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // satirsayiLabel
            // 
            this.satirsayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.satirsayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.satirsayiLabel.Location = new System.Drawing.Point(137, 0);
            this.satirsayiLabel.Name = "satirsayiLabel";
            this.satirsayiLabel.Size = new System.Drawing.Size(128, 27);
            this.satirsayiLabel.TabIndex = 4;
            this.satirsayiLabel.Text = "Satır: 0";
            this.satirsayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karaktersayiLabel
            // 
            this.karaktersayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.karaktersayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.karaktersayiLabel.Location = new System.Drawing.Point(3, 0);
            this.karaktersayiLabel.Name = "karaktersayiLabel";
            this.karaktersayiLabel.Size = new System.Drawing.Size(128, 27);
            this.karaktersayiLabel.TabIndex = 3;
            this.karaktersayiLabel.Text = "Karakter: 0";
            this.karaktersayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // duzenlemeMenuStrip
            // 
            this.duzenlemeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaMenuButton,
            this.kesMenuButton,
            this.yapistirMenuButton,
            this.silMenuButton,
            this.tumunusecMenuButton,
            this.gerialMenuButton,
            this.ilerialMenuButton});
            this.duzenlemeMenuStrip.Name = "duzenlemeMenuStrip";
            this.duzenlemeMenuStrip.Size = new System.Drawing.Size(183, 158);
            // 
            // kopyalaMenuButton
            // 
            this.kopyalaMenuButton.Name = "kopyalaMenuButton";
            this.kopyalaMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaMenuButton.Size = new System.Drawing.Size(182, 22);
            this.kopyalaMenuButton.Text = "Kopyala";
            this.kopyalaMenuButton.Click += new System.EventHandler(this.kopyalaMenuButton_Click);
            // 
            // kesMenuButton
            // 
            this.kesMenuButton.Name = "kesMenuButton";
            this.kesMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesMenuButton.Size = new System.Drawing.Size(182, 22);
            this.kesMenuButton.Text = "Kes";
            this.kesMenuButton.Click += new System.EventHandler(this.kesMenuButton_Click);
            // 
            // yapistirMenuButton
            // 
            this.yapistirMenuButton.Name = "yapistirMenuButton";
            this.yapistirMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapistirMenuButton.Size = new System.Drawing.Size(182, 22);
            this.yapistirMenuButton.Text = "Yapıştır";
            this.yapistirMenuButton.Click += new System.EventHandler(this.yapistirMenuButton_Click);
            // 
            // silMenuButton
            // 
            this.silMenuButton.Name = "silMenuButton";
            this.silMenuButton.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.silMenuButton.Size = new System.Drawing.Size(182, 22);
            this.silMenuButton.Text = "Sil";
            this.silMenuButton.Click += new System.EventHandler(this.silMenuButton_Click);
            // 
            // tumunusecMenuButton
            // 
            this.tumunusecMenuButton.Name = "tumunusecMenuButton";
            this.tumunusecMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tumunusecMenuButton.Size = new System.Drawing.Size(182, 22);
            this.tumunusecMenuButton.Text = "Tümünü Seç";
            this.tumunusecMenuButton.Click += new System.EventHandler(this.tumunusecMenuButton_Click);
            // 
            // gerialMenuButton
            // 
            this.gerialMenuButton.Name = "gerialMenuButton";
            this.gerialMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.gerialMenuButton.Size = new System.Drawing.Size(182, 22);
            this.gerialMenuButton.Text = "Geri Al";
            this.gerialMenuButton.Click += new System.EventHandler(this.gerialMenuButton_Click);
            // 
            // ilerialMenuButton
            // 
            this.ilerialMenuButton.Name = "ilerialMenuButton";
            this.ilerialMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.ilerialMenuButton.Size = new System.Drawing.Size(182, 22);
            this.ilerialMenuButton.Text = "İleri Al";
            this.ilerialMenuButton.Click += new System.EventHandler(this.ilerialMenuButton_Click);
            // 
            // scintilla1
            // 
            this.scintilla1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla1.CaretLineVisible = true;
            this.scintilla1.CaretWidth = 3;
            this.scintilla1.ContextMenuStrip = this.duzenlemeMenuStrip;
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.EdgeColor = System.Drawing.Color.OrangeRed;
            this.scintilla1.Location = new System.Drawing.Point(0, 25);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(567, 331);
            this.scintilla1.TabIndex = 6;
            this.scintilla1.WhitespaceSize = 0;
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            // 
            // kodlamaRenklendirmeToolStripMenuItem
            // 
            this.kodlamaRenklendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.containerToolStripMenuItem,
            this.cPPToolStripMenuItem,
            this.phytonToolStripMenuItem});
            this.kodlamaRenklendirmeToolStripMenuItem.Name = "kodlamaRenklendirmeToolStripMenuItem";
            this.kodlamaRenklendirmeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kodlamaRenklendirmeToolStripMenuItem.Text = "Kodlama Renklendirme";
            // 
            // cPPToolStripMenuItem
            // 
            this.cPPToolStripMenuItem.Name = "cPPToolStripMenuItem";
            this.cPPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cPPToolStripMenuItem.Text = "CPP";
            this.cPPToolStripMenuItem.Click += new System.EventHandler(this.cPPToolStripMenuItem_Click);
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.containerToolStripMenuItem.Text = "Container";
            this.containerToolStripMenuItem.Click += new System.EventHandler(this.containerToolStripMenuItem_Click);
            // 
            // phytonToolStripMenuItem
            // 
            this.phytonToolStripMenuItem.Name = "phytonToolStripMenuItem";
            this.phytonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phytonToolStripMenuItem.Text = "Phyton";
            this.phytonToolStripMenuItem.Click += new System.EventHandler(this.phytonToolStripMenuItem_Click);
            // 
            // anaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(567, 383);
            this.Controls.Add(this.scintilla1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ustmenuToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "anaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mNotepad -- Adsız";
            this.Load += new System.EventHandler(this.anaEkranForm_Load);
            this.ustmenuToolStrip.ResumeLayout(false);
            this.ustmenuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.duzenlemeMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label karaktersayiLabel;
        private System.Windows.Forms.Label satirsayiLabel;
        private System.Windows.Forms.Label karakterkodlamaLabel;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriAlToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip duzenlemeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kopyalaMenuButton;
        private System.Windows.Forms.ToolStripMenuItem kesMenuButton;
        private System.Windows.Forms.ToolStripMenuItem yapistirMenuButton;
        private System.Windows.Forms.ToolStripMenuItem silMenuButton;
        private System.Windows.Forms.ToolStripMenuItem tumunusecMenuButton;
        private System.Windows.Forms.ToolStripMenuItem gerialMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ilerialMenuButton;
        private System.Windows.Forms.ToolStripDropDownButton kodlamaButton;
        private System.Windows.Forms.ToolStripMenuItem aNSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.ToolStripMenuItem kodlamaRenklendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phytonToolStripMenuItem;
    }
}

