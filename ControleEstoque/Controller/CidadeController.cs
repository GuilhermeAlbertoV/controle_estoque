using ControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Controller
{
    class CidadeController
    {




        #region Variaveis

        #region Contrutor

        private CidadeDAO cidadeDAO = null;


        EstadoController estadoController = new EstadoController();

        public CidadeController()
        {
            cidadeDAO = new CidadeDAO();
        }

        #endregion Contrutor


        #region Métodos
        public int IncluirCidadeController(CidadeModel cidadeModel)
        {
            return cidadeDAO.IncluirCidadeDAO(cidadeModel);
        }

        public int AlterarCidadeController(CidadeModel cidadeModel)
        {
            return cidadeDAO.AlterarCidadeDAO(cidadeModel);
        }

        public int ExcluirCidadeController(int pidcidade)
        {

            return cidadeDAO.ExcluirCidadeDAO(pidcidade);
        }

        ///<summary>
        ///Método que Recupera do Banco de dados de todos os registros.
        ///</summary>
        ///<param name="dtg"></param>
        ///<returns>DataTable</returns>

        public ObterRegistroCidade()
        {
            cidadeDAO = new CidadeDAO();
            return cidadeDAO.ObterAllCidades();
        }

        ///<summary>
        ///Método que solicita a pesquisa do texto dentro do datagridview
        ///</summary>
        ///<param name="dtg"></param>
        ///<param name="texto"></param>
        public void PesquisarCidade(DataGridView dtg, string texto)
        {
            ((DataTable)dtg.DataSource).DefaultView.RowFilter = string.Format("NomeCidade" + "like '%{`0}%'", texto.Replace("'","''"));
        }

        public void PopularCBEstado(ComboBox cbo)
        {
            EstadoController estadoCrl = new EstadoController();
            estadoController.PreencherCboEstado(cbo);
        }

        #endregion Métodos




        #endregion Variaveis


    }

}

