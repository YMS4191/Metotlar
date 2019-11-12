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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }



        void Temizle(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = nmr.Minimum;
                }
                else if (item is PictureBox)
                {
                    PictureBox pcb = (PictureBox)item;
                    pcb.Image = null;
                }
                else if (item is GroupBox)
                {
                    Temizle(item);
                }
            }
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            Temizle(this);
            Temizle(groupBox1);
            Temizle(groupBox2);
            Temizle(groupBox3);
        }
    }
}
