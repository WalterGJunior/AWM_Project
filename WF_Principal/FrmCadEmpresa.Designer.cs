using Persistência.Models;
namespace WF_Principal
{
    partial class FrmCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEmpresa));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.bscEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.txtPessoaContato = new DevExpress.XtraEditors.TextEdit();
            this.spinEditCNPJ = new DevExpress.XtraEditors.SpinEdit();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.TxtRazaoSocial = new DevExpress.XtraEditors.TextEdit();
            this.TxtNomeFantasia = new DevExpress.XtraEditors.TextEdit();
            this.spinEditCEP = new DevExpress.XtraEditors.SpinEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomefantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazaosocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpessoaContato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dxValidacao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoaContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCNPJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazaoSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomeFantasia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCEP.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Fantasia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Razão Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pessoa de Contato:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(259, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 40);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(558, 347);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(407, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 40);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtPessoaContato);
            this.groupBox1.Controls.Add(this.spinEditCNPJ);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.TxtRazaoSocial);
            this.groupBox1.Controls.Add(this.TxtNomeFantasia);
            this.groupBox1.Controls.Add(this.spinEditCEP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Empresa";
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(132, 209);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "(00)0000-0000";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefone.Size = new System.Drawing.Size(102, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // bscEmpresa
            // 
            this.bscEmpresa.DataSource = typeof(Persistência.Models.tb_Empresa);
            this.bscEmpresa.CurrentChanged += new System.EventHandler(this.bscEmpresa_CurrentItemChanged);
            // 
            // txtPessoaContato
            // 
            this.txtPessoaContato.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "pessoaContato", true));
            this.txtPessoaContato.Location = new System.Drawing.Point(132, 249);
            this.txtPessoaContato.Name = "txtPessoaContato";
            this.txtPessoaContato.Properties.MaxLength = 50;
            this.txtPessoaContato.Size = new System.Drawing.Size(384, 20);
            this.txtPessoaContato.TabIndex = 19;
            // 
            // spinEditCNPJ
            // 
            this.spinEditCNPJ.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "cnpj", true));
            this.spinEditCNPJ.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCNPJ.Location = new System.Drawing.Point(132, 56);
            this.spinEditCNPJ.Name = "spinEditCNPJ";
            this.spinEditCNPJ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCNPJ.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditCNPJ.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCNPJ.Properties.IsFloatValue = false;
            this.spinEditCNPJ.Properties.Mask.EditMask = "00.000.000/0000-00";
            this.spinEditCNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.spinEditCNPJ.Properties.Mask.SaveLiteral = false;
            this.spinEditCNPJ.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditCNPJ.Size = new System.Drawing.Size(124, 20);
            this.spinEditCNPJ.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "CNPJ Informado deve ser informado!";
            this.dxValidacao.SetValidationRule(this.spinEditCNPJ, conditionValidationRule1);
            // 
            // txtEstado
            // 
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "estado", true));
            this.txtEstado.Location = new System.Drawing.Point(583, 209);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Properties.MaxLength = 15;
            this.txtEstado.Size = new System.Drawing.Size(107, 20);
            this.txtEstado.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Estado não é válido!";
            this.dxValidacao.SetValidationRule(this.txtEstado, conditionValidationRule2);
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(400, 209);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.MaxLength = 20;
            this.txtCidade.Size = new System.Drawing.Size(127, 20);
            this.txtCidade.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Cidade deve ser informada.";
            this.dxValidacao.SetValidationRule(this.txtCidade, conditionValidationRule3);
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(132, 167);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.MaxLength = 50;
            this.txtEndereco.Size = new System.Drawing.Size(558, 20);
            this.txtEndereco.TabIndex = 4;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Endereço deve ser informado.";
            this.dxValidacao.SetValidationRule(this.txtEndereco, conditionValidationRule4);
            // 
            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "razaosocial", true));
            this.TxtRazaoSocial.Location = new System.Drawing.Point(132, 127);
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.Properties.MaxLength = 50;
            this.TxtRazaoSocial.Size = new System.Drawing.Size(558, 20);
            this.TxtRazaoSocial.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Razão Social não é válido!";
            this.dxValidacao.SetValidationRule(this.TxtRazaoSocial, conditionValidationRule5);
            // 
            // TxtNomeFantasia
            // 
            this.TxtNomeFantasia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "nomefantasia", true));
            this.TxtNomeFantasia.Location = new System.Drawing.Point(132, 92);
            this.TxtNomeFantasia.Name = "TxtNomeFantasia";
            this.TxtNomeFantasia.Properties.MaxLength = 50;
            this.TxtNomeFantasia.Size = new System.Drawing.Size(558, 20);
            this.TxtNomeFantasia.TabIndex = 2;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Nome Fantasia não é válido!";
            this.dxValidacao.SetValidationRule(this.TxtNomeFantasia, conditionValidationRule6);
            // 
            // spinEditCEP
            // 
            this.spinEditCEP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bscEmpresa, "cep", true));
            this.spinEditCEP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCEP.Location = new System.Drawing.Point(276, 209);
            this.spinEditCEP.Name = "spinEditCEP";
            this.spinEditCEP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCEP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditCEP.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCEP.Properties.IsFloatValue = false;
            this.spinEditCEP.Properties.Mask.EditMask = "00000-999";
            this.spinEditCEP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.spinEditCEP.Properties.Mask.SaveLiteral = false;
            this.spinEditCEP.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditCEP.Size = new System.Drawing.Size(68, 20);
            this.spinEditCEP.TabIndex = 5;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "CEP informado não é válido!";
            this.dxValidacao.SetValidationRule(this.spinEditCEP, conditionValidationRule7);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefone:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(114, 349);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 38);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 434);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Todas as Empresas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bscEmpresa;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(946, 402);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcnpj,
            this.colnomefantasia,
            this.colrazaosocial,
            this.colendereco,
            this.colcep,
            this.coltelefone,
            this.colcidade,
            this.colestado,
            this.colpessoaContato});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colcnpj
            // 
            this.colcnpj.FieldName = "cnpj";
            this.colcnpj.Name = "colcnpj";
            this.colcnpj.OptionsColumn.AllowEdit = false;
            this.colcnpj.OptionsColumn.AllowFocus = false;
            this.colcnpj.Visible = true;
            this.colcnpj.VisibleIndex = 0;
            // 
            // colnomefantasia
            // 
            this.colnomefantasia.FieldName = "nomefantasia";
            this.colnomefantasia.Name = "colnomefantasia";
            this.colnomefantasia.Visible = true;
            this.colnomefantasia.VisibleIndex = 1;
            // 
            // colrazaosocial
            // 
            this.colrazaosocial.FieldName = "razaosocial";
            this.colrazaosocial.Name = "colrazaosocial";
            this.colrazaosocial.Visible = true;
            this.colrazaosocial.VisibleIndex = 2;
            // 
            // colendereco
            // 
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.Visible = true;
            this.colendereco.VisibleIndex = 3;
            // 
            // colcep
            // 
            this.colcep.FieldName = "cep";
            this.colcep.Name = "colcep";
            this.colcep.Visible = true;
            this.colcep.VisibleIndex = 4;
            // 
            // coltelefone
            // 
            this.coltelefone.FieldName = "telefone";
            this.coltelefone.Name = "coltelefone";
            this.coltelefone.OptionsColumn.AllowEdit = false;
            this.coltelefone.OptionsColumn.AllowFocus = false;
            this.coltelefone.Visible = true;
            this.coltelefone.VisibleIndex = 5;
            // 
            // colcidade
            // 
            this.colcidade.FieldName = "cidade";
            this.colcidade.Name = "colcidade";
            this.colcidade.Visible = true;
            this.colcidade.VisibleIndex = 6;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.OptionsColumn.AllowFocus = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 7;
            // 
            // colpessoaContato
            // 
            this.colpessoaContato.FieldName = "pessoaContato";
            this.colpessoaContato.Name = "colpessoaContato";
            this.colpessoaContato.Visible = true;
            this.colpessoaContato.VisibleIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empresas";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 434);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Empresas";
            this.Load += new System.EventHandler(this.FrmCadEmpresa_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoaContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCNPJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazaoSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomeFantasia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCEP.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidacao;
        private DevExpress.XtraEditors.SpinEdit spinEditCEP;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.TextEdit TxtRazaoSocial;
        private DevExpress.XtraEditors.TextEdit TxtNomeFantasia;
        private DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private System.Windows.Forms.BindingSource bscEmpresa;
        private DevExpress.XtraEditors.SpinEdit spinEditCNPJ;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtPessoaContato;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colcnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colnomefantasia;
        private DevExpress.XtraGrid.Columns.GridColumn colrazaosocial;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
        private DevExpress.XtraGrid.Columns.GridColumn colcep;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colcidade;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colpessoaContato;

        public DevExpress.XtraEditors.SpinEdit spinEdit2 { get; set; }
    }
}