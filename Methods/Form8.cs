using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Proccess();
        }

        private void Proccess()
        {
            listBox1.Items.Clear();
            Process currentProcess = Process.GetCurrentProcess();
            Process[] localAll = Process.GetProcesses();

            foreach (var item in localAll)
            {
                listBox1.Items.Add(item.ProcessName);
            }
        }

        private void tsmStop_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string proccessName = listBox1.SelectedItem.ToString();
                Process[] localByName = Process.GetProcessesByName(proccessName);

                foreach (var item in localByName)
                {
                    item.Kill();
                }

                Proccess();
            }

        }
    }
}
