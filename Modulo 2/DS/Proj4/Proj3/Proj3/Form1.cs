using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            int matricula;
            double Bim1,Bim2,Bim3,Media;
            String Nome, Curso, Boletim, Periodo = "",MediaR = "";

            


            matricula = Convert.ToInt32(txtMatricula.Text);
            Bim1= Convert.ToDouble(txtBim1.Text);
            Bim2 = Convert.ToDouble(txtBim2.Text);
            Bim3 = Convert.ToDouble(txtBim3.Text);
            Nome = txtNome.Text;
            Curso = cbbCurso.Text;


           Media = (Bim1 + Bim2 + Bim3) / 3;


            if (Media < 4.99)
            {
                
                MediaR = "Resultado: Retido";
                lblResultado.ForeColor = Color.Red;

            }
            else if (Media < 6.99)
            {
                MediaR = "Resultado: Recuperação";
                lblResultado.ForeColor= Color.Blue ;

            }
            else
            {

                MediaR = "Resultado: Aprovado";
                lblResultado.ForeColor = Color.Green;
            }

            if (rdbM.Checked)
            {
                Periodo = "Manhã";
            }
            else if (rdbT.Checked)
            {
                Periodo = "Tarde";
            }
            else {
            
                Periodo = "Noite";
            }

            Boletim = "Boletim" +
                "\nMatricula: " + matricula +
                "\nNome: " + Nome +
                "\nCurso: " + Curso +
                "\nPerído: " + Periodo +
                "\nNotas" +
                "\nB1: " + Bim1 + " B2: " + Bim2 + " B3: " + Bim3 +
                "\nMédia: " + Media;


            lblBoletim.Text = Convert.ToString(Boletim);
            lblResultado.Text = MediaR;

        }
    }
}
