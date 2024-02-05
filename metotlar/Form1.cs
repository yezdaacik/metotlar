using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        Color renk = Color.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.uzunKenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.kisaKenar = Convert.ToInt32(txtSayi2.Text);
            sekil1.sekilCiz(btnSekil, renk);
            sekil1.mesajGonderme(btnSekil, txtMesaj.Text);

            btnSekil.Width = Convert.ToInt32(txtSayi1.Text);
            btnSekil.Height = Convert.ToInt32(txtSayi2.Text);
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
    }
}
