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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = null;
            textBox3.Clear();
            textBox4.Text = string.Empty;
            textBox5.Text = default;
            textBox6.Text = "";
            textBox7.Text = textBox8.Text = textBox9.Text = "";
            textBox10.Text = "";
            textBox11.ResetText();
            textBox12.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // db kayıt işlemleri
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Temizle();
        } 
    }
}
