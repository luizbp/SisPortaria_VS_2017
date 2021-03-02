namespace SisPortaria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarExcluirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasEmAndamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbHr = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.visitaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 71);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitantesToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.editarExcluirUsuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 67);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cadastroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // visitantesToolStripMenuItem
            // 
            this.visitantesToolStripMenuItem.Name = "visitantesToolStripMenuItem";
            this.visitantesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.visitantesToolStripMenuItem.Text = "Visitante";
            this.visitantesToolStripMenuItem.Click += new System.EventHandler(this.visitantesToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // editarExcluirUsuarioToolStripMenuItem
            // 
            this.editarExcluirUsuarioToolStripMenuItem.Name = "editarExcluirUsuarioToolStripMenuItem";
            this.editarExcluirUsuarioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editarExcluirUsuarioToolStripMenuItem.Text = "Editar/ Excluir Usuario";
            this.editarExcluirUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarExcluirUsuarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 67);
            this.toolStripMenuItem1.Text = "|";
            // 
            // visitaToolStripMenuItem
            // 
            this.visitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVisitaToolStripMenuItem,
            this.saídaToolStripMenuItem,
            this.visitasEmAndamentoToolStripMenuItem});
            this.visitaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitaToolStripMenuItem.Image")));
            this.visitaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visitaToolStripMenuItem.Name = "visitaToolStripMenuItem";
            this.visitaToolStripMenuItem.Size = new System.Drawing.Size(60, 67);
            this.visitaToolStripMenuItem.Text = "Visitas";
            this.visitaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // novaVisitaToolStripMenuItem
            // 
            this.novaVisitaToolStripMenuItem.Name = "novaVisitaToolStripMenuItem";
            this.novaVisitaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaVisitaToolStripMenuItem.Text = "Entrada";
            this.novaVisitaToolStripMenuItem.Click += new System.EventHandler(this.novaVisitaToolStripMenuItem_Click);
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saídaToolStripMenuItem.Text = "Saída";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.saídaToolStripMenuItem_Click);
            // 
            // visitasEmAndamentoToolStripMenuItem
            // 
            this.visitasEmAndamentoToolStripMenuItem.Name = "visitasEmAndamentoToolStripMenuItem";
            this.visitasEmAndamentoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.visitasEmAndamentoToolStripMenuItem.Text = "Em andamento";
            this.visitasEmAndamentoToolStripMenuItem.Click += new System.EventHandler(this.visitasEmAndamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 67);
            this.toolStripMenuItem2.Text = "|";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioToolStripMenuItem.Image")));
            this.relatorioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 67);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lbHr,
            this.toolStripSeparator1,
            this.label2,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 476);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "Logado como:";
            // 
            // lbHr
            // 
            this.lbHr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbHr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbHr.Name = "lbHr";
            this.lbHr.Size = new System.Drawing.Size(49, 22);
            this.lbHr.Text = "Horario";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.Text = "name";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Portaria Seme - New";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasEmAndamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel lbHr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editarExcluirUsuarioToolStripMenuItem;
    }
}

