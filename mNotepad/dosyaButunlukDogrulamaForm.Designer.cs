namespace mNotepad
{
    partial class dosyaButunlukDogrulamaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dosyaButunlukDogrulamaForm));
            this.dosyaisimTextBox = new System.Windows.Forms.TextBox();
            this.dosyadurumTextBox = new System.Windows.Forms.TextBox();
            this.altbilgiLabel = new System.Windows.Forms.Label();
            this.kapatButton = new System.Windows.Forms.Button();
            this.ustbilgiLabel = new System.Windows.Forms.Label();
            this.kontrolBaslatGeciktirmeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dosyaisimTextBox
            // 
            this.dosyaisimTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyaisimTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(40)))));
            this.dosyaisimTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosyaisimTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dosyaisimTextBox.ForeColor = System.Drawing.Color.White;
            this.dosyaisimTextBox.Location = new System.Drawing.Point(12, 77);
            this.dosyaisimTextBox.Multiline = true;
            this.dosyaisimTextBox.Name = "dosyaisimTextBox";
            this.dosyaisimTextBox.ReadOnly = true;
            this.dosyaisimTextBox.ShortcutsEnabled = false;
            this.dosyaisimTextBox.Size = new System.Drawing.Size(228, 133);
            this.dosyaisimTextBox.TabIndex = 0;
            this.dosyaisimTextBox.Text = " AxInterop.WMPLib.dll\r\n Interop.WMPLib.dll\r\n settings.xml\r\n ScintillaNET.dll\r\n Ud" +
    "e.dll\r\n chiptune1.mp3";
            // 
            // dosyadurumTextBox
            // 
            this.dosyadurumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyadurumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(40)))));
            this.dosyadurumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosyadurumTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dosyadurumTextBox.ForeColor = System.Drawing.Color.White;
            this.dosyadurumTextBox.Location = new System.Drawing.Point(232, 77);
            this.dosyadurumTextBox.Multiline = true;
            this.dosyadurumTextBox.Name = "dosyadurumTextBox";
            this.dosyadurumTextBox.ReadOnly = true;
            this.dosyadurumTextBox.ShortcutsEnabled = false;
            this.dosyadurumTextBox.Size = new System.Drawing.Size(72, 133);
            this.dosyadurumTextBox.TabIndex = 1;
            this.dosyadurumTextBox.Text = "TARANIYOR\r\nTARANIYOR\r\nTARANIYOR\r\nTARANIYOR\r\nTARANIYOR\r\nTARANIYOR";
            this.dosyadurumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altbilgiLabel
            // 
            this.altbilgiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.altbilgiLabel.ForeColor = System.Drawing.Color.White;
            this.altbilgiLabel.Location = new System.Drawing.Point(9, 213);
            this.altbilgiLabel.Name = "altbilgiLabel";
            this.altbilgiLabel.Size = new System.Drawing.Size(295, 31);
            this.altbilgiLabel.TabIndex = 2;
            this.altbilgiLabel.Text = "Dosya bütünlüğü taraması yapılıyor lütfen bekleyin...";
            // 
            // kapatButton
            // 
            this.kapatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kapatButton.Location = new System.Drawing.Point(110, 247);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(96, 23);
            this.kapatButton.TabIndex = 3;
            this.kapatButton.Text = "Tamam";
            this.kapatButton.UseVisualStyleBackColor = true;
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // ustbilgiLabel
            // 
            this.ustbilgiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ustbilgiLabel.ForeColor = System.Drawing.Color.White;
            this.ustbilgiLabel.Location = new System.Drawing.Point(9, 9);
            this.ustbilgiLabel.Name = "ustbilgiLabel";
            this.ustbilgiLabel.Size = new System.Drawing.Size(295, 65);
            this.ustbilgiLabel.TabIndex = 4;
            this.ustbilgiLabel.Text = "mNotepad programının düzgün çalışabilmesi için aşağıda listenen dosyaların progra" +
    "m ile aynı dizinde bulunması gerekmektedir. Eğer eksik bir dosya var ise lütfen " +
    "mNotepad programını yeniden indirin.";
            // 
            // kontrolBaslatGeciktirmeTimer
            // 
            this.kontrolBaslatGeciktirmeTimer.Enabled = true;
            this.kontrolBaslatGeciktirmeTimer.Interval = 1500;
            this.kontrolBaslatGeciktirmeTimer.Tick += new System.EventHandler(this.kontrolBaslatGeciktirmeTimer_Tick);
            // 
            // dosyaButunlukDogrulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(316, 282);
            this.Controls.Add(this.ustbilgiLabel);
            this.Controls.Add(this.kapatButton);
            this.Controls.Add(this.altbilgiLabel);
            this.Controls.Add(this.dosyadurumTextBox);
            this.Controls.Add(this.dosyaisimTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dosyaButunlukDogrulamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mNotepad Hata Giderme Aracı";
            this.Load += new System.EventHandler(this.dosyaButunlukDogrulamaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dosyaisimTextBox;
        private System.Windows.Forms.TextBox dosyadurumTextBox;
        private System.Windows.Forms.Label altbilgiLabel;
        private System.Windows.Forms.Button kapatButton;
        private System.Windows.Forms.Label ustbilgiLabel;
        private System.Windows.Forms.Timer kontrolBaslatGeciktirmeTimer;
    }
}