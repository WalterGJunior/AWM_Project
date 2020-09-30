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
    public partial class FormCadColaborador : WF_Principal.FormBase
    {
        RepositorioFuncionario _repositorioFuncionario;
        RepositorioEmpresa _repositorioEmpresa;
        bool _modoEdicao;

        public FormCadColaborador()
        {
            InitializeComponent();
            _repositorioFuncionario = new RepositorioFuncionario(new BANCO_AWMContext());
            _repositorioEmpresa = new RepositorioEmpresa(new BANCO_AWMContext());
            this.Initialize();
            //this.AdicionaRegrasDeValidacao();
        }

       
        private void Initialize()
        {
            SpindEditMatricula.Properties.Buttons.Clear();
        }

        private void CarregarGrid()
        {
            _modoEdicao = false;
            bscFuncionario.Add(new tb_Colaborador());
            bscFuncionario.MoveLast();
            bscFuncionario.ResetBindings(true);
            this.EnableEditarExcluir(false);
        }

        private void EnableEditarExcluir(bool habilita)
        {
            btnSalvar.Enabled = !habilita;
            _modoEdicao = btnExcluir.Enabled = btnEditar.Enabled = habilita;
        }

        private void FormCadFuncionarios_Load(object sender, EventArgs e)
        {
            this.PreparaCombo();
            bscFuncionario.DataSource = _repositorioFuncionario.Tudo().ToList();
            bscFuncionario.ResetBindings(true);
        }

        private bool Validar(tb_Colaborador funcionario)
        {
            var msg = _repositorioFuncionario.Validar(funcionario);

            if (string.IsNullOrWhiteSpace(msg))
                return true;
            else
                XtraMessageBox.Show(msg);   
        
            return false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dxValidacao.Validate())
            {
                var funcionario = (tb_Colaborador)bscFuncionario.Current;
                if (Validar(funcionario))
                {
                    DelegateCRUD.ExecuteAdd(() =>
                    {
                        _repositorioFuncionario.Adicionar(funcionario);
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
            var funcionario = (tb_Colaborador)bscFuncionario.Current;
            if (Validar(funcionario))
            {
                DelegateCRUD.ExecuteEditar(() =>
                {
                    _repositorioFuncionario.Editar((tb_Colaborador)bscFuncionario.Current);
                    XtraMessageBox.Show(Mensagens.AlteracaoComSucesso);
                });               

            }
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (base.DesejaRealmenteExcluir())
                DelegateCRUD.ExecuteExcluir(() => {
                    _repositorioFuncionario.Remover((tb_Colaborador)bscFuncionario.Current);
                    XtraMessageBox.Show(Mensagens.ExcluirComSucesso);
                });
        }


        private void bscFuncionario_CurrentChanged(object sender, EventArgs e)
        {
            var funcionario = ((tb_Colaborador)bscFuncionario.Current);

            if (funcionario != null)
            {
                this.EnableEditarExcluir(!string.IsNullOrEmpty(funcionario.cpf));

                this.RemoverLinhaVazia();
            }
        }

        private void RemoverLinhaVazia()
        {
            if (_modoEdicao)
            {
                var lista = new List<tb_Colaborador>();
                foreach (var item in bscFuncionario.DataSource as List<tb_Colaborador>)
                {
                    if (string.IsNullOrEmpty(item.cpf))
                        lista.Add(item);
                }

                foreach (var item in lista)
                {
                    bscFuncionario.Remove(item);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void PreparaCombo()
        {
            _repositorioEmpresa = new RepositorioEmpresa(new BANCO_AWMContext());
            cmbEmpresa.DataSource = _repositorioEmpresa.Tudo().ToList();
            
        }
   
    }
}
