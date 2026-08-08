using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proj12
{
    internal class clsConexao
    {
        MySqlConnection Conn = new MySqlConnection();
        public MySqlCommand Cmd = new MySqlCommand();

        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        private string strConexao = "datasource=localhost;username=root" + ";password=;database=Etec";

        private MySqlConnection AbrirBanco()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }

        private void Fechar (SqlConnection Conn)
        {
            if(Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDataSet() //Select
        {
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();
            try
            {   
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;

                DA.SelectCommand = Cmd;
                DA.Fill(DS);
                return (DS);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }

        }

        public MySqlDataReader RetornarDataReader()//Select
        {
            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;
                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex) { throw ex; }

        }

        public int ExecutarCmd()//Insert/delete/update
        {
            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;
                return Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message.ToString());

            }
            finally { Conn.Close(); }
        }
    }
}
