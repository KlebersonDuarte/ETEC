using MySqlX.XDevAPI;
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
    public partial class Listagens : Form
    {
        clsConexao conexao = new clsConexao();
        StringBuilder str = new StringBuilder();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Listagens()
        {
            InitializeComponent();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            try
            {
                str.Clear();
                str.Append("SELECT * FROM TUTOR ORDER BY NOME_TUTOR");

                conexao.StrString = str.ToString();

                ds = conexao.DateSet();
                dt = ds.Tables[0];
                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos tutores. " + ex.Message);
            }
        }

        private void btnPetNasc_Click(object sender, EventArgs e)
        {
            try
            {
                str.Clear();
                str.Append("SELECT P.COD_PET AS CODIGO-PET,P.NOME_PET AS NOME, P.NASC_PET AS NASCIMENTO, T.CPF_TUTOR AS TUTOR FROM PET AS P INNER JOIN TUTOR AS T ON P.CPF_TUTOR = T.CPF_TUTOR ORDER BY P.NASC_PET");
                conexao.StrString = str.ToString();
                ds = conexao.DateSet();
                dt = ds.Tables[0];

                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos pets por data de nascimento. " + ex.Message);
            }
        }

        private void btnPetSem_Click(object sender, EventArgs e)
        {
            try
            {
                str.Clear();
                str.Append("SELECT P.COD_PET AS CODIGO-PET, T.CPF_TUTOR AS CPF, T.CEL_TUTOR AS CELULAR, P.NOME_PET AS NOME-PET, P.GENE_PET AS GENERO, P.RACA_PET AS RACA FROM PET AS P INNER JOIN TUTOR AS T ON P.CPF_TUTOR = T.CPF_TUTOR");

                conexao.StrString = str.ToString();
                ds = conexao.DateSet();
                dt = ds.Tables[0];

                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos pets. " + ex.Message);
            }
        }

        private void btnPetFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEspecie.Text == "")
                {
                    MessageBox.Show("Por favor escolha a espécie do pet antes de buscar");
                    return;
                }

                str.Clear();
                str.Append("SELECT COD_PET AS CODIGO-PET,NOME_PET AS NOME-PET, ESPECIE_PET AS ESPECIE, RACA_PET AS RACA FROM PET WHERE ESPECIE_PET = @ESPECIE_PET");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@ESPECIE_PET", cboEspecie.Text);

                conexao.StrString = str.ToString();
                ds = conexao.DateSet();
                dt = ds.Tables[0];

                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos pets com filtro nas espécies. " + ex.Message);
            }
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoServ.Text == "")
                {
                    MessageBox.Show("Por favor escolha o serviço e a data");
                    return;
                }

                str.Clear();
                str.Append("SELECT S.ID_SERV AS ID ,S.TIPO_SERV AS TIPO-SERVICO, S.DATA_SERV AS DATA-SERVICO, T.NOME_TUTOR AS NOME-TUTOR, P.NOME_PET AS NOME-PET FROM SERVICOS AS S INNER JOIN PET AS P ON S.COD_PET = P.COD_PET INNER JOIN TUTOR AS T ON T.CPF_TUTOR = P.CPF_TUTOR WHERE S.TIPO_SERV = " +
                    "@TIPO_SERV || S.DATA_SERV = @DATA_SERV ORDER BY S.TIPO_SERV, P.NOME_PET");


                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@TIPO_SERV",cboTipoServ.Text);
                conexao.cmd.Parameters.AddWithValue("@DATA_SERV", dtpDataServ.Value);

                conexao.StrString = str.ToString();
                ds = conexao.DateSet();
                dt = ds.Tables[0];

                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do serviço com filtros e ordem. " + ex.Message);
            }
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                str.Clear();
                str.Append("SELECT C.ID_CONSULTA AS ID,P.COD_PET AS COD-PET, P.NOME_PET AS NOME-PET, T.NOME_TUTOR AS NOME-TUTOR, C.DATA_CONSULTA AS DATA-CONSULTA, C.PRESC_CONSULTA FROM CONSULTA AS C INNER JOIN PET AS P ON P.COD_PET = C.COD_PET  " +
                    "INNER JOIN TUTOR AS T ON T.CPF_TUTOR = P.CPF_TUTOR");

                conexao.StrString = str.ToString();
                ds = conexao.DateSet();
                dt = ds.Tables[0];

                if (!Tabela(dt))
                {
                    return;
                }

                dgvListagens.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da consulta. " + ex.Message);
            }
        }

        public bool Tabela(DataTable tb)
        {
            if (tb == null || tb.Rows.Count == 0)
            {
                MessageBox.Show("Não encontramos nada :/");
                return false;
            }
            return true;
            }
        }
}
