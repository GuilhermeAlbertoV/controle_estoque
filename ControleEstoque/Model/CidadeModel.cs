using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Model
{
    class CidadeModel
    {
        private int idCidade;
        private string nomecidade;
        private EstadoModel estadoModel;

        public CidadeModel(EstadoModel estadoModel)
        {
            if (estadoModel == null)
            {
                this.estadoModel = new EstadoModel();

            }
            else
            {
                this.estadoModel = estadoModel;
            }
        }

        public int IdCidade { get => idCidade; set => idCidade = value; }
        public string NomeCidadde { get => nomecidade; set => nomecidade = value; }
        public EstadoModel EstadoModel { get => estadoModel; set => estadoModel = value; }

    }
}
