using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halis_Projeleri
{
    public partial class Form1 : Form
    {
        private const string V = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv)";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = V;
            //Müzik çaların çalabileceği dosyaları FileDialog sayesinde filtreledik.
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName; 
            axWindowsMediaPlayer1.URL = textBox1.Text;
            textBox1.Text = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
