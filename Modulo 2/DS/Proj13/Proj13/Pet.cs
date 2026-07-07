using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj13
{
    public partial class Pet : Form
    {
        clsConexao conexao = new clsConexao();
        StringBuilder str = new StringBuilder();
        MySqlDataReader SDR;

        public Pet()
        {
            InitializeComponent();
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            try
            {
                String genero = "";
                if (rdbMacho.Checked)
                {
                    genero = "Macho";
                }
                else if (rdbFemea.Checked)
                {
                    genero = "Fêmea";
                }

                if (txtCpfTutor.Text == "" || txtNomePet.Text == "" || txtRaca.Text == "" || cboEspecie.Text == "" || genero == "" || ptbPet.ImageLocation == null)
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

                byte[] foto = File.ReadAllBytes(ptbPet.ImageLocation);
                str.Clear();
                str.Append("INSERT INTO PET (CPF_TUTOR, NASC_PET, GENE_PET, RACA_PET, FOTO_PET, NOME_PET, ESPECIE_PET) VALUES " +
                    "(@CPF_TUTOR, @NASC_PET, @GENE_PET, @RACA_PET, @FOTO_PET, @NOME_PET, @ESPECIE_PET)");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@CPF_TUTOR", txtCpfTutor.Text);
                conexao.cmd.Parameters.AddWithValue("@NASC_PET", dtpNascimento.Value);
                conexao.cmd.Parameters.AddWithValue("@GENE_PET", genero);
                conexao.cmd.Parameters.AddWithValue("@RACA_PET", txtRaca.Text);
                conexao.cmd.Parameters.AddWithValue("@FOTO_PET", foto);
                conexao.cmd.Parameters.AddWithValue("@NOME_PET", txtNomePet.Text);
                conexao.cmd.Parameters.AddWithValue("@ESPECIE_PET", cboEspecie.Text);


                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Pet cadastrado com sucesso!");
                    return;
                }

                MessageBox.Show("Por favor verifique se o cpf do tutor está correto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao incluir. " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try {
                if(txtIDPet.Text == "")
                {
                    MessageBox.Show("Por favor, informe o código do pet.");
                    return;
                }

                str.Clear();
                str.Append("DELETE FROM PET WHERE COD_PET = @COD_PET");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@COD_PET", txtIDPet.Text);
                conexao.StrString = str.ToString();

                if (conexao.ExecutarComando() > 0)
                {
                    MessageBox.Show("Pet excluído com sucesso!");
                    return;
                }

                MessageBox.Show("Não há pet cadastrado com os dados informados.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir. " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpfTutor.Text = "";
            dtpNascimento.Text = "";
            rdbMacho.Checked = false;
            rdbFemea.Checked = false;
            txtRaca.Text = "";
            ptbPet.Image = null;
            txtNomePet.Text = "";
            cboEspecie.Text = "";
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Imagem|*.jpg;*.jpeg;*.png;";
            
            if (foto.ShowDialog() == DialogResult.OK)
            {
                ptbPet.ImageLocation = foto.FileName;
            }
        }

        private void btnPesqRapP_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIDPet.Text == "")
                {
                    MessageBox.Show("Por favor, informe o código do pet.");
                    return;
                }

                str.Clear();
                str.Append("SELECT * FROM PET WHERE COD_PET = @COD_PET");

                conexao.cmd.Parameters.Clear();
                conexao.cmd.Parameters.AddWithValue("@COD_PET", txtIDPet.Text);

                conexao.StrString = str.ToString();

                SDR = conexao.DataReader();

                if (SDR.Read())
                {
                    txtNomePet.Text = SDR["NOME_PET"].ToString();
                    txtRaca.Text = SDR["RACA_PET"].ToString();
                    cboEspecie.Text = SDR["ESPECIE_PET"].ToString();
                    dtpNascimento.Text = SDR["NASC_PET"].ToString();

                    if (SDR["GENE_PET"].ToString() == "Macho")
                    {
                        rdbMacho.Checked = true;
                    }
                    rdbFemea.Checked = true;

                    byte[] imagemBytes = (byte[])SDR["FOTO_PET"];

                    MemoryStream ms = new MemoryStream(imagemBytes);

                    ptbPet.Image = Image.FromStream(ms);
                    return;
                }
                MessageBox.Show("Pet não encontrado.");
            }
            catch (Exception ex) {
                MessageBox.Show("Falha ao pesquisar. " + ex.Message);
            }
            }
    }
}
