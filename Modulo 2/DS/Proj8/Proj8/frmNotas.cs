using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj8
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }



        private void btnBoletim_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();



            String Nome, Curso, Periodo,Resultado;
            double N1, N2, N3, Media;
            int Matricula;

            Nome = txtNome.Text.ToString();
            Curso = cboCurso.Text.ToString();
            Matricula = int.Parse(txtMatricula.Text.ToString());

            N1 = double.Parse(txt1.Text.ToString());
            N2 = double.Parse(txt2.Text.ToString());
            N3 = double.Parse(txt3.Text.ToString());

            if (rdbManha.Checked)
            {
                Periodo = "Manhâ";
            }
            else if (rdbTarde.Checked)
            {
                Periodo = "Tarde";
            }
            else if (rdbNoite.Checked)
            {
                Periodo = "Noite";
            }
            else {
                MessageBox.Show("Selecione uma opção válida");
                return;
            }




            Media = fMedia(N1,N2,N3);

            if (Media < 4)
            {
                Resultado = "Retido";
                lblResultado.ForeColor = Color.Red;
            }
            else if (Media < 7)
            {
                Resultado = "Recuperação";
                lblResultado.ForeColor = Color.Blue;
            }
            else if (Media <= 10)
            {
                Resultado = "Aprovado";
                lblResultado.ForeColor = Color.Green;

            }
            else {
                lblResultado.Text = "Falha no sistema";
                MessageBox.Show("Falha no sistema");
                lblResultado.ForeColor= Color.Red;
                return;
            }

            msg.Remove(0, msg.Length);
            msg.Append("***Boletim***");
            msg.Append(" \n Matricula: " +Matricula);
            msg.Append("  Nome: " + Nome);
            msg.Append(" \n Período: " + Periodo);
            msg.Append(" \n Bim1: " + N1 + " Bim2: " + N2 + " Bim3: " + N3);
            msg.Append(" \n Média: " + Media.ToString("N2"));
            msg.Append(" \n Resultado: " + Resultado);
            lblBoletim.Text = msg.ToString();
            lblResultado.Text = Resultado.ToString();
            MessageBox.Show(msg.ToString());

        }
        double fMedia(double Nota1, double Nota2, double Nota3)
        {
            double mediaFinal;
            mediaFinal = (Nota1 + Nota2 + Nota3) / 3;
            return mediaFinal;
        }
    }
}
