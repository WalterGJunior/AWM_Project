#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Persistência.Base;
using Persistência.Models;

namespace WF_Principal
{
    public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        RepositorioEmpresa _repositorioEmpresa;
        RepositorioTreinamentos _repositorioTreinamentos;

        public CustomAppointmentForm()
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }

        private void PreparaCombo()
        {

            _repositorioEmpresa = new RepositorioEmpresa(new BANCO_AWMContext());
            _repositorioTreinamentos = new RepositorioTreinamentos(new BANCO_AWMContext());
            cmbEmpresa.DataSource = _repositorioEmpresa.Tudo().ToList();
            cmbTreinamento.DataSource = _repositorioTreinamentos.Tudo().ToList();
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(Appointment appointment)
        {
            this.PreparaCombo();
            var treinamento = appointment.CustomFields["TreinamentosID"];
            var empresa = appointment.CustomFields["EmpresaID"];
            var participantes = appointment.CustomFields["Qtdeparticipantes"];

            if (treinamento != null)
                cmbTreinamento.SelectedValue = treinamento;

            if (empresa != null)
                cmbEmpresa.SelectedValue = empresa;

            if (participantes != null)
                txtParticipantes.EditValue = participantes;

            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(Appointment appointment)
        {
            appointment.CustomFields["TreinamentosID"] = cmbTreinamento.SelectedValue;
            appointment.CustomFields["EmpresaID"] = cmbEmpresa.SelectedValue;
            appointment.CustomFields["Qtdeparticipantes"] = txtParticipantes.EditValue;
            return base.SaveFormData(appointment);
        }
        
        
        private void lblResource_Click(object sender, EventArgs e)
        {
            //System.Drawing.KnownColor.Beige
        }
    }
}
