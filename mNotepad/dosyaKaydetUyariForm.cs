using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mNotepad
{
    public partial class dosyaKaydetUyariForm : Form
    {
        public dosyaKaydetUyariForm()
        {
            InitializeComponent();
        }

        anaEkranForm anaEkranFormfrm = new anaEkranForm();

        private void dosyaKaydetUyariForm_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void kaydetmedencikButton_Click(object sender, EventArgs e)
        {
            programZorlaCikis();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void programZorlaCikis()
        {
            //Programdan zorla çıkar.
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C taskkill /F /IM mNotepad.exe";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
