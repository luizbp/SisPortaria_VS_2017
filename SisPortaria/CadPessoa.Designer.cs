namespace SisPortaria
{
    partial class CadPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPessoa));
            this.btNovo = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btPesq = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCadastro.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.Color.Green;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(11, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(101, 38);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btGravar
            // 
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.ForeColor = System.Drawing.Color.Olive;
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.Location = new System.Drawing.Point(118, 12);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(101, 38);
            this.btGravar.TabIndex = 2;
            this.btGravar.Text = "Gravar";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(225, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(101, 38);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Brown;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(332, 12);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 38);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Navy;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(773, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 38);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tabPesquisa);
            this.tbCadastro.Controls.Add(this.tabCadastro);
            this.tbCadastro.Location = new System.Drawing.Point(7, 56);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(871, 544);
            this.tbCadastro.TabIndex = 1;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.groupBox1);
            this.tabPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(863, 518);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPesq);
            this.groupBox1.Controls.Add(this.btPesq);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 506);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPessoa);
            this.groupBox2.Location = new System.Drawing.Point(6, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 436);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPessoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPessoa.Location = new System.Drawing.Point(3, 17);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoa.Size = new System.Drawing.Size(831, 416);
            this.dgvPessoa.TabIndex = 0;
            this.dgvPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoa_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(6, 26);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(703, 21);
            this.txtPesq.TabIndex = 5;
            // 
            // btPesq
            // 
            this.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPesq.Image = ((System.Drawing.Image)(resources.GetObject("btPesq.Image")));
            this.btPesq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesq.Location = new System.Drawing.Point(715, 20);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(128, 38);
            this.btPesq.TabIndex = 6;
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
            this.tabCadastro.Size = new System.Drawing.Size(863, 518);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.mskCpf);
            this.gbCadastro.Controls.Add(this.mskRg);
            this.gbCadastro.Controls.Add(this.cbSexo);
            this.gbCadastro.Controls.Add(this.txtNumero);
            this.gbCadastro.Controls.Add(this.txtEndereco);
            this.gbCadastro.Controls.Add(this.txtNome);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.label6);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Enabled = false;
            this.gbCadastro.Location = new System.Drawing.Point(21, 23);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(784, 164);
            this.gbCadastro.TabIndex = 1;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(189, 51);
            this.mskCpf.Mask = "000000000/00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(99, 20);
            this.mskCpf.TabIndex = 8;
            this.mskCpf.Click += new System.EventHandler(this.mskCpf_Click);
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(56, 50);
            this.mskRg.Mask = "00.000.000-0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(91, 20);
            this.mskRg.TabIndex = 7;
            this.mskRg.Click += new System.EventHandler(this.mskRg_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.ItemHeight = 13;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino ",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(618, 22);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(134, 21);
            this.cbSexo.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(366, 82);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(72, 81);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(261, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(514, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nº :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // CadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 602);
            this.Controls.Add(this.tbCadastro);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pessoa";
            this.Load += new System.EventHandler(this.CadPessoa_Load);
            this.tbCadastro.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
    }
}