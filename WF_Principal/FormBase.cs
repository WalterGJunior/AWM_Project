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
using WF_Principal.Util;

namespace WF_Principal
{
    public partial class FormBase : XtraForm
    {
        public FormBase()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        //public virtual void EnableEditarExcluir(bool habilita)
        //{
        //    btnSave.Enabled = !habilita;
        //    btnDelete.Enabled = btnUpdate.Enabled = habilita;
        //}

        public bool DesejaRealmenteExcluir()
        {
            var resultado = XtraMessageBox.Show(Mensagens.DesejaRealmenteExcluir, "Alerta", MessageBoxButtons.YesNo);
            return resultado.ToString() == "Yes";
        }
    }
}