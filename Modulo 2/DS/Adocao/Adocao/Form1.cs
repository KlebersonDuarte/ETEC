namespace Adocao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdotarcs adotarcs = new frmAdotarcs();
            adotarcs.ShowDialog();
        }
    }
}
