using System;
using System.Drawing;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int Hesapla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }


        private void btnToplamaYap_Click(object sender, EventArgs e)
        {
            int sonuc = Hesapla(10, 10);
            MessageBox.Show(sonuc.ToString());
        }



        int TekCiftKontrol(int sayi)
        {
            #region Örnek
            //int sonuc = 0;
            //if (sayi == 0)
            //{
            //    sonuc = 0;
            //}

            //if (sayi % 2 == 0)
            //{
            //    sonuc = -1;
            //}
            //else
            //{
            //    sonuc = 1;
            //}
            //return sonuc; 
            #endregion

            if (sayi == 0)
            {
                return 0;
            }

            if (sayi % 2 == 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // dışarıdan girilen sayının, tek çift ve 0'a eşit olma durumunu kontrol eden bir metot (function) yazınız
            // Eğer kullanıcı 0 değeri girerse 0
            // Eğer kullanıcı tek sayı girerse 1
            // Eğer kullanıcı çift sayı girerse -1 değerini döndürünüz! 

            MessageBox.Show(TekCiftKontrol(int.Parse(txtOrnekIki.Text)).ToString());
        }




        string Mail(string ad, string soyad)
        {
            string yeniFirstName = $"{ad.Substring(0, 2).ToUpper()}{ad.Substring(2, ad.Length - 2).ToLower()}";
            string newSoyad = soyad.ToLower().Replace('a', 'e');
            return $"{yeniFirstName}.{newSoyad}@hotmail.com";
        }
        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Disaridan girilen ilk kelimenin ilk iki harfini buyuk,
            //geri kalanini kucuk aliniz.. 
            //ikinci kelimenin icerisinde gecen tum a'lari e'ile degistiriniz 
            //ve sonuna @hotmail.com ekleyerek geri dondurunuz...

            MessageBox.Show(Mail(txtAd.Text, txtSoyad.Text));
        }


        int[] SayilarVadisi(string param) => Array.ConvertAll(param.Split(' ', ',', ';'), Convert.ToInt32);



        double Hesapla(int[] dizi)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return Math.Sqrt(toplam);
        }
        private void btnDiziIsleme_Click(object sender, EventArgs e)
        {
            //Disaridan bir int[] dizisinin parametre olarak alan bir metot yaziniz. Metot, parametredeki dizide yer alan elemanlarin toplaminin karekökünü dondursun... (ONDALIKLI GELEBILIR!)


            MessageBox.Show(string.Join("-", SayilarVadisi(txtAd.Text)));

            double result = Hesapla(SayilarVadisi(txtAd.Text));
            MessageBox.Show(result.ToString());
            //int[] cukur = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Hesapla(cukur);

            //double sonuc = Hesapla(new[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            //MessageBox.Show(sonuc.ToString());


            // Kullanıcı dışarıdan aldığı değerleri bir diziye atıp :) metoda gönderiniz
            // dizinin elemanlarını textbox'tan alınız :)
        }


        Color RenkYakala(Control ctrl) => ctrl.BackColor;


        private void btnRenkYakalayici_Click(object sender, EventArgs e)
        {
            this.BackColor = RenkYakala(btnRenkYakalayici);
        }
    }
}
