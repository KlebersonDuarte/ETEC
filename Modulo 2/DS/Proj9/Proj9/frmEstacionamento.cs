using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj9
{
    public partial class frmEstacionamento : Form
    {
        public frmEstacionamento()
        {
            InitializeComponent();
        }
 
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                string placa, marca, modelo, convenio;
                DateTime entrada, saida;
                double valorHora = 0, tempo, desconto = 0;
                StringBuilder msg = new StringBuilder();

                placa = txtPlaca.Text;
                marca = cboMarca.Text;
                modelo = cboModelo.Text;
                convenio = cboConvenio.Text;
                entrada = DateTime.Parse(dtpEntrada.Text);
                saida = DateTime.Parse(dtpSaida.Text);

                tempo = (saida - entrada).TotalHours;

                //Verifica se todos os campos estão preenchidos
                if (placa != string.Empty && marca != string.Empty && modelo != string.Empty && convenio != string.Empty && dtpEntrada.Text != string.Empty && dtpSaida.Text != string.Empty)
                {
                    //Verifica se a data da saída é anterioar a data de entrada
                    if (saida > entrada){
                    if (tempo <= 0.5)
                    {
                        valorHora = 10;
                    }
                    else if (tempo <= 1)
                    {
                        valorHora = 18;
                    }
                    else if (tempo <= 2)
                    {
                        valorHora = 30;
                    }
                    else if (tempo <= 3)
                    {
                        valorHora = 45;
                    }
                    else
                    {
                        valorHora = 60;
                    }
                }

                else
                {
                    MessageBox.Show("Data de saída deve ser maior que a data de entrada.");
                    return;
                }


                //Desconto do convênio
                if (convenio == "5%")
                {
                    desconto = valorHora * (1 - 0.05);
                }
                else if (convenio == "2,5%")
                {
                    desconto = valorHora * (1 - 0.025);
                }
                else if (convenio == "R$5")
                {
                    desconto = valorHora - 5;
                }
                else
                {
                    MessageBox.Show("Falha do sistema");
                    return;
                }

                //Mensagem Final
                    msg.AppendLine($"\nPlaca: {placa}");
                    msg.AppendLine($"\nMarca: {marca}");
                    msg.AppendLine($"\nModelo: {modelo}");
                    msg.AppendLine($"\nConvênio: {convenio}");
                    msg.AppendLine($"\nEntrada: {entrada}");
                    msg.AppendLine($"\nSaída: {saida}");
                    msg.AppendLine($"\nTempo: {tempo} horas");
                    msg.AppendLine($"\nValor a parte: R$ {valorHora}");
                    msg.AppendLine($"\nValor com desconto: R$ {desconto}");
                    lblResposta.Text = msg.ToString(); 
                }

                else {
                    MessageBox.Show("Preencha todos os Campos");
                }
            }
            catch (Exception ex) { 
            Console.Error.WriteLine(ex.ToString());
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMarca.Text == "Honda") // Honda
                {
                    cboModelo.Items.Clear();
                    cboModelo.Text = "";
                    cboModelo.Items.Add("Honda Civic");
                    cboModelo.Items.Add("Honda HR-V");
                    cboModelo.Items.Add("Honda City Hatch");
                }

                else if (cboMarca.Text == "Toyota") //Toyota
                {
                    cboModelo.Items.Clear();
                    cboModelo.Text = "";
                    cboModelo.Items.Add("Toyota Corolla");
                    cboModelo.Items.Add("Toyota Hilux");
                    cboModelo.Items.Add("Toyota Corolla Cross");
                }
                else //Ford
                {
                    cboModelo.Items.Clear();
                    cboModelo.Text = "";
                    cboModelo.Items.Add("Ford Motor Company Ranger");
                    cboModelo.Items.Add("Ford Motor Company Mustang");
                    cboModelo.Items.Add("Ford Motor Company Territory");
                }
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                    }
            
        } 
    }
}
