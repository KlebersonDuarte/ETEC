using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj13
{
    public partial class Servicos : Form
    {
        clsConexao conexao = new clsConexao();
        StringBuilder str = new StringBuilder();
        MySqlDataReader SDR;

        public Servicos()
        {
            InitializeComponent();
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoPet.Text == "" || txtValor.Text == "" || cboTipo.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

                str.Clear();
                str.Append("INSERT INTO SERVICOS (TIPO_SERV, DATA_SERV, VALOR_SERV, COD_PET) VALUES " +
                    "(@TIPO_SERV, @DATA_SERV, @VALOR_SERV, @COD_PET)");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@TIPO_SERV", cboTipo.Text);
                conexao.cmd.Parameters.AddWithValue("@DATA_SERV", dtpData.Value);
                conexao.cmd.Parameters.AddWithValue("@VALOR_SERV", txtValor.Text);
                conexao.cmd.Parameters.AddWithValue("@COD_PET", txtCodigoPet.Text);

                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Serviço marcado com sucesso!");
                    return;
                }
                MessageBox.Show("Por favor verifique se o código do pet está correto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao incluir. " + ex.Message);
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            try
            {   if(txtIDServico.Text == "")
                {
                    MessageBox.Show("Por favor, informe o ID do serviço.");
                    return;
                }

                str.Clear();
                str.Append("DELETE FROM SERVICOS WHERE ID_SERV = @ID_SERV");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@ID_SERV", txtIDServico.Text);

                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Serviço desmarcado com sucesso!");
                    return;
                }
                MessageBox.Show("Não há serviço marcado com os dados informados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir. " + ex.Message);

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoPet.Text = "";
            txtValor.Text = "";
            cboTipo.Text = "";
            dtpData.Text = "";
        }

        private void btnPesqRapS_Click(object sender, EventArgs e)
        {
            try
            {   if(txtIDServico.Text == "")
                {
                    MessageBox.Show("Por favor, informe o ID do serviço.");
                    return;
                }

                str.Clear();
                str.Append("SELECT * FROM SERVICOS WHERE ID_SERV = @ID_SERV");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@ID_SERV", txtIDServico.Text);

                conexao.StrString = str.ToString();

                SDR = conexao.DataReader();

                if (SDR.Read())
                {
                    cboTipo.Text = SDR["TIPO_SERV"].ToString();
                    txtValor.Text = SDR["VALOR_SERV"].ToString();
                    dtpData.Text = SDR["DATA_SERV"].ToString();
                    return;
                }

                MessageBox.Show("Serviço não encontrado.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao pesquisar. " + ex.Message);
            }
        }
    }
}
