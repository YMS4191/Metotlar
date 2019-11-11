using System;
using System.Drawing;
using System.Linq;
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

        #region Vol 1
        void SesliGosterVol1(string metin)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                switch (karakterler[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':

                    case 'A':
                    case 'E':
                    case 'I':
                    case 'İ':
                    case 'O':
                    case 'Ö':
                    case 'U':
                    case 'Ü':

                        listBox1.Items.Add(karakterler[i]);
                        break;
                    default:
                        listBox2.Items.Add(karakterler[i]);
                        break;
                }
            }

            MessageBox.Show($"{(listBox1.Items.Count > 0 ? $"dizi içerisinde toplamda sesli harf sayısı : {listBox1.Items.Count}" : "dizi içerisinde sesli harf bulunmamaktadır")}\ndizi içerisinde toplamda sessiz harf sayısı : { listBox2.Items.Count}");
        }
        #endregion

        #region Vol 2
        void SesliGosterVol2(string metin)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] karakterler = metin.ToCharArray(); // asdfgzxcvb

            for (int i = 0; i < karakterler.Length; i++)
            {
                bool result = false;
                for (int z = 0; z < sesliler.Length; z++)
                {
                    if (karakterler[i].ToString().Equals(sesliler[z].ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        listBox1.Items.Add(karakterler[i]);
                        result = true;
                        break; // bağlı bulunduğu yapıyı sonlandırır.
                    }
                }

                if (!result)
                {
                    listBox2.Items.Add(karakterler[i]);
                }
            }

            MessageBox.Show($"{(listBox1.Items.Count > 0 ? $"dizi içerisinde toplamda sesli harf sayısı : {listBox1.Items.Count}" : "dizi içerisinde sesli harf bulunmamaktadır")}\ndizi içerisinde toplamda sessiz harf sayısı : { listBox2.Items.Count}");
        }
        #endregion

        #region Vol 3
        void SesliGosterVol3(string metin)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                if (sesliler.Contains(karakterler[i]))

                    listBox1.Items.Add(karakterler[i]);
                else
                    listBox2.Items.Add(karakterler[i]);
            }

            MessageBox.Show($"{(listBox1.Items.Count > 0 ? $"dizi içerisinde toplamda sesli harf sayısı : {listBox1.Items.Count}" : "dizi içerisinde sesli harf bulunmamaktadır")}\ndizi içerisinde toplamda sessiz harf sayısı : { listBox2.Items.Count}");
        }
        #endregion

        private void btnSesliKontrolu_Click(object sender, EventArgs e)
        {
            //Textbox'tan gelen değerde eğer sesli bir harf varsa, o harfleri 1.listboxa atın ve kaç adet olduğunu msgboxta gösterin, eğer yoksa bu kümede sesli harf bulunmamaktadır uyarısını veriniz.Girilen metinde sessiz harfleride listbox2'ye atınız. Kullanıcı büyük küçük harf gözetmeksizin giriş yapabilir ancak siz içeride herbirini küçük olarak değerlendirin.

            //A,E,I,İ,O,Ö,U,Ü
            //SesliGosterVol1(txtDeger1.Text);
            //SesliGosterVol2(txtDeger1.Text);
            SesliGosterVol3(txtDeger1.Text);
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
