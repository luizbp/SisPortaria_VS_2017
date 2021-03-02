namespace SisPortaria
{
    partial class Saida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saida));
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.rtbObservacao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtLocalVisita = new System.Windows.Forms.TextBox();
            this.txtNomePes = new System.Windows.Forms.TextBox();
            this.txtIDPes = new System.Windows.Forms.TextBox();
            this.dgvAndamento = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btPesq = new System.Windows.Forms.Button();
            this.tabAndamento = new System.Windows.Forms.TabPage();
            this.gbAndamento = new System.Windows.Forms.GroupBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tbEntrada = new System.Windows.Forms.TabControl();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabAndamento.SuspendLayout();
            this.gbAndamento.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.rtbObservacao);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Controls.Add(this.txtMotivo);
            this.gbCadastro.Controls.Add(this.txtLocalVisita);
            this.gbCadastro.Controls.Add(this.txtNomePes);
            this.gbCadastro.Controls.Add(this.txtIDPes);
            this.gbCadastro.Enabled = false;
            this.gbCadastro.Location = new System.Drawing.Point(6, 6);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(541, 255);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            // 
            // rtbObservacao
            // 
            this.rtbObservacao.Location = new System.Drawing.Point(80, 117);
            this.rtbObservacao.Name = "rtbObservacao";
            this.rtbObservacao.ReadOnly = true;
            this.rtbObservacao.Size = new System.Drawing.Size(439, 105);
            this.rtbObservacao.TabIndex = 21;
            this.rtbObservacao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Local da Visita:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(57, 80);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(462, 20);
            this.txtMotivo.TabIndex = 13;
            // 
            // txtLocalVisita
            // 
            this.txtLocalVisita.Location = new System.Drawing.Point(91, 50);
            this.txtLocalVisita.Name = "txtLocalVisita";
            this.txtLocalVisita.ReadOnly = true;
            this.txtLocalVisita.Size = new System.Drawing.Size(428, 20);
            this.txtLocalVisita.TabIndex = 14;
            // 
            // txtNomePes
            // 
            this.txtNomePes.Location = new System.Drawing.Point(121, 21);
            this.txtNomePes.Name = "txtNomePes";
            this.txtNomePes.ReadOnly = true;
            this.txtNomePes.Size = new System.Drawing.Size(398, 20);
            this.txtNomePes.TabIndex = 15;
            // 
            // txtIDPes
            // 
            this.txtIDPes.Location = new System.Drawing.Point(51, 21);
            this.txtIDPes.Name = "txtIDPes";
            this.txtIDPes.ReadOnly = true;
            this.txtIDPes.Size = new System.Drawing.Size(68, 20);
            this.txtIDPes.TabIndex = 16;
            // 
            // dgvAndamento
            // 
            this.dgvAndamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAndamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAndamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAndamento.Location = new System.Drawing.Point(3, 16);
            this.dgvAndamento.Name = "dgvAndamento";
            this.dgvAndamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAndamento.Size = new System.Drawing.Size(755, 310);
            this.dgvAndamento.TabIndex = 0;
            this.dgvAndamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAndamento_CellDoubleClick);
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
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(12, 29);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(621, 20);
            this.txtPesq.TabIndex = 14;
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
            this.btPesq.TabIndex = 1;
            this.btPesq.Text = "Pesquisar";
            this.btPesq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesq_Click);
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
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.gbCadastro);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(778, 403);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tbEntrada
            // 
            this.tbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntrada.Controls.Add(this.tabAndamento);
            this.tbEntrada.Controls.Add(this.tabConsulta);
            this.tbEntrada.Location = new System.Drawing.Point(5, 49);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.SelectedIndex = 0;
            this.tbEntrada.Size = new System.Drawing.Size(786, 429);
            this.tbEntrada.TabIndex = 12;
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Navy;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(686, 9);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 38);
            this.btSair.TabIndex = 11;
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
            this.btCancelar.Location = new System.Drawing.Point(176, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 38);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.Teal;
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFinalizar.Location = new System.Drawing.Point(9, 5);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(161, 38);
            this.btFinalizar.TabIndex = 8;
            this.btFinalizar.Text = "Finalizar Visita";
            this.btFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 483);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saida";
            this.Text = "Saida";
            this.MinimumSizeChanged += new System.EventHandler(this.Saida_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Saida_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabAndamento.ResumeLayout(false);
            this.tabAndamento.PerformLayout();
            this.gbAndamento.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tbEntrada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.DataGridView dgvAndamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.TabPage tabAndamento;
        private System.Windows.Forms.GroupBox gbAndamento;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabControl tbEntrada;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.RichTextBox rtbObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtLocalVisita;
        private System.Windows.Forms.TextBox txtNomePes;
        private System.Windows.Forms.TextBox txtIDPes;
    }
}