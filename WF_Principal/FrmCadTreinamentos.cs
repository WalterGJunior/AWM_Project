using DevExpress.XtraEditors;
using Persistência.Base;
using Persistência.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WF_Principal.Util;
using System.Data;


namespace WF_Principal
{
    public partial class FrmCadTreinamentos : FormBase
    {
        RepositorioTreinamentos _repositorioTreinamentos;
        RepositorioTreinador _repositorioTreinador;
        bool _modoEdicao;

        public FrmCadTreinamentos()
        {
            InitializeComponent();
            _repositorioTreinamentos = new RepositorioTreinamentos(new BANCO_AWMContext());
            _repositorioTreinador = new RepositorioTreinador(new BANCO_AWMContext());
            this.Initialize();
        }

        private void Initialize()
        {
            spinEditCodTreinamentos.Properties.Buttons.Clear();
        }


        private void CarregarGrid()
        {
            _modoEdicao = false;
            bscTreinamentos.Add(new tb_Treinamentos());
            bscTreinamentos.MoveLast();
            bscTreinamentos.ResetBindings(true);
            this.EnableEditarExcluir(false);
        }

        

        private void EnableEditarExcluir(bool habilita)
        {
            btnSalvar.Enabled = !habilita;
            _modoEdicao = btnExcluir.Enabled = btnEditar.Enabled = habilita;
        }

        private void FrmCadTreinamentos_Load(object sender, EventArgs e)
        {
            this.PreparaCombo();
            bscTreinamentos.DataSource = _repositorioTreinamentos.Tudo().ToList();
            bscTreinamentos.ResetBindings(true);

        }

        private bool Validar(tb_Treinamentos treinamentos)
        {
            var msg = _repositorioTreinamentos.Validar(treinamentos);

            if (string.IsNullOrWhiteSpace(msg))
                return true;
            else
                MessageBox.Show(msg);
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
                var treinamentos = (tb_Treinamentos)bscTreinamentos.Current;
                if (Validar(treinamentos))
                {
                    DelegateCRUD.ExecuteAdd(() =>
                    {
                        _repositorioTreinamentos.Adicionar(treinamentos);
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
            var treinamentos = (tb_Treinamentos)bscTreinamentos.Current;
            if (Validar(treinamentos))
            {
                DelegateCRUD.ExecuteEditar(() =>
                {
                    _repositorioTreinamentos.Editar((tb_Treinamentos)bscTreinamentos.Current);
                    XtraMessageBox.Show(Mensagens.AlteracaoComSucesso);
                }); 
            }
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (base.DesejaRealmenteExcluir())
                DelegateCRUD.ExecuteExcluir(() => {
                    _repositorioTreinamentos.Remover((tb_Treinamentos)bscTreinamentos.Current);
                    XtraMessageBox.Show(Mensagens.ExcluirComSucesso);
                });
        }

        private void bscTreinamentos_CurrentChanged(object sender, EventArgs e)
        {
            var treinamentos = ((tb_Treinamentos)bscTreinamentos.Current);

            if (treinamentos != null)
            {
                this.EnableEditarExcluir(treinamentos.Id_Treinamentos != 0);
                this.RemoverLinhaVazia();
            }
        }

        private void RemoverLinhaVazia()
        {
            if (_modoEdicao)
            {
                var lista = new List<tb_Treinamentos>();
                foreach (var item in bscTreinamentos.DataSource as List<tb_Treinamentos>)
                {
                    
                   if (item.Id_Treinamentos == 0)
                        lista.Add(item);
                }

                foreach (var item in lista)
                {
                    bscTreinamentos.Remove(item);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedTabPageIndex = 1;
        }

        private void PreparaCombo()
        {
            _repositorioTreinador = new RepositorioTreinador(new BANCO_AWMContext());
            cmbTreinador.DataSource = _repositorioTreinador.Tudo().ToList();
        }

        }
    }

