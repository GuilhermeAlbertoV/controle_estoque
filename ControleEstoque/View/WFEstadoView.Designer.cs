
using System;

namespace ControleEstoque.View
{
    partial class WFEstadoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPersquisa = new System.Windows.Forms.TextBox();
            this.TxtUf = new System.Windows.Forms.TextBox();
            this.TxtNomeEstado = new System.Windows.Forms.TextBox();
            this.LblNumCodico = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblNomeEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalRegistros = new System.Windows.Forms.Label();
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.sistema_de_estoqueDataSet = new ControleEstoque.sistema_de_estoqueDataSet();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new ControleEstoque.sistema_de_estoqueDataSetTableAdapters.estadoTableAdapter();
            this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Location = new System.Drawing.Point(23, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(510, -1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 43);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(375, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(242, -3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 43);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(122, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 40);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(0, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(87, 40);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtPersquisa);
            this.panel2.Controls.Add(this.TxtUf);
            this.panel2.Controls.Add(this.TxtNomeEstado);
            this.panel2.Controls.Add(this.LblNumCodico);
            this.panel2.Controls.Add(this.lblPesquisa);
            this.panel2.Controls.Add(this.lblUf);
            this.panel2.Controls.Add(this.lblNomeEstado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 262);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(13, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 1);
            this.panel3.TabIndex = 2;
            // 
            // txtPersquisa
            // 
            this.txtPersquisa.Location = new System.Drawing.Point(93, 187);
            this.txtPersquisa.Name = "txtPersquisa";
            this.txtPersquisa.Size = new System.Drawing.Size(220, 20);
            this.txtPersquisa.TabIndex = 1;
            // 
            // TxtUf
            // 
            this.TxtUf.Location = new System.Drawing.Point(93, 81);
            this.TxtUf.Name = "TxtUf";
            this.TxtUf.Size = new System.Drawing.Size(61, 20);
            this.TxtUf.TabIndex = 1;
            this.TxtUf.Enter += new System.EventHandler(this.TxtNomeEstado_Enter);
            this.TxtUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUf_KeyPress);
            this.TxtUf.Leave += new System.EventHandler(this.TxtNomeEstado_Leave);
            // 
            // TxtNomeEstado
            // 
            this.TxtNomeEstado.Location = new System.Drawing.Point(93, 55);
            this.TxtNomeEstado.Name = "TxtNomeEstado";
            this.TxtNomeEstado.Size = new System.Drawing.Size(220, 20);
            this.TxtNomeEstado.TabIndex = 1;
            this.TxtNomeEstado.TextChanged += new System.EventHandler(this.TxtNomeEstado_TextChanged);
            this.TxtNomeEstado.Enter += new System.EventHandler(this.TxtNomeEstado_Enter);
            this.TxtNomeEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeEstado_KeyPress);
            this.TxtNomeEstado.Leave += new System.EventHandler(this.TxtNomeEstado_Leave);
            // 
            // LblNumCodico
            // 
            this.LblNumCodico.AutoSize = true;
            this.LblNumCodico.Location = new System.Drawing.Point(90, 35);
            this.LblNumCodico.Name = "LblNumCodico";
            this.LblNumCodico.Size = new System.Drawing.Size(76, 13);
            this.LblNumCodico.TabIndex = 0;
            this.LblNumCodico.Text = "LblNumCódico";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(10, 194);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisa :";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(10, 88);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 0;
            this.lblUf.Text = "UF :";
            // 
            // lblNomeEstado
            // 
            this.lblNomeEstado.AutoSize = true;
            this.lblNomeEstado.Location = new System.Drawing.Point(10, 62);
            this.lblNomeEstado.Name = "lblNomeEstado";
            this.lblNomeEstado.Size = new System.Drawing.Size(77, 13);
            this.lblNomeEstado.TabIndex = 0;
            this.lblNomeEstado.Text = "Nome Estado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Códico :";
            // 
            // LblTotalRegistros
            // 
            this.LblTotalRegistros.AutoSize = true;
            this.LblTotalRegistros.Location = new System.Drawing.Point(371, 364);
            this.LblTotalRegistros.Name = "LblTotalRegistros";
            this.LblTotalRegistros.Size = new System.Drawing.Size(93, 13);
            this.LblTotalRegistros.TabIndex = 0;
            this.LblTotalRegistros.Text = "Total de Registros";
            // 
            // dgvEstado
            // 
            this.dgvEstado.AllowUserToAddRows = false;
            this.dgvEstado.AllowUserToDeleteRows = false;
            this.dgvEstado.AutoGenerateColumns = false;
            this.dgvEstado.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstadoDataGridViewTextBoxColumn,
            this.nomeEstadoDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn});
            this.dgvEstado.DataSource = this.estadoBindingSource;
            this.dgvEstado.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEstado.Location = new System.Drawing.Point(358, 115);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Size = new System.Drawing.Size(427, 234);
            this.dgvEstado.TabIndex = 2;
            this.dgvEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvEstado_KeyUp);
            // 
            // ttp
            // 
            this.ttp.BackColor = System.Drawing.Color.LemonChiffon;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(358, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Incluir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // sistema_de_estoqueDataSet
            // 
            this.sistema_de_estoqueDataSet.DataSetName = "sistema_de_estoqueDataSet";
            this.sistema_de_estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.sistema_de_estoqueDataSet;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.HeaderText = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            this.idEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeEstadoDataGridViewTextBoxColumn
            // 
            this.nomeEstadoDataGridViewTextBoxColumn.DataPropertyName = "NomeEstado";
            this.nomeEstadoDataGridViewTextBoxColumn.HeaderText = "NomeEstado";
            this.nomeEstadoDataGridViewTextBoxColumn.Name = "nomeEstadoDataGridViewTextBoxColumn";
            this.nomeEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WFEstadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 544);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTotalRegistros);
            this.Controls.Add(this.button1);
            this.Name = "WFEstadoView";
            this.Text = "Cadastro De Estado";
            this.Load += new System.EventHandler(this.WFEstadoView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPersquisa;
        private System.Windows.Forms.TextBox TxtUf;
        private System.Windows.Forms.TextBox TxtNomeEstado;
        private System.Windows.Forms.Label LblNumCodico;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblNomeEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalRegistros;
        private System.Windows.Forms.DataGridView dgvEstado;
        private System.Windows.Forms.ToolTip ttp;
        private EventHandler txtPersquisa_GotFocus;
        private System.Windows.Forms.Button button1;
        private sistema_de_estoqueDataSet sistema_de_estoqueDataSet;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private sistema_de_estoqueDataSetTableAdapters.estadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
    }
}