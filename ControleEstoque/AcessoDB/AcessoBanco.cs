using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.AcessoDB
{
    public class AcessoBanco
    {
        #region Variáveis
        private MySqlConnection conectar;
        private string StrConn = String.Empty;
        private MySqlTransaction tran;
        private MySqlDataAdapter da;

        #endregion Variáveis

        #region Contrutor
        public AcessoBanco()
        {

        }

        public MySqlConnection conectarDB()
        {
            try
            {
                if (StrConn.Trim().Length == 0)
                {
                    StrConn = ConfigurationManager.ConnectionStrings["strconn"].ToString();
                }
                conectar = new MySqlConnection(StrConn);

            }
            catch (Exception)
            {



            }
            return conectar;

        }
        public MySqlConnection AbrirConexao()
        {
            conectar.Open();
            return conectar;
        }

        public void FecharConexao()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

        #endregion Contrutor
        MySqlCommand cmd;
        private readonly string pNomeStoredProcedure;

        #region Métodos
        public MySqlConnection ConectarDB()
        {
            try
            {
                if (StrConn.Trim().Length == 0)
                {
                    StrConn = ConfigurationManager.ConnectionStrings["strconn"].ToString();
                }
                conectar = new MySqlConnection(StrConn);

            }
            catch (Exception)
            {



            }
            return conectar;

        }
        public MySqlConnection AbrirConexão()
        {
            conectar.Open();
            return conectar;
        }

        public void FecharConexão()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

        public MySqlTransaction IniciarMySqlTransaction(MySqlCommand cmd)
        {
            tran = conectar.BeginTransaction();
            cmd.Connection = conectar;
            cmd.Transaction = tran;
            return tran;
        }

        public void FinalizarTransacao(Boolean ret)
        {
            if (ret)
            {
                tran.Commit();
            }
            else
            {
                tran.Rollback();
            }
        }

        public DataTable ExecDataTable(string pNomeStoredProcedure)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(pNomeStoredProcedure, conectar))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter Adapter = new MySqlDataAdapter(cmd);
                try
                {
                    Adapter.Fill(dt);
                }
                catch (InvalidOperationException)
                {


                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dt;
            }

        }

        public DataTable ExecDataTable(string pNome, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(pNomeStoredProcedure))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(pNomeStoredProcedure, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion Métodos
    }
}
