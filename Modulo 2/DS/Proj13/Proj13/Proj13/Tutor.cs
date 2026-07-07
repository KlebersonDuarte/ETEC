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
    public partial class Tutor : Form
    {
        clsConexao conexao = new clsConexao();
        StringBuilder str = new StringBuilder();
        MySqlDataReader SDR;

        public Tutor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Adicionamos funções extras que achamos necessários para o usuário
            try
            {
                if (txtNome.Text == "" || txtCpf.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

                str.Clear();
                str.Append("SELECT CPF_TUTOR, EMAIL_TUTOR FROM TUTOR WHERE CPF_TUTOR = @CPF_TUTOR || EMAIL_TUTOR = @EMAIL_TUTOR");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@CPF_TUTOR", txtCpf.Text);
                conexao.cmd.Parameters.AddWithValue("@EMAIL_TUTOR", txtEmail.Text);

                conexao.StrString = str.ToString();

                SDR = conexao.DataReader();

                if (SDR.Read())
                {
                    MessageBox.Show("Usuário já cadastrado");
                    return;
                }


                str.Clear();
                str.Append("INSERT INTO TUTOR (CPF_TUTOR, NOME_TUTOR, CEL_TUTOR, EMAIL_TUTOR) VALUES " +
                    "(@CPF_TUTOR, @NOME_TUTOR, @CEL_TUTOR, @EMAIL_TUTOR)");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@CPF_TUTOR", txtCpf.Text);
                conexao.cmd.Parameters.AddWithValue("@NOME_TUTOR", txtNome.Text);
                conexao.cmd.Parameters.AddWithValue("@CEL_TUTOR", txtCelular.Text);
                conexao.cmd.Parameters.AddWithValue("@EMAIL_TUTOR", txtEmail.Text);

                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Tutor cadastrado com sucesso!");
                    return;
                }

                MessageBox.Show("Erro ao cadastrar tutor.");
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao incluir. " +  ex.Message);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {   
                if(txtCpf.Text == "")
                {
                    MessageBox.Show("Por favor, informe o CPF do tutor.");
                    return;
                }

                str.Clear();
                str.Append("DELETE FROM TUTOR WHERE CPF_TUTOR = @CPF_TUTOR");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@CPF_TUTOR", txtCpf.Text);
                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Tutor excluído com sucesso!");
                    return;
                }

                MessageBox.Show("Não há tutor cadastrado com os dados informados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir. " + ex.Message);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelular.Text = "";
            txtCpf.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void btnPesqRapT_Click(object sender, EventArgs e)
        {
            try
            {   
                if(txtCpf.Text == "")
                {
                    MessageBox.Show("Por favor, informe o CPF do tutor.");
                    return;
                }

                str.Clear();
                str.Append("SELECT * FROM TUTOR WHERE CPF_TUTOR = @CPF_TUTOR");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@CPF_TUTOR", txtCpf.Text);

                conexao.StrString = str.ToString();

                SDR = conexao.DataReader();

                if (SDR.Read())
                {
                    txtNome.Text = SDR["NOME_TUTOR"].ToString();
                    txtCelular.Text = SDR["CEL_TUTOR"].ToString();
                    txtEmail.Text = SDR["EMAIL_TUTOR"].ToString();
                    return;
                }

                MessageBox.Show("Tutor não encontrado.");
            }
            catch (Exception ex) { 
            MessageBox.Show("Falha ao pesquisar. " + ex.Message);
            }
            
        }
    }
}
