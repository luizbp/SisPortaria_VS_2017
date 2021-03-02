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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            using (var db = new PortDB())
            {
                try
                {
                    int id = db.login.Where(d => txtLogin.Text == d.LOGIN1 && txtSenha.Text == d.SENHA).FirstOrDefault().ID;
                    Menu me = new Menu(id);
                    this.Visible = false;
                    me.Show();
                }
                catch
                {
                    MessageBox.Show("Login ou senha incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Finalizar Programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Finalizar Programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}
