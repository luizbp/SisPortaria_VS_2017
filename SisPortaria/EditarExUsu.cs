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
    public partial class EditarExUsu : Form
    {
        int idUsu;
        public EditarExUsu()
        {
            InitializeComponent();
        }

        private void gbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void EditarExUsu_Load(object sender, EventArgs e)
        {
            carregarDgv();
            habilitarBt(false, false, false);
            txtSenha.UseSystemPasswordChar = true;
        }

        private void carregarDgv()
        {
            using (var db = new PortDB())
            {
                dgvLogin.DataSource = db.login.Where(d => d.DELETADO != "S").Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    LOGIN = d.LOGIN1,
                    ADMINISTRADOR = d.ADMIN

                }).ToList();
            }
        }

        private void habilitarBt(bool alterar, bool cancelar, bool excluir)
        {
            btAlterar.Enabled = alterar;
            btCancelar.Enabled = cancelar;
            btExcluir.Enabled = excluir;
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            using (var db = new PortDB())
            {
                dgvLogin.DataSource = db.login.Where(d => d.DELETADO != "S" && d.NOME.Contains(txtPesq.Text)).Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    LOGIN = d.LOGIN1,
                    ADMINISTRADOR = d.ADMIN

                }).ToList();
            }
        }

        private void dgvLogin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCadastro.SelectTab(tabCadastro);
                gbCadastro.Enabled = true;
                habilitarBt(true, true, true);
                int linha = Convert.ToInt32(dgvLogin.CurrentCell.RowIndex);
                idUsu = Convert.ToInt32(dgvLogin[0, linha].Value.ToString());
                using (var db = new PortDB())
                {
                    login lo = db.login.Find(idUsu);
                    txtNome.Text = lo.NOME;
                    txtLogin.Text = lo.LOGIN1;
                    txtSenha.Text = lo.SENHA;
                    if (lo.ADMIN == "S")
                        chkAdmin.Checked = true;
                    else if(lo.ADMIN == "N")
                            chkAdmin.Checked = false;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    login lo = db.login.Find(idUsu);
                    lo.NOME = txtNome.Text;
                    lo.SENHA = txtSenha.Text;
                    lo.LOGIN1 = txtLogin.Text;
                    db.Entry(lo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    txtLogin.Clear();
                    txtNome.Clear();
                    txtSenha.Clear();
                    gbCadastro.Enabled = false;
                    MessageBox.Show("Sua alteração foi realizada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCadastro.SelectTab(tabPesquisa);
                    carregarDgv();
                    habilitarBt(false, false, false);

                }
            }catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo deletar o usuario? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new PortDB())
                    {
                        login lo = db.login.Find(idUsu);
                        lo.DELETADO = "S";
                        db.Entry(lo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        txtLogin.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();
                        gbCadastro.Enabled = false;
                        MessageBox.Show("Usuario excluido com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCadastro.SelectTab(tabPesquisa);
                        carregarDgv();
                        habilitarBt(false, false, false);

                    }
                }



                catch (Exception erro)
                {
                    MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            gbCadastro.Enabled = false;
            tbCadastro.SelectTab(tabPesquisa);
            carregarDgv();
            habilitarBt(false, false, false);
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
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

        private void EditarExUsu_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
