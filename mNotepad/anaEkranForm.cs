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

namespace mNotepad
{
    
    public partial class anaEkranForm : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public anaEkranForm()
        {
            InitializeComponent();
        }

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
        //---------------------------------------------------

        //Dosya seçme ekranını açar ve sonrasında seçilen dosyayı uygulamaya aktarır.
        public void editorDosyaAc()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Metin belgesi (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //seçilen dosyanın bulunduğu dizinini al.
                    filePath = openFileDialog.FileName;
                    this.Text = "mNotepad -- " + filePath;
                    //seçilen dosyanın kodlanmasını bul (örn: UTF8 vs...)
                    var encoding = FileEncoding.DetectFileEncoding(filePath);
                    //editör kısmına seçilen dosyadaki verileri yaz.
                        scintilla1.Text = File.ReadAllText(filePath, encoding);
                        karakterkodlamaLabel.Text = encoding.BodyName.ToUpper();
                }
            }
        }

        //Dosya kaydetme ekranını açar ve onay verildikten sonra dosyaya verileri yazar.
        public void editorDosyaFarkliKaydet()
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = string.Format("Metin belgesi (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*"),
                RestoreDirectory = true,
                ShowHelp = true,
                CheckFileExists = false
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, scintilla1.Text);
            }
        }

        //editörün fontunu ve font boyutunu değiştirir.
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
            scintilla1.WrapMode = WrapMode.None;
            scintilla1.IndentationGuides = IndentView.LookBoth;
            InitColors();
            InitNumberMargin();
            InitSyntaxColoring();
        }

        private void editorLexerCpp()
        {
            // Configure the CPP (C#) lexer styles
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

        private void editorLexerDefault()
        {
            InitColors();
            InitNumberMargin();

        }

        private void InitSyntaxColoring()
        {
            editorLexerCpp();
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

            scintilla1.Styles[Style.LineNumber].BackColor =  LINE_BACK_COLOR;
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
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla1.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 16;
            scintilla1.Margins[0].Width = scintilla1.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
            altBilgiGuncelle();
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

        private void containerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            scintilla1.Lexer = Lexer.Container;
            
        }

        private void cPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            scintilla1.Lexer = Lexer.Cpp;
            
        }

        private void phytonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            scintilla1.Lexer = Lexer.Python;
            
        }
    }
}