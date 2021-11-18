using System;
using System.Windows.Forms;

namespace pascalUcgeni
{
    public partial class Form1 : Form
    {
        int drc;
        string pascal;

        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBTN_Click(object sender, EventArgs e)
        {
            drc = Convert.ToInt32(dereceTB.Text);
            if (drc <= 1)
            {
                pascal = "1;";
            }
            else if (drc >= 2)
            {
                pascal = "1;1,1;";
            }
            doldur();
            ekranaYaz();
        }

        private void doldur()
        {
            string[] satirlar = pascal.Split(';');
            string[] degerler;
            while (satirlar.Length < drc + 1)
            {
                for (int i = 0; i < (drc + 1) - satirlar.Length; i++)
                {
                    pascal += "1,";
                    degerler = satirlar[satirlar.Length - 2].Split(',');
                    for (int j = 1; j < degerler.Length; j++)
                    {
                        pascal += (Convert.ToInt32(degerler[j]) + Convert.ToInt32(degerler[j - 1])).ToString() + ",";
                    }
                    pascal += "1;";
                    satirlar = pascal.Split(';');
                }
            }
        }

        private void ekranaYaz()
        {
            
            string[] satirlar = pascal.Split(';');
            yaziEkraniRTB.Text = "";
            for (int i = 0; i < satirlar.Length; i++)
            {
                for (int j = 1; j < drc - i; j++)
                {
                    yaziEkraniRTB.Text += "   ";
                }
                yaziEkraniRTB.Text += satirlar[i].Replace(",", "     ") + "\n";
            }
        }

    }
}
