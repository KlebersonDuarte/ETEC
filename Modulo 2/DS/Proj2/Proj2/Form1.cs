using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Atributos
            double Valor,VlTotal;
            int Quantidade;


            //Pegando o valor (Linkando)
            Valor =Convert.ToDouble( txtValor.Text);
            Quantidade =Convert.ToInt32 (txtQuantidade.Text);

            VlTotal = Valor * Quantidade;
                

            //Mostrando a msg
            lblResultado.Text =Convert.ToString(VlTotal);

            if (VlTotal > 100)
            {
                VlTotal = VlTotal - (VlTotal * 10 / 100);
            }
            else 
            {
                VlTotal = VlTotal - (VlTotal * 5 / 100);
            }
            lblDesconto.Text = Convert.ToString(VlTotal);

        }
    }
}
