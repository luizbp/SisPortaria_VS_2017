namespace SisPortaria
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.tbEntrada = new System.Windows.Forms.TabControl();
            this.tabAndamento = new System.Windows.Forms.TabPage();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.gbAndamento = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAndamento = new System.Windows.Forms.DataGridView();
            this.btPesq = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.rtbObservacao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClearNome = new System.Windows.Forms.Button();
            this.btPesqNome = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtLocalVisita = new System.Windows.Forms.TextBox();
            this.txtNomePes = new System.Windows.Forms.TextBox();
            this.txtIDPes = new System.Windows.Forms.TextBox();
            this.tbEntrada.SuspendLayout();
            this.tabAndamento.SuspendLayout();
            this.gbAndamento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndamento)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Brown;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(329, 9);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 38);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(222, 9);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(101, 38);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btGravar
            // 
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.ForeColor = System.Drawing.Color.Olive;
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.Location = new System.Drawing.Point(115, 9);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(101, 38);
            this.btGravar.TabIndex = 2;
            this.btGravar.Text = "Gravar";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btNovo
            // 
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.Color.Green;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(8, 9);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(101, 38);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Navy;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(687, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 38);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // tbEntrada
            // 
            this.tbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntrada.Controls.Add(this.tabAndamento);
            this.tbEntrada.Controls.Add(this.tabCadastro);
            this.tbEntrada.Location = new System.Drawing.Point(6, 53);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.SelectedIndex = 0;
            this.tbEntrada.Size = new System.Drawing.Size(786, 429);
            this.tbEntrada.TabIndex = 6;
            // 
            // tabAndamento
            // 
            this.tabAndamento.Controls.Add(this.txtPesq);
            this.tabAndamento.Controls.Add(this.gbAndamento);
            this.tabAndamento.Location = new System.Drawing.Point(4, 22);
            this.tabAndamento.Name = "tabAndamento";
            this.tabAndamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabAndamento.Size = new System.Drawing.Size(778, 403);
            this.tabAndamento.TabIndex = 0;
            this.tabAndamento.Text = "Em Andamento";
            this.tabAndamento.UseVisualStyleBackColor = true;
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(12, 29);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(621, 20);
            this.txtPesq.TabIndex = 6;
            // 
            // gbAndamento
            // 
            this.gbAndamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAndamento.Controls.Add(this.groupBox2);
            this.gbAndamento.Controls.Add(this.btPesq);
            this.gbAndamento.Location = new System.Drawing.Point(6, 6);
            this.gbAndamento.Name = "gbAndamento";
            this.gbAndamento.Size = new System.Drawing.Size(767, 390);
            this.gbAndamento.TabIndex = 15;
            this.gbAndamento.TabStop = false;
            this.gbAndamento.Text = "Visitas em Andamento (Hoje)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvAndamento);
            this.groupBox2.Location = new System.Drawing.Point(6, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 329);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgvAndamento
            // 
            this.dgvAndamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAndamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAndamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAndamento.Location = new System.Drawing.Point(3, 16);
            this.dgvAndamento.Name = "dgvAndamento";
            this.dgvAndamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAndamento.Size = new System.Drawing.Size(755, 310);
            this.dgvAndamento.TabIndex = 0;
            this.dgvAndamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAndamento_CellContentClick);
            this.dgvAndamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAndamento_CellDoubleClick);
            // 
            // btPesq
            // 
            this.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPesq.Image = ((System.Drawing.Image)(resources.GetObject("btPesq.Image")));
            this.btPesq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesq.Location = new System.Drawing.Point(633, 12);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(128, 38);
            this.btPesq.TabIndex = 7;
            this.btPesq.Text = "Pesquisar";
            this.btPesq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesq_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.gbCadastro);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(778, 403);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.rtbObservacao);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Controls.Add(this.btClearNome);
            this.gbCadastro.Controls.Add(this.btPesqNome);
            this.gbCadastro.Controls.Add(this.txtMotivo);
            this.gbCadastro.Controls.Add(this.txtLocalVisita);
            this.gbCadastro.Controls.Add(this.txtNomePes);
            this.gbCadastro.Controls.Add(this.txtIDPes);
            this.gbCadastro.Enabled = false;
            this.gbCadastro.Location = new System.Drawing.Point(6, 6);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(631, 303);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro de Visitas";
            // 
            // rtbObservacao
            // 
            this.rtbObservacao.Location = new System.Drawing.Point(82, 118);
            this.rtbObservacao.Name = "rtbObservacao";
            this.rtbObservacao.Size = new System.Drawing.Size(439, 105);
            this.rtbObservacao.TabIndex = 10;
            this.rtbObservacao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local da Visita:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // btClearNome
            // 
            this.btClearNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClearNome.BackgroundImage")));
            this.btClearNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearNome.FlatAppearance.BorderSize = 0;
            this.btClearNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearNome.Location = new System.Drawing.Point(527, 17);
            this.btClearNome.Name = "btClearNome";
            this.btClearNome.Size = new System.Drawing.Size(33, 29);
            this.btClearNome.TabIndex = 6;
            this.btClearNome.UseVisualStyleBackColor = true;
            this.btClearNome.Click += new System.EventHandler(this.btClearNome_Click);
            // 
            // btPesqNome
            // 
            this.btPesqNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqNome.BackgroundImage")));
            this.btPesqNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqNome.FlatAppearance.BorderSize = 0;
            this.btPesqNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqNome.ForeColor = System.Drawing.Color.Transparent;
            this.btPesqNome.Location = new System.Drawing.Point(566, 17);
            this.btPesqNome.Name = "btPesqNome";
            this.btPesqNome.Size = new System.Drawing.Size(33, 29);
            this.btPesqNome.TabIndex = 7;
            this.btPesqNome.UseVisualStyleBackColor = true;
            this.btPesqNome.Click += new System.EventHandler(this.btPesqNome_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(59, 81);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(462, 20);
            this.txtMotivo.TabIndex = 9;
            // 
            // txtLocalVisita
            // 
            this.txtLocalVisita.Location = new System.Drawing.Point(93, 51);
            this.txtLocalVisita.Name = "txtLocalVisita";
            this.txtLocalVisita.Size = new System.Drawing.Size(428, 20);
            this.txtLocalVisita.TabIndex = 8;
            // 
            // txtNomePes
            // 
            this.txtNomePes.Location = new System.Drawing.Point(123, 22);
            this.txtNomePes.Name = "txtNomePes";
            this.txtNomePes.ReadOnly = true;
            this.txtNomePes.Size = new System.Drawing.Size(398, 20);
            this.txtNomePes.TabIndex = 0;
            // 
            // txtIDPes
            // 
            this.txtIDPes.Location = new System.Drawing.Point(53, 22);
            this.txtIDPes.Name = "txtIDPes";
            this.txtIDPes.ReadOnly = true;
            this.txtIDPes.Size = new System.Drawing.Size(68, 20);
            this.txtIDPes.TabIndex = 0;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 483);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.MinimumSizeChanged += new System.EventHandler(this.Entrada_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.tbEntrada.ResumeLayout(false);
            this.tabAndamento.ResumeLayout(false);
            this.tabAndamento.PerformLayout();
            this.gbAndamento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndamento)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TabControl tbEntrada;
        private System.Windows.Forms.TabPage tabAndamento;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.GroupBox gbAndamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAndamento;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.RichTextBox rtbObservacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClearNome;
        private System.Windows.Forms.Button btPesqNome;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtLocalVisita;
        private System.Windows.Forms.TextBox txtNomePes;
        private System.Windows.Forms.TextBox txtIDPes;
        private System.Windows.Forms.Label label4;
    }
}