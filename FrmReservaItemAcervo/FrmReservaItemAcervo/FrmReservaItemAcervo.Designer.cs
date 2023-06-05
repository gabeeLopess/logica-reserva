namespace FrmReservaItemAcervo
{
	partial class FrmReservaItemAcervo
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservaItemAcervo));
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSitucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.cbxTipoMovimento = new System.Windows.Forms.ComboBox();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.btnSelecionarItemAcervo = new System.Windows.Forms.Button();
            this.txtTipoItem = new System.Windows.Forms.TextBox();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.lblCodLeitor = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarLeitor = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNumExemplar = new System.Windows.Forms.Label();
            this.txtNumExemplar = new System.Windows.Forms.TextBox();
            this.lblSelecionarLeitor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPrazoReserva = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSelecionarItemAcervo = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridLayout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem,
            this.colSitucao,
            this.colLeitor,
            this.colDataReserva,
            this.colDataRetorno,
            this.colTipoMovimento,
            this.colLocalizacao,
            this.colTipoItem,
            this.colNumExemplar,
            this.colCodLeitor});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(4, 263);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.RowHeadersWidth = 51;
            this.gridLayout.Size = new System.Drawing.Size(770, 252);
            this.gridLayout.TabIndex = 3;
            this.gridLayout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellDoubleClick);
            // 
            // colCodItem
            // 
            this.colCodItem.HeaderText = "Id Item";
            this.colCodItem.MinimumWidth = 6;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Item da Biblioteca";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colSitucao
            // 
            this.colSitucao.HeaderText = "Situação";
            this.colSitucao.MinimumWidth = 6;
            this.colSitucao.Name = "colSitucao";
            this.colSitucao.ReadOnly = true;
            // 
            // colLeitor
            // 
            this.colLeitor.HeaderText = "Leitor";
            this.colLeitor.MinimumWidth = 6;
            this.colLeitor.Name = "colLeitor";
            this.colLeitor.ReadOnly = true;
            // 
            // colDataReserva
            // 
            this.colDataReserva.HeaderText = "Data Reserva";
            this.colDataReserva.MinimumWidth = 6;
            this.colDataReserva.Name = "colDataReserva";
            this.colDataReserva.ReadOnly = true;
            // 
            // colDataRetorno
            // 
            this.colDataRetorno.HeaderText = "Data Retorno";
            this.colDataRetorno.MinimumWidth = 6;
            this.colDataRetorno.Name = "colDataRetorno";
            this.colDataRetorno.ReadOnly = true;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.HeaderText = "tipo movimento";
            this.colTipoMovimento.MinimumWidth = 6;
            this.colTipoMovimento.Name = "colTipoMovimento";
            this.colTipoMovimento.ReadOnly = true;
            this.colTipoMovimento.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localizacao";
            this.colLocalizacao.MinimumWidth = 6;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLocalizacao.Visible = false;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "TipoItem";
            this.colTipoItem.MinimumWidth = 6;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Num Exemplar";
            this.colNumExemplar.MinimumWidth = 6;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.HeaderText = "Codigo Leitor";
            this.colCodLeitor.MinimumWidth = 6;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            this.colCodLeitor.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblTipoMovimento);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.lblCodigoItem);
            this.groupBox1.Controls.Add(this.txtCodigoItem);
            this.groupBox1.Controls.Add(this.cbxTipoMovimento);
            this.groupBox1.Controls.Add(this.cbxSituacao);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(766, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Location = new System.Drawing.Point(199, 26);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(83, 13);
            this.lblTipoMovimento.TabIndex = 2;
            this.lblTipoMovimento.Text = "Tipo Movimento";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(487, 27);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 3;
            this.lblSituacao.Text = "Situação";
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(-3, 26);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(63, 13);
            this.lblCodigoItem.TabIndex = 0;
            this.lblCodigoItem.Text = "Código Item";
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(61, 23);
            this.txtCodigoItem.Multiline = true;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.ReadOnly = true;
            this.txtCodigoItem.Size = new System.Drawing.Size(121, 21);
            this.txtCodigoItem.TabIndex = 1;
            this.txtCodigoItem.TextChanged += new System.EventHandler(this.txtCodigoItem_TextChanged);
            // 
            // cbxTipoMovimento
            // 
            this.cbxTipoMovimento.FormattingEnabled = true;
            this.cbxTipoMovimento.Items.AddRange(new object[] {
            "Devolver",
            "Empréstimo"});
            this.cbxTipoMovimento.Location = new System.Drawing.Point(290, 24);
            this.cbxTipoMovimento.Name = "cbxTipoMovimento";
            this.cbxTipoMovimento.Size = new System.Drawing.Size(172, 21);
            this.cbxTipoMovimento.TabIndex = 0;
            this.cbxTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMovimento_SelectedIndexChanged);
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Devolvido",
            "Emprestado"});
            this.cbxSituacao.Location = new System.Drawing.Point(584, 24);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(180, 21);
            this.cbxSituacao.TabIndex = 1;
            this.cbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cbxSituacao_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(-2, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome Item";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(61, 13);
            this.txtNomeItem.Multiline = true;
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.ReadOnly = true;
            this.txtNomeItem.Size = new System.Drawing.Size(401, 19);
            this.txtNomeItem.TabIndex = 3;
            // 
            // btnSelecionarItemAcervo
            // 
            this.btnSelecionarItemAcervo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarItemAcervo.Image")));
            this.btnSelecionarItemAcervo.Location = new System.Drawing.Point(706, 97);
            this.btnSelecionarItemAcervo.Name = "btnSelecionarItemAcervo";
            this.btnSelecionarItemAcervo.Size = new System.Drawing.Size(39, 19);
            this.btnSelecionarItemAcervo.TabIndex = 4;
            this.btnSelecionarItemAcervo.UseVisualStyleBackColor = true;
            this.btnSelecionarItemAcervo.Click += new System.EventHandler(this.btnSelecionarItemAcervo_Click);
            // 
            // txtTipoItem
            // 
            this.txtTipoItem.Location = new System.Drawing.Point(584, 13);
            this.txtTipoItem.Multiline = true;
            this.txtTipoItem.Name = "txtTipoItem";
            this.txtTipoItem.ReadOnly = true;
            this.txtTipoItem.Size = new System.Drawing.Size(180, 19);
            this.txtTipoItem.TabIndex = 5;
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(487, 18);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(51, 13);
            this.lblTipoItem.TabIndex = 6;
            this.lblTipoItem.Text = "Tipo Item";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(-2, 75);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(64, 13);
            this.lblNomeLeitor.TabIndex = 8;
            this.lblNomeLeitor.Text = "Nome Leitor";
            // 
            // lblCodLeitor
            // 
            this.lblCodLeitor.AutoSize = true;
            this.lblCodLeitor.Location = new System.Drawing.Point(487, 75);
            this.lblCodLeitor.Name = "lblCodLeitor";
            this.lblCodLeitor.Size = new System.Drawing.Size(69, 13);
            this.lblCodLeitor.TabIndex = 11;
            this.lblCodLeitor.Text = "Código Leitor";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Location = new System.Drawing.Point(584, 72);
            this.txtCodLeitor.Multiline = true;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.ReadOnly = true;
            this.txtCodLeitor.Size = new System.Drawing.Size(180, 19);
            this.txtCodLeitor.TabIndex = 12;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(61, 45);
            this.txtLocalizacao.Multiline = true;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.ReadOnly = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(401, 19);
            this.txtLocalizacao.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Localização";
            // 
            // btnSelecionarLeitor
            // 
            this.btnSelecionarLeitor.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarLeitor.Image")));
            this.btnSelecionarLeitor.Location = new System.Drawing.Point(706, 122);
            this.btnSelecionarLeitor.Name = "btnSelecionarLeitor";
            this.btnSelecionarLeitor.Size = new System.Drawing.Size(39, 19);
            this.btnSelecionarLeitor.TabIndex = 16;
            this.btnSelecionarLeitor.UseVisualStyleBackColor = true;
            this.btnSelecionarLeitor.Click += new System.EventHandler(this.btnSelecionarLeitor_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(526, 147);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 20);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNumExemplar
            // 
            this.lblNumExemplar.AutoSize = true;
            this.lblNumExemplar.Location = new System.Drawing.Point(487, 43);
            this.lblNumExemplar.Name = "lblNumExemplar";
            this.lblNumExemplar.Size = new System.Drawing.Size(75, 13);
            this.lblNumExemplar.TabIndex = 22;
            this.lblNumExemplar.Text = "Num Exemplar";
            // 
            // txtNumExemplar
            // 
            this.txtNumExemplar.Location = new System.Drawing.Point(584, 41);
            this.txtNumExemplar.Multiline = true;
            this.txtNumExemplar.Name = "txtNumExemplar";
            this.txtNumExemplar.ReadOnly = true;
            this.txtNumExemplar.Size = new System.Drawing.Size(180, 19);
            this.txtNumExemplar.TabIndex = 23;
            // 
            // lblSelecionarLeitor
            // 
            this.lblSelecionarLeitor.AutoSize = true;
            this.lblSelecionarLeitor.Location = new System.Drawing.Point(603, 122);
            this.lblSelecionarLeitor.Name = "lblSelecionarLeitor";
            this.lblSelecionarLeitor.Size = new System.Drawing.Size(86, 13);
            this.lblSelecionarLeitor.TabIndex = 24;
            this.lblSelecionarLeitor.Text = "Selecionar Leitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDataReserva);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpPrazoReserva);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.lblSelecionarItemAcervo);
            this.groupBox2.Controls.Add(this.lblSelecionarLeitor);
            this.groupBox2.Controls.Add(this.txtNumExemplar);
            this.groupBox2.Controls.Add(this.lblNumExemplar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnSelecionarLeitor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLocalizacao);
            this.groupBox2.Controls.Add(this.txtCodLeitor);
            this.groupBox2.Controls.Add(this.lblCodLeitor);
            this.groupBox2.Controls.Add(this.txtNomeLeitor);
            this.groupBox2.Controls.Add(this.lblNomeLeitor);
            this.groupBox2.Controls.Add(this.lblTipoItem);
            this.groupBox2.Controls.Add(this.txtTipoItem);
            this.groupBox2.Controls.Add(this.btnSelecionarItemAcervo);
            this.groupBox2.Controls.Add(this.txtNomeItem);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Location = new System.Drawing.Point(8, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Data Reseva";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Location = new System.Drawing.Point(189, 110);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(239, 20);
            this.dtpDataReserva.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prazo Reserva";
            // 
            // dtpPrazoReserva
            // 
            this.dtpPrazoReserva.Location = new System.Drawing.Point(189, 142);
            this.dtpPrazoReserva.Name = "dtpPrazoReserva";
            this.dtpPrazoReserva.Size = new System.Drawing.Size(239, 20);
            this.dtpPrazoReserva.TabIndex = 30;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(654, 147);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 20);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSelecionarItemAcervo
            // 
            this.lblSelecionarItemAcervo.AutoSize = true;
            this.lblSelecionarItemAcervo.Location = new System.Drawing.Point(603, 102);
            this.lblSelecionarItemAcervo.Name = "lblSelecionarItemAcervo";
            this.lblSelecionarItemAcervo.Size = new System.Drawing.Size(80, 13);
            this.lblSelecionarItemAcervo.TabIndex = 25;
            this.lblSelecionarItemAcervo.Text = "Selecionar Item";
            this.lblSelecionarItemAcervo.Click += new System.EventHandler(this.lblSelecionarItemAcervo_Click);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(61, 73);
            this.txtNomeLeitor.Multiline = true;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.ReadOnly = true;
            this.txtNomeLeitor.Size = new System.Drawing.Size(401, 19);
            this.txtNomeLeitor.TabIndex = 9;
            // 
            // FrmReservaItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReservaItemAcervo";
            this.Text = "Reserva Item Acervo";
            this.Load += new System.EventHandler(this.FrmReservaItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTipoMovimento;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.Label lblCodigoItem;
		private System.Windows.Forms.TextBox txtCodigoItem;
		private System.Windows.Forms.ComboBox cbxSituacao;
		private System.Windows.Forms.ComboBox cbxTipoMovimento;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNomeItem;
		private System.Windows.Forms.Button btnSelecionarItemAcervo;
		private System.Windows.Forms.TextBox txtTipoItem;
		private System.Windows.Forms.Label lblTipoItem;
		private System.Windows.Forms.Label lblNomeLeitor;
		private System.Windows.Forms.Label lblCodLeitor;
		private System.Windows.Forms.TextBox txtCodLeitor;
		private System.Windows.Forms.TextBox txtLocalizacao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelecionarLeitor;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblNumExemplar;
		private System.Windows.Forms.TextBox txtNumExemplar;
		private System.Windows.Forms.Label lblSelecionarLeitor;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblSelecionarItemAcervo;
		private System.Windows.Forms.TextBox txtNomeLeitor;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpDataReserva;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpPrazoReserva;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSitucao;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLeitor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimento;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
	}
}

