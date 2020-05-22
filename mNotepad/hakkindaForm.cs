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
            //form açılınca arkada çok güzel bir müzik çalması için dizindeki mp3 dosyasını oynatır.
            wmp.URL = programyolu + @"\res\chiptune1.mp3";
            wmp.controls.play();
        }

        private void hakkindaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.controls.stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrpatatesamca/mNotepad");
        }
    }
}
