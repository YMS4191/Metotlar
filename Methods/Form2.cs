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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /*
       Geriye deger dondurmeyen, yalnizca uzerine dusen isi yapan işlemlerle void metotlar ya da subrutinler denir...
       1) Tekrarlı kodlari engellemek...
       2) Kod kalabaligindan kurtulup daha esnek kodlar yazabilmek...
       3) Merkeziyetci kod yapisini hedef haline getirebilmek. Yani, herhangi bir problem ya da degisiklik durumunda birden fazla yeri kontrol etmek yerine, merkez yapiya mudahele ederek en kısa ve en net sekilde sorunlari cozmek..
     */
        void DonguluMetot()
        {

            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            DonguluMetot();
        }


        void Tadilatci()
        {
            this.BackColor = Color.White;
            this.Size = new Size(400, 400);
        }
        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // formun genişliğini 400, 400 ve arka plan rengini beyaz yapam metot yazınız
            Tadilatci();
        }
    }
}
