using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex27_Desafio_II_061125
{
    public partial class Form1 : Form
    {
        int Tamanho;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Tamanho = int.Parse(txtTamanho.Text);
                ListaImpar.Items.Clear();
                ListaPar.Items.Clear();
                int Contador = 0;
                while(Contador < Tamanho) 
                {

                        if (Contador % 2 == 0)
                        {
                            ListaPar.Items.Add(Contador);
                        }
                        if (Contador % 2 != 0)
                        {
                            ListaImpar.Items.Add(Contador);
                        }
                    Contador++;
                }
            }
            catch (Exception)
            {
                ListaImpar.Items.Add("Valor inválido");
                ListaPar.Items.Add("Valor inválido");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListaImpar.Items.Clear();
            ListaPar.Items.Clear();

            txtTamanho.Clear();
        }
        private void ListaPar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaImpar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTamanho_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPara_Click(object sender, EventArgs e)
        {
            try { 
            Tamanho = int.Parse(txtTamanho.Text);
            ListaImpar.Items.Clear();
            ListaPar.Items.Clear();

                for(int i = 0; i < Tamanho; i++) {
                    if (i % 2 == 0)
                    {
                        ListaPar.Items.Add(i);
                    }
                    if (i % 2 != 0)
                    {
                        ListaImpar.Items.Add(i);
                    }
                
            }
            }
            catch (Exception)
            {
                ListaImpar.Items.Add("Valor inválido");
                ListaPar.Items.Add("Valor inválido");
            }
        }
    }
}
