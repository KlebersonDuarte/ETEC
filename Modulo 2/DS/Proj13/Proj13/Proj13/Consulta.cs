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
    public partial class Consulta : Form
    {
        clsConexao conexao = new clsConexao();
        StringBuilder str = new StringBuilder();
        MySqlDataReader SDR;

        public Consulta()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDConsulta.Text == "")
                {
                    MessageBox.Show("Por favor, informe o ID da consulta.");
                    return;
                }

                str.Clear();
                str.Append("DELETE FROM CONSULTA WHERE ID_CONSULTA = @ID_CONSULTA");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@ID_CONSULTA", txtIDConsulta.Text);

                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Consulta excluída com sucesso!");
                    return;
                }
                MessageBox.Show("Não há consulta marcada com os dados informados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir. " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoPet.Text = "";
            txtPrescricao.Text = "";
            dtpData.Text = "";

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try {
                if (txtCodigoPet.Text == "" || txtPrescricao.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

                str.Clear();
                str.Append("INSERT INTO CONSULTA (COD_PET, DATA_CONSULTA, PRESC_CONSULTA) VALUES " +
                    "(@COD_PET, @DATA_CONSULTA, @PRESC_CONSULTA)");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@COD_PET", txtCodigoPet.Text);
                conexao.cmd.Parameters.AddWithValue("@DATA_CONSULTA", dtpData.Value);
                conexao.cmd.Parameters.AddWithValue("@PRESC_CONSULTA", txtPrescricao.Text);

                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Consulta marcada com sucesso!");
                    return;
                }
                MessageBox.Show("Por favor verifique se o código do pet está correto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao incluir. " + ex.Message);
            }
        }

        private void btnPesqRapC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDConsulta.Text == "")
                {
                    MessageBox.Show("Por favor, informe o ID da consulta.");
                    return;
                }

                str.Clear();
                str.Append("SELECT * FROM CONSULTA WHERE ID_CONSULTA = @ID_CONSULTA");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@ID_CONSULTA", txtIDConsulta.Text);

                conexao.StrString = str.ToString();

                SDR = conexao.DataReader();

                if (SDR.Read())
                {
                    dtpData.Text = SDR["DATA_CONSULTA"].ToString();
                    txtPrescricao.Text = SDR["PRESC_CONSULTA"].ToString();
                    return;
                }
                    MessageBox.Show("Consulta não encontrada.");
                
            }
            catch (Exception ex) {
                MessageBox.Show("Falha ao pesquisar. " + ex.Message);
            }
        }
    }
}
