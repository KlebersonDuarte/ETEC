using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj12
{
    public partial class FrmProdutos : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder CmdSql = new StringBuilder();
        DataSet DS;
        DataTable DT;
        MySqlDataReader SDR;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CmdSql.Remove(0, CmdSql.Length);
            CmdSql.Append("insert into Produtos ");
            CmdSql.Append("(Codigo, Descricao, Valor, Vencimento) ");
            CmdSql.Append("values ");
            CmdSql.Append("(@Codigo, @Descricao, @Valor, @Vencimento)");

            Conexao.Cmd.Parameters.Clear();
            Conexao.Cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            Conexao.Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Conexao.Cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
            Conexao.Cmd.Parameters.AddWithValue("@Vencimento", dtpVencimento.Value);

            Conexao.StrSql = CmdSql.ToString();

            if (Conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Inclusao com sucesso");
                ChamarGrid();
            }
            else
            {
                MessageBox.Show("Erro na inclusão");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CmdSql.Remove(0, CmdSql.Length);
            CmdSql.Append("delete from Produtos");
            CmdSql.Append(" where Codigo = @Codigo");

            Conexao.Cmd.Parameters.Clear();
            Conexao.Cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

            Conexao.StrSql = CmdSql.ToString();

            if (Conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Deletado com sucesso");
                ChamarGrid();
            }
            else
            {
                MessageBox.Show("Erro na deletação");
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CmdSql.Clear();
            CmdSql.Append("select * from Produtos");

            Conexao.StrSql = CmdSql.ToString();
            DS = Conexao.RetornarDataSet();

            DT = DS.Tables[0];
            dgvBanco.DataSource = DT;
        }

        private void ChamarGrid()
        {
            Conexao.StrSql = "select * from Produtos";
            DS = Conexao.RetornarDataSet();

            DT = DS.Tables[0];
            dgvBanco.DataSource = DT;
        }

        private void btnPesqPrcl_Click(object sender, EventArgs e)
        {
            CmdSql.Clear();
            CmdSql.Append("select * from Produtos ");
            CmdSql.Append("where Codigo = @Codigo");

            Conexao.Cmd.Parameters.Clear();
            Conexao.Cmd.Parameters.AddWithValue("@Codigo",txtCodigo.Text);

            Conexao.StrSql = CmdSql.ToString();
            SDR = Conexao.RetornarDataReader();

            if (SDR.Read())
            {
                txtDescricao.Text = SDR["Descricao"].ToString();
                txtValor.Text = SDR["Valor"].ToString();
                dtpVencimento.Text = SDR["Vencimento"].ToString();
            }
        }
    }       

}
