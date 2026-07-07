using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaração de variáveis
                String nome, msg, genero = "", faixa;
                DateTime nascimento, hoje = DateTime.Now;
                double peso, altura, imc;
                int idade;


                if (txtNome.Text == "" || txtPeso.Text == "" || txtAltura.Text == "" || dtpNascimento.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

                //Pegando os valores
                nome = (String)txtNome.Text;
                nascimento = (DateTime)Convert.ToDateTime(dtpNascimento.Text);
                peso = (double)Convert.ToDouble(txtPeso.Text);
                altura = (double)Convert.ToDouble(txtAltura.Text);


                //Calculando o imc
                imc = peso / (altura * altura);


                //Verificando se a data de nascimento é menor que a data atual
                if (nascimento > hoje) { 
                    MessageBox.Show("Data de nascimento inválida");
                    return;
                }

                //Check do gênero
                if (rdbMasc.Checked)
                {
                    genero = "Masculino";

                }
                 else if (rdbFem.Checked)
                {
                    genero = "Feminino";

                }
                else
                {
                    MessageBox.Show("Por favor escolha uma opção");
                        return;
                }

                //Faixa do imc
                if (imc <= 10.4)
                {
                    faixa = "Baixa";
                }
                else if (imc <= 24.9)
                {
                    faixa = "Normal";
                }
                else
                {
                    faixa = "Alta";
                }

                //Quantos anos a pessoa tem
                idade = hoje.Year - nascimento.Year;

                //msg
                msg = "Relátorio:" +
                    "\nNome" + nome +
                    "\nIdade:" + idade +
                    "\nGênero:" + genero +
                    "\nPeso:" + peso +
                    "\nAltura" + altura +
                    "\n Seu IMC é:" + imc.ToString("N2") +
                    "\nFaixa: " + faixa;

                lblResultado.Text = Convert.ToString(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
