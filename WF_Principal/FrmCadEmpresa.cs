using DevExpress.XtraEditors;
using Persistência.Base;
using Persistência.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WF_Principal.Util;

namespace WF_Principal
{
    public partial class FrmCadEmpresa : FormBase
    {
        RepositorioEmpresa _repositorioEmpresa;
        bool _modoEdicao;

        public FrmCadEmpresa()
        {
            InitializeComponent();
            _repositorioEmpresa = new RepositorioEmpresa(new BANCO_AWMContext());
            this.Initialize();
        }

        private void Initialize()
        {
            spinEditCEP.Properties.Buttons.Clear();
            spinEditCNPJ.Properties.Buttons.Clear();
        }


        private void CarregarGrid()
        {
            _modoEdicao = false;
            bscEmpresa.Add(new tb_Empresa());
            bscEmpresa.MoveLast();
            bscEmpresa.ResetBindings(true);
            this.EnableEditarExcluir(false);
        }

        private void EnableEditarExcluir(bool habilita)
        {
            btnSalvar.Enabled = !habilita;
            _modoEdicao = btnExcluir.Enabled = btnEditar.Enabled = habilita;
        }

        private void DesabilitarBotoes()
        {
            btnExcluir.Enabled = btnEditar.Enabled = btnSalvar.Enabled = false;
        }

        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {
            var empresa = _repositorioEmpresa.Tudo().ToList();

            if (empresa.Count == 0)
                this.DesabilitarBotoes();

            bscEmpresa.DataSource = empresa;
            bscEmpresa.ResetBindings(true);
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

        //Botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.CarregarGrid();  
        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dxValidacao.Validate())
            {
                var empresa = (tb_Empresa)bscEmpresa.Current;
                if (Validar(empresa))
                {
                    DelegateCRUD.ExecuteAdd(() =>
                    {
                        _repositorioEmpresa.Adicionar(empresa);
                        XtraMessageBox.Show(Mensagens.SalvoComSucesso);

                    });
                }
            }
            else
            {
                XtraMessageBox.Show("Houve erros de validação");
            }
        }


        //Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var empresa = (tb_Empresa)bscEmpresa.Current;
            if (Validar(empresa))
            {
                DelegateCRUD.ExecuteEditar(() =>
                {
                    _repositorioEmpresa.Editar((tb_Empresa)bscEmpresa.Current);
                    // Sim ou nao
                    XtraMessageBox.Show(Mensagens.AlteracaoComSucesso);
                }); 
            }
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (base.DesejaRealmenteExcluir())
                DelegateCRUD.ExecuteExcluir(() =>
                {
                    _repositorioEmpresa.Remover((tb_Empresa)bscEmpresa.Current);
                    // Sim ou nao
                    XtraMessageBox.Show(Mensagens.ExcluirComSucesso);

                }); 
        }

        private void gridEmpresas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bscEmpresa_CurrentItemChanged(object sender, EventArgs e)
        {
            var empresa = ((tb_Empresa)bscEmpresa.Current);

            if (empresa != null)
            {
                this.EnableEditarExcluir(!string.IsNullOrEmpty(empresa.cnpj));

                this.RemoverLinhaVazia();
            }           
        }

        private void RemoverLinhaVazia()
        {
            if (_modoEdicao)
            {
                var lista = new List<tb_Empresa>();
                foreach (var item in bscEmpresa.DataSource as List<tb_Empresa>)
                {
                    if (string.IsNullOrEmpty(item.cnpj))
                        lista.Add(item);
                }

                foreach (var item in lista)
                {
                    bscEmpresa.Remove(item);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
