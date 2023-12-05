using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_Repetitivas_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, count = 0, Limite;
            n = int.Parse(valor.Text);
            Limite = int.Parse(limite.Text);

            do
            {
                lista.Items.Add(n + " * " + count + "=" + n * count);
                count++;
            } while (count <= Limite);

        }
    }
}
