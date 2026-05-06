using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OdbojkaskiSavez
{
    public partial class IgracForma : Form
    {
        int korisnikid;

        public IgracForma(int id)
        {
            InitializeComponent();
            korisnikid = id;
        }

        DataTable tabela;

        private void IgracForma_Load(object sender, EventArgs e)
        {
            loaddata();
            textload();
        }

        private int mojTimId()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand cmd = new SqlCommand(
                "SELECT timid FROM igraci WHERE korisnikid = " + korisnikid,
                veza
            );

            veza.Open();
            int timid = Convert.ToInt32(cmd.ExecuteScalar());
            veza.Close();

            return timid;
        }
        private void loaddata()
        {
            int timid = mojTimId();

            SqlConnection veza = Konekcija.Connect();

            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT " +
                "korisnici.ime, " +
                "korisnici.prezime, " +
                "timovi.nazivtima AS tim, " +
                "igraci.pozicija " +
                "FROM igraci " +
                "JOIN korisnici ON igraci.korisnikid = korisnici.korisnikid " +
                "JOIN timovi ON igraci.timid = timovi.timid " +
                "WHERE igraci.timid = " + timid,
                veza
            );

            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void textload()
        {
            gridigrac.DataSource = tabela;
        }

        private void IgracForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}