using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisPortaria.Models;
using MySql.Data;
using System.Data.Entity;

namespace SisPortaria
{
    public partial class CadLogin : Form
    {
        bool Perm;
        public CadLogin(bool Admin)
        {
            InitializeComponent();
            Perm = Admin;
        }
        
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() ==  true)
                {
                    using (var db = new PortDB())
                    {
                    if (Perm == false)
                        {

                        try
                        {
                                    login lo = db.login.Find(1);
                                    verificacao ve = db.verificacao.Find(1);
                                    ve.P_LOGIN = "S";
                                    lo.NOME = txtNome.Text;
                                    lo.SENHA = txtSenha.Text;
                                    lo.LOGIN1 = txtLogin.Text;
                                    lo.DELETADO = "N";
                                    lo.ATIVO = "S";
                                    db.Entry(lo).State = System.Data.Entity.EntityState.Modified;
                                    db.Entry(ve).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                    MessageBox.Show("Administrador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    Login lo2 = new Login();
                                    lo2.Show();

                        }
                        
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        }
                    
                    else if (Perm == true)
                    {
                        try
                        {
                            login lo = new login();
                            lo.NOME = txtNome.Text;
                            lo.SENHA = txtSenha.Text;
                            lo.LOGIN1 = txtLogin.Text;
                            lo.DELETADO = "N";
                            lo.ATIVO = "S";
                            if (chkAdmin.Checked)
                            {
                                lo.ADMIN = "S";
                            }
                            else
                            {
                                lo.ADMIN = "N";
                            }
                            db.Entry(lo).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                            MessageBox.Show("Administrador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Focus();
                            txtLogin.Clear();
                            txtNome.Clear();
                            txtSenha.Clear();
                            chkAdmin.Checked = false;
                        
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    }

                }
            
            else
            {
                MessageBox.Show("Algum campo esta vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void CadLogin_Load(object sender, EventArgs e)
        {
            if(Perm == false)
            {
                chkAdmin.Visible = false;
            }
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (Perm == false)
            {
                if (MessageBox.Show("Deseja mesmo sair? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo sair? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private bool verificarCampos()
        {
            if(txtLogin.Text != "" || txtNome.Text != "" || txtSenha.Text != "")
                return true;
            else
                return false;
        }
        
    }
}
