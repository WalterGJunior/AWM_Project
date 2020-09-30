using Persistência;
using Persistência.Base;
using Persistência.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Principal.Util;
using DevExpress.XtraEditors;

namespace WF_Principal
{
    public partial class FrmCadPalestrante : FormBase
    {
        RepositorioTreinador _repositoriotreinador;
        bool _modoEdicao;

        public FrmCadPalestrante()
        {
            InitializeComponent();
            _repositoriotreinador = new RepositorioTreinador(new BANCO_AWMContext());
            this.Initialize();
        }

        private void Initialize()
        {
            SpindEditMatriculaTreinador.Properties.Buttons.Clear();
            spinEditIdade.Properties.Buttons.Clear();
            //spinEditTelefoneFixo.Properties.Buttons.Clear();
            //textEdit1.Properties.Buttons.Clear();

        }

        private void CarregarGrid()
        {
            _modoEdicao = false;
            bscTreinador.Add(new tb_Palestrante());
            bscTreinador.MoveLast();
            bscTreinador.ResetBindings(true);
            this.EnableEditarExcluir(false);
        }

        private void EnableEditarExcluir(bool habilita)
        {
            btnSalvar.Enabled = !habilita;
            _modoEdicao = btnExcluir.Enabled = btnEditar.Enabled = habilita;
        }

        private void FrmCadTreinador_Load(object sender, EventArgs e)
        {
            bscTreinador.DataSource = _repositoriotreinador.Tudo().ToList();
            bscTreinador.ResetBindings(true);
        }


        private bool Validar(tb_Palestrante treinador)
        {
            var msg = _repositoriotreinador.Validar(treinador);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dxValidacao.Validate())
            {
                var treinador = (tb_Palestrante)bscTreinador.Current;
                if (Validar(treinador))
                {
                    DelegateCRUD.ExecuteAdd(() =>
                    {
                        _repositoriotreinador.Adicionar(treinador);
                        XtraMessageBox.Show(Mensagens.SalvoComSucesso);
                    });
                }
            }
            else
            {
                XtraMessageBox.Show("Houve erros de validação");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var treinador = (tb_Palestrante)bscTreinador.Current;
            if (Validar(treinador))
            {
                DelegateCRUD.ExecuteEditar(() =>
                {
                    _repositoriotreinador.Editar((tb_Palestrante)bscTreinador.Current);
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
                    _repositoriotreinador.Remover((tb_Palestrante)bscTreinador.Current);
                    MessageBox.Show(Mensagens.ExcluirComSucesso);
                });
        }

        private void RemoverLinhaVazia()
        {
            if (_modoEdicao)
            {
                var lista = new List<tb_Palestrante>();
                foreach (var item in bscTreinador.DataSource as List<tb_Palestrante>)
                {
                    if (string.IsNullOrEmpty(item.nome))
                        lista.Add(item);
                }

                foreach (var item in lista)
                {
                    bscTreinador.Remove(item);
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void bscTreinador_CurrentChanged(object sender, EventArgs e)
        {
            var treinador = ((tb_Palestrante)bscTreinador.Current);

            if (treinador != null)
            {
                this.EnableEditarExcluir(!string.IsNullOrEmpty(treinador.nome));

                this.RemoverLinhaVazia();
            }
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataNascimento.EditValue.GetType() != typeof(DateTime))
                return;

            var data = (DateTime)dtpDataNascimento.EditValue;
            var dataAtual = DateTime.Now;

            if (data != null)
            {
                int diferencaAnos = dataAtual.Year - data.Year;

                if (data.Month > dataAtual.Month)
                    diferencaAnos -= 1;
                else if (data.Month == dataAtual.Month)
                {
                    if (data.Day > dataAtual.Day)
                        diferencaAnos -= 1;
                }
                var treinador = (tb_Palestrante)bscTreinador.Current;

                if (treinador != null)
                    treinador.idade = diferencaAnos;

                spinEditIdade.EditValue = diferencaAnos;
            }
        }

    }

}

