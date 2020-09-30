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
using DevExpress.XtraBars.Alerter;
using DevExpress.Utils;

namespace WF_Principal
{
    public partial class FrmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.AbrirFormFundo();            
        }

        private void AbrirFormFundo()
        {

            this.xtraTabbedMdiManager1.PageAdded += NovaPaginaAdicionada;
            this.ShowForm(new FrmFundo());
        }

        private void NovaPaginaAdicionada(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (e.Page.Text == "Principal") 
                e.Page.ShowCloseButton = DefaultBoolean.False;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmCadEmpresa());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FormCadColaborador());
        }

        private void ShowForm(XtraForm form)
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                if (formFilho.GetType() == form.GetType())
                {
                    formFilho.Focus();
                    return;
                }
            }

            form.IsMdiContainer = false;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmCadPalestrante());
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmCadTreinamentos());
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmCadAlunoTreinamento());
        }

        private void btnAgenda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmAgenda());
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new FrmRelatorios());
        }


       
    }
}