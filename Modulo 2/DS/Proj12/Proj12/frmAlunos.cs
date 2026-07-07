using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proj12
{
    public partial class frmAlunos : Form
    { clsConexao conn = new clsConexao();
        StringBuilder sb = new StringBuilder();
        MySqlDataReader SDR;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();


        public frmAlunos()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

          

            if (txtMatricula.Text == "" || txtNome.Text == "" || txtEmail.Text == "" || txtCpf.Text == "" || dtpNascimento.Text == "" || ptbFoto.Image == null)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            sb.Clear();
            sb.Append("select Matricula from Alunos where Matricula = @Matricula");

            conn.cmd.Parameters.Clear();
            conn.cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);

            conn.StrSql = sb.ToString();

            if (conn.ExecutarCmd() > 0)
            {
                MessageBox.Show("Já existe um aluno com essa matrícula");
                return;
            }

            byte[] imageBytes = File.ReadAllBytes(ptbFoto.ImageLocation);
            try
            {
                sb.Clear();
                sb.Append(" insert into Alunos( Matricula, Nome, Email, Nascimento, cpf, Foto) ");
                sb.Append("values  ");
                sb.Append("(@Matricula, @Nome, @Email, @Nascimento, @cpf, @Foto )");

                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
                conn.cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                conn.cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                conn.cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                conn.cmd.Parameters.AddWithValue("@Nascimento", dtpNascimento.Value);
                conn.cmd.Parameters.AddWithValue("@Foto", imageBytes);

                conn.StrSql = sb.ToString();

                if (conn.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Incluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao incluir");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Falha do sistema: " +  ex.ToString());
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtMatricula.Text = "";
            txtNome.Text = "";
            dtpNascimento.Text = "";
            ptbFoto.Image = null;
        }

        private void btnAlterarAlunos_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "" || txtNome.Text == "" || txtEmail.Text == "" || txtCpf.Text == "" || dtpNascimento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            try
            {
                sb.Clear();
                sb.Append(" update Alunos set Nome = @Nome, Email = @Email, Nascimento = @Nascimento, cpf = @cpf where Matricula = @Matricula ");
                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
                conn.cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                conn.cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                conn.cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                conn.cmd.Parameters.AddWithValue("@Nascimento", dtpNascimento.Value);
                conn.cmd.Parameters.AddWithValue("@Foto", ptbFoto.Image);

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

        private void btnExcluirAlunos_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "")
            {
                MessageBox.Show("Informe a matrícula");
                return;
            }
            try
            {
                sb.Clear();
                sb.Append(" delete from Alunos where @Matricula = Matricula ");
                conn.cmd.Parameters.Clear();
                conn.cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
                
                conn.StrSql = sb.ToString();

                if (conn.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Excluído com sucesso ");

                }

                else
                {
                    MessageBox.Show("Verifique se a matrícula está correta");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha no sistema " + ex.ToString());
            }
        }

        private void btnConsGeral_Click(object sender, EventArgs e)
        {
            try
            {
                sb.Clear();
                sb.Append("select * from Alunos order by Nome");

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvAlunos.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private void btnConsIndi_Click(object sender, EventArgs e)
        {

            

            sb.Clear();
            sb.Append("select * from Alunos ");
            sb.Append("where Matricula = @Matricula");

            conn.cmd.Parameters.Clear();
            conn.cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);

            conn.StrSql = sb.ToString();
            SDR = conn.RetornarDados();

            if (SDR.Read())
            {

                txtNome.Text = SDR["Nome"].ToString();
                txtEmail.Text = SDR["Email"].ToString();
                dtpNascimento.Text = SDR["Nascimento"].ToString();
                txtCpf.Text = SDR["cpf"].ToString();


                byte[] imagemBytes = (byte[])SDR["Foto"];

                MemoryStream ms = new MemoryStream(imagemBytes);

                ptbFoto.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Não localizado");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();

            foto.Filter = "imagens|*.jpg;*.png;*.jpeg";

            if (foto.ShowDialog() == DialogResult.OK)
            {
                ptbFoto.ImageLocation = foto.FileName;
            }
        }

        private void dgvAlunos_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                if (dgvAlunos.CurrentRow != null)
                {
                    txtMatricula.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                    txtNome.Text = dgvAlunos.CurrentRow.Cells[1].Value.ToString();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao selecionar aluno: " + ex.ToString());
            }
        }
    }
}
