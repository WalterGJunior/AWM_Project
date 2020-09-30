using Persistência.Models;
namespace WF_Principal
{
    partial class FrmCadPalestrante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPalestrante));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.bscTreinador = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new DevExpress.XtraEditors.DateEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.spinEditIdade = new DevExpress.XtraEditors.SpinEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.SpindEditMatriculaTreinador = new DevExpress.XtraEditors.SpinEdit();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dxValidacao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatenascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefonefixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefonecelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bscTreinador)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataNascimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditIdade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpindEditMatriculaTreinador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bscTreinador
            // 
            this.bscTreinador.DataSource = typeof(Persistência.Models.tb_Palestrante);
            this.bscTreinador.CurrentChanged += new System.EventHandler(this.bscTreinador_CurrentChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Formação:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(278, 258);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(412, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(144, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 40);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpDataNascimento);
            this.groupBox1.Controls.Add(this.memoEdit1);
            this.groupBox1.Controls.Add(this.spinEditIdade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.SpindEditMatriculaTreinador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Treinadores";
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "telefonefixo", true));
            this.txtTelefone.Location = new System.Drawing.Point(86, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "(00)0000-0000";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefone.Size = new System.Drawing.Size(129, 20);
            this.txtTelefone.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Número de celular não é válido!";
            this.dxValidacao.SetValidationRule(this.txtTelefone, conditionValidationRule1);
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "telefonecelular", true));
            this.txtCelular.Location = new System.Drawing.Point(350, 107);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Mask.EditMask = "(00)0000-0000";
            this.txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCelular.Size = new System.Drawing.Size(132, 20);
            this.txtCelular.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Número de celular não é válido!";
            this.dxValidacao.SetValidationRule(this.txtCelular, conditionValidationRule2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Celular:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "datenascimento", true));
            this.dtpDataNascimento.EditValue = null;
            this.dtpDataNascimento.Location = new System.Drawing.Point(120, 84);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDataNascimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDataNascimento.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dtpDataNascimento.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dtpDataNascimento.Size = new System.Drawing.Size(130, 20);
            this.dtpDataNascimento.TabIndex = 5;
            this.dtpDataNascimento.EditValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "formacao", true));
            this.memoEdit1.Location = new System.Drawing.Point(86, 140);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(396, 96);
            this.memoEdit1.TabIndex = 13;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Formação não informada!";
            this.dxValidacao.SetValidationRule(this.memoEdit1, conditionValidationRule3);
            // 
            // spinEditIdade
            // 
            this.spinEditIdade.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "idade", true));
            this.spinEditIdade.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditIdade.Enabled = false;
            this.spinEditIdade.Location = new System.Drawing.Point(350, 81);
            this.spinEditIdade.Name = "spinEditIdade";
            this.spinEditIdade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditIdade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditIdade.Properties.Mask.SaveLiteral = false;
            this.spinEditIdade.Size = new System.Drawing.Size(100, 20);
            this.spinEditIdade.TabIndex = 7;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Idade não Informada!";
            this.dxValidacao.SetValidationRule(this.spinEditIdade, conditionValidationRule4);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(86, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(396, 20);
            this.txtNome.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Nome não Informado!";
            this.dxValidacao.SetValidationRule(this.txtNome, conditionValidationRule5);
            // 
            // SpindEditMatriculaTreinador
            // 
            this.SpindEditMatriculaTreinador.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscTreinador, "matricula", true));
            this.SpindEditMatriculaTreinador.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpindEditMatriculaTreinador.Location = new System.Drawing.Point(86, 24);
            this.SpindEditMatriculaTreinador.Name = "SpindEditMatriculaTreinador";
            this.SpindEditMatriculaTreinador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpindEditMatriculaTreinador.Properties.IsFloatValue = false;
            this.SpindEditMatriculaTreinador.Size = new System.Drawing.Size(100, 20);
            this.SpindEditMatriculaTreinador.TabIndex = 1;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Matricula não Informada!";
            this.dxValidacao.SetValidationRule(this.SpindEditMatriculaTreinador, conditionValidationRule6);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(20, 258);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 40);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(699, 349);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(693, 321);
            this.xtraTabPage3.Text = "Todos os Palestrantes";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bscTreinador;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(693, 321);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmatricula,
            this.colnome,
            this.colidade,
            this.coldatenascimento,
            this.colformacao,
            this.coltelefonefixo,
            this.coltelefonecelular});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colmatricula
            // 
            this.colmatricula.FieldName = "matricula";
            this.colmatricula.Name = "colmatricula";
            this.colmatricula.Visible = true;
            this.colmatricula.VisibleIndex = 0;
            // 
            // colnome
            // 
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            // 
            // colidade
            // 
            this.colidade.FieldName = "idade";
            this.colidade.Name = "colidade";
            this.colidade.Visible = true;
            this.colidade.VisibleIndex = 2;
            // 
            // coldatenascimento
            // 
            this.coldatenascimento.FieldName = "datenascimento";
            this.coldatenascimento.Name = "coldatenascimento";
            this.coldatenascimento.Visible = true;
            this.coldatenascimento.VisibleIndex = 3;
            // 
            // colformacao
            // 
            this.colformacao.FieldName = "formacao";
            this.colformacao.Name = "colformacao";
            this.colformacao.Visible = true;
            this.colformacao.VisibleIndex = 4;
            // 
            // coltelefonefixo
            // 
            this.coltelefonefixo.FieldName = "telefonefixo";
            this.coltelefonefixo.Name = "coltelefonefixo";
            this.coltelefonefixo.Visible = true;
            this.coltelefonefixo.VisibleIndex = 5;
            // 
            // coltelefonecelular
            // 
            this.coltelefonecelular.FieldName = "telefonecelular";
            this.coltelefonecelular.Name = "coltelefonecelular";
            this.coltelefonecelular.Visible = true;
            this.coltelefonecelular.VisibleIndex = 6;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.btnNovo);
            this.xtraTabPage4.Controls.Add(this.btnSalvar);
            this.xtraTabPage4.Controls.Add(this.groupBox1);
            this.xtraTabPage4.Controls.Add(this.btnEditar);
            this.xtraTabPage4.Controls.Add(this.btnExcluir);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(693, 321);
            this.xtraTabPage4.Text = "Palestrante";
            // 
            // FrmCadPalestrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 349);
            this.Controls.Add(this.xtraTabControl2);
            this.IsMdiContainer = true;
            this.Name = "FrmCadPalestrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Palestrante";
            this.Load += new System.EventHandler(this.FrmCadTreinador_Load);
            this.Controls.SetChildIndex(this.xtraTabControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bscTreinador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataNascimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditIdade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpindEditMatriculaTreinador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.BindingSource bscTreinador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidacao;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.SpinEdit SpindEditMatriculaTreinador;
        private DevExpress.XtraEditors.SpinEdit spinEditIdade;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_treinador;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colidade;
        private DevExpress.XtraGrid.Columns.GridColumn coldatenascimento;
        private DevExpress.XtraGrid.Columns.GridColumn colformacao;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefonefixo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefonecelular;
        private DevExpress.XtraEditors.DateEdit dtpDataNascimento;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;


        public System.Windows.Forms.TabControl tabControl1 { get; set; }

        public System.Windows.Forms.TabControl tabControl2 { get; set; }
    }
}