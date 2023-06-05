namespace FrmReservaItemAcervo
{
	partial class FrmSelecionarItemAcervo
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
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumExemplar = new System.Windows.Forms.Label();
            this.txtNumExemplar = new System.Windows.Forms.TextBox();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtTipoItem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(4, 37);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(58, 13);
            this.lblNomeLeitor.TabIndex = 29;
            this.lblNomeLeitor.Text = "Nome Item";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeItem.Location = new System.Drawing.Point(98, 34);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(374, 20);
            this.txtNomeItem.TabIndex = 28;
            this.txtNomeItem.TextChanged += new System.EventHandler(this.txtNomeItem_TextChanged_1);
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigoItem.Location = new System.Drawing.Point(98, 5);
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(201, 20);
            this.txtCodigoItem.TabIndex = 27;
            this.txtCodigoItem.TextChanged += new System.EventHandler(this.txtCodigoItem_TextChanged);
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(4, 10);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoItem.TabIndex = 26;
            this.lblCodigoItem.Text = "Código";
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLeitor,
            this.colNomeItem,
            this.colNumExemplar,
            this.colTipoItem,
            this.colLocalizacao});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(6, 160);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.RowHeadersWidth = 51;
            this.gridLayout.Size = new System.Drawing.Size(465, 254);
            this.gridLayout.TabIndex = 25;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
            this.gridLayout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellDoubleClick);
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.HeaderText = "Id";
            this.colCodLeitor.MinimumWidth = 6;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Nome Item";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Num Exemplar";
            this.colNumExemplar.MinimumWidth = 6;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 6;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.MinimumWidth = 6;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            // 
            // lblNumExemplar
            // 
            this.lblNumExemplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumExemplar.AutoSize = true;
            this.lblNumExemplar.Location = new System.Drawing.Point(4, 68);
            this.lblNumExemplar.Name = "lblNumExemplar";
            this.lblNumExemplar.Size = new System.Drawing.Size(75, 13);
            this.lblNumExemplar.TabIndex = 30;
            this.lblNumExemplar.Text = "Num Exemplar";
            // 
            // txtNumExemplar
            // 
            this.txtNumExemplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumExemplar.Location = new System.Drawing.Point(98, 63);
            this.txtNumExemplar.Name = "txtNumExemplar";
            this.txtNumExemplar.Size = new System.Drawing.Size(374, 20);
            this.txtNumExemplar.TabIndex = 31;
            this.txtNumExemplar.TextChanged += new System.EventHandler(this.txtNumExemplar_TextChanged);
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(4, 96);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(51, 13);
            this.lblTipoItem.TabIndex = 32;
            this.lblTipoItem.Text = "Tipo Item";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(4, 128);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 34;
            this.lblLocalizacao.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocalizacao.Location = new System.Drawing.Point(98, 125);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(374, 20);
            this.txtLocalizacao.TabIndex = 35;
            this.txtLocalizacao.TextChanged += new System.EventHandler(this.txtLocalizacao_TextChanged_1);
            // 
            // txtTipoItem
            // 
            this.txtTipoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTipoItem.Location = new System.Drawing.Point(98, 93);
            this.txtTipoItem.Name = "txtTipoItem";
            this.txtTipoItem.Size = new System.Drawing.Size(374, 20);
            this.txtTipoItem.TabIndex = 33;
            this.txtTipoItem.TextChanged += new System.EventHandler(this.txtTipoItem_TextChanged);
            // 
            // FrmSelecionarItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 417);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.txtTipoItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.txtNumExemplar);
            this.Controls.Add(this.lblNumExemplar);
            this.Controls.Add(this.lblNomeLeitor);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtCodigoItem);
            this.Controls.Add(this.lblCodigoItem);
            this.Controls.Add(this.gridLayout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSelecionarItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Item";
            this.Load += new System.EventHandler(this.FrmSelecionarItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeLeitor;
		private System.Windows.Forms.TextBox txtNomeItem;
		private System.Windows.Forms.TextBox txtCodigoItem;
		private System.Windows.Forms.Label lblCodigoItem;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.Label lblNumExemplar;
		private System.Windows.Forms.TextBox txtNumExemplar;
		private System.Windows.Forms.Label lblTipoItem;
		private System.Windows.Forms.Label lblLocalizacao;
		private System.Windows.Forms.TextBox txtLocalizacao;
		private System.Windows.Forms.TextBox txtTipoItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
	}
}