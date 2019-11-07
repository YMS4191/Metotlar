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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verilen kullanıcı adına göre hotmail.com adresi teslim edilir.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakrak kullanıcı adı ve soyadı parametresi veriniz</param>
        void Mail(string user)
        {
            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1]}@hotmail.com";
            MessageBox.Show(mail);
        }

        /// <summary>
        /// Verilen kullanıcı adına  ve seçilen domain adresine göre mail adresi teslim edilir.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakrak kullanıcı adı ve soyadı parametresi veriniz</param>
        /// <param name="domain">Geçerli bir mail sunucu adı giriniz</param>
        void Mail(string user, string domain)
        {
            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1].ToLower()}@{domain}";
            MessageBox.Show(mail);
        }

        private void btnMailOlustur_Click(object sender, EventArgs e)
        {
            if (cmbSunucuAdlari.SelectedIndex == -1)
            {
                Mail(txtMailKullaniciAdi.Text);
            }
            else
            {
                Mail(txtMailKullaniciAdi.Text, cmbSunucuAdlari.Text);
            }

            Mail("",)
        }
    }
}
