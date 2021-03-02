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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 4;
            if (progressBar1.Value == 100)
            {
                PortDB db = new PortDB();
                verificacao ve = db.verificacao.Find(1);
                if (ve.P_LOGIN == "N")
                {
                    CadLogin ca = new CadLogin(false);
                    ca.Show();
                    timer1.Stop();
                    this.Visible = false;
                }
                else
                {
                    timer1.Stop();
                    this.Visible = false;
                    Login lo = new Login();
                    lo.Show();
                }
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
