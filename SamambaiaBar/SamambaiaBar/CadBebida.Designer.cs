
namespace SamambaiaBar
{
    partial class CadBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadBebida));
            this.lblCadBebida = new System.Windows.Forms.Label();
            this.lblNomeBeb = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtBebida = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblSamamb = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.pctreLogo = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgCadastro = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctreLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadBebida
            // 
            this.lblCadBebida.AutoSize = true;
            this.lblCadBebida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCadBebida.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadBebida.Location = new System.Drawing.Point(197, 9);
            this.lblCadBebida.Name = "lblCadBebida";
            this.lblCadBebida.Size = new System.Drawing.Size(133, 23);
            this.lblCadBebida.TabIndex = 0;
            this.lblCadBebida.Text = "Cadastro de Bebida";
            // 
            // lblNomeBeb
            // 
            this.lblNomeBeb.AutoSize = true;
            this.lblNomeBeb.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBeb.Location = new System.Drawing.Point(13, 60);
            this.lblNomeBeb.Name = "lblNomeBeb";
            this.lblNomeBeb.Size = new System.Drawing.Size(75, 18);
            this.lblNomeBeb.TabIndex = 1;
            this.lblNomeBeb.Text = "Nome Bebida:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(13, 91);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(59, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(13, 119);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 18);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 147);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(60, 18);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descricao:";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(12, 303);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(35, 18);
            this.lblLista.TabIndex = 5;
            this.lblLista.Text = "Lista:";
            // 
            // txtBebida
            // 
            this.txtBebida.Location = new System.Drawing.Point(95, 57);
            this.txtBebida.Name = "txtBebida";
            this.txtBebida.Size = new System.Drawing.Size(314, 20);
            this.txtBebida.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(95, 89);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(314, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(95, 120);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(314, 20);
            this.txtValor.TabIndex = 9;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(95, 148);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(314, 47);
            this.txtDescricao.TabIndex = 10;
            // 
            // lblSamamb
            // 
            this.lblSamamb.AutoSize = true;
            this.lblSamamb.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamamb.Location = new System.Drawing.Point(421, 148);
            this.lblSamamb.Name = "lblSamamb";
            this.lblSamamb.Size = new System.Drawing.Size(111, 23);
            this.lblSamamb.TabIndex = 12;
            this.lblSamamb.Text = "samambaia bar";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.SaddleBrown;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExcluir.Location = new System.Drawing.Point(434, 379);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExcluir.Size = new System.Drawing.Size(86, 40);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // pctreLogo
            // 
            this.pctreLogo.Image = global::SamambaiaBar.Properties.Resources.favicon_96x96_created_by_logaster;
            this.pctreLogo.Location = new System.Drawing.Point(434, 57);
            this.pctreLogo.Name = "pctreLogo";
            this.pctreLogo.Size = new System.Drawing.Size(81, 80);
            this.pctreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctreLogo.TabIndex = 11;
            this.pctreLogo.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpar.Location = new System.Drawing.Point(434, 321);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btLimpar.Size = new System.Drawing.Size(86, 40);
            this.btLimpar.TabIndex = 17;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEditar.Location = new System.Drawing.Point(434, 262);
            this.btEditar.Name = "btEditar";
            this.btEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEditar.Size = new System.Drawing.Size(86, 40);
            this.btEditar.TabIndex = 18;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSalvar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalvar.Location = new System.Drawing.Point(434, 201);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSalvar.Size = new System.Drawing.Size(86, 40);
            this.btSalvar.TabIndex = 19;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgCadastro
            // 
            this.dgCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColBebida,
            this.ColCategoria,
            this.ColDescricao,
            this.ColStatus});
            this.dgCadastro.Location = new System.Drawing.Point(95, 202);
            this.dgCadastro.Name = "dgCadastro";
            this.dgCadastro.Size = new System.Drawing.Size(314, 217);
            this.dgCadastro.TabIndex = 20;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 50;
            // 
            // ColBebida
            // 
            this.ColBebida.HeaderText = "Bebida";
            this.ColBebida.Name = "ColBebida";
            // 
            // ColCategoria
            // 
            this.ColCategoria.HeaderText = "Categoria";
            this.ColCategoria.Name = "ColCategoria";
            // 
            // ColDescricao
            // 
            this.ColDescricao.HeaderText = "Descricao";
            this.ColDescricao.Name = "ColDescricao";
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.Width = 10;
            // 
            // CadBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(544, 449);
            this.Controls.Add(this.dgCadastro);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lblSamamb);
            this.Controls.Add(this.pctreLogo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtBebida);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNomeBeb);
            this.Controls.Add(this.lblCadBebida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Bebida";
            this.Load += new System.EventHandler(this.CadBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctreLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadBebida;
        private System.Windows.Forms.Label lblNomeBeb;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtBebida;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox pctreLogo;
        private System.Windows.Forms.Label lblSamamb;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}