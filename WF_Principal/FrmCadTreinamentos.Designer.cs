using Persistência.Models;
namespace WF_Principal
{
    partial class FrmCadTreinamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTreinamentos));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label2 = new System.Windows.Forms.Label();
            this.bscTreinamentos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTreinador = new System.Windows.Forms.ComboBox();
            this.TxtNomeTreinamento = new DevExpress.XtraEditors.TextEdit();
            this.memoEditDescTreinamento = new DevExpress.XtraEditors.MemoEdit();
            this.spinEditCodTreinamentos = new DevExpress.XtraEditors.SpinEdit();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodTreinamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomeTreinamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricaoTreinamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dxValidacao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bscTreinamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomeTreinamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescTreinamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCodTreinamentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código Treinamento:";
            // 
            // bscTreinamentos
            // 
            this.bscTreinamentos.DataSource = typeof(Persistência.Models.tb_Treinamentos);
            this.bscTreinamentos.CurrentChanged += new System.EventHandler(this.bscTreinamentos_CurrentChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nome do Treinador:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome do Treinamento:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Descrição do Treinamento:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(357, 281);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(508, 281);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(214, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 40);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTreinador);
            this.groupBox1.Controls.Add(this.TxtNomeTreinamento);
            this.groupBox1.Controls.Add(this.memoEditDescTreinamento);
            this.groupBox1.Controls.Add(this.spinEditCodTreinamentos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 257);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Treinamentos";
            // 
            // cmbTreinador
            // 
            this.cmbTreinador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bscTreinamentos, "PalestranteID", true));
            this.cmbTreinador.DisplayMember = "nome";
            this.cmbTreinador.FormattingEnabled = true;
            this.cmbTreinador.Location = new System.Drawing.Point(168, 49);
            this.cmbTreinador.Name = "cmbTreinador";
            this.cmbTreinador.Size = new System.Drawing.Size(339, 21);
            this.cmbTreinador.TabIndex = 39;
            this.cmbTreinador.ValueMember = "Id_Palestrante";
            // 
            // TxtNomeTreinamento
            // 
            this.TxtNomeTreinamento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinamentos, "nomeTreinamento", true));
            this.TxtNomeTreinamento.Location = new System.Drawing.Point(39, 90);
            this.TxtNomeTreinamento.Name = "TxtNomeTreinamento";
            this.TxtNomeTreinamento.Size = new System.Drawing.Size(468, 20);
            this.TxtNomeTreinamento.TabIndex = 40;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nome do Treinamento não Informado!";
            this.dxValidacao.SetValidationRule(this.TxtNomeTreinamento, conditionValidationRule1);
            // 
            // memoEditDescTreinamento
            // 
            this.memoEditDescTreinamento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinamentos, "descricaoTreinamento", true));
            this.memoEditDescTreinamento.Location = new System.Drawing.Point(40, 133);
            this.memoEditDescTreinamento.Name = "memoEditDescTreinamento";
            this.memoEditDescTreinamento.Size = new System.Drawing.Size(467, 96);
            this.memoEditDescTreinamento.TabIndex = 41;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Descrição do Treinamento deve ser informada!";
            this.dxValidacao.SetValidationRule(this.memoEditDescTreinamento, conditionValidationRule2);
            // 
            // spinEditCodTreinamentos
            // 
            this.spinEditCodTreinamentos.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinamentos, "CodTreinamento", true));
            this.spinEditCodTreinamentos.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCodTreinamentos.Location = new System.Drawing.Point(39, 48);
            this.spinEditCodTreinamentos.Name = "spinEditCodTreinamentos";
            this.spinEditCodTreinamentos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCodTreinamentos.Properties.IsFloatValue = false;
            this.spinEditCodTreinamentos.Properties.Mask.EditMask = "N00";
            this.spinEditCodTreinamentos.Size = new System.Drawing.Size(100, 20);
            this.spinEditCodTreinamentos.TabIndex = 38;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Código do Treinamento não informado!";
            this.dxValidacao.SetValidationRule(this.spinEditCodTreinamentos, conditionValidationRule3);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(63, 281);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(111, 40);
            this.btnNovo.TabIndex = 42;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabPage = this.xtraTabPage2;
            this.tabControl1.Size = new System.Drawing.Size(772, 368);
            this.tabControl1.TabIndex = 47;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(766, 340);
            this.xtraTabPage2.Text = "Todos os Treinamentos";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bscTreinamentos;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 340);
            this.gridControl1.TabIndex = 48;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodTreinamento,
            this.colnomeTreinamento,
            this.coldescricaoTreinamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colCodTreinamento
            // 
            this.colCodTreinamento.FieldName = "CodTreinamento";
            this.colCodTreinamento.Name = "colCodTreinamento";
            this.colCodTreinamento.Visible = true;
            this.colCodTreinamento.VisibleIndex = 0;
            // 
            // colnomeTreinamento
            // 
            this.colnomeTreinamento.FieldName = "nomeTreinamento";
            this.colnomeTreinamento.Name = "colnomeTreinamento";
            this.colnomeTreinamento.Visible = true;
            this.colnomeTreinamento.VisibleIndex = 1;
            // 
            // coldescricaoTreinamento
            // 
            this.coldescricaoTreinamento.FieldName = "descricaoTreinamento";
            this.coldescricaoTreinamento.Name = "coldescricaoTreinamento";
            this.coldescricaoTreinamento.Visible = true;
            this.coldescricaoTreinamento.VisibleIndex = 2;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnNovo);
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Controls.Add(this.btnExcluir);
            this.xtraTabPage1.Controls.Add(this.btnEditar);
            this.xtraTabPage1.Controls.Add(this.btnSalvar);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(766, 340);
            this.xtraTabPage1.Text = "Treinamentos";
            // 
            // FrmCadTreinamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCadTreinamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Treinamentos";
            this.Load += new System.EventHandler(this.FrmCadTreinamentos_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bscTreinamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomeTreinamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescTreinamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCodTreinamentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.BindingSource bscTreinamentos;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descricaoTreinamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNovo;
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidacao;
        private DevExpress.XtraEditors.SpinEdit spinEditCodTreinamentos;
        private DevExpress.XtraEditors.MemoEdit memoEditDescTreinamento;
        private DevExpress.XtraEditors.TextEdit TxtNomeTreinamento;
        private System.Windows.Forms.ComboBox cmbTreinador;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTreinamento;
        private DevExpress.XtraGrid.Columns.GridColumn colnomeTreinamento;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricaoTreinamento;
    }
}