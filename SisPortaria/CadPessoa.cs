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
    public partial class CadPessoa : Form
    {
        int idPes;
        public CadPessoa()
        {
            InitializeComponent();
        }

        private void CadPessoa_Load(object sender, EventArgs e)
        {
            habilitarBt(true, false, false, false);
            carregarDgv();
        }

        private void habilitarBt(bool novo, bool gravar, bool alterar, bool cancelar)
        {
            btNovo.Enabled = novo;
            btGravar.Enabled = gravar;
            btAlterar.Enabled = alterar;
            btCancelar.Enabled = cancelar;
        }
        
        private void carregarDgv()
        {
            using(var db = new PortDB())
            {
                dgvPessoa.DataSource = db.pessoa.Where(d=> d.DELETADO != "S").Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    CPF = d.CPF,
                    RG = d.RG
                }).ToList();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            tbCadastro.SelectTab(tabCadastro);
            gbCadastro.Enabled = true;
            habilitarBt(false, true, false, true);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    pessoa pe = new pessoa();
                    pe.NOME = txtNome.Text;
                    pe.SEXO = cbSexo.Text;
                    pe.RG = mskRg.Text;
                    pe.CPF = mskCpf.Text;
                    pe.ENDERECO = txtEndereco.Text;
                    pe.NUMERO_CA = Convert.ToInt32(txtNumero.Text);
                    db.Entry(pe).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    habilitarBt(true, false, false, false);
                    gbCadastro.Enabled = false;
                    tbCadastro.SelectTab(tabPesquisa);
                    limparcampos();
                    carregarDgv();
                    MessageBox.Show("Seu cadastro foi realizado com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void limparcampos()
        {
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            mskCpf.Clear();
            mskRg.Clear();
            cbSexo.Text = "";
        }

        private void dgvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCadastro.SelectTab(tabCadastro);
                gbCadastro.Enabled = true;
                habilitarBt(false, false, true, true);
                int linha = Convert.ToInt32(dgvPessoa.CurrentCell.RowIndex);
                idPes = Convert.ToInt32(dgvPessoa[0, linha].Value.ToString());
                using (var db = new PortDB())
                {
                    pessoa pes = db.pessoa.Find(idPes);
                    txtNome.Text = pes.NOME;
                    cbSexo.Text = pes.SEXO;
                    txtEndereco.Text = pes.ENDERECO;
                    txtNumero.Text = Convert.ToString(pes.NUMERO_CA);
                    mskCpf.Text = pes.CPF;
                    mskRg.Text = pes.RG;
                }
            }
            catch
            {
                MessageBox.Show("Não a pessoas cadastradas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    pessoa pe = db.pessoa.Find(idPes);
                    pe.NOME = txtNome.Text;
                    pe.SEXO = cbSexo.Text;
                    pe.RG = mskRg.Text;
                    pe.CPF = mskCpf.Text;
                    pe.ENDERECO = txtEndereco.Text;
                    pe.NUMERO_CA = Convert.ToInt32(txtNumero.Text);
                    db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    habilitarBt(true, false, false, false);
                    gbCadastro.Enabled = false;
                    tbCadastro.SelectTab(tabPesquisa);
                    limparcampos();
                    carregarDgv();
                    MessageBox.Show("Sua alteração foi realizada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancelar cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                habilitarBt(true, false, false, false);
                gbCadastro.Enabled = false;
                tbCadastro.SelectTab(tabPesquisa);
                limparcampos();
                carregarDgv();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja sair do cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            using (var db = new PortDB())
            {
                dgvPessoa.DataSource = db.pessoa.Where(d=>  d.NOME.Contains(txtPesq.Text) && d.DELETADO != "S").Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    CPF = d.CPF,
                    RG = d.RG
                }).ToList();
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deletar cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                try
                {
                    int linha = Convert.ToInt32(dgvPessoa.CurrentCell.RowIndex);
                    idPes = Convert.ToInt32(dgvPessoa[0, linha].Value.ToString());
                    using (var db = new PortDB())
                    {
                        pessoa pe = db.pessoa.Find(idPes);
                        pe.DELETADO = "S";
                        db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        carregarDgv();
                        MessageBox.Show("Ação realizada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mskRg_Click(object sender, EventArgs e)
        {
            //if(mskRg.Text == string.Empty)
            //{
                mskRg.Select(0, 0);
            //}
        }

        private void mskCpf_Click(object sender, EventArgs e)
        {
            //if (mskCpf.Text == string.Empty)
            //{
                mskCpf.Select(0, 0);
            //}
        }
    }
}
