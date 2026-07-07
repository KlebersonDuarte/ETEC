using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj10
{
    public partial class frnProdutos : Form
    {
        clsProdutos Produtos = new clsProdutos();
        String prod, forPagamento = "";
        int quant,parcelas = 0;
        double preco;

        public frnProdutos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            //pegando o dados do form
            prod =  (String) txtProduto.Text;
            quant = (int) int.Parse(txtQntd.Text);
            preco = (double) double.Parse(txtPreco.Text);

            //Adicionando atributos ao objeto
            Produtos.qntd = (int)int.Parse(txtQntd.Text);
            Produtos.preco = (double)double.Parse(txtPreco.Text);
            Produtos.forPagamento = forPagamento;
            Produtos.parcelas = parcelas;

           double valorFinal = Produtos.valorTotal();

            StringBuilder msg = new StringBuilder();

            msg.AppendLine("Produto: " + prod);
            msg.AppendLine("Quantidade: " + quant);
            msg.AppendLine("Preço: " + preco);
            msg.AppendLine("Forma de pagamento: " + forPagamento);
            msg.AppendLine("Parcelas: " + parcelas);
            msg.AppendLine("Valor final: " + valorFinal);

            lblResposta.Text = msg.ToString();

        }

        private void cboCredito_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCredito.Text == "5x")
            {
                rdbPix.Checked = false;
                forPagamento = "Crédito";
                parcelas = 5;
            }
            else {
                rdbPix.Checked = false;
                forPagamento = "Crédito";
                parcelas = 10;
            }
        }

        private void rdbPix_Click(object sender, EventArgs e)
        {
            if (rdbPix.Checked)
            {
                forPagamento = "Pix";
                cboCredito.Text = "";
                parcelas = 0;
            }
        }
    }
}
