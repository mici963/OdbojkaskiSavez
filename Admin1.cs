using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdbojkaskiSavez
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.Show();
            this.Hide();
        }

        private void dodajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin2 f = new Admin2();
            f.Show();
            this.Hide();
        }

        private void izmeniUtakmicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin3 f = new Admin3();
            f.Show();
            this.Hide();
        }

        private void Admin1_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void Admin1_Load(object sender, EventArgs e)
        {

        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
