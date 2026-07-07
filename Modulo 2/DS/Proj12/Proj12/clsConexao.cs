using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Proj12
{
    internal class clsConexao
    {
        public MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();

        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        private string conexao = "datasource = localhost; username = root; password = ;database = Escola";

        private MySqlConnection AbrirBanco()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = conexao;
            conn.Open();
            return conn;
        }

        private void FecharBanco(SqlConnection conn)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataSet RetornarDataSet()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                DA.SelectCommand = cmd;
                DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public MySqlDataReader RetornarDados()
        {
            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutarCmd()
        {
            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex.Message.ToString());
            }
            finally { conn.Close(); }
        }
    }

}
