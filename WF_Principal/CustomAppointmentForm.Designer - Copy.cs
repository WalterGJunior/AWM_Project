namespace WF_Principal
{
    partial class CustomAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTreinamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtParticipantes = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticipantes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.Text = "&Descrição";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(17, 47);
            this.lblLocation.Size = new System.Drawing.Size(62, 13);
            this.lblLocation.Text = "&Participantes";
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(16, 70);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(16, 95);
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(217, 181);
            this.lblShowTimeAs.Visible = false;
            // 
            // chkAllDay
            // 
            this.chkAllDay.AllowDrop = true;
            this.chkAllDay.Location = new System.Drawing.Point(3, 37);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(19, 247);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 247);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 247);
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(283, 247);
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(96, 67);
            this.edtStartDate.Size = new System.Drawing.Size(130, 20);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(96, 92);
            this.edtEndDate.Size = new System.Drawing.Size(130, 20);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(234, 68);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(234, 92);
            // 
            // edtLabel
            // 
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(297, 178);
            this.edtShowTimeAs.Size = new System.Drawing.Size(226, 20);
            this.edtShowTimeAs.Visible = false;
            // 
            // tbSubject
            // 
            this.tbSubject.Size = new System.Drawing.Size(426, 20);
            // 
            // edtResource
            // 
            // 
            // edtResources
            // 
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            // 
            // chkReminder
            // 
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(13, 254);
            this.tbDescription.Size = new System.Drawing.Size(506, 0);
            this.tbDescription.Visible = false;
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(193, 121);
            this.tbLocation.Size = new System.Drawing.Size(226, 20);
            this.tbLocation.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(327, 44);
            this.panel1.Visible = false;
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(13, 218);
            this.progressPanel.Size = new System.Drawing.Size(506, 30);
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(51, 3);
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(397, 27);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(488, 10);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nome Treinamento:";
            // 
            // cmbTreinamento
            // 
            this.cmbTreinamento.DisplayMember = "nomeTreinamento";
            this.cmbTreinamento.FormattingEnabled = true;
            this.cmbTreinamento.Location = new System.Drawing.Point(13, 191);
            this.cmbTreinamento.Name = "cmbTreinamento";
            this.cmbTreinamento.Size = new System.Drawing.Size(430, 21);
            this.cmbTreinamento.TabIndex = 31;
            this.cmbTreinamento.ValueMember = "id_Treinamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome Empresa:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DisplayMember = "razaosocial";
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(13, 143);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(430, 21);
            this.cmbEmpresa.TabIndex = 29;
            this.cmbEmpresa.ValueMember = "cnpj";
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtParticipantes.Location = new System.Drawing.Point(96, 42);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtParticipantes.Size = new System.Drawing.Size(100, 20);
            this.txtParticipantes.TabIndex = 33;
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 282);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTreinamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.MinimumSize = new System.Drawing.Size(518, 306);
            this.Name = "CustomAppointmentForm";
            this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            this.Controls.SetChildIndex(this.edtEndTime, 0);
            this.Controls.SetChildIndex(this.edtEndDate, 0);
            this.Controls.SetChildIndex(this.btnRecurrence, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.tbLocation, 0);
            this.Controls.SetChildIndex(this.lblSubject, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.tbSubject, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.edtStartDate, 0);
            this.Controls.SetChildIndex(this.edtStartTime, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(this.cmbEmpresa, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbTreinamento, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtParticipantes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticipantes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTreinamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private DevExpress.XtraEditors.SpinEdit txtParticipantes;
    }
}
