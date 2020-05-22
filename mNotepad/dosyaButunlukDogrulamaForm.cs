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
    public partial class dosyaButunlukDogrulamaForm : Form
    {
        public dosyaButunlukDogrulamaForm()
        {
            InitializeComponent();
        }

        //evrensel değişkenler
        string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        private void dosyaButunlukDogrulamaForm_Load(object sender, EventArgs e)
        {
            dosyaisimTextBox.SelectionStart = dosyaisimTextBox.Text.Length;
            dosyadurumTextBox.SelectionStart = dosyadurumTextBox.Text.Length;
        }

        private void dosyaButunlukDogrula() //dosyaları kontrol et, eğer dosya yerinde yoksa uyarı ver.
        {
            //-------------------------------------------------------------------
            if (File.Exists("AxInterop.WMPLib.dll"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------
            if (File.Exists("Interop.WMPLib.dll"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------
            if (File.Exists(programyolu + @"\res\settings.xml"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------
            if (File.Exists("ScintillaNET.dll"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------
            if (File.Exists("Ude.dll"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------
            if (File.Exists(programyolu + @"\res\chiptune1.mp3"))
            {
                dosyadurumTextBox.AppendText("TAMAM" + Environment.NewLine);
            }
            else
            {
                dosyadurumTextBox.AppendText("EKSİK" + Environment.NewLine);
            }
            //-------------------------------------------------------------------

            //hata var mı yok mu onu kontrol et.
            if (dosyadurumTextBox.Text.Contains("EKSİK"))
            {
                altbilgiLabel.Text = "Hata! Eksik dosya bulundu! Program bu şekilde çalışamaz, lütfen programı tekrar indirin!";
                altbilgiLabel.ForeColor = Color.Tomato;
                kapatButton.Text = "Programı Kapat";
            }
            else
            {
                altbilgiLabel.Text = "Bütün dosyalar yerinde ve kullanılmaya hazır!";
                altbilgiLabel.ForeColor = Color.LimeGreen;
                kapatButton.Text = "Tamam";
            }
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            if (kapatButton.Text == "Tamam")
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }

        }

        private void kontrolBaslatGeciktirmeTimer_Tick(object sender, EventArgs e)
        {
            dosyadurumTextBox.Text = string.Empty;
            kontrolBaslatGeciktirmeTimer.Stop();
            dosyaButunlukDogrula();
        }
    }
}
