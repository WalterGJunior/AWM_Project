namespace WF_Principal
{
    partial class FrmCadAlunoTreinamento
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
            this.components = new System.ComponentModel.Container();
            this.cmbAgenda = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdAlunos = new DevExpress.XtraGrid.GridControl();
            this.bscAlunoTreinamento = new System.Windows.Forms.BindingSource(this.components);
            this.grdAlunosView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_Funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFuncionario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bscFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.colPresenca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotaAvaliacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscAlunoTreinamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunosView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAgenda
            // 
            this.cmbAgenda.Location = new System.Drawing.Point(59, 24);
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
            this.cmbAgenda.TabIndex = 4;
            this.cmbAgenda.EditValueChanged += new System.EventHandler(this.cmbAgenda_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Agenda:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // grdAlunos
            // 
            this.grdAlunos.DataSource = this.bscAlunoTreinamento;
            this.grdAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAlunos.Location = new System.Drawing.Point(2, 21);
            this.grdAlunos.MainView = this.grdAlunosView;
            this.grdAlunos.Name = "grdAlunos";
            this.grdAlunos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbFuncionario});
            this.grdAlunos.Size = new System.Drawing.Size(733, 270);
            this.grdAlunos.TabIndex = 6;
            this.grdAlunos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdAlunosView});
            // 
            // bscAlunoTreinamento
            // 
            this.bscAlunoTreinamento.DataSource = typeof(Persistência.Models.tb_AlunoTreinamento);
            // 
            // grdAlunosView
            // 
            this.grdAlunosView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_Funcionario,
            this.colPresenca,
            this.colNotaAvaliacao});
            this.grdAlunosView.GridControl = this.grdAlunos;
            this.grdAlunosView.Name = "grdAlunosView";
            // 
            // colId_Funcionario
            // 
            this.colId_Funcionario.Caption = "Funcionário";
            this.colId_Funcionario.ColumnEdit = this.cmbFuncionario;
            this.colId_Funcionario.FieldName = "colaboradorID";
            this.colId_Funcionario.Name = "colId_Funcionario";
            this.colId_Funcionario.Visible = true;
            this.colId_Funcionario.VisibleIndex = 0;
            this.colId_Funcionario.Width = 464;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.AutoHeight = false;
            this.cmbFuncionario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuncionario.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Colaborador", "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "nome")});
            this.cmbFuncionario.DataSource = this.bscFuncionario;
            this.cmbFuncionario.DisplayMember = "nome";
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.ValueMember = "Id_Colaborador";
            // 
            // bscFuncionario
            // 
            this.bscFuncionario.DataSource = typeof(Persistência.Models.tb_Colaborador);
            // 
            // colPresenca
            // 
            this.colPresenca.FieldName = "Presenca";
            this.colPresenca.Name = "colPresenca";
            this.colPresenca.Visible = true;
            this.colPresenca.VisibleIndex = 1;
            this.colPresenca.Width = 92;
            // 
            // colNotaAvaliacao
            // 
            this.colNotaAvaliacao.FieldName = "NotaAvaliacao";
            this.colNotaAvaliacao.Name = "colNotaAvaliacao";
            this.colNotaAvaliacao.Visible = true;
            this.colNotaAvaliacao.VisibleIndex = 2;
            this.colNotaAvaliacao.Width = 133;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbAgenda);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(737, 52);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Agenda";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.grdAlunos);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 52);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(737, 293);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Alunos";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRemover);
            this.panelControl1.Controls.Add(this.btnConfirmar);
            this.panelControl1.Controls.Add(this.btnAdicionar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(733, 31);
            this.panelControl1.TabIndex = 7;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(235, 5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(115, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(5, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 22);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FrmCadAlunoTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 345);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCadAlunoTreinamento";
            this.Text = "Lista de Presença";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAgenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscAlunoTreinamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunosView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbAgenda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdAlunos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdAlunosView;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bscAlunoTreinamento;
        private DevExpress.XtraGrid.Columns.GridColumn colPresenca;
        private DevExpress.XtraGrid.Columns.GridColumn colNotaAvaliacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbFuncionario;
        private System.Windows.Forms.BindingSource bscFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Funcionario;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
    }
}