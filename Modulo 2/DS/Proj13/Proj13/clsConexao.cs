using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Proj13
{
    internal class clsConexao
    {
        MySqlConnection conn = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();

        private string _StrString;
        
        public string StrString
        {
            get { return _StrString; }
            set { _StrString = value; }
        }

        private string host = "datasource=localhost; user = root; password =;database = Proj13;";

        private MySqlConnection AbrirBanco()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = host;
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

        public MySqlDataReader DataReader()
        {
            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrString;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public DataSet DateSet()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrString;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                conn.Close( );
            }
        }

        public int ExecutarComando()
        {
            try
            {
                conn = AbrirBanco();
                cmd.CommandText = _StrString;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
