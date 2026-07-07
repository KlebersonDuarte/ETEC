using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX26_REPETIDORES_VISUAL_061125
{
    public partial class Form1 : Form
    {
        int Tamanho;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tamanho  = int.Parse(txtTamanho.Text);
            Lista.Items.Clear();

            for (int i = 0; i < Tamanho; i++) { 
            Lista.Items.Add(i);
            }
        }

        private void txtTamanho_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPara_Click(object sender, EventArgs e)
        {
            Tamanho = int.Parse(txtTamanho.Text);
            Lista.Items.Clear();
            int Contador = 0;

            while (Contador < Tamanho) { 
            
            Lista.Items.Add(Contador);
                Contador++;
            }
        }
    }
}
