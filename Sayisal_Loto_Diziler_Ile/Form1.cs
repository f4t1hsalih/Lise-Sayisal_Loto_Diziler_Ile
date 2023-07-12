using System;
using System.Windows.Forms;

namespace Sayisal_Loto_Diziler_Ile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[6];
        Random rnd = new Random();
        int sayac;
        string st, a, b, c, d, f, g;
        int h;

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            f = textBox5.Text;
            g = textBox6.Text;

            for (int i = 0; i < 6; i++)
            {
                h = rnd.Next(0, 50);
                sayilar[i] = h;
                st +=  sayilar[i].ToString();
                if (sayilar[i] == int.Parse(a)) sayac++;
                if (sayilar[i] == int.Parse(b)) sayac++;
                if (sayilar[i] == int.Parse(c)) sayac++;
                if (sayilar[i] == int.Parse(d)) sayac++;
                if (sayilar[i] == int.Parse(f)) sayac++;
                if (sayilar[i] == int.Parse(g)) sayac++;
                if (i <= 4)
                    st += "-";
            }
            textBox7.Text = st;
            MessageBox.Show(sayac.ToString() + " Tane Bildiniz");

        }
    }
}
