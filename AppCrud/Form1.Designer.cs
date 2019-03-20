namespace AppCrud
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNovo = new System.Windows.Forms.ToolStripButton();
            this.TsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TslId = new System.Windows.Forms.ToolStripLabel();
            this.TstId = new System.Windows.Forms.ToolStripTextBox();
            this.TsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskCep = new System.Windows.Forms.MaskedTextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtUf = new System.Windows.Forms.TextBox();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblUf = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNovo,
            this.TsbCancelar,
            this.TsbSalvar,
            this.TsbExcluir,
            this.toolStripSeparator1,
            this.TslId,
            this.TstId,
            this.TsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(639, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbNovo
            // 
            this.TsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNovo.Image")));
            this.TsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNovo.Name = "TsbNovo";
            this.TsbNovo.Size = new System.Drawing.Size(23, 22);
            this.TsbNovo.Text = "Novo";
            this.TsbNovo.Click += new System.EventHandler(this.TsbNovo_Click);
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.TsbCancelar.Text = "Cancelar";
            this.TsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.TsbSalvar.Text = "Salvar";
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.TsbExcluir.Text = "Excluir";
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TslId
            // 
            this.TslId.Name = "TslId";
            this.TslId.Size = new System.Drawing.Size(79, 22);
            this.TslId.Text = "Buscar por Id:";
            // 
            // TstId
            // 
            this.TstId.Name = "TstId";
            this.TstId.Size = new System.Drawing.Size(100, 25);
            // 
            // TsbBuscar
            // 
            this.TsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TsbBuscar.Image")));
            this.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBuscar.Name = "TsbBuscar";
            this.TsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.TsbBuscar.Text = "Buscar";
            this.TsbBuscar.Click += new System.EventHandler(this.TsbBuscar_Click);
            // 
            // TxtId
            // 
            this.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtId.Location = new System.Drawing.Point(12, 43);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(51, 20);
            this.TxtId.TabIndex = 1;
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Location = new System.Drawing.Point(67, 43);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(545, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEndereco.Location = new System.Drawing.Point(12, 82);
            this.TxtEndereco.MaxLength = 50;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(600, 20);
            this.TxtEndereco.TabIndex = 3;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(9, 24);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 9;
            this.LblId.Text = "Id";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(64, 24);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 10;
            this.LblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(9, 66);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 11;
            this.lblEndereco.Text = "Endereco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // MskCep
            // 
            this.MskCep.Location = new System.Drawing.Point(12, 122);
            this.MskCep.Mask = "00000-000";
            this.MskCep.Name = "MskCep";
            this.MskCep.Size = new System.Drawing.Size(100, 20);
            this.MskCep.TabIndex = 13;
            // 
            // TxtBairro
            // 
            this.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairro.Location = new System.Drawing.Point(121, 122);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(216, 20);
            this.TxtBairro.TabIndex = 14;
            // 
            // TxtCidade
            // 
            this.TxtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCidade.Location = new System.Drawing.Point(343, 122);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(212, 20);
            this.TxtCidade.TabIndex = 15;
            // 
            // TxtUf
            // 
            this.TxtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUf.Location = new System.Drawing.Point(561, 122);
            this.TxtUf.MaxLength = 2;
            this.TxtUf.Name = "TxtUf";
            this.TxtUf.Size = new System.Drawing.Size(51, 20);
            this.TxtUf.TabIndex = 16;
            // 
            // MskTelefone
            // 
            this.MskTelefone.Location = new System.Drawing.Point(12, 161);
            this.MskTelefone.Mask = "(99) 99999-9999";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(100, 20);
            this.MskTelefone.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CEP";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(118, 106);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(34, 13);
            this.LblBairro.TabIndex = 19;
            this.LblBairro.Text = "Bairro";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(340, 105);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(40, 13);
            this.LblCidade.TabIndex = 20;
            this.LblCidade.Text = "Cidade";
            // 
            // LblUf
            // 
            this.LblUf.AutoSize = true;
            this.LblUf.Location = new System.Drawing.Point(558, 105);
            this.LblUf.Name = "LblUf";
            this.LblUf.Size = new System.Drawing.Size(21, 13);
            this.LblUf.TabIndex = 21;
            this.LblUf.Text = "UF";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(9, 145);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(49, 13);
            this.LblTel.TabIndex = 22;
            this.LblTel.Text = "Telefone";
            this.LblTel.Click += new System.EventHandler(this.Label9_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 207);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblUf);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskTelefone);
            this.Controls.Add(this.TxtUf);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.MskCep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNovo;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel TslId;
        private System.Windows.Forms.ToolStripTextBox TstId;
        private System.Windows.Forms.ToolStripButton TsbBuscar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskCep;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtUf;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblUf;
        private System.Windows.Forms.Label LblTel;
    }
}

