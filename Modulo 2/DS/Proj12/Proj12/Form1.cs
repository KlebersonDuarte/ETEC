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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos alunos = new frmAlunos();
            alunos.ShowDialog();
        }

        private void mensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMensalidade mensalidade = new frmMensalidade();
            mensalidade.ShowDialog();
        }

        private void listagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagem listagem = new frmListagem();
            listagem.ShowDialog();
        }
    }
}
