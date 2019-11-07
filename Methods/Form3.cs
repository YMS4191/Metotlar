using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
       PARAMETRELİ METOTLAR
       Disaridan gelecek olan degerlere gore islem yonunu degistirecek olan metotlardir...
       Parametredeki degiskene, iceride deger atanmaz!
       Metot prensipleri geregi, parametrenin nereden gelecegi soylenmez....
   */
        }


        #region Örnek 1
        void ParametreliMetot(int sayi)
        {
            //sayi = 100; => parametreye içeriden değer atanmaz
            //sayi = int.Parse(txtDeger1.Text); => parametrenin nerden geleceği kesinlikle söylenmez
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            ParametreliMetot(50);
            ParametreliMetot(int.Parse(txtDeger1.Text));
        }
        #endregion

        #region Örnek 2
        void HesapMakinesi(int s1, int s2)
        {
            int toplam = s1 + s2;
            int sonuc = Convert.ToInt32(Math.Pow(toplam, 3));

            MessageBox.Show("İşlem sonucu " + sonuc);
        }
        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //Disaridan girilen iki sayinin toplaminin kupunu MessageBox'la gosterecek bir metot yaziniz...
            int sayi1 = int.Parse(txtDeger1.Text);
            int sayi2 = int.Parse(txtDeger2.Text);
            HesapMakinesi(sayi1, sayi2);
            HesapMakinesi(int.Parse(txtDeger1.Text), int.Parse(txtDeger2.Text));
        }
        #endregion

        #region Örnek 3
        void SonUcHarfKesici(string param)
        {
            //if (param.Length <= 3)
            //{
            //    MessageBox.Show(param);
            //}
            //else
            //{
            //    param = param.Substring(param.Length - 3);
            //    MessageBox.Show(param);
            //}

            MessageBox.Show(param.Length <= 3 ? param : param.Substring(param.Length - 3));
        }
        private void btnKirp_Click(object sender, EventArgs e)
        {
            //Disaridan girilen degerin son 3 harfini messageBoxla içerisinde bir metot yaziniz. Ancak girilen deger 3 harften azsa ya da 3 harfe esitse direkt olarak tamamini gostersin...

            // Tek satır içerisinde hallediniz :)
            SonUcHarfKesici(txtDeger1.Text);
        }
        #endregion


        #region Örnek 4
        void MailAyristirici(string mails)
        {
            string[] mailler = mails.Split(',', ';', '+');
            foreach (var item in mailler)
            {
                listBox1.Items.Add(item);
            }
        }
        private void btnListBoxaDoldur_Click(object sender, EventArgs e)
        {
            //Disaridan girilen mailleri ;,+ gordugu yerden ayirip listboxa dolduran bir metot yaziniz...
            MailAyristirici(txtDeger1.Text);
        }
        #endregion

        #region Örnek 5
        private void btnSesliKontrolu_Click(object sender, EventArgs e)
        {
            //Textbox'tan gelen değerde eğer sesli bir harf varsa, o harfleri 1.listboxa atın ve kaç adet olduğunu msgboxta gösterin, eğer yoksa bu kümede sesli harf bulunmamaktadır uyarısını veriniz.Girilen metinde sessiz harfleride listbox2'ye atınız. Kullanıcı büyük küçük harf gözetmeksizin giriş yapabilir ancak siz içeride herbirini küçük olarak değerlendirin.

            //A,E,I,İ,O,Ö,U,Ü
        }
        #endregion


        void ArkaplanRenkChange(string color)
        {
            this.BackColor = Color.FromName(color);
        }
        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            //Combobox'tan secilen rengi formun arkaplanina atayan bir metot yaziniz...
            ArkaplanRenkChange(cmbRenkler.Text);
        }
    }
}
