using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace metotlar
{
    internal class Sekil
    {
        
        public int uzunKenar { get; set; }
        public int kisaKenar { get; set; }
        
        public void KareYaz()
        {
            int sonuc = this.kisaKenar * this.uzunKenar;
            MessageBox.Show($"Şeklin karesi {sonuc}");
        }

        public void sekilCiz(Button btn, Color renk)
        {
            btn.Width = this.uzunKenar;
            btn.Height = this.kisaKenar;
            btn.BackColor = renk;
            
        }

        public void mesajGonderme (Button btn, String mesaj)
        {
            btn.Text = mesaj;
        }

        public int alanHesapla()
        {
            int sonuc = this.kisaKenar * this.uzunKenar;
            return sonuc;
        }
    }
}
