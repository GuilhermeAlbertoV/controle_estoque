using ControleEstoque.AcessoDB;
using ControleEstoque.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Model
{
    public class EstadoModel
    {
        private int idestado;
        private string nomeestado;
        private string uf;

        public int idEstado { get; set; }
        public string NomeEstado { get; set; }
        public string UF { get; set; }


        #region variaveis

        private MySqlConnection conn = null;
        private int retorno = 0;
        private AcessoBanco conexao = null;

        #endregion variaveis
        #region contrutor

        public EstadoModel()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConectarDB();
        }



        #endregion contrutor
        #region Metodos

        public int IncluirEstadoDAO(EstadoModel pEstadoModel)
        {

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("uspestadoincluir", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nomeestado", pEstadoModel.NomeEstado);
                    cmd.Parameters.AddWithValue("@uf", pEstadoModel.UF);


                    conexao.AbrirConexao();
                    retorno = cmd.ExecuteNonQuery();


                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conexao.FecharConexao();
            }
            return retorno;

        }

        internal int AlterarEstadoController(EstadoModel estadoModel)
        {
            throw new NotImplementedException();
        }

        internal int EstadoExcluirController(int idEstado)
        {
            throw new NotImplementedException();
        }



        #endregion Metodos
    }
}
