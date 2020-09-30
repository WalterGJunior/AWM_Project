using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Persistência.Base;
using Persistência.Models;

namespace WF_Principal
{
    public partial class FrmCadAlunoTreinamento : FormBase
    {
        RepositorioAgendaTreinamentos repositorio;
        RepositorioAlunoTreinamento repositorioAlunos;
        RepositorioFuncionario repositorioFuncionario;
        BANCO_AWMContext _contexto = new BANCO_AWMContext();

        public FrmCadAlunoTreinamento()
        {
            InitializeComponent();
            repositorio = new RepositorioAgendaTreinamentos(_contexto);
            repositorioAlunos = new RepositorioAlunoTreinamento(_contexto);
            repositorioFuncionario = new RepositorioFuncionario(_contexto);
            this.Initialize();
        }

        private void Initialize()
        {
            cmbAgenda.Properties.DataSource = repositorio.RetornaDTOAgenda().ToList();
            bscFuncionario.DataSource = repositorioFuncionario.Tudo().ToList();
            bscFuncionario.ResetBindings(true);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmbAgenda_EditValueChanged(object sender, EventArgs e)
        {
            
            var valor = (int)cmbAgenda.EditValue;
            if (valor > 0)
            {
                bscAlunoTreinamento.DataSource = repositorioAlunos
                    .Tudo()
                    .Where(x => x.AgendaTreinamentoID == valor)
                    .ToList();
                bscAlunoTreinamento.ResetBindings(true);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bscAlunoTreinamento.Add(new tb_AlunoTreinamento((int)cmbAgenda.EditValue));
            bscAlunoTreinamento.ResetBindings(true);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var aluno = (tb_AlunoTreinamento)bscAlunoTreinamento.Current;
            if (aluno != null)
            {
                if (aluno.Id_AlunoTreinamento > 0)
                {
                    if (!repositorioAlunos.Edit(aluno))
                    {
                        this.ExibeErro();
                    }
                }
                else
                    if (!repositorioAlunos.Add(aluno))
                        this.ExibeErro();
            }
        }

        private void ExibeErro()
        {
            XtraMessageBox.Show("Aluno já cadastrado!");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var aluno = (tb_AlunoTreinamento)bscAlunoTreinamento.Current;
            if (aluno != null)
            {
                if (base.DesejaRealmenteExcluir())
                {
                    if (aluno.Id_AlunoTreinamento != 0)
                        repositorioAlunos.Remover(aluno);

                    bscAlunoTreinamento.RemoveCurrent();
                    bscAlunoTreinamento.ResetBindings(true);
                }
            }
        }
    }
}