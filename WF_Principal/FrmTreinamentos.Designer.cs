namespace WF_Principal
{
    partial class FrmEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIncMunicipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabTodasEmpresas = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscestadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insmunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bscEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTodasEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Controls.Add(this.tabTodasEmpresas);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.BackColor = System.Drawing.Color.LightGray;
            this.tabPageCadastro.Controls.Add(this.btnPesquisar);
            this.tabPageCadastro.Controls.Add(this.txtPesquisa);
            this.tabPageCadastro.Controls.Add(this.btnEditar);
            this.tabPageCadastro.Controls.Add(this.btnExcluir);
            this.tabPageCadastro.Controls.Add(this.btnNovo);
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(762, 435);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(406, 381);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 40);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(559, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(92, 382);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 38);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInscEstadual);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIncMunicipal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNomeFantasia);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 312);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Empresa";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(108, 249);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(199, 20);
            this.txtInscEstadual.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(516, 209);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(128, 20);
            this.txtEstado.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(108, 40);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(199, 20);
            this.txtCNPJ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Fantasia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Razão Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CEP:";
            // 
            // txtIncMunicipal
            // 
            this.txtIncMunicipal.Location = new System.Drawing.Point(447, 249);
            this.txtIncMunicipal.Name = "txtIncMunicipal";
            this.txtIncMunicipal.Size = new System.Drawing.Size(199, 20);
            this.txtIncMunicipal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(312, 209);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(128, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Inscrição Estadual:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(108, 209);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(128, 20);
            this.txtCEP.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Inscrição Municipal:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(108, 167);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(536, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(108, 88);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(537, 20);
            this.txtNomeFantasia.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(108, 127);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(536, 20);
            this.txtRazaoSocial.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(251, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 40);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabTodasEmpresas
            // 
            this.tabTodasEmpresas.Controls.Add(this.dataGridView1);
            this.tabTodasEmpresas.Location = new System.Drawing.Point(4, 22);
            this.tabTodasEmpresas.Name = "tabTodasEmpresas";
            this.tabTodasEmpresas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodasEmpresas.Size = new System.Drawing.Size(871, 415);
            this.tabTodasEmpresas.TabIndex = 1;
            this.tabTodasEmpresas.Text = "Todas as Empresas";
            this.tabTodasEmpresas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpjDataGridViewTextBoxColumn,
            this.nomefantasiaDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.inscestadualDataGridViewTextBoxColumn,
            this.insmunicipalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bscEmpresa;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(862, 403);
            this.dataGridView1.TabIndex = 27;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefantasiaDataGridViewTextBoxColumn
            // 
            this.nomefantasiaDataGridViewTextBoxColumn.DataPropertyName = "nomefantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.Name = "nomefantasiaDataGridViewTextBoxColumn";
            this.nomefantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razaosocial";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            this.razaosocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscestadualDataGridViewTextBoxColumn
            // 
            this.inscestadualDataGridViewTextBoxColumn.DataPropertyName = "inscestadual";
            this.inscestadualDataGridViewTextBoxColumn.HeaderText = "Inscrição Estadual";
            this.inscestadualDataGridViewTextBoxColumn.Name = "inscestadualDataGridViewTextBoxColumn";
            this.inscestadualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insmunicipalDataGridViewTextBoxColumn
            // 
            this.insmunicipalDataGridViewTextBoxColumn.DataPropertyName = "insmunicipal";
            this.insmunicipalDataGridViewTextBoxColumn.HeaderText = "Inscrição Municipal";
            this.insmunicipalDataGridViewTextBoxColumn.Name = "insmunicipalDataGridViewTextBoxColumn";
            this.insmunicipalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bscEmpresa
            // 
            this.bscEmpresa.DataSource = typeof(Persistência.Models.tb_Empresa);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(24, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 32);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(132, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(536, 20);
            this.txtPesquisa.TabIndex = 32;
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEmpresas";
            this.Text = "Cadastrar Empresas";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTodasEmpresas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabTodasEmpresas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIncMunicipal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bscEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscestadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insmunicipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;

    }
}