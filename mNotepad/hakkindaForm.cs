using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace mNotepad
{
    public partial class hakkindaForm : Form
    {
        public hakkindaForm()
        {
            InitializeComponent();
        }
        //global şeyler
        string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private void hakkindaForm_Load(object sender, EventArgs e)
        {
            //eğer dosya yerindeyse sil onu çünkü biz zaten yenisini yazacağız oraya
            if (File.Exists(programyolu + @"\mrp\chiptune1.mp3"))
            {
                File.Delete(programyolu + @"\mrp\chiptune1.mp3");
            }
            //form açılınca arkada çok güzel bir müzik çalması için resources içindeki mp3 dosyasını geçici olarak bir dizine çıkartır ve oradan oynatır.
            File.WriteAllBytes(programyolu + @"\mrp\chiptune1.mp3", Properties.Resources.chiptune1);
            wmp.URL = programyolu + @"\mrp\chiptune1.mp3";
            wmp.controls.play();
        }

        private void hakkindaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.controls.stop();
            //eğer dosya yerindeyse sil onu
            if (File.Exists(programyolu + @"\mrp\chiptune1.mp3"))
            {
                File.Delete(programyolu + @"\mrp\chiptune1.mp3");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrpatatesamca/mNotepad");
        }
    }
}
