using ControleEstoque.AcessoDB;
using ControleEstoque.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.DAO
{
    public class EstadoDAO
    {
        #region variaveis

        private MySqlConnection conn = null;
        private int retorno = 0;
        private AcessoBanco conexao = null;
        EstadoDAO estadoDAO = null;

        #endregion variaveis
        #region contrutor
        public EstadoDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConectarDB();
        }

        #endregion contrutor
        #region Metodos



        internal static DataTable ObterTodosRegistros()
        {
            throw new NotImplementedException();
        }

        public DataTable ObterTodosEstados()
        {
            try
            {
                return conexao.ExecDataTable("usplocalizar", conn);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ObterTodosEstado()
        {
            return estadoDAO.ObterTodosEstados();
        }

        public int IncluirEstadoDAO(EstadoModel pEstadoModel)
        {

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("uspEstadoIncluir", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nomeestado", pEstadoModel.NomeEstado);
                    cmd.Parameters.AddWithValue("uf", pEstadoModel.UF);
                   
                    conexao.AbrirConexao();
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexao.FecharConexao();
            }
            return retorno;


        }

        public int AlterarEstadoDAO(EstadoModel pEstadoModel)
        {

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("uspEstadoAlterar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idestado", pEstadoModel.idEstado);
                    cmd.Parameters.AddWithValue("@nomeestado", pEstadoModel.NomeEstado);
                    cmd.Parameters.AddWithValue("@uf", pEstadoModel.UF);

                    conexao.AbrirConexao();
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexao.FecharConexao();
            }
            return retorno;


        }

        public int ExcluirEstadoDAO(int pid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("uspEstadoAlterar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idestado", pid);


                    conexao.AbrirConexao();
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexao.FecharConexao();
            }
            return retorno;
        }



        #endregion Metodos
    }
}
