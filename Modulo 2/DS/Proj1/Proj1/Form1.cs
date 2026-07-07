namespace Proj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int Matricula;
            string Nome;

            Matricula = Convert.ToInt16( txtMatricula.Text);
            Nome =txtNome.Text;

            MessageBox.Show("Nome do aluno:" + Nome);
            MessageBox.Show(Convert.ToString (Matricula));
            
        }
    }
}
