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
    public partial class Saida : Form
    {
        DateTime data = DateTime.Now.Date;
        int idVis;

        public Saida()
        {
            InitializeComponent();
        }

        private void Saida_MinimumSizeChanged(object sender, EventArgs e)
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

        private void habilitarBt(bool finalizar, bool cancelar)
        {
            btFinalizar.Enabled = finalizar;
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

        private void Saida_Load(object sender, EventArgs e)
        {
            carregarDgv();
            habilitarBt(false, false);
        }

        private void dgvAndamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbEntrada.SelectTab(tabConsulta);
                gbCadastro.Enabled = true;
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
                    habilitarBt(true, true);
                    
                }
            }
            catch
            {
                MessageBox.Show("Não a pessoas cadastradas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PortDB())
                {
                    visitas vi = db.visitas.Find(idVis);
                    vi.HR_SAIDA = DateTime.Now.ToString("HH:mm:ss");
                    vi.ANDAMENTO = "N";
                    db.Entry(vi).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Sua visita foi finalizada com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    carregarDgv();
                    habilitarBt(false, false);
                    tbEntrada.SelectTab(tabAndamento);
                }
            }
            catch (Exception erro)
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                limparCampos();
                carregarDgv();
                habilitarBt(false, false);
                tbEntrada.SelectTab(tabAndamento);
            }
        }
    }
}
