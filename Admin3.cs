using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdbojkaskiSavez
{
    public partial class Admin3 : Form
    {
        public Admin3()
        {
            InitializeComponent();
        }

        DataTable tabelautakmice;
        private void Admin3_Load(object sender, EventArgs e)
        {
            loaddatautakmice();
            gridutakmice.DataSource = tabelautakmice;
            gridutakmice.Columns["utakmicaid"].Visible = false;
            gridutakmice.ReadOnly = true;
            gridutakmice.AllowUserToAddRows = false;
            gridutakmice.AllowUserToDeleteRows = false;
        }
        private void loaddatautakmice()
        {
            SqlConnection veza = Konekcija.Connect();

            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT " +
                "utakmice.utakmicaid, " +
                "tim1.nazivtima AS domaci_tim, " +
                "tim2.nazivtima AS gostujuci_tim, " +
                "utakmice.datum, " +
                "utakmice.vreme, " +
                "utakmice.lokacija " +
                "FROM utakmice " +
                "JOIN timovi AS tim1 ON utakmice.domacitimid = tim1.timid " +
                "JOIN timovi AS tim2 ON utakmice.gostujucitimid = tim2.timid",
                veza);

            tabelautakmice = new DataTable();
            adapter.Fill(tabelautakmice);
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (gridutakmice.CurrentRow == null)
            {
                MessageBox.Show("Izaberi utakmicu!");
                return;
            }
            if (MessageBox.Show("Da li želiš da obrišeš utakmicu?",
                "Brisanje", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = Convert.ToInt32(
                gridutakmice.CurrentRow.Cells["utakmicaid"].Value);

            SqlConnection veza = Konekcija.Connect();

            try
            {
                veza.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM utakmice WHERE utakmicaid=" + id, veza);

                cmd.ExecuteNonQuery();

                veza.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            loaddatautakmice();
            gridutakmice.DataSource = tabelautakmice;
        }

        private void Admin3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonnazad_Click(object sender, EventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
    }
}
