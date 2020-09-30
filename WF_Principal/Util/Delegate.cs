using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Principal.Util
{
    public class DelegateCRUD
    {
        public static void ExecuteExcluir(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Mensagens.ErroAoExcluir);
            }
        }

        public static void ExecuteEditar(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Mensagens.ErroAoAlterar);
            }
        }

        public static void ExecuteAdd(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (DbEntityValidationException e)
            {
                var x = e.EntityValidationErrors;
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Mensagens.ErroAoAdicionar);
            }
        }
    }
}
