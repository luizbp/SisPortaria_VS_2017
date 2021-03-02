namespace SisPortaria
{
    partial class CadLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(62, 58);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(59, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(177, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkAdmin);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btConf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostar senha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.Location = new System.Drawing.Point(59, 106);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(102, 17);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelar.BackgroundImage")));
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelar.Location = new System.Drawing.Point(391, 122);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(47, 44);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConf
            // 
            this.btConf.BackColor = System.Drawing.Color.Transparent;
            this.btConf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConf.BackgroundImage")));
            this.btConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConf.FlatAppearance.BorderSize = 0;
            this.btConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConf.ForeColor = System.Drawing.Color.Transparent;
            this.btConf.Location = new System.Drawing.Point(344, 122);
            this.btConf.Margin = new System.Windows.Forms.Padding(0);
            this.btConf.Name = "btConf";
            this.btConf.Size = new System.Drawing.Size(47, 44);
            this.btConf.TabIndex = 6;
            this.btConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConf.UseVisualStyleBackColor = false;
            this.btConf.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Esse cadastro só pode ser efetuado por adiministradores";
            // 
            // CadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 175);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuarios";
            this.Load += new System.EventHandler(this.CadLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}