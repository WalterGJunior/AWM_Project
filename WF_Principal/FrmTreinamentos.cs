using DevExpress.XtraEditors;
using Persistência.Base;
using Persistência.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WF_Principal.Util;

namespace WF_Principal
{
    public partial class FrmEmpresas : Form
    {
        RepositorioEmpresa _repositorioEmpresa;

        public FrmEmpresas()
        {
            InitializeComponent();
            _repositorioEmpresa = new RepositorioEmpresa(new BANCO_AWMContext());
            this.Limpar();
        }

        private void Limpar()
        {
            txtCNPJ.Clear();
            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtEndereco.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtIncMunicipal.Clear();
            txtInscEstadual.Clear();
        }

        private void CarregarGrid()
        {
            bscEmpresa.ResetBindings(true);
            bscEmpresa.DataSource = new List<tb_Empresa>();
            bscEmpresa.Add(new tb_Empresa());
            bscEmpresa.MoveFirst();
            this.EnableEditarExcluir(false);
        }

        private void EnableEditarExcluir(bool habilita)
        {
            btnExcluir.Enabled = btnEditar.Enabled = habilita;
        }

        private bool Validar(tb_Empresa empresa)
        {
            var msg = _repositorioEmpresa.Validar(empresa);

            if (string.IsNullOrWhiteSpace(msg))
                return true;
            else
                XtraMessageBox.Show(msg);

            return false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var empresa = (tb_Empresa)bscEmpresa.Current;
            if (Validar(empresa))
            {
                _repositorioEmpresa.Adicionar(empresa);
                XtraMessageBox.Show(Mensagens.SalvoComSucesso);
                this.Limpar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var empresa = (tb_Empresa)bscEmpresa.Current;
            if (Validar(empresa))
            {
                _repositorioEmpresa.Editar((tb_Empresa)bscEmpresa.Current);
                // Sim ou nao
                XtraMessageBox.Show(Mensagens.AlteracaoComSucesso);
                this.Limpar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _repositorioEmpresa.Remover((tb_Empresa)bscEmpresa.Current);
            // Sim ou nao
            XtraMessageBox.Show(Mensagens.ExcluirComSucesso);
            this.Limpar();
        }
    }
}
