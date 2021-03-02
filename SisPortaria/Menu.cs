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
namespace SisPortaria
{
    public partial class Menu : Form
    {
        int idLog;
        public Menu(int idAlt)
        {
            InitializeComponent();
            idLog = idAlt;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            using (var db = new PortDB())
            {
                label2.Text = db.login.Where(d => d.ID == idLog).FirstOrDefault().NOME;
                login ve = db.login.Find(idLog);
                if (ve.ADMIN == "N")
                {
                    loginToolStripMenuItem.Visible = false;
                    editarExcluirUsuarioToolStripMenuItem.Visible = false;
                }
                else
                {
                    loginToolStripMenuItem.Visible = true;
                    editarExcluirUsuarioToolStripMenuItem.Visible = true;
                }
            }
        }

        private void visitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPessoa cad = new CadPessoa();
            cad.MdiParent = this;
            cad.Show();
            cad.WindowState = FormWindowState.Maximized;
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHr.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss")) ;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void novaVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrada en = new Entrada(0);
            en.MdiParent = this;
            en.Show();
            en.WindowState = FormWindowState.Maximized;
            
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saida sa = new Saida();
            sa.MdiParent = this;
            sa.Show();
            sa.WindowState = FormWindowState.Maximized;
            
        }

        private void visitasEmAndamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Andamento an = new Andamento();
            an.MdiParent = this;
            an.Show();
            an.WindowState = FormWindowState.Maximized;
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLogin lo = new CadLogin(true);
            lo.Show();
            lo.StartPosition = FormStartPosition.CenterParent;
            
        }

        private void editarExcluirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarExUsu es = new EditarExUsu();
            es.MdiParent = this;
            es.Show();
            es.WindowState = FormWindowState.Maximized;
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                System.Environment.Exit(0); 
            }
            else 
            {
                e.Cancel = true;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio re = new Relatorio();
            re.MdiParent = this;
            re.Show();
            re.WindowState = FormWindowState.Maximized;
            
        }
    }
}
