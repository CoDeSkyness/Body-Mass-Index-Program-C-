using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKİkodlamaGELİSMİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ad, soyad;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            double kilo, boy, sonuc;

            kilo = Convert.ToDouble(textBox4.Text);
            boy = Convert.ToDouble(textBox3.Text);

            sonuc = kilo / (boy * boy);

            if (sonuc < 18)
            {
                listBox1.Items.Add(ad + "   " + soyad);
                label12.Text = sonuc.ToString();
            }
            else if (sonuc >= 18 && sonuc < 25)
            {
                listBox2.Items.Add(ad + "   " + soyad);
                label12.Text = sonuc.ToString();
            }
            else if (sonuc >= 25)
            {
                listBox3.Items.Add(ad + "   " + soyad);
                label12.Text = sonuc.ToString();
            }

            temizle();
        }
       void temizle()
       {
          textBox1.Clear();
          textBox2.Clear();
          textBox3.Clear();
          textBox4.Clear();
       }
    }
}
