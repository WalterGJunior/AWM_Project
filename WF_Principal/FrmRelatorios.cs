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
using Persistência.Models;
using Persistência.Base;
using WF_Principal.Relatorios;
using FastReport;

namespace WF_Principal
{
    public partial class FrmRelatorios : FormBase
    {
        RepositorioAgendaTreinamentos repositorio;
        BANCO_AWMContext _contexto = new BANCO_AWMContext();

        public FrmRelatorios()
        {
            InitializeComponent();
            repositorio = new RepositorioAgendaTreinamentos(_contexto);
            this.Initialize();
        }

        private void Initialize()
        {
            cmbAgenda.Properties.DataSource = repositorio.RetornaDTOAgenda().ToList();
        }

        private void btnListaAlunos_Click(object sender, EventArgs e)
        {
            var agenda = (int)cmbAgenda.EditValue;

            if (agenda > 0)
            {
                Report relatorio = new Report();

                // Registrar fonte de dados
                relatorio.Load("Relatorios/alunos.frx");//hehe
                relatorio.RegisterData(this.GetCabecalho("Lista de alunos", string.Empty), "Cabecalho");
                relatorio.RegisterData(
                    repositorio.ObtemPorId(agenda)
                    .tb_AlunoTreinamento.Select(x => new Aluno
                    {
                        Nome = x.tb_Colaborador.nome,
                        CPFCNPJ = x.tb_Colaborador.cpf
                    }), "ListaDados");

                // Uma fonte de dados com Nome/CPFCNPJ
                relatorio.Show();
                relatorio.Dispose();
            }
            else
                XtraMessageBox.Show("Selecione uma agenda");

        }
        
        private IEnumerable<Cabecalho> GetCabecalho(string titulo, string subtitulo) 
        {
            yield return new Cabecalho { Titulo = titulo, Subtitutlo = subtitulo };
        }
    }
}