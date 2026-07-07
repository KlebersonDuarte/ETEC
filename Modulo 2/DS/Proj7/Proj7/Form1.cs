using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj7
{
    public partial class Form1 : Form
    {
        double precoOriginal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adiciona os itens ao combo box de móveis
            cboMoveis.Items.Add("Mesa");
            cboMoveis.Items.Add("Sofá");
            cboMoveis.Items.Add("Armário");
        }

        private void cboMoveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resetar os combo box de opções1 e opções2 e aa labels
            cboOpcao1.Items.Clear();
            cboOpcao1.Text = "";

            cboOpcao2.Items.Clear();
            cboOpcao2.Text = "";

            lblResposta.Text = "...";
            lblValorParcela.Text = "";
            lblValorDesconto.Text = "";

            precoOriginal = 0;

            //adiciona os itens ao combo box de opções1, dependendo do móvel selecionado
            if (cboMoveis.Text == "Mesa")
            {
                cboOpcao1.Items.Clear();
                cboOpcao1.Text = "";
                cboOpcao1.Items.Add("Redonda");
                cboOpcao1.Items.Add("Quadrada");
            }

            else if (cboMoveis.Text == "Sofá")
            {
                cboOpcao1.Items.Clear();
                cboOpcao1.Text = "";
                cboOpcao1.Items.Add("2 lugares");
                cboOpcao1.Items.Add("3 lugares");
                cboOpcao1.Items.Add("5 lugares");
            }
            else
            {
                cboOpcao1.Items.Clear();
                cboOpcao1.Text = "";
                cboOpcao1.Items.Add("2 porta");
                cboOpcao1.Items.Add("4 portas");
                cboOpcao1.Items.Add("6 portas");
            }


        }


            private void cboOpcao2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Mostra o preço do móvel, dependendo do móvel, da opção1 e da opção2 selecionados
            //Mesa
            if (cboOpcao2.Text == "2 lugares" && cboMoveis.Text == "Mesa")
                precoOriginal = 1200;

            else if (cboOpcao2.Text == "4 lugares" && cboMoveis.Text == "Mesa")
                precoOriginal = 1600;

            else if (cboOpcao2.Text == "6 lugares" && cboMoveis.Text == "Mesa")
                precoOriginal = 2100;

            //Sofá
            else if (cboOpcao2.Text == "Preto" && cboMoveis.Text == "Sofá")
                precoOriginal = 820;

            else if (cboOpcao2.Text == "Marfim" && cboMoveis.Text == "Sofá")
                precoOriginal = 1250;

            else if (cboOpcao2.Text == "Marrom" && cboMoveis.Text == "Sofá")
                precoOriginal = 1500;

            //Armário
            else if (cboOpcao2.Text == "Branco" && cboMoveis.Text == "Armário")
                precoOriginal = 1850;

            else if (cboOpcao2.Text == "Cinza" && cboMoveis.Text == "Armário")
                precoOriginal = 2010;

            else if (cboOpcao2.Text == "Preto" && cboMoveis.Text == "Armário")
                precoOriginal = 2500;

            else
            {
                lblResposta.Text = "Opção não encontrada";
                return;
            }

            lblResposta.Text = precoOriginal.ToString("N2");
        }




        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (precoOriginal == 0)
                return;


            cboParcelas.Visible = true;


            cboParcelas.Items.Add("Parcelas");

            for (int i = 2; i <= 12; i++) { 
            cboParcelas.Items.Add(i); }
                

                double desconto = precoOriginal * (1 - 0.075);
                lblValorDesconto.Text = desconto.ToString("N2");
            
         
        }


        private void cboOpcao1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resetar o combo box de opções2 e a label de resposta
            cboOpcao2.Items.Clear();
            cboOpcao2.Text = "";
            lblResposta.Text = "...";
            lblValorParcela.Text = "";

            //Adiciona os itens ao combo box de opções2, dependendo do móvel e da opção1 selecionado
            if (cboMoveis.Text == "Mesa")
            {
                cboOpcao2.Items.Clear();
                cboOpcao2.Text = "";
                cboOpcao2.Items.Add("2 lugares");
                cboOpcao2.Items.Add("4 lugares");
                cboOpcao2.Items.Add("6 lugares");
            }
            else if (cboMoveis.Text == "Sofá")
            {
                cboOpcao2.Items.Clear();
                cboOpcao2.Text = "";
                cboOpcao2.Items.Add("Preto");
                cboOpcao2.Items.Add("Marfim");
                cboOpcao2.Items.Add("Marrom");
            }

            else{

                cboOpcao2.Items.Clear();
                cboOpcao2.Text = "";
                cboOpcao2.Items.Add("Branco");
                cboOpcao2.Items.Add("Cinza");
                cboOpcao2.Items.Add("Preto");
            }

        }

        private void cboParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboParcelas.Text == "Parcelas")
            {
                lblValorParcela.Text = "";
                return;
            }


            double preco = double.Parse(lblResposta.Text);
            double parcelas = double.Parse(cboParcelas.Text);

            double valorParcela = preco / parcelas;

            lblValorParcela.Text = "Valor por parcela: " + valorParcela.ToString("N2");
        
    }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            if (cboParcelas.Text == "Parcelas")
            {
                lblValorParcela.Text = "";
                return;
            }

            cboParcelas.Visible = false;
            cboParcelas.Items.Clear();
            cboParcelas.Text = "";
            lblValorParcela.Text = "";


            double desconto = precoOriginal * (1 - 0.055);
            lblValorDesconto.Text = desconto.ToString("N2");
        }
    }
}
