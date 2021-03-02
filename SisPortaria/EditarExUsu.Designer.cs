namespace SisPortaria
{
    partial class EditarExUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarExUsu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btPesq = new System.Windows.Forms.Button();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvLogin);
            this.groupBox2.Location = new System.Drawing.Point(6, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 436);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dgvLogin
            // 
            this.dgvLogin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLogin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogin.Location = new System.Drawing.Point(3, 17);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogin.Size = new System.Drawing.Size(831, 416);
            this.dgvLogin.TabIndex = 0;
            this.dgvLogin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogin_CellDoubleClick);
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
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(6, 26);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(703, 21);
            this.txtPesq.TabIndex = 5;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.txtLogin);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.txtNome);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.button1);
            this.gbCadastro.Controls.Add(this.txtSenha);
            this.gbCadastro.Controls.Add(this.label6);
            this.gbCadastro.Controls.Add(this.chkAdmin);
            this.gbCadastro.Controls.Add(this.label7);
            this.gbCadastro.Enabled = false;
            this.gbCadastro.Location = new System.Drawing.Point(21, 23);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(784, 164);
            this.gbCadastro.TabIndex = 1;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            this.gbCadastro.Enter += new System.EventHandler(this.gbCadastro_Enter);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(63, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostar senha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(63, 65);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(177, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.Location = new System.Drawing.Point(60, 93);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(102, 17);
            this.chkAdmin.TabIndex = 9;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(15, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Esse cadastro só pode ser efetuado por adiministradores";
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPesq);
            this.groupBox1.Controls.Add(this.btPesq);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 506);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCadastro.Controls.Add(this.tabPesquisa);
            this.tbCadastro.Controls.Add(this.tabCadastro);
            this.tbCadastro.Location = new System.Drawing.Point(6, 53);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(871, 544);
            this.tbCadastro.TabIndex = 7;
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
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Navy;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(772, 9);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 38);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Brown;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(227, 9);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 38);
            this.btCancelar.TabIndex = 3;
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
            this.btAlterar.Location = new System.Drawing.Point(6, 9);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(101, 38);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(113, 9);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(104, 38);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // EditarExUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 606);
            this.Controls.Add(this.tbCadastro);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarExUsu";
            this.Text = "Editar/Excluir Usuarios";
            this.MinimumSizeChanged += new System.EventHandler(this.EditarExUsu_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.EditarExUsu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btExcluir;
    }
}