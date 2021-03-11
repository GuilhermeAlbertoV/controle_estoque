using ControleEstoque.Controller;
using ControleEstoque.Model;
using ControleEstoque.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoque.DAO;


namespace ControleEstoque.View
{
    public partial class WFEstadoView : MetroFramework.Forms.MetroForm
    {
        #region Váriaveis
        private enum OPERACAO { Incluir, Alterar, Excluir, StandBy }
        private OPERACAO enuAcao;

        string[] nomeColuna = { "Códico", "Nome Estado" };
        bool[] colunaVisivel = { true, true, true };

        private bool bolIni;

        EstadoController estadoController = null;

        public object RefreshDataGrid { get; private set; }
        #endregion Váriaveis
        #region Construtor
        public WFEstadoView()
        {
            InitializeComponent();
            PadraoForm.SettingsForm(this);
            this.estadoController = new EstadoController();
        }

        #endregion Construtor
        #region Métodos
        public void TelaInicial(Boolean nolIni)
        {
            enuAcao = OPERACAO.StandBy;
            habilitarBotoes(true);
            habilitarBotoes(true);

            if (bolIni)
            {
                RefreshDataGridView(dgvEstado, true);
                EstilizarDataGridView.EstiloTituloColuna(dgvEstado, nomeColuna, colunaVisivel);
            }
        }

        private void RefreshDataGridView(DataGridView dtg, Boolean bolRefresh)
        {
            if (bolRefresh) { PreencherDataGridView(dtg); }
        }

        private void PreencherDataGridView(DataGridView dtg)
        {
            List<EstadoModel> listEstados = new List<EstadoModel>();
            //EstadoController estadocontroller = new EstadoController();

            try
            {
                dtg.DataSource = null;
                dtg.Rows.Clear();
                dtg.DataSource = this.estadoController.ObterTodosRegistro();
                TotalRegistrosDataGridView(dtg, LblTotalRegistros);
            }
            catch (Exception ex)
            {


            }
        }

        private void TotalRegistrosDataGridView(DataGridView dtg, Label lbl)
        {
            lbl.Text = "Total Registros" + (dtg.Rows.Count).ToString();

        }


        private void habilitarBotoes(Boolean bolHabil)
        {
            btnIncluir.Enabled = bolHabil;
            btnAlterar.Enabled = bolHabil;
            btnExcluir.Enabled = bolHabil;
        }

        private void HabilitarCampos(Boolean bolHabil)
        {
            TxtNomeEstado.ReadOnly = bolHabil;
            TxtUf.ReadOnly = bolHabil;
        }
        #endregion Métodos










