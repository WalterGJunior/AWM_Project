namespace WF_Principal
{
    partial class FrmRelatorios
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnListaAlunos = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAgenda = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgenda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnListaAlunos);
            this.groupControl1.Controls.Add(this.cmbAgenda);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(787, 453);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Por Agenda";
            // 
            // btnListaAlunos
            // 
            this.btnListaAlunos.Location = new System.Drawing.Point(8, 50);
            this.btnListaAlunos.Name = "btnListaAlunos";
            this.btnListaAlunos.Size = new System.Drawing.Size(658, 23);
            this.btnListaAlunos.TabIndex = 8;
            this.btnListaAlunos.Text = "Lista de alunos";
            this.btnListaAlunos.Click += new System.EventHandler(this.btnListaAlunos_Click);
            // 
            // cmbAgenda
            // 
            this.cmbAgenda.Location = new System.Drawing.Point(55, 24);
            this.cmbAgenda.Name = "cmbAgenda";
            this.cmbAgenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAgenda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_AgendaTreinamentos", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Empresa", 60, "Empresa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Treinamento", 60, "Treinamento"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 40, "Descrição"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataInicio", "DataInicio", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataTermino", "DataTermino", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default)});
            this.cmbAgenda.Properties.DisplayMember = "Treinamento";
            this.cmbAgenda.Properties.NullText = "";
            this.cmbAgenda.Properties.ValueMember = "Id_AgendaTreinamentos";
            this.cmbAgenda.Size = new System.Drawing.Size(611, 20);
            this.cmbAgenda.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Agenda:";
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmRelatorios";
            this.Text = "Relatórios";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgenda.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnListaAlunos;
        private DevExpress.XtraEditors.LookUpEdit cmbAgenda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}