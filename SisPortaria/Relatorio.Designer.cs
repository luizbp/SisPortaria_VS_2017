﻿namespace SisPortaria
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGerar = new System.Windows.Forms.TabPage();
            this.btExcel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.gbTipos = new System.Windows.Forms.GroupBox();
            this.btCarregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.rbPer = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbHoje = new System.Windows.Forms.RadioButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.rvDoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.btPasta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbGerar.SuspendLayout();
            this.gbTipos.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.tbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbGerar);
            this.tabControl1.Controls.Add(this.tbReport);
            this.tabControl1.Location = new System.Drawing.Point(7, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tbGerar
            // 
            this.tbGerar.Controls.Add(this.label3);
            this.tbGerar.Controls.Add(this.btPasta);
            this.tbGerar.Controls.Add(this.txtNome);
            this.tbGerar.Controls.Add(this.txtPasta);
            this.tbGerar.Controls.Add(this.btExcel);
            this.tbGerar.Controls.Add(this.btOK);
            this.tbGerar.Controls.Add(this.gbTipos);
            this.tbGerar.Controls.Add(this.gbData);
            this.tbGerar.Location = new System.Drawing.Point(4, 22);
            this.tbGerar.Name = "tbGerar";
            this.tbGerar.Padding = new System.Windows.Forms.Padding(3);
            this.tbGerar.Size = new System.Drawing.Size(1035, 618);
            this.tbGerar.TabIndex = 0;
            this.tbGerar.Text = "Gerar";
            this.tbGerar.UseVisualStyleBackColor = true;
            // 
            // btExcel
            // 
            this.btExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcel.Enabled = false;
            this.btExcel.FlatAppearance.BorderSize = 2;
            this.btExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btExcel.Image = ((System.Drawing.Image)(resources.GetObject("btExcel.Image")));
            this.btExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcel.Location = new System.Drawing.Point(687, 550);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(168, 54);
            this.btExcel.TabIndex = 9;
            this.btExcel.Text = "Excel";
            this.btExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Visible = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Enabled = false;
            this.btOK.FlatAppearance.BorderSize = 2;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btOK.Image = ((System.Drawing.Image)(resources.GetObject("btOK.Image")));
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.Location = new System.Drawing.Point(861, 550);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(168, 54);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "PDF";
            this.btOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // gbTipos
            // 
            this.gbTipos.Controls.Add(this.btCarregar);
            this.gbTipos.Controls.Add(this.label2);
            this.gbTipos.Controls.Add(this.label1);
            this.gbTipos.Controls.Add(this.dtpAte);
            this.gbTipos.Controls.Add(this.dtpDe);
            this.gbTipos.Controls.Add(this.rbPer);
            this.gbTipos.Controls.Add(this.rbTodos);
            this.gbTipos.Controls.Add(this.rbHoje);
            this.gbTipos.Location = new System.Drawing.Point(6, 9);
            this.gbTipos.Name = "gbTipos";
            this.gbTipos.Size = new System.Drawing.Size(1023, 53);
            this.gbTipos.TabIndex = 8;
            this.gbTipos.TabStop = false;
            this.gbTipos.Text = "Filtros";
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(880, 23);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(75, 23);
            this.btCarregar.TabIndex = 4;
            this.btCarregar.Text = "Carregar";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.Location = new System.Drawing.Point(621, 25);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(240, 20);
            this.dtpAte.TabIndex = 1;
            this.dtpAte.Value = new System.DateTime(2016, 8, 11, 0, 0, 0, 0);
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(356, 25);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(229, 20);
            this.dtpDe.TabIndex = 1;
            this.dtpDe.Value = new System.DateTime(2016, 8, 11, 0, 0, 0, 0);
            // 
            // rbPer
            // 
            this.rbPer.AutoSize = true;
            this.rbPer.Location = new System.Drawing.Point(236, 25);
            this.rbPer.Name = "rbPer";
            this.rbPer.Size = new System.Drawing.Size(94, 17);
            this.rbPer.TabIndex = 0;
            this.rbPer.TabStop = true;
            this.rbPer.Text = "Personalizado.";
            this.rbPer.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(122, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(100, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos registros.";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbHoje
            // 
            this.rbHoje.AutoSize = true;
            this.rbHoje.Location = new System.Drawing.Point(6, 25);
            this.rbHoje.Name = "rbHoje";
            this.rbHoje.Size = new System.Drawing.Size(110, 17);
            this.rbHoje.TabIndex = 0;
            this.rbHoje.TabStop = true;
            this.rbHoje.Text = "Registros de hoje.";
            this.rbHoje.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.dgvRelatorio);
            this.gbData.Location = new System.Drawing.Point(6, 68);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(1023, 460);
            this.gbData.TabIndex = 7;
            this.gbData.TabStop = false;
            // 
            // dgvRelatorio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRelatorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelatorio.Enabled = false;
            this.dgvRelatorio.Location = new System.Drawing.Point(3, 16);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(1017, 441);
            this.dgvRelatorio.TabIndex = 0;
            this.dgvRelatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorio_CellContentClick);
            // 
            // tbReport
            // 
            this.tbReport.Controls.Add(this.rvDoc);
            this.tbReport.Location = new System.Drawing.Point(4, 22);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(1035, 601);
            this.tbReport.TabIndex = 1;
            this.tbReport.Text = "Documento";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // rvDoc
            // 
            this.rvDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvDoc.Location = new System.Drawing.Point(3, 3);
            this.rvDoc.Name = "rvDoc";
            this.rvDoc.Size = new System.Drawing.Size(1029, 595);
            this.rvDoc.TabIndex = 1;
            this.rvDoc.Load += new System.EventHandler(this.rvDoc_Load);
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(122, 552);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.ReadOnly = true;
            this.txtPasta.Size = new System.Drawing.Size(197, 20);
            this.txtPasta.TabIndex = 10;
            // 
            // btPasta
            // 
            this.btPasta.Enabled = false;
            this.btPasta.Location = new System.Drawing.Point(12, 550);
            this.btPasta.Name = "btPasta";
            this.btPasta.Size = new System.Drawing.Size(108, 23);
            this.btPasta.TabIndex = 11;
            this.btPasta.Text = "Selecionar pasta:";
            this.btPasta.UseVisualStyleBackColor = true;
            this.btPasta.Click += new System.EventHandler(this.btPasta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome do arquivo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 582);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 10;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 655);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.MinimumSizeChanged += new System.EventHandler(this.Relatorio_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbGerar.ResumeLayout(false);
            this.tbGerar.PerformLayout();
            this.gbTipos.ResumeLayout(false);
            this.gbTipos.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.tbReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGerar;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox gbTipos;
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.RadioButton rbPer;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbHoje;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.TabPage tbReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvDoc;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btPasta;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
    }
}