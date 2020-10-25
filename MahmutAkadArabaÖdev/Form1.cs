using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahmutAkadArabaÖdev
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.Id = int.Parse(tbId.Text);
            araba.Marka = tbMarka.Text;
            araba.Model = tbModel.Text;
            araba.KapıSayısı = tbKapıSyısı.Text;
            araba.BeygirGücü = tbBeygirGücü.Text;
            araba.ArabaTür = tbArabaTürü.Text;
            araba.MaxHız = tbMaxHız.Text;
            araba.Çekiş = tbCekıs.Text;
            araba.SıfırYüz = tbSıfırYuz.Text;
            araba.Agırlık = tbAgırlık.Text;
            araba.Hacmi = tbHacım.Text;

        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += tbId.Text;
            richTextBox1.Text +=" "+ tbMarka.Text;
            richTextBox1.Text += " "+tbModel.Text;
            richTextBox1.Text += " "+tbKapıSyısı.Text;
            richTextBox1.Text += " "+tbBeygirGücü.Text;
            richTextBox1.Text += " "+tbArabaTürü.Text;
            richTextBox1.Text += " "+tbMaxHız.Text;
            richTextBox1.Text += " "+tbCekıs.Text;
            richTextBox1.Text += " "+tbSıfırYuz.Text;
            richTextBox1.Text += " "+tbAgırlık.Text;
            richTextBox1.Text += " "+tbHacım.Text;

        }

        
    }
}
