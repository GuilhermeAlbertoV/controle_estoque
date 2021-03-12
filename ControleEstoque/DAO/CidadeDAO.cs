using ControleEstoque.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoque.AcessoDB;
using System.Data;



namespace ControleEstoque.DAO
{
    class CidadeDAO
    {
        #region Variavies

        private MySqlConnection conn = null;
        private AcessoBanco conexao = null;
        private int retorno = 0;

        #endregion Variavies

        #region Construtor

        ///<summary>
        ///Inclusao de uma nova Cidade
        ///</summary>
        /// <param name="pCidadeModel">Classe CidadeModel</param>
        /// <returns>Coódico da cidade que foi incluida</returns>


        public CidadeDAO()
        {
            conexao = new AcessoBanco();
            conn = conexao.ConectarDB();
        }
        #endregion Construtor

        #region Métodos

        public int IncluirCidadeDAO(CidadeModel pCidadeModel)
        {
            int retorno = 0;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("uspCidadeIncluir", conexao.ConectarDB()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idNomeCidade",pCidadeModel.NomeCidadde)
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