        private void WFEstadoView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_de_estoqueDataSet.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.sistema_de_estoqueDataSet.estado);
            TelaInicial(true);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            enuAcao = OPERACAO.Incluir;
            habilitarBotoes(false);
            TxtNomeEstado.Focus();
            HabilitarCampos(true);
            LimparCampos();
        }

        

        private void LimparCampos()
        {
            LblNumCodico.Text = TxtNomeEstado.Text = txtPersquisa.Text = string.Empty;
        }

        private void TxtNomeEstado_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
            Diversos.ControlBackColorGor(sender);
        }

        private void TxtNomeEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Diversos.ControlBackColorLost(sender);
        }

        private void TxtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSalvar.Focus();
            }
        }

        private void TxtNomeEstado_Leave(object sender, EventArgs e)
        {
            
            Diversos.ControlBackColorLost(sender);
        }

        private void txtPesquisar_GotFocus(object sender, EventArgs e)
        {
            txtPersquisa.Text = string.Empty;
            Diversos.ControlBackColorGor(sender);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (dgvEstado.DataSource != null)
            {
                EstadoController estadocontrol = new EstadoController();
                estadocontrol.PesquisarEstados(dgvEstado, txtPersquisa.Text.Trim);
                TotalRegistrosNoDataGridView(dgvEstado, LblTotalRegistros);

            }
            else
            {
                MGMessageError.MensagemErro("Sem registro para pesquisar!", "2020202021-1", "x");
            }
        }

        private void TotalRegistrosNoDataGridView(DataGridView dtg, Label lbl)
        {
            lbl.Text = "Toatl de Registros " + (dtg.Rows.Count).ToString();
        }

        private void AtribuirValoresDaLinhaDataGridViiew(int index)
        {
            index = RecuperaLinhasSelecionadaDataGridView();
            LblNumCodico.Text = dgvEstado.Rows[index].Cells[0].Value.ToString();
            TxtNomeEstado.Text = dgvEstado.Rows[index].Cells[1].Value.ToString();
            TxtUf.Text = dgvEstado.Rows[index].Cells[2].Value.ToString();
        }
        private int RecuperaLinhasSelecionadaDataGridView()
        {
            DataGridViewRow linhaatual = dgvEstado.CurrentRow;
            int numerolinha = linhaatual.Index;
            return numerolinha;
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //int indice = RecuperaLinhasSelecionadaDataGridView();
            if (TxtNomeEstado.Text.Trim().Length >= 0)
            {
                enuAcao = OPERACAO.Alterar;
                HabilitarCampos(true);
                AtribuirValoresDaLinhaDataGridViiew();
                habilitarBotoes(false);
                TxtNomeEstado.Focus();
            }
            else
            {
                enuAcao = OPERACAO.StandBy;
                MGMessageError.MensagemErro("Selecione um Registro no Grid e Depois Pressione o Botão Alterar", "20200824-2", "a");
            }
        }

        private void AtribuirValoresDaLinhaDataGridViiew()
        {
            throw new NotImplementedException();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //int indice = RecuperaLinhasSelecionadaDataGridView();
            if (TxtNomeEstado.Text.Trim().Length >= 0)
            {
                AtribuirValoresDaLinhaDataGridViiew();
                habilitarBotoes(false);
                HabilitarCampos(false);

                if (MessageBox.Show("Deseja Excluir o Registro Selecionado?", "Confimação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    enuAcao = OPERACAO.Excluir;
                    btnExcluir_Click(sender, e);
                }
                else
                {
                    TelaInicial(false);
                }
            }
            else
            {
                MGMessageError.MensagemErro("Selecione um Registro no Grid e Depois Presione o Botão Excluir.", "2020071-3", "a");
                
            }

        }
        private Boolean Validar()
        {
            if (TxtNomeEstado.Text.Trim().Length == 0)
            {
                MGMessageError.MensagemErro("O Campo " + lblNomeEstado.Text + "é Obrigatório.", "2020020-2", "a");
                TxtNomeEstado.Focus();
                return false;

            }

            if (TxtUf.Text.Trim().Length == 0)
            {
                MGMessageError.MensagemErro("O campo" + lblUf.Text + "é Obrigatorio", "a");
            }
            return true;
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (enuAcao == OPERACAO.StandBy)
            {
                MGMessageError.MensagemErro("Primeiro Selecione a ação que deseja realizar pressionado um dos botões do menu,202020720-6,A");
               
            } return;

            if (!Validar())
            {
                return;
            }
            EstadoModel estadoModel = new EstadoModel();

            estadoModel.NomeEstado = TxtNomeEstado.Text.Trim();
            estadoModel.UF = TxtUf.Text.Trim();

            int retorno = 0;
            switch (enuAcao)
            {
                case OPERACAO.Incluir:
                    retorno = estadoController.incluirEstadoController(estadoModel);
                    break;

                case OPERACAO.Alterar:
                    estadoModel.idEstado = Convert.ToInt32(LblNumCodico.Text);
                    retorno = estadoModel.AlterarEstadoController(estadoModel);
                    break;

                case OPERACAO.Excluir:
                    estadoModel.idEstado = Convert.ToInt32(LblNumCodico.Text);
                    retorno = estadoModel.EstadoExcluirController(estadoModel.idEstado);
                    break;

            }
        }

        private void TxtNomeEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
            {
                AtribuirValoresDaLinhaDataGridViiew();
            }
        }
    }
}

