using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_Repetitivas_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoinferiro, rangosuperiror, suma = 0;
            rangoinferiro = int.Parse(textBox1.Text);
            rangosuperiror = int.Parse(textBox2.Text);
            for(int i = rangoinferiro; i <= rangosuperiror; i++)
            {
                listBox1.Items.Add(i);
                suma = suma+i;
            }
            textBox3.Text = suma.ToString();
        }
    }
}
