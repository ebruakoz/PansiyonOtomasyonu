using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.posta.com.tr/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.onedio.com/");
        }
    }
}
