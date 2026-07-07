using MySql.Data.MySqlClient;
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
    public partial class frmListagem : Form
    {   
        clsConexao conn = new clsConexao();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        StringBuilder sb = new StringBuilder();
        public frmListagem()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                sb.Clear();
                sb.Append("select * from Alunos order by Nome");

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvResultado.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private void btnNiver_Click(object sender, EventArgs e)
        {
            try {
                if (Data() == 1)
                {
                    return;
                }

                sb.Clear();
                sb.Append("select Nome, Nascimento from Alunos where MONTH(Nascimento) = " + int.Parse(txtMes.Text) + " order by Nascimento");

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvResultado.DataSource = DT;
            }catch(Exception ex)
            {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
            }

        private void btnPg_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data() == 1)
                {
                    return;
                }
                sb.Clear();
                sb.Append("select * from Mensalidade where MONTH(data_pagamento) =  " + int.Parse(txtMes.Text));

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvResultado.DataSource = DT;
            }
            catch(Exception ex) {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            try
            {

                if (Data() == 1)
                {
                    return;
                }

                sb.Clear();
                sb.Append("select count(*) as Descontos from Mensalidade where valor_bruto < valor_pagar && MONTH(data_pagamento) = " + int.Parse(txtMes.Text));

                conn.StrSql = sb.ToString();

                DS = conn.RetornarDataSet();
                DT = DS.Tables[0];
                dgvResultado.DataSource = DT;
            }
            catch (Exception ex) {
                MessageBox.Show("Falha do sistema: " + ex.ToString());
            }
        }

        private int Data()
        {   
            if(txtMes.Text == "")
            {
                MessageBox.Show("Informe o mês!");
                return 1;
            }

            try
            {
                int mes = int.Parse(txtMes.Text);


                if (mes < 1 || mes > 12)
                {
                    MessageBox.Show("Mês inválido!");
                    return 1;
                }
                return 0;
            }
            catch {
                MessageBox.Show("Mês inválido!");
                return 1;
            }
        }
    }
}
