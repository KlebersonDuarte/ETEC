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

namespace Proj12
{
    public partial class frmMensalidade : Form
    {
        clsPrazo prazo = new clsPrazo();
        clsConexao conn = new clsConexao();
        StringBuilder sb = new StringBuilder();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        MySqlDataReader SDR;

        public frmMensalidade()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           txtIDMatricula.Text = "";
            txtValor.Text = "";
            dtpPagamento.Text = "";
        }

        private void btnMensal_Click(object sender, EventArgs e)
        {
           // DateTime now = DateTime.Now;
            if(txtIDMatricula.Text == "" || txtValor.Text == "" || dtpPagamento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            try
            {
                /*if(dtpPagamento.Value.Month < now.Month || dtpPagamento.Value.Year < now.Year)
                {
                    MessageBox.Show("Por favor, selecione uma data de pagamento que não seja anterior à data atual");
                    return;
                } */

                sb.Clear();
                sb.Append("select Matricula from Alunos where Matricula = @Matricula");

                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtIDMatricula.Text);

                conn.StrSql = sb.ToString();

               if(conn.ExecutarCmd() == 0)
                {
                    MessageBox.Show("Matrícula não encontrada");
                    return;
                }

                prazo.strData = dtpPagamento.Value;
                prazo.vlBruto = Convert.ToDouble(txtValor.Text);

                sb.Clear();
                sb.Append("insert into mensalidade( Matricula, data_pagamento, valor_pagar, valor_bruto) ");
                sb.Append("values  ");
                sb.Append("(@Matricula, @data_pagamento, @valor_pagar, @valor_bruto)");

                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtIDMatricula.Text);
                conn.cmd.Parameters.AddWithValue("@valor_pagar", txtValor.Text);
                conn.cmd.Parameters.AddWithValue("@valor_bruto", prazo.CalcularPrazo());
                conn.cmd.Parameters.AddWithValue("@data_pagamento", dtpPagamento.Value);

                conn.StrSql = sb.ToString();

                if (conn.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Incluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao incluir");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private void btnAlterarMens_Click(object sender, EventArgs e)
        {
            if (txtIDMatricula.Text == "" || txtValor.Text == "" || dtpPagamento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            try
            {
                sb.Clear();
                sb.Append(" update Mensalidade set valor_pagar = @ValorPagar, valor_bruto = @ValorBruto, data_pagamento = @dtaPagamento where Matricula = @Matricula ");
                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtIDMatricula.Text);
                conn.cmd.Parameters.AddWithValue("@ValorPagar", txtValor.Text);
                conn.cmd.Parameters.AddWithValue("@ValorBruto", prazo.CalcularPrazo());
                conn.cmd.Parameters.AddWithValue("@dpaPagamento", dtpPagamento.Value);

                conn.StrSql = sb.ToString();

                if (conn.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Alterado com sucesso");

                }
                else
                {
                    MessageBox.Show("Erro ao alterar");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha no sistema: " + ex.ToString());

            }
        }

        private void btnExcluirMens_Click(object sender, EventArgs e)
        {
            if (txtIDMatricula.Text == "")
            {
                MessageBox.Show("Informe a matrícula");
                return;
            }
            try
            {
                sb.Clear();
                sb.Append(" delete from Mensalidade where @Matricula = Matricula ");
                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtIDMatricula.Text);

                conn.StrSql = sb.ToString();

                if (conn.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Excluído com sucesso ");

                }

                else
                {
                    MessageBox.Show("Erro ao excluir ");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha no sistema " + ex.ToString());
            }
        }

        private void btnConsGeralMens_Click(object sender, EventArgs e)
        {
            try
            {
                sb.Clear();
                sb.Append("select * from Mensalidade order by data_pagamento");

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvMens.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private void btnConsIndiMens_Click(object sender, EventArgs e)
        {
            sb.Clear();
            sb.Append("select * from Mensalidade where Matricula = @Matricula");

            conn.cmd.Parameters.Clear();
            conn.cmd.Parameters.AddWithValue("@Matricula", txtIDMatricula.Text);
            conn.StrSql = sb.ToString();


            SDR = conn.RetornarDados();

            if (SDR.Read())
            {
                txtValor.Text = SDR["valor_pagar"].ToString();
                dtpPagamento.Text = SDR["data_pagamento"].ToString();
            }

        }

        private void dgvMens_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvMens.CurrentRow != null)
                {
                    txtIDMatricula.Text = dgvMens.CurrentRow.Cells[1].Value.ToString();
                    dtpPagamento.Value = DateTime.Parse(dgvMens.CurrentRow.Cells[2].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar aluno: " + ex.ToString());
            }
        }
    }
}
