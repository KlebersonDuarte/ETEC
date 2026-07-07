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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Tutor tutor = new Tutor();
            tutor.ShowDialog();
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos();
            servicos.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.ShowDialog();
        }

        private void listagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagens listagens = new Listagens();
            listagens.ShowDialog();
        }
    }
}
