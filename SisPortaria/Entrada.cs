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
using System.Globalization;
namespace SisPortaria
{

    public partial class Entrada : Form
    {
        DateTime data = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        
        int idAlt;
        int idVis;
        public Entrada(int Idpes)
        {
            InitializeComponent();
            idAlt = Idpes;
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            carregarDgv();
            habilitarBt(true, false, false, false);
        }

        PesqPessoa pesq = new PesqPessoa();
        private void btPesqNome_Click(object sender, EventArgs e)
        {
            pesq.Load += pesqDiag_Load;
            pesq.btPesqDoc.Click += btPDiag_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDPes, txtNomePes, pesq.retornoID, pesq.retornoDesc);
        }
        private void pesqDiag_Load(object sender, EventArgs e)
        {
            using (var db = new PortDB())
            {

                pesq.dgvPesq.DataSource = db.pessoa.Where(d=> d.DELETADO != "S").Select(d => new
                {
                    ID = d.ID,
                    NOME = d.NOME,
                    RG = d.RG,
                    CPF = d.CPF

                }).ToList();
            }
        }
        private void btPDiag_Click(object sender, EventArgs e)
        {
            PortDB db = new PortDB();
            pesq.dgvPesq.DataSource = PesqPessoa(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object PesqPessoa(string pesquisa)
        {
            PortDB db = new PortDB();

            return db.pessoa.Where(d => d.NOME.Contains(pesquisa)).Select(d => new
            {

                ID = d.ID,
                NOME = d.NOME,
                RG = d.RG,
                CPF = d.CPF

            }).ToList();
        }
        private void preencheCampos(object sender1, object sender2, string ID, string Desc)
        {
            TextBox tID = sender1 as TextBox;
            if (!string.IsNullOrWhiteSpace(ID))
                tID.Text = ID;
            tID.BackColor = Color.White;


            TextBox tDesc = sender2 as TextBox;
            if (!string.IsNullOrWhiteSpace(Desc))
                tDesc.Text = Desc;


        }

        private void Entrada_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void habilitarBt(bool novo, bool gravar, bool alterar, bool cancelar)
        {
            btNovo.Enabled = novo;
            btGravar.Enabled = gravar;
            btAlterar.Enabled = alterar;
            btCancelar.Enabled = cancelar;
        }

        public void carregarDgv()
        {
            using (var db = new PortDB())
            {
                

                dgvAndamento.DataSource = db.visitas.Where(d => d.ANDAMENTO != "N" && d.DELETADO != "S" && d.DATA == data).Select(d => new
                {
                    ID = d.ID,
                    IDPESSOA = d.pessoa.ID,
                    NOME = d.pessoa.NOME,
                    HORA_DE_ENTRADA = d.HR_ENTRADA,
                    LOCAL_DA_VISITA = d.LOCAL_VISITA,
                    MOTIVO = d.MOTIVO,
                    OBSERVAÇÃO = d.OBSERVACAO
                }).ToList();
            }
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            using (var db = new PortDB())
            {
                string pesquisa = txtPesq.Text;
                dgvAndamento.DataSource = db.visitas.Where(d => d.ANDAMENTO != "N" && d.DELETADO != "S" && d.pessoa.NOME.Contains(pesquisa) && d.DATA == data).Select(d => new
                {
                    ID = d.ID,
                    IDPESSOA = d.pessoa.ID,
                    NOME = d.pessoa.NOME,
                    HORA_DE_ENTRADA = d.HR_ENTRADA,
                    LOCAL_DA_VISITA = d.LOCAL_VISITA,
                    MOTIVO = d.MOTIVO,
                    OBSERVAÇÃO = d.OBSERVACAO
                }).ToList();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarBt(false, true,false,true);
            gbCadastro.Enabled = true;
            tbEntrada.SelectTab(tabCadastro);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    idAlt = Convert.ToInt32(txtIDPes.Text);
                    visitas vi = new visitas();
                    vi.IDPESSOA = idAlt;
                    vi.HR_ENTRADA = DateTime.Now.ToString("HH:mm:ss");
                    vi.LOCAL_VISITA = txtLocalVisita.Text;
                    vi.DATA = data;
                    vi.ANDAMENTO = "S";
                    vi.MOTIVO = txtMotivo.Text;
                    vi.OBSERVACAO = rtbObservacao.Text;
                    vi.ATIVO = "S";
                    vi.DELETADO = "N";
                    db.Entry(vi).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    MessageBox.Show("Sua visita foi registrada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    carregarDgv();
                    gbCadastro.Enabled = false;
                    habilitarBt(true, false, false, false);
                    tbEntrada.SelectTab(tabAndamento);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparCampos()
        {
            txtIDPes.Clear();
            txtLocalVisita.Clear();
            txtMotivo.Clear();
            txtNomePes.Clear();
            rtbObservacao.Clear();
        }

        private void btClearNome_Click(object sender, EventArgs e)
        {
            txtIDPes.Clear();
            txtNomePes.Clear();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    visitas vi = db.visitas.Find(idVis);
                    vi.IDPESSOA = idAlt;
                    vi.HR_ENTRADA = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
                    vi.LOCAL_VISITA = txtLocalVisita.Text;
                    vi.DATA = data;
                    vi.ANDAMENTO = "S";
                    vi.MOTIVO = txtMotivo.Text;
                    vi.OBSERVACAO = rtbObservacao.Text;
                    vi.ATIVO = "S";
                    vi.DELETADO = "N";
                    db.Entry(vi).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Sua alteração realizada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    carregarDgv();
                    gbCadastro.Enabled = false;
                    habilitarBt(true, false, false, false);
                    tbEntrada.SelectTab(tabAndamento);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAndamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbEntrada.SelectTab(tabCadastro);
                gbCadastro.Enabled = true;
                habilitarBt(false, false, true, true);
                int linha = Convert.ToInt32(dgvAndamento.CurrentCell.RowIndex);
                idVis = Convert.ToInt32(dgvAndamento[0, linha].Value.ToString());
                using (var db = new PortDB())
                {
                    visitas vi = db.visitas.Find(idVis);
                    txtIDPes.Text = Convert.ToString(vi.IDPESSOA);
                    txtLocalVisita.Text = vi.LOCAL_VISITA;
                    txtMotivo.Text = vi.MOTIVO;
                    txtNomePes.Text = vi.pessoa.NOME;
                    rtbObservacao.Text = vi.OBSERVACAO;
                }
            }
            catch
            {
                MessageBox.Show("Não a pessoas cadastradas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                limparCampos();
                carregarDgv();
                gbCadastro.Enabled = false;
                habilitarBt(true, false, false, false);
                tbEntrada.SelectTab(tabAndamento);
            }
        }

        private void dgvAndamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
