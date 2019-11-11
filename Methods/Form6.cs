using System;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        void Hesapla(int s1, int s2, out int sonuc)
        {
            sonuc = s1 + s2;

            // return s1 + s2;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            Hesapla(12, 34, out toplam);
        }


        int HesaplaVol2(int s1, int s2, out double bolum)
        {
            bolum = s1 / s2;
            return s1 + s2;
        }
        private void btnOutIki_Click(object sender, EventArgs e)
        {
            double bolmeSonucu = 0;
            int sonuc = HesaplaVol2(11, 22, out bolmeSonucu);
        }












        void Hesapla(int s1, int s2, out int toplam, out int fark, out double bolme)
        {
            bolme = s1 / s2;
            toplam = s1 + s2;
            fark = s1 - s2;
        }

        private void btnOutUc_Click(object sender, EventArgs e)
        {
            int toplamaSonucu = 0;
            int farkSonucu = 0;
            double bolmeSonucu = 0;

            Hesapla(15, 15, out toplamaSonucu, out farkSonucu, out bolmeSonucu);

            MessageBox.Show($"Toplama işleminin sonucu : {toplamaSonucu}\nÇıkartma işleminin sonucu : {farkSonucu}\nBölme işleminin sonucu : {bolmeSonucu}");
        }


        double HesapBakiyesi(params double[] sayilar)
        {
            double toplam = 0;
            foreach (double sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }



        private void btnParams_Click(object sender, EventArgs e)
        {
            // diziye parametre olarak gelecek olan eleman sayısı bilinmiyor ise, params anahtar kelimesi kullanılır..

            double[] dizi = { 11, 22, 44, 55, 66.0, 66, 77 };
            double sonuc1 = HesapBakiyesi(dizi);



            double sonuc2 = HesapBakiyesi(new[] { 11, 22, 44, 55, 66.0, 66, 77 });
            MessageBox.Show(sonuc1.ToString());

            double sonuc3 = HesapBakiyesi(11, 23, 4, 5, 6, 7, 55, 8, 5, 3, 2, 3, 4, 5);
            //char[] elemanlar = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //"".Split(elemanlar);
        }
    }
}
