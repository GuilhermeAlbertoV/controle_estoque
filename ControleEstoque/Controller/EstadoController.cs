using ControleEstoque.DAO;
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
    public class EstadoController
    {
        EstadoDAO estadoDAO = null;

        public EstadoController()
        {
            estadoDAO = new EstadoDAO();
            //++Wyllian em 11/03/2021 - Wyllian é fodao

        }

        public int incluirEstadoController(EstadoModel pEstadoModel)
        {
            try
            {
                return estadoDAO.IncluirEstadoDAO(pEstadoModel);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public  DataTable ObterTodosRegistro()
        {
            return EstadoDAO.ObterTodosRegistros();
        }

        private void PesquisarEstados(DataGridView dtg,string texto)
        {
            ((DataTable)dtg.DataSource).DefaultView.RowFilter = string.Format("NomeEstado" + "Like '%{0}%'", texto.Replace("'","' '"));
        }

        internal void PesquisarEstados(DataGridView dgvEstado, Func<char[], string> trim)
        {
            throw new NotImplementedException();
        }

        internal static int estadoAlterarController(EstadoModel em)
        {
            throw new NotImplementedException();
        }

        public int AlterarEstadoController(EstadoModel pEstadoModel)
        {

            try
            {
                return estadoDAO.AlterarEstadoDAO(pEstadoModel);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int ExcluirEstadoController(int pEstadoModel)
        {

            try
            {
                return estadoDAO.ExcluirEstadoDAO(pEstadoModel);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
