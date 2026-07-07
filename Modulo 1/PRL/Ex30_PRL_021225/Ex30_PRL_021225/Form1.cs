using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex30_PRL_021225
{
    public partial class Form1 : Form
    {
        string[,] Jogadores = new string[11, 2]; // 11 Linhas  2 Colunas
        int ContadorJogador = 0; // Variavel Publica Inteira
        int ContadorFaltas = 0; // Variavel Publica inteira

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFaltas_Click(object sender, EventArgs e)
        {
            if (ContadorFaltas <= 10 && txtFaltas.Text != "") // Condicional 1
            {
                Jogadores[ContadorFaltas, 1] = txtFaltas.Text; // Entrada 1
                ContadorFaltas++; // Processo 1
                txtFaltas.Text = null; // Processo 2
            }
            else // Negação Condicional 1
            {
                BtnFaltas.Enabled = false; // Processo 3
            }
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            ListaJogadores.Items.Clear();
            for (int i = 0; i < ContadorJogador; i++)
            {
                ListaJogadores.Items.Add(Jogadores[i, 0] + " - Total Faltas: " + Jogadores[i, 1]);
            }
        }

        private void BtnJogador_Click(object sender, EventArgs e)
        {
            if (ContadorJogador <= 10 && txtJogador.Text != "") // Condicional 1
            {
                Jogadores[ContadorJogador, 0] = txtJogador.Text; // Entrada 1
                ContadorJogador++; // Processo 1
                txtJogador.Text = null; // Processo 2
            }
            else // Negação Condicional 1
            {
                BtnJogador.Enabled = false; // Processo 3
            }
        }
    }
}
