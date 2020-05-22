using mNotepad.SimpleHelpers;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mNotepad
{

    public partial class anaEkranForm : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        XmlTextReader xtr = new XmlTextReader(programyolu + @"\res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        

        //Renkleri buradan değiştirebilirsiniz.
        Color BACK_COLOR = Color.FromArgb(21, 33, 36);
        Color LINE_BACK_COLOR = Color.IndianRed;
        Color FORE_COLOR = Color.White;
        Color SELECTION_COLOR = Color.Gray;
        Color CARET_FORE_COLOR = Color.White;
        Color CARET_LINE_BACK_COLOR = Color.FromArgb(31, 43, 46);
        private int maxLineNumberCharLength;
        private const int NUMBER_MARGIN = 0;
        private const int CARET_WIDTH = 2;

        //Evrensel değişkenler.
        Font evrenselfont = new Font("Consolas", 10.0f);
        string dosyauzanti;
        public bool dosyaKaydetDurum = false;
        bool dosyaKaydetİlkDefaDurum = true;
        string dosyaDizinEvrensel;
        int formSizeW;
        int formSizeH;
        string formState;
        string dosyaKaydetOrj;
        string xmlAyarIsim;
        string xmlAyarDeger;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        public anaEkranForm()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            dosyaButunlukDogrula(); //dosyaların yerinde olduğunu kontrol et önce
            editorAyarYukle(); //XML dosyasından ayarları yükle
        }

        public void editorAyarYukle()
        {
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "name") //xml içindeki name elementini al
                    {
                        xmlAyarIsim += xtr.ReadElementContentAsString() + "*";
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "value") //xml içindeki value elementini al
                    {
                        xmlAyarDeger += xtr.ReadElementContentAsString() + "*";
                    }
                }
                string data1;
                string data2;
                string[] splitted_data1;
                string[] splitted_data2;
                data1 = xmlAyarIsim;
                data2 = xmlAyarDeger;
                splitted_data1 = data1.Split('*');
                splitted_data2 = data2.Split('*');
                //değerleri gerekli değişkenlere ata.
                formSizeW = Convert.ToInt32(splitted_data2[0]);
                formSizeH = Convert.ToInt32(splitted_data2[1]);
                formState = splitted_data2[2];
                xtr.Close();
            }
            catch
            {
                MessageBox.Show(@"Ayarlar diskten okunamadı! Lütfen programı yeniden indirin! (res\settings.xml dosyası bozuk veya değiştirilmiş!)", "Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void editorAyarKaydet()
        {
            try
            {
                XmlTextWriter xtw = new XmlTextWriter(programyolu + @"\res\settings.xml", System.Text.Encoding.UTF8); //XML dosyasını yazmak için hazırlık yap
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();

                xtw.WriteComment("mNotepad ayarlarının saklandığı yer.");
                xtw.WriteComment("Ne yaptığınızı bilmiyorsanız lütfen hiç bir şeye dokunmayınız!");

                xtw.WriteStartElement("ayarlar");
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "formSizeW");
                xtw.WriteElementString("value", this.Width.ToString());
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "formSizeY");
                xtw.WriteElementString("value", this.Height.ToString());
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "formState");
                xtw.WriteElementString("value", formState);
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteEndElement();
                xtw.WriteComment("Bu ayar dosyası program tarafından oluşturuldu. [" + System.DateTime.Now + "]");
                xtw.WriteEndDocument();
                xtw.Flush();
                xtw.Close();
            }
            catch
            {
                MessageBox.Show(@"Ayarlar diske yazılamadı! Lütfen programı yeniden indirin! (res\settings.xml dosyası bozuk veya değiştirilmiş!)", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //Dosya seçme ekranını açar ve sonrasında seçilen dosyayı uygulamaya aktarır.
        public void editorDosyaAc()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Bir Belge Aç";
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*|Yaygın Belge Formatları|*.txt;*.rtf;*.log;*.c;*.cs;*.cpp;*.vb;*.java;*.js;*.jar;*.py;*.html;*.htm;*.xhtml;*.php;*.xml;*.xaml;*.ini;*.cmd;*.bat;*.v;*.sh";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //dosyanın dizinini evrensel bir değişkene ata
                        dosyaDizinEvrensel = openFileDialog.FileName;
                        //seçilen dosyanın uzantısını bul ve ona göre kodlama renklendirmesi uygula.
                        dosyauzanti = Path.GetExtension(openFileDialog.FileName); //uzantıyı aldık örn: .txt | .xml
                        editorDosyaTurBelirle(); //uzantıya göre dosyanın türünü belirle
                        //seçilen dosyanın kodlanmasını bul (örn: UTF8 vs...)
                        var encoding = FileEncoding.DetectFileEncoding(openFileDialog.FileName);
                        //editör kısmına seçilen dosyadaki verileri yaz.
                        scintilla1.Text = File.ReadAllText(openFileDialog.FileName, encoding);
                        karakterkodlamaLabel.Text = encoding.BodyName.ToUpper();
                        //dosya içeriğini program belleğine yaz ve kaydetme durumu için karşılaştırmak üzere beklet
                        dosyaKaydetOrj = scintilla1.Text;
                        dosyaKaydetDurum = true;
                        dosyaKaydetİlkDefaDurum = false;
                        //editör imleç en sondaki harfa gitsin
                        scintilla1.SelectionStart = scintilla1.Text.Length;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dosya açılırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editorDosyaTurBelirle()
        {
            if (dosyauzanti == ".cs") //eğer dosya C# belgesi ise.
            {
                dosyaturuLabel.Text = "C# Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".cpp") //eğer dosya C++ belgesi ise.
            {
                dosyaturuLabel.Text = "C++ Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".c") //eğer dosya C belgesi ise.
            {
                dosyaturuLabel.Text = "C Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".vb") //eğer dosya Visual Basic belgesi ise.
            {
                dosyaturuLabel.Text = "Visual Basic Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".js" || dosyauzanti == ".java") //eğer dosya JavaScript belgesi ise.
            {
                dosyaturuLabel.Text = "Java Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".xml" || dosyauzanti == ".xaml") //eğer dosya Extensible Markup belgesi ise
            {
                dosyaturuLabel.Text = "Extensible Markup Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".py") //eğer dosya Python belgesi ise.
            {
                dosyaturuLabel.Text = "Python Belgesi";
                editorLexerPython();
            }

            if (dosyauzanti == ".html" || dosyauzanti == ".htm" || dosyauzanti == ".xhtml") //eğer dosya HyperText Markup belgesi ise.
            {
                dosyaturuLabel.Text = "HyperText Belgesi";
                editorLexerHTML();
            }

            if (dosyauzanti == ".ini") //eğer dosya INI Yapılandırma belgesi ise.
            {
                dosyaturuLabel.Text = "INI Yapılandırma Belgesi";
                editorLexerCpp();
            }

            if (dosyauzanti == ".bat" || dosyauzanti == ".cmd") //eğer dosya Batch belgesi ise.
            {
                dosyaturuLabel.Text = "Batch Belgesi";
                editorLexerBatch();
            }

            if (dosyauzanti == ".log") //eğer dosya Batch belgesi ise.
            {
                dosyaturuLabel.Text = "Log Belgesi";
                editorLexerDefault();
            }

            if (dosyauzanti == ".txt") //eğer dosya düz metin belgesi ise.
            {
                dosyaturuLabel.Text = "Metin Belgesi";
                editorLexerDefault();
            }
        }

        //Dosyayı kaydeder eğer daha önce kaydedilmemişse dosya kaydetme ekranını açar ve onay verildikten sonra dosyaya verileri yazar.
        public void editorDosyaKaydet()
        {
            if (dosyaKaydetİlkDefaDurum == true) //eğer dosya ilk defa kaydedilecek ise
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Belgeyi Kaydet";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    saveFileDialog.Filter = "Metin Belgesi (*.txt)|*.txt|Zengin Metin Belgesi (*.rtf)|*.rtf|Log Belgesi (*.log)|*.log|C Kaynak Belgesi (*.c)|*.c|C# Kaynak Belgesi (*.cs)|*.cs|C++ Kaynak Belgesi (*.cpp)|*.cpp|VB.Net Kaynak Belgesi (*.vb)|*.vb|Batch Dosyası (*.bat)|*.bat|INI Belgesi (*.ini)|*.ini|Extensible Markup Belgesi (*.xml, *.xaml)|*.xml;*.xaml|HyperText Belgesi (*.html, *.htm, *xhtml)|*.html;*.htm;*.xhtml|Tüm Dosyalar (*.*)|*.*";
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.CheckFileExists = false;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, scintilla1.Text);
                        dosyaKaydetDurum = true;
                        dosyaKaydetİlkDefaDurum = false;
                        dosyaDizinEvrensel = saveFileDialog.FileName;
                        dosyaKaydetOrj = scintilla1.Text;
                    }
                }
            }
            else //eğer dosya daha önce kaydedilmiş ise
            {
                File.WriteAllText(dosyaDizinEvrensel, scintilla1.Text);
                dosyaKaydetDurum = true;
                dosyaKaydetİlkDefaDurum = false;
                dosyaKaydetOrj = scintilla1.Text;
            }

        }

        //Dosya kaydetme ekranını açar ve onay verildikten sonra dosyaya verileri yazar.
        public void editorDosyaFarkliKaydet()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Belgeyi Farklı Kaydet";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Metin Belgesi (*.txt)|*.txt|Zengin Metin Belgesi (*.rtf)|*.rtf|Log Belgesi (*.log)|*.log|C Kaynak Belgesi (*.c)|*.c|C# Kaynak Belgesi (*.cs)|*.cs|C++ Kaynak Belgesi (*.cpp)|*.cpp|VB.Net Kaynak Belgesi (*.vb)|*.vb|Tüm dosyalar (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CheckFileExists = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, scintilla1.Text);
                    dosyaKaydetDurum = true;
                    dosyaDizinEvrensel = saveFileDialog.FileName;
                    dosyaKaydetOrj = scintilla1.Text;
                }
            }
        }

        //Editörün fontunu ve font boyutunu değiştirir.
        public void editorFontAyarla()
        {
            FontDialog fontsecme = new FontDialog();
            fontsecme.ShowEffects = true;
            fontsecme.ShowColor = true;
            //FontDialog ve Scintilla'nın beraber düzgünce çalışabilmesi için birkaç dönüştürmelere ihtiyaç var.
            var cvt = new FontConverter(); //String olan font ismini Font olarak dönüştürür.
            Font fontcevirilmis = cvt.ConvertFromString(scintilla1.Styles[Style.Default].Font) as Font;

            fontsecme.Color = scintilla1.Styles[Style.Default].ForeColor;
            fontsecme.Font = fontcevirilmis;
            if (fontsecme.ShowDialog() == DialogResult.OK)
            {
                scintilla1.SetSelectionBackColor(true, SELECTION_COLOR); //editör seçili metin renk
                scintilla1.StyleResetDefault();
                scintilla1.Styles[Style.Default].Font = fontsecme.Font.Name; //editör font
                scintilla1.Styles[Style.Default].BackColor = BACK_COLOR; //editör arkaplan
                scintilla1.Styles[Style.Default].ForeColor = fontsecme.Color; //editör font renk
                scintilla1.Styles[Style.Default].Size = 10; //editör font boyut
                scintilla1.CaretForeColor = CARET_FORE_COLOR; //yazarken yanıp sönen imleç renk
                scintilla1.CaretWidth = CARET_WIDTH; //yanıp sönen imleç kalınlık
                scintilla1.CaretLineBackColor = CARET_LINE_BACK_COLOR; //yazdığın satırda gözükecek olan çizgi renk
                scintilla1.StyleClearAll();
                evrenselfont = fontsecme.Font;
                scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR; //editör satır numara arkaplan
                scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR; //editör satır numara yazı renk
                scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
                scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;
            }

        }

        //Form yüklendiğinde bir takım şeyleri ayarlar.
        private void anaEkranForm_Load(object sender, EventArgs e)
        {
            

            //Temel ayarlamalar
            if (formState == "tamekran")
            {
                this.WindowState = FormWindowState.Maximized;
                tamEkranToolStripMenuItem.Text = "Küçültülmüş Ekran";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Width = formSizeW;
                this.Height = formSizeH;
                tamEkranToolStripMenuItem.Text = "Tam Ekran";
            }
            dosyaKaydetOrj = string.Empty;
            scintilla1.WrapMode = WrapMode.None;
            scintilla1.IndentationGuides = IndentView.LookBoth;
            InitColors();
            editorLexerDefault();
            InitNumberMargin();
        }

        private void editorLexerCpp()
        {
            //Lexer renklendirmesinin çalışabilmesi için önce ayarları sıfırlamak gerekiyor.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = evrenselfont.Name;
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR;
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR;
            scintilla1.StyleClearAll();

            //soldaki satır sayısını gösteren alanı da ayarlamak gerekiyor.
            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;

            //CPP Lexer için metin renk kodları.
            scintilla1.Styles[Style.Cpp.Identifier].ForeColor = Color.AliceBlue;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.LightGreen;
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.Chocolate;
            scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.Beige;
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.Bisque;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.Violet;
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.DarkCyan;
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.Firebrick;
            scintilla1.Styles[Style.Cpp.Regex].ForeColor = Color.Green;
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.DarkGoldenrod;
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.YellowGreen;
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Brown;
            scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.Lavender;
            scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.LemonChiffon;
            scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = Color.Turquoise;

            scintilla1.Lexer = Lexer.Cpp;

            scintilla1.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            scintilla1.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
        }

        private void editorLexerBatch()
        {
            //Lexer renklendirmesinin çalışabilmesi için önce ayarları sıfırlamak gerekiyor.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = evrenselfont.Name;
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR;
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR;
            scintilla1.StyleClearAll();

            //soldaki satır sayısını gösteren alanı da ayarlamak gerekiyor.
            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;

            //CPP Lexer için metin renk kodları.
            scintilla1.Styles[Style.Cpp.Identifier].ForeColor = Color.AliceBlue;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.LightGreen;
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.Chocolate;
            scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.Beige;
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.Bisque;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.Violet;
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.DarkCyan;
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.Firebrick;
            scintilla1.Styles[Style.Cpp.Regex].ForeColor = Color.Green;
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.DarkGoldenrod;
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.YellowGreen;
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Brown;
            scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.Lavender;
            scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.LemonChiffon;
            scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = Color.Turquoise;

            scintilla1.Lexer = Lexer.Batch;

            scintilla1.SetKeywords(0, "assoc aux break call cd chcp chdir choice cls cmdextversion color com com1 com2 com3 com4 con copy country ctty date defined del dir do dpath echo else endlocal erase errorlevel exist exit for ftype goto if in loadfix loadhigh lpt lpt1 lpt2 lpt3 lpt4 md mkdir move not nul path pause popd prn prompt pushd rd rem ren rename rmdir set setlocal shift start time title type ver verify vol");
        }

        private void editorLexerHTML()
        {
            //Lexer renklendirmesinin çalışabilmesi için önce ayarları sıfırlamak gerekiyor.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = evrenselfont.Name;
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR;
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR;
            scintilla1.StyleClearAll();

            //soldaki satır sayısını gösteren alanı da ayarlamak gerekiyor.
            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;

            //CPP Lexer için metin renk kodları.
            scintilla1.Styles[Style.Cpp.Identifier].ForeColor = Color.AliceBlue;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.LightGreen;
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.Chocolate;
            scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.Beige;
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.Bisque;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.Violet;
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.DarkCyan;
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.Firebrick;
            scintilla1.Styles[Style.Cpp.Regex].ForeColor = Color.Green;
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.DarkGoldenrod;
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.YellowGreen;
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Brown;
            scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.Lavender;
            scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.LemonChiffon;
            scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = Color.Turquoise;

            scintilla1.Lexer = Lexer.Html;

            scintilla1.SetKeywords(0, "!doctype a abbr accept accept-charset accesskey acronym action address align alink alt applet archive area article aside async audio autocomplete autofocus axis b background base basefont bdi bdo bgcolor bgsound big blink blockquote body border br button canvas caption cellpadding cellspacing center char charoff charset checkbox checked cite class classid clear code codebase codetype col colgroup color cols colspan command compact content contenteditable contextmenu coords data datafld dataformatas datalist datapagesize datasrc datetime dd declare defer del details dfn dialog dir disabled div dl draggable dropzone dt element em embed enctype event face fieldset figcaption figure file font footer for form formaction formenctype formmethod formnovalidate formtarget frame frameborder frameset h1 h2 h3 h4 h5 h6 head header headers height hgroup hidden hr href hreflang hspace html http-equiv i id iframe image img input ins isindex ismap kbd keygen label lang language leftmargin legend li link list listing longdesc main manifest map marginheight marginwidth mark marquee max maxlength media menu menuitem meta meter method min multicol multiple name nav nobr noembed noframes nohref noresize noscript noshade novalidate nowrap object ol onabort onafterprint onautocomplete onautocompleteerror onbeforeonload onbeforeprint onblur oncancel oncanplay oncanplaythrough onchange onclick onclose oncontextmenu oncuechange ondblclick ondrag ondragend ondragenter ondragleave ondragover ondragstart ondrop ondurationchange onemptied onended onerror onfocus onhashchange oninput oninvalid onkeydown onkeypress onkeyup onload onloadeddata onloadedmetadata onloadstart onmessage onmousedown onmouseenter onmouseleave onmousemove onmouseout onmouseover onmouseup onmousewheel onoffline ononline onpagehide onpageshow onpause onplay onplaying onpointercancel onpointerdown onpointerenter onpointerleave onpointerlockchange onpointerlockerror onpointermove onpointerout onpointerover onpointerup onpopstate onprogress onratechange onreadystatechange onredo onreset onresize onscroll onseeked onseeking onselect onshow onsort onstalled onstorage onsubmit onsuspend ontimeupdate ontoggle onundo onunload onvolumechange onwaiting optgroup option output p param password pattern picture placeholder plaintext pre profile progress prompt public q radio readonly rel required reset rev reversed role rows rowspan rp rt rtc ruby rules s samp sandbox scheme scope scoped script seamless section select selected shadow shape size sizes small source spacer span spellcheck src srcdoc standby start step strike strong style sub submit summary sup svg svg:svg tabindex table target tbody td template text textarea tfoot th thead time title topmargin tr track tt type u ul usemap valign value valuetype var version video vlink vspace wbr width xml xmlns xmp");
        }
        private void editorLexerPython()
        {
            //Lexer renklendirmesinin çalışabilmesi için önce ayarları sıfırlamak gerekiyor.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = evrenselfont.Name;
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR;
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR;
            scintilla1.StyleClearAll();

            //soldaki satır sayısını gösteren alanı da ayarlamak gerekiyor.
            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;

            //CPP Lexer için metin renk kodları.
            scintilla1.Styles[Style.Cpp.Identifier].ForeColor = Color.AliceBlue;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.LightGreen;
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.Chocolate;
            scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.Beige;
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.Bisque;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.Violet;
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.DarkCyan;
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.Firebrick;
            scintilla1.Styles[Style.Cpp.Regex].ForeColor = Color.Green;
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.DarkGoldenrod;
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.YellowGreen;
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Brown;
            scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.Lavender;
            scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.LemonChiffon;
            scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = Color.Turquoise;

            scintilla1.Lexer = Lexer.Python;

            scintilla1.SetKeywords(0, "and as assert async await break class continue def del elif else except finally for from global if import in is lambda nonlocal not or pass raise return try while with yield");
            scintilla1.SetKeywords(1, "ArithmeticError AssertionError AttributeError BaseException BlockingIOError BrokenPipeError BufferError BytesWarning ChildProcessError ConnectionAbortedError ConnectionError ConnectionRefusedError ConnectionResetError DeprecationWarning EOFError Ellipsis EnvironmentError Exception False FileExistsError FileNotFoundError FloatingPointError FutureWarning GeneratorExit IOError ImportError ImportWarning IndentationError IndexError InterruptedError IsADirectoryError KeyError KeyboardInterrupt LookupError MemoryError ModuleNotFoundError NameError None NotADirectoryError NotImplemented NotImplementedError OSError OverflowError PendingDeprecationWarning PermissionError ProcessLookupError RecursionError ReferenceError ResourceWarning RuntimeError RuntimeWarning StopAsyncIteration StopIteration SyntaxError SyntaxWarning SystemError SystemExit TabError TimeoutError True TypeError UnboundLocalError UnicodeDecodeError UnicodeEncodeError UnicodeError UnicodeTranslateError UnicodeWarning UserWarning ValueError Warning WindowsError ZeroDivisionError abs all any ascii bin bool breakpoint bytearray bytes callable chr classmethod compile complex copyright credits delattr dict dir divmod enumerate eval exec exit filter float format frozenset getattr globals hasattr hash help hex id input int isinstance issubclass iter len license list locals map max memoryview min next object oct open ord pow print property quit range repr reversed round set setattr slice sorted staticmethod str sum super tuple type vars zip");
        }

        private void editorLexerDefault()
        {
            //Lexer renklendirmesinin çalışabilmesi için önce ayarları sıfırlamak gerekiyor.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = evrenselfont.Name;
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR;
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR;
            scintilla1.StyleClearAll();

            scintilla1.Lexer = Lexer.Container;

            //soldaki satır sayısını gösteren alanı da ayarlamak gerekiyor.
            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;
        }

        //Temalandırma alanı
        private void InitColors()
        {
            scintilla1.SetSelectionBackColor(true, SELECTION_COLOR); //seçili metin rengi
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas"; //editör font
            scintilla1.Styles[Style.Default].Size = 10; //editör font boyut
            scintilla1.Styles[Style.Default].BackColor = BACK_COLOR; //editör arkaplan
            scintilla1.Styles[Style.Default].ForeColor = FORE_COLOR; //editör font yazı
            scintilla1.CaretForeColor = CARET_FORE_COLOR; //yazarken yanıp sönen imleç renk
            scintilla1.CaretWidth = CARET_WIDTH; //yanıp sönen imleç kalınlık
            scintilla1.CaretLineBackColor = CARET_LINE_BACK_COLOR; //yazdığın satırda gözükecek olan çizgi renk
            scintilla1.StyleClearAll(); //ayarları uygula
        }

        //Yandaki satır sayılarını ayarla.
        private void InitNumberMargin()
        {

            scintilla1.Styles[Style.LineNumber].BackColor = LINE_BACK_COLOR;
            scintilla1.Styles[Style.LineNumber].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].ForeColor = FORE_COLOR;
            scintilla1.Styles[Style.IndentGuide].BackColor = LINE_BACK_COLOR;

            var nums = scintilla1.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
        }

        private void altBilgiGuncelle()
        {
            karaktersayiLabel.Text = "Karakter: " + scintilla1.Text.Length.ToString();
            satirsayiLabel.Text = "Satır: " + scintilla1.Lines.Count;
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var maxLineNumberCharLength = scintilla1.Lines.Count.ToString().Length;
            const int padding = 16;
            scintilla1.Margins[0].Width = scintilla1.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void editorKopyala()
        {
            scintilla1.Copy();
        }

        private void editorKes()
        {
            scintilla1.Cut();
        }

        private void editorYapistir()
        {
            scintilla1.Paste();
        }

        private void editorGeriAl()
        {
            scintilla1.Undo();
        }

        private void editorYinele()
        {
            scintilla1.Redo();
        }

        private void editorTumunuSec()
        {
            scintilla1.SelectAll();
        }

        private void editorSil()
        {
            scintilla1.Clear();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorSil();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorKopyala();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorKes();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorYapistir();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorTumunuSec();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorGeriAl();
        }

        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorYinele();
        }

        private void kopyalaMenuButton_Click(object sender, EventArgs e)
        {
            editorKopyala();
        }

        private void kesMenuButton_Click(object sender, EventArgs e)
        {
            editorKes();
        }

        private void yapistirMenuButton_Click(object sender, EventArgs e)
        {
            editorYapistir();
        }

        private void silMenuButton_Click(object sender, EventArgs e)
        {
            editorSil();
        }

        private void tumunusecMenuButton_Click(object sender, EventArgs e)
        {
            editorTumunuSec();
        }

        private void gerialMenuButton_Click(object sender, EventArgs e)
        {
            editorGeriAl();
        }

        private void ilerialMenuButton_Click(object sender, EventArgs e)
        {
            editorYinele();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorDosyaAc();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorDosyaFarkliKaydet();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorFontAyarla();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkindaForm hakkindaFormfrm = new hakkindaForm();
            hakkindaFormfrm.Show();
        }

        private void düzMetinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".txt";
            editorDosyaTurBelirle();
        }

        private void altBilgiGuncelleTimer_Tick(object sender, EventArgs e)
        {
            altBilgiGuncelle();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".c";
            editorDosyaTurBelirle();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".cs";
            editorDosyaTurBelirle();
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".cpp";
            editorDosyaTurBelirle();
        }

        private void vBNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".vb";
            editorDosyaTurBelirle();
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".js";
            editorDosyaTurBelirle();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".py";
            editorDosyaTurBelirle();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".bat";
            editorDosyaTurBelirle();
        }

        private void xMLXAMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".xml";
            editorDosyaTurBelirle();
        }

        private void ıNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".ini";
            editorDosyaTurBelirle();
        }

        private void hTMHTMLXHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyauzanti = ".html";
            editorDosyaTurBelirle();
        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form'un o anki durumuna göre değişen pencere ayarı.
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                tamEkranToolStripMenuItem.Text = "Küçültülmüş Ekran";
                tamEkranToolStripMenuItem.ToolTipText = "Program penceresini küçültür.";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                tamEkranToolStripMenuItem.Text = "Tam Ekran";
                tamEkranToolStripMenuItem.ToolTipText = "Program penceresini tam ekran yapar.";
            }
            //----------------------------------------------------------
        }

        private void anaEkranForm_SizeChanged(object sender, EventArgs e)
        {
            formSizeW = this.Width;
            formSizeH = this.Height;
            if (this.WindowState == FormWindowState.Maximized)
            {
                formState = "tamekran";
                tamEkranToolStripMenuItem.Text = "Küçültülmüş Ekran";
            }
            else
            {
                formState = "normalekran";
                tamEkranToolStripMenuItem.Text = "Tam Ekran";
            }
        }

        private void pencereBoyutunuSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Width = 583;
            this.Height = 422;
        }

        private void dosyaKaydetDurumKontrolEt()
        {
            if (scintilla1.Text == dosyaKaydetOrj)
            {
                dosyaKaydetDurum = true;
                this.Text = "mNotepad -- " + dosyaDizinEvrensel;
            }
            else
            {
                dosyaKaydetDurum = false;
                this.Text = "mNotepad -- " + dosyaDizinEvrensel + "*";
            }
        }

        private void üstteGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üstte göster - gösterme butonu için
            if (this.TopMost == true)
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.TopMost = false;
            }
            else
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Checked;
                this.TopMost = true;
            }
        }

        private void dosyaKaydetDurumKontrolTimer_Tick(object sender, EventArgs e)
        {
            dosyaKaydetDurumKontrolEt();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorDosyaKaydet();
        }

        private void anaEkranForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dosyaKaydetUyariForm dosyaKaydetUyariFormfrm = new dosyaKaydetUyariForm();
            //dosya kaydedilmemişse program kapanmadan önce uyar
            if (dosyaKaydetDurum == false)
            {
                e.Cancel = true;
                dosyaKaydetUyariFormfrm.ShowDialog();
            }
            else //daha önce kaydedilmiş ise
            {
                editorAyarKaydet();
                Application.Exit();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yakınlaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomIn();
        }

        private void uzaklaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomOut();
        }

        private void yakınlaştırmayıSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Zoom = 0;
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(scintilla1.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void hataGidermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaButunlukDogrulamaForm dosyaButunlukDogrulamaFormfrm = new dosyaButunlukDogrulamaForm();
            dosyaButunlukDogrulamaFormfrm.Show();
        }

        private void dosyaButunlukDogrula() //dosyaları kontrol et, eğer dosya yerinde yoksa uyarı ver.
        {
            dosyaButunlukDogrulamaForm dosyaButunlukDogrulamaFormfrm = new dosyaButunlukDogrulamaForm();
            
            //-------------------------------------------------------------------
            if (!File.Exists("AxInterop.WMPLib.dll"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
            if (!File.Exists("Interop.WMPLib.dll"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
            if (!File.Exists(programyolu + @"\res\settings.xml"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
            if (!File.Exists("ScintillaNET.dll"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
            if (!File.Exists("Ude.dll"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
            if (!File.Exists(programyolu + @"\res\chiptune1.mp3"))
            {
                dosyaButunlukDogrulamaFormfrm.ShowDialog();
            }
            //-------------------------------------------------------------------
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programyolu + @"\mNotepad.exe");
        }
    }
}