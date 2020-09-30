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
    public partial class FrmFundo : DevExpress.XtraEditors.XtraForm
    {
        RepositorioAgendaTreinamentos repositorio;
        public FrmFundo()
        {
            InitializeComponent();
            controleAlertas.Show(this, "# WELCOME #", " # Bem Vindo #");
            this.repositorio = new RepositorioAgendaTreinamentos(new BANCO_AWMContext());
            this.GerarAlertas();
        }

        private void GerarAlertas()
        {
            var dataAtual = DateTime.Now;
            var dataAtualMaisUmaSemana = dataAtual.AddDays(7);
            //.Where(x => x.dtInicio >= dataAtual && x.dtTermino <= dataAtualMaisUmaSemana)
            foreach (var item in repositorio.Tudo().ToList())
            {
                this.AdicionarAlerta(
                    item.dtInicio.ToShortDateString() + " - " +
                    item.dtInicio.ToShortTimeString() +
                    "\n" +
                    item.dtTermino.ToShortDateString() + " - " +
                    item.dtTermino.ToShortTimeString(),
                    item.descricao);
            }
        }

        private void AdicionarAlerta(string titulo, string descricao)
        {
            //AlertInfo info = new AlertInfo(titulo, descricao);
            controleAlertas.Show(this, titulo, descricao);
        }
    }
}