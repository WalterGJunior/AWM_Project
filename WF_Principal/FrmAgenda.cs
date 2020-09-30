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
using DevExpress.XtraScheduler;
using WF_Principal.Util;

namespace WF_Principal
{
    public partial class FrmAgenda : DevExpress.XtraEditors.XtraForm
    {
        Timer timer;
        public FrmAgenda()
        {
            InitializeComponent();
            this.schedulerStorage1.AppointmentChanging += OnMudanca;
            this.schedulerStorage1.AppointmentDeleting += OnMudanca;
            this.schedulerStorage1.AppointmentInserting += OnMudanca;
        }

        private void InicializaTimer()
        {
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 2000;
            timer.Enabled = true;
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            OnMudanca(null, null);
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCO_AWMCategoria.tb_Categoria' table. You can move, or remove it, as needed.
            this.tb_CategoriaTableAdapter.Fill(this.bANCO_AWMCategoria.tb_Categoria);
            // TODO: This line of code loads data into the 'bANCO_AWMAgenda.tb_AgendaTreinamentos' table. You can move, or remove it, as needed.
            this.tb_AgendaTreinamentosTableAdapter.Fill(this.bANCO_AWMAgenda.tb_AgendaTreinamentos);

        }

        private void OnMudanca(object sender, PersistentObjectCancelEventArgs e)
        {
            try
            {
                tb_AgendaTreinamentosTableAdapter.Update(bANCO_AWMAgenda);
                bANCO_AWMAgenda.AcceptChanges();
            }
            catch(Exception)
            {
                XtraMessageBox.Show("Não é possível excluir este registro, existem alunos cadastrados neste treinamento!");
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            WF_Principal.CustomAppointmentForm form = new WF_Principal.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            var resultado = XtraMessageBox.Show(Mensagens.DesejaRealmenteExcluir, "Alerta", MessageBoxButtons.YesNo);
            if (resultado.ToString() == "No")
                e.Cancel = true;
        }
    }
}