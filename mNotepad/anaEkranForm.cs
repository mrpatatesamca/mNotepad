using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mNotepad
{

    public partial class anaEkranForm : Form
    {
        public anaEkranForm()
        {
            InitializeComponent();
        }

        //bu kısım solda bulunan satır sayılarının yer aldığı bölümü yazılar eklendikçe genişletir.
        public int getWidth()
        {
            int w = 25;
            //bütün satır sayılarını al
            int line = richTextBox1.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBox1.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBox1.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBox1.Font.Size;
            }

            return w;
        }

        //bu kısım formun sol tarafında bulunan satır sayılarının gösterildiği yere satır numaralarını yazar.
        public void AddLineNumbers()
        {   
            Point pt = new Point(0, 0);
            //ilk satırı al
            int First_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int First_Line = richTextBox1.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            //son satırı al  
            int Last_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBox1.GetLineFromCharIndex(Last_Index);
            //ortaya hizalama yap. 
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            //LineNumberTextBox yazısını boş yap ve width değişkenini al.  
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            //son satıra kadar bütün satır sayılarını ekle.
            for (int i = First_Line; i <= Last_Line + 99; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        //Dosya seçme ekranını açar ve sonrasında seçilen dosyayı uygulamaya aktarır.
        public void dosyaAc()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Metin belgesi (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    this.Text = "mNotepad -- " + filePath;
                    richTextBox1.Text = File.ReadAllText(filePath, Encoding.Default);
                    AddLineNumbers();
                }
            }
        }

        //Dosya kaydetme ekranını açar ve onay verildikten sonra dosyaya verileri yazar.
        public void dosyaFarkliKaydet()
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
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
        }

        //editörün fontunu ve font boyutunu değiştirir.
        public void fontAyarla()
        {
            FontDialog fontsecme = new FontDialog();
            fontsecme.ShowColor = true;
            fontsecme.ShowEffects = true;
            fontsecme.Color = Color.White;
            fontsecme.Font = richTextBox1.Font;
            if (fontsecme.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontsecme.Font;
                richTextBox1.ForeColor = fontsecme.Color;
            }

        }

        private void anaEkranForm_Load(object sender, EventArgs e)
        {
            textEditorBaslat();

        }
        public void textEditorBaslat()
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();

        }

        private void anaEkranForm_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                AddLineNumbers();
            }
            satirsayiLabel.Text = "Satır: " + richTextBox1.Lines.Length.ToString();
            karaktersayiLabel.Text = "Karakter: " + richTextBox1.Text.Length.ToString();
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();

        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaFarkliKaydet();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontAyarla();
        }
    }
}